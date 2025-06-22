using CareerGuidance.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareerGuidance.DataAccess.Data.Interface
{
    public interface IRefreshTokenData
    {
        public Task<RefreshToken> AddRefreshTokenAsync(RefreshToken refreshToken);
        public Task<RefreshToken?> GetByTokenAsync(string tokenHash, bool asNoTracking = false);
        public Task<RefreshToken?> UpdateRefreshTokenAsync(RefreshToken token);
    }
}
