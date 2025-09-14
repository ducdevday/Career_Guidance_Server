using AutoMapper;
using CareerGuidance.BussinessLogic.Interface;
using CareerGuidance.Data.Entity;
using CareerGuidance.DataAccess;
using CareerGuidance.DTO.Dtos.Nested;
using CareerGuidance.DTO.Request;
using CareerGuidance.DTO.Response;
using CareerGuidance.Validation.Service;
using CareerGuidance.Data.Enum;
using Microsoft.AspNetCore.Http;
using System.Net;
using CareerGuidance.Shared.Constant;

namespace CareerGuidance.BussinessLogic.Business
{
    public class UserBusiness : BaseBusiness, IUserBusiness
    {
        public UserBusiness(IDataAccessFacade context, IMapper mapper, IValidationService validation, IHttpContextAccessor httpContextAccessor) : base(context, mapper, validation, httpContextAccessor)
        {

        }

        public async Task<GetUserByIdResponse> GetUserByIdAsync(Guid id)
        {
            var user = await _context.UserData.GetAsync(x => x.Id == id);
            if (user == null)
                return new GetUserByIdResponse(HttpStatusCode.NotFound, new List<string> { "User Not Found" }, null);

            var userDto = _mapper.Map<UserDto>(user);
            return new GetUserByIdResponse(HttpStatusCode.OK, new List<string> { "Get User Successfully" }, userDto);
        }

        public async Task<DeleteUserResponse> HardDeleteUserAsync(Guid id)
        {
            var user = await _context.UserData.GetAsync(x => x.Id == id);
            if (user == null)
                return new DeleteUserResponse(HttpStatusCode.NotFound, new List<string> { "User Not Found" }, false);
            await _context.UserData.HardDeleteAsync(user);
            var result = await _context.CommitAsync();
            if (result)
                return new DeleteUserResponse(HttpStatusCode.OK, new List<string> { "User Deleted Successfully" }, true);
            else
                return new DeleteUserResponse(HttpStatusCode.InternalServerError, new List<string> { "User Deletion Failed" }, false);
        }

        
        public async Task<SearchUserResponse> SearchUserAsync(SearchUserRequest request)
        {
            var (users, count) = await _context.UserData.GetListAsync(request.PageIndex, request.PageSize, x => x.FirstName.Contains(request.Keyword ?? string.Empty) || x.LastName.Contains(request.Keyword ?? string.Empty) || x.LastName.Contains(request.Keyword ?? string.Empty), x => x.Id, true);
            var userDtos = _mapper.Map<List<UserDto>>(users);
            var response = new SearchUserResponse(HttpStatusCode.OK, new List<string> { "Search User Successfully" }, userDtos)
            {
                TotalCount = count
            };
            return response;
        }

        public async Task<DeleteUserResponse> SoftDeleteUserAsync(Guid id)
        {
            var user = await _context.UserData.GetAsync(x=> x.Id == id);
            if (user == null)
                return new DeleteUserResponse(HttpStatusCode.NotFound, new List<string> { "User Not Found" }, false);
            await _context.UserData.SoftDeleteAsync(user);
            var result = await _context.CommitAsync();
            if (result)
                return new DeleteUserResponse(HttpStatusCode.OK, new List<string> { "User Deleted Successfully" }, true);
            else
                return new DeleteUserResponse(HttpStatusCode.InternalServerError, new List<string> { "User Deletion Failed" }, false);
        }

        public async Task<UpdateUserResponse> UpdateUserAsync(UpdateUserRequest request)
        {
            var validation = await _validation.ValidateAsync(request);
            if (!validation.IsValid)
            {
                return new UpdateUserResponse(HttpStatusCode.BadRequest,
                    validation.Errors.Select(e => e.ErrorMessage).ToList(), false);
            }
            var user = await _context.UserData.GetAsync(x => x.Id == request.UserId);
            if (user == null)
                return new UpdateUserResponse(HttpStatusCode.NotFound, new List<string> { "User Not Found" }, false);
            _mapper.Map(request, user);
            await _context.UserData.UpdateAsync(user);
            var result = await _context.CommitAsync();
            if (result)
                return new UpdateUserResponse(HttpStatusCode.OK, new List<string> { "User Updated Successfully" }, true);
            else
                return new UpdateUserResponse(HttpStatusCode.InternalServerError, new List<string> { "User Update Failed" }, false);
        }
    }
}
