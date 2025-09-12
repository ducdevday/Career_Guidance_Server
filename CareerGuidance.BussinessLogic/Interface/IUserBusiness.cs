using CareerGuidance.DTO.Request;
using CareerGuidance.DTO.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareerGuidance.BussinessLogic.Interface
{
    public interface IUserBusiness
    {
        public Task<GetUserByIdResponse> GetUserByIdAsync(Guid id);
        public Task<UpdateUserResponse> UpdateUserAsync(UpdateUserRequest request);
        public Task<DeleteUserResponse> SoftDeleteUserAsync(Guid id);
        public Task<DeleteUserResponse> HardDeleteUserAsync(Guid id);
        public Task<SearchUserResponse> SearchUserAsync(SearchUserRequest request);
    }
}
