using AutoMapper;
using CareerGuidance.BussinessLogic.Interface;
using CareerGuidance.DataAccess;
using CareerGuidance.DTO.Request;
using CareerGuidance.DTO.Response;
using CareerGuidance.Validation.Service;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using CareerGuidance.Data.Entity;
using CareerGuidance.DTO.Dtos.Nested;
using Microsoft.VisualBasic;
namespace CareerGuidance.BussinessLogic.Business
{
    public class IndustryBusiness : BaseBusiness, IIndustryBusiness
    {
        public IndustryBusiness(IDataAccessFacade context, IMapper mapper, IValidationService validation, IHttpContextAccessor httpContextAccessor) : base(context, mapper, validation, httpContextAccessor)
        {
        }

        public async Task<CreateIndustryResponse> CreateIndustryAsync(CreateIndustryRequest request)
        {
            var validation = await _validation.ValidateAsync(request);
            if (!validation.IsValid)
            {
                return new CreateIndustryResponse(HttpStatusCode.BadRequest,
                    validation.Errors.Select(e => e.ErrorMessage).ToList(), false);
            }
            var isExist = await _context.IndustryData.IsExistAsync(x => x.Name == request.Name);

            if (isExist)
            {
                return new CreateIndustryResponse(HttpStatusCode.BadRequest, new List<string> { "Industry Is Exist" }, false);
            }

            var industry = _mapper.Map<Industry>(request);

            await _context.IndustryData.CreateAsync(industry);
            var res = await _context.CommitAsync();
            if (res) return new CreateIndustryResponse(HttpStatusCode.OK, new List<string> { "Industry Create Success" }, true);
            else return new CreateIndustryResponse(HttpStatusCode.InternalServerError, new List<string> { "Industry Create Failed" }, false);
        }

        public async Task<DeleteIndustryResponse> SoftDeleteIndustryAsync(DeleteIndustryRequest request)
        {
            var validation = await _validation.ValidateAsync(request);
            if (!validation.IsValid)
            {
                return new DeleteIndustryResponse(HttpStatusCode.BadRequest,
                    validation.Errors.Select(e => e.ErrorMessage).ToList(), false);
            }

            var industry = await _context.IndustryData.GetByIdAsync(request.Id);
            if (industry == null) return new DeleteIndustryResponse(HttpStatusCode.NotFound, new List<string> { "Industry Not Found" }, false);

            await _context.IndustryData.SoftDeleteAsync(industry);
            var res = await _context.CommitAsync();
            if (res) return new DeleteIndustryResponse(HttpStatusCode.OK, new List<string> { "Industry Deleted Successfully" }, true);
            else return new DeleteIndustryResponse(HttpStatusCode.InternalServerError, new List<string> { "Industry Deletion Failed" }, false);
        }

        public async Task<GetIndustryByIdResponse> GetIndustryAsync(GetIndustryRequest request)
        {
            var validation = await _validation.ValidateAsync(request);
            if (!validation.IsValid)
            {
                return new GetIndustryByIdResponse(HttpStatusCode.BadRequest,
                    validation.Errors.Select(e => e.ErrorMessage).ToList(), null);
            }
            var industry = await _context.IndustryData.GetByIdAsync(request.Id);
            if (industry == null) return new GetIndustryByIdResponse(HttpStatusCode.NotFound, new List<string> { "Industry Not Found" }, null);

            var industryDto = _mapper.Map<IndustryDto>(industry);
            return new GetIndustryByIdResponse(HttpStatusCode.OK, new List<string> { "Industry Retrieved Successfully" }, industryDto);
        }
        public async Task<UpdateIndustryResponse> UpdateIndustryAsync(UpdateIndustryRequest request)
        {
            var validation = _validation.ValidateAsync(request);
            if (!validation.Result.IsValid)
            {
                return new UpdateIndustryResponse(HttpStatusCode.BadRequest,
                    validation.Result.Errors.Select(e => e.ErrorMessage).ToList(), false);
            }
            var industry = await _context.IndustryData.GetByIdAsync(request.Id);
            if (industry == null)
            {
                return new UpdateIndustryResponse(HttpStatusCode.NotFound, new List<string> { "Industry Not Found" }, false);
            }

            var isExist = await _context.IndustryData.IsExistAsync(x => x.Name == request.Name && x.Id != request.Id);
            if (isExist) return new UpdateIndustryResponse(HttpStatusCode.BadRequest, new List<string> { "Industry Name Already Exists" }, false);

            _mapper.Map(request, industry);
            var res = await _context.CommitAsync();
            if (res) return new UpdateIndustryResponse(HttpStatusCode.OK, new List<string> { "Industry Updated Successfully" }, true);
            else return new UpdateIndustryResponse(HttpStatusCode.InternalServerError, new List<string> { "Industry Update Failed" }, false);
        }

        public async Task<DeleteIndustryResponse> HardDeleteIndustryAsync(DeleteIndustryRequest request)
        {
            var validation = _validation.ValidateAsync(request);
            if (!validation.Result.IsValid)
            {
                return new DeleteIndustryResponse(HttpStatusCode.BadRequest,
                    validation.Result.Errors.Select(e => e.ErrorMessage).ToList(), false);
            }

            var industry = _context.IndustryData.GetByIdAsync(request.Id).Result;
            if (industry == null)
            {
                return new DeleteIndustryResponse(HttpStatusCode.NotFound, new List<string> { "Industry Not Found" }, false);
            }

            await _context.IndustryData.HardDeleteAsync(industry);
            var res = _context.CommitAsync().Result;
            if (res) return new DeleteIndustryResponse(HttpStatusCode.OK, new List<string> { "Industry Deleted Successfully" }, true);
            else return new DeleteIndustryResponse(HttpStatusCode.InternalServerError, new List<string> { "Industry Deletion Failed" }, false);
        }

        public async Task<SearchIndustryResponse> SearchAsync(SearchIndustryRequest request)
        {
            var validation = _validation.ValidateAsync(request);
            if (!validation.Result.IsValid)
            {
                return new SearchIndustryResponse(HttpStatusCode.BadRequest,
                    validation.Result.Errors.Select(e => e.ErrorMessage).ToList(), null);
            }

            var (industries, count) = await _context.IndustryData.GetListAsync(request.PageIndex, request.PageSize, null);

            var industryDtos = _mapper.Map<List<IndustryDto>>(industries);
            var searchDto = new SearchIndustryDto
            {
                Industries = industryDtos,
                TotalCount = count
            };
            return new SearchIndustryResponse(HttpStatusCode.OK, new List<string> { "Industries Retrieved Successfully" }, searchDto);
        }

        public async Task<GetHomeIndustryResposne> GetHomeIndustryAsync()
        {
            var (industries, count) = await _context.IndustryData.GetListAsync(1, 10, x => x.Active);

            var industryDtos = _mapper.Map<List<IndustryDto>>(industries);
            return new GetHomeIndustryResposne(HttpStatusCode.OK, new List<string> { "Industries Retrieved Successfully" }, industryDtos);
        }
    }
}
