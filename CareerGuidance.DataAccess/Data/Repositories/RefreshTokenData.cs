using CareerGuidance.Data;
using CareerGuidance.Data.Entity;
using CareerGuidance.DataAccess.Data.Interface;
using Microsoft.EntityFrameworkCore;

namespace CareerGuidance.DataAccess.Data.Repositories
{
    public class RefreshTokenData : IRefreshTokenData
    {
        private readonly CareerGuidanceDBContext _context;
        public RefreshTokenData(CareerGuidanceDBContext context)
        {
            _context = context;
        }
        public Task<RefreshToken> AddRefreshTokenAsync(RefreshToken refreshToken)
        {
            var addedRefreshToken = _context.RefreshToken.Add(refreshToken);
            return Task.FromResult(addedRefreshToken.Entity);
        }

        public Task<RefreshToken?> GetByTokenAsync(string tokenHash, bool asNoTracking = false)
        {
            IQueryable<RefreshToken> query = _context.RefreshToken;
            if (asNoTracking)
            {
                query = query.AsNoTracking();
            }
            var refreshToken = query
                .FirstOrDefault(rt => rt.TokenHash == tokenHash);
            return Task.FromResult(refreshToken);
        }

        public Task<RefreshToken?> UpdateRefreshTokenAsync(RefreshToken token)
        {
            throw new NotImplementedException();
        }
    }
}
