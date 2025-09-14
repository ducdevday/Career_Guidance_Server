using CareerGuidance.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareerGuidance.DataAccess.Data.Interface
{
    public interface IUserData
    {
        Task<bool> IsExistAsync(Func<User, bool> predicate);
        public Task<User> SignUpAccountAsync(User user);
        public Task<User?> GetAsync(Func<User, bool> predicate);
        public Task<User> UpdateAsync(User user);
        public Task SoftDeleteAsync(User user);
        public Task HardDeleteAsync(User user);
        public Task<(List<User>, int)> GetListAsync(int page, int size, Func<User, bool>? filter, Func<User, object>? sortby, bool descending = false);
    }
}
