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
        public Task<bool> IsExistedUserAsync(string email, string phoneNumber);
        public Task<bool> IsExistedUserAsync(string email);
        public Task<User> SignUpAccountAsync(User user);
        public Task<User?> GetUserByEmailAsync(string email, bool asNoTracking = false);
        public Task<User> UpdateUser(User user);
    }
}
