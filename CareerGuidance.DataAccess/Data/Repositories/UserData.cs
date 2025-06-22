using CareerGuidance.Data;
using CareerGuidance.Data.Entity;
using CareerGuidance.DataAccess.Data.Interface;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareerGuidance.DataAccess.Data.Repositories
{
    public class UserData : IUserData
    {
        private readonly CareerGuidanceDBContext _context;

        public UserData(CareerGuidanceDBContext context)
        {
            _context = context;
        }

        public async Task<User?> GetUserByEmailAsync(string email, bool asNoTracking = false)
        {
            IQueryable<User> query = _context.User;
            if (asNoTracking)
            {
                query = query.AsNoTracking();
            }
            return await query.FirstOrDefaultAsync(u => u.Email == email);
        }

        public Task<User> UpdateUserAsync(User user)
        {
            var updatedUser = _context.User.Update(user);
            return Task.FromResult(updatedUser.Entity);
        }

        public async Task<bool> IsExistedUserAsync(string email, string phoneNumber)
        {
            return await _context.User.AnyAsync(u => u.Email == email || u.PhoneNumber == phoneNumber);
        }

        public async Task<bool> IsExistedUserAsync(string email)
        {
            return await _context.User.AnyAsync(u => u.Email == email);
        }

        public Task<User> SignUpAccountAsync(User user)
        {
            var addedUser = _context.User.Add(user);
            return Task.FromResult(addedUser.Entity);
        }

        public Task<User> UpdateUser(User user)
        {
            throw new NotImplementedException();
        }
    }
}
