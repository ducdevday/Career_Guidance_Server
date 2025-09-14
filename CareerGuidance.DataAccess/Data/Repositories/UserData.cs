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

        public Task<User?> GetAsync(Func<User,bool> filter)
        {
            var user = _context.User.FirstOrDefault(filter);
            return Task.FromResult(user);
        }

        public Task<(List<User>, int)> GetListAsync(int page, int size, Func<User, bool>? filter, Func<User, object>? sortby, bool descending = false)
        {
            IQueryable<User> query = _context.User.AsNoTracking();

            if (filter != null)
            {
                query = query.Where(filter).AsQueryable(); // Dummy Industry object for filtering
            }

            if (sortby != null)
            {
                query = descending ? query.OrderByDescending(sortby).AsQueryable() : query.OrderBy(sortby).AsQueryable();
            }

            var totalItems = query.Count();
            var users = query.Skip((page - 1) * size).Take(size).ToList();

            return Task.FromResult((users, totalItems));
        }

        public Task HardDeleteAsync(User user)
        {
            _context.User.Remove(user);
            return Task.CompletedTask;
        }

        public Task<bool> IsExistAsync(Func<User, bool> predicate)
        {
            var isExist = _context.User.Any(predicate); ;
            return Task.FromResult(isExist);
        }

        public Task<User> SignUpAccountAsync(User user)
        {
            var addedUser = _context.User.Add(user);
            return Task.FromResult(addedUser.Entity);
        }

        public Task SoftDeleteAsync(User user)
        {
            user.Active = false;
            return Task.CompletedTask;
        }

        public Task<User> UpdateAsync(User user)
        {
            var updatedUser = _context.User.Update(user);
            return Task.FromResult(updatedUser.Entity);
        }
    }
}
