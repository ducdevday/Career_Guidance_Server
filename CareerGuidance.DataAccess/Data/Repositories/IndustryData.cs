using Azure.Core;
using CareerGuidance.Data;
using CareerGuidance.Data.Entity;
using CareerGuidance.DataAccess.Data.Interface;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace CareerGuidance.DataAccess.Data.Repositories
{
    public class IndustryData : IIndustryData
    {
        private readonly CareerGuidanceDBContext _context;

        public IndustryData(CareerGuidanceDBContext context)
        {
            _context = context;
        }

        public Task CreateAsync(Industry industry)
        {
            _context.Industry.Add(industry);
            return Task.CompletedTask;
        }

        public Task HardDeleteAsync(Industry industry)
        {
            _context.Industry.Remove(industry);
            return Task.CompletedTask;
        }

        public Task SoftDeleteAsync(Industry industry)
        {
            industry.Active = false;
            return Task.CompletedTask;
        }

        public Task<Industry?> GetByIdAsync(int id)
        {
            var industry = _context.Industry.FirstOrDefault(x => x.Id == id);
            return Task.FromResult(industry);
        }

        public Task<bool> IsExistAsync(Func<Industry, bool> predicate)
        {
            var isExist = _context.Industry.Any(predicate);
            return Task.FromResult(isExist);
        }

        public Task UpdateAsync(Industry industry)
        {
            _context.Industry.Update(industry);
            return Task.CompletedTask;
        }

        public Task<(List<Industry>, int)> GetListAsync(int page, int size, Func<Industry, bool>? predicate)
        {
            IQueryable<Industry> query = _context.Industry.AsNoTracking();

            if (predicate != null)
                query = query.Where(predicate).AsQueryable();

            int total = query.Count();

            List<Industry> items = query
                .Skip((page - 1) * size)
                .Take(size)
                .ToList();

            return Task.FromResult((items, total));
        }
    }
}
