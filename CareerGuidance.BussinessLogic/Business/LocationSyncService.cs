using CareerGuidance.Data.Entity;
using CareerGuidance.DTO.Dtos.Nested;
using CareerGuidance.DTO.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using CareerGuidance.Data;
using Microsoft.EntityFrameworkCore;

namespace CareerGuidance.BussinessLogic.Business
{
    public class LocationSyncService
    {
        private readonly HttpClient _http;
        private readonly CareerGuidanceDBContext _db;

        // VNAppMob v2 dùng host api.vnappmob.com theo docs
        // /api/v2/province, /api/v2/province/district/{provinceId}, /api/v2/province/ward/{districtId}
        // Ref: https://api.vnappmob.com (docs Province API)
        public LocationSyncService(HttpClient http, CareerGuidanceDBContext db)
        {
            _http = http;
            _http.BaseAddress = new Uri("https://api.vnappmob.com");
            _db = db;
        }

        public async Task<int> SyncAllAsync(CancellationToken ct = default)
        {
            // 1) Provinces
            var provinces = await _http.GetFromJsonAsync<ApiListResponse<ProvinceDto>>(
                "/api/v2/province/", cancellationToken: ct);

            if (provinces?.Results == null || provinces.Results.Count == 0)
                return 0;

            // Upsert Provinces
            foreach (var p in provinces.Results)
            {
                var exists = await _db.Province.FindAsync(new object[] { p.ProvinceId }, ct);
                if (exists == null)
                {
                    _db.Province.Add(new Province
                    {
                        ProvinceId = p.ProvinceId,
                        ProvinceName = p.ProvinceName,
                        ProvinceType = p.ProvinceType
                    });
                }
                else
                {
                    exists.ProvinceName = p.ProvinceName;
                    exists.ProvinceType = p.ProvinceType;
                    _db.Province.Update(exists);
                }
            }
            await _db.SaveChangesAsync(ct);

            // 2) Districts per province (giới hạn concurrency để tránh bị chặn)
            var semaphore = new SemaphoreSlim(6); // chạy tối đa 6 request song song là an toàn
            var districtTasks = provinces.Results.Select(async prov =>
            {
                await semaphore.WaitAsync(ct);
                try
                {
                    var districts = await _http.GetFromJsonAsync<ApiListResponse<DistrictDto>>(
                        $"/api/v2/province/district/{prov.ProvinceId}", cancellationToken: ct);

                    if (districts?.Results == null) return;

                    foreach (var d in districts.Results)
                    {
                        var exists = await _db.District.FindAsync(new object[] { d.DistrictId }, ct);
                        if (exists == null)
                        {
                            _db.District.Add(new District
                            {
                                DistrictId = d.DistrictId,
                                DistrictName = d.DistrictName,
                                ProvinceId = prov.ProvinceId
                            });
                        }
                        else
                        {
                            exists.DistrictName = d.DistrictName;
                            exists.ProvinceId = prov.ProvinceId;
                            _db.District.Update(exists);
                        }
                    }
                    await _db.SaveChangesAsync(ct);

                    // 3) Wards per district
                    foreach (var d in districts.Results)
                    {
                        // (tuỳ chọn) delay nhẹ để lịch sự với API
                        await Task.Delay(30, ct);

                        var wards = await _http.GetFromJsonAsync<ApiListResponse<WardDto>>(
                            $"/api/v2/province/ward/{d.DistrictId}", cancellationToken: ct);

                        if (wards?.Results == null) continue;

                        foreach (var w in wards.Results)
                        {
                            var existsWard = await _db.Ward.FindAsync(new object[] { w.WardId }, ct);
                            if (existsWard == null)
                            {
                                _db.Ward.Add(new Ward
                                {
                                    WardId = w.WardId,
                                    WardName = w.WardName,
                                    DistrictId = d.DistrictId
                                });
                            }
                            else
                            {
                                existsWard.WardName = w.WardName;
                                existsWard.DistrictId = d.DistrictId;
                                _db.Ward.Update(existsWard);
                            }
                        }
                        await _db.SaveChangesAsync(ct);
                    }
                }
                finally
                {
                    semaphore.Release();
                }
            });

            await Task.WhenAll(districtTasks);

            return await _db.Province.CountAsync(ct);
        }
    }
}
