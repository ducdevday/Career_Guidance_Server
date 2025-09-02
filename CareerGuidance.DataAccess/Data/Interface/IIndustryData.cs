using CareerGuidance.Data.Entity;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareerGuidance.DataAccess.Data.Interface
{
    public interface IIndustryData
    {
        Task<bool> IsExistAsync (Func<Industry, bool> predicate);
        Task CreateAsync(Industry industry);
        Task<Industry?> GetByIdAsync(int id);
        Task UpdateAsync(Industry industry);
        Task SoftDeleteAsync(Industry industry);
        Task HardDeleteAsync(Industry industry);
        Task<(List<Industry>, int)> GetListAsync(int page, int size, Func<Industry, bool>? predicate);
    }
}
