using AutoMapper;
using CareerGuidance.Data.Enum;
using CareerGuidance.DataAccess;
using CareerGuidance.Shared.Constant;
using CareerGuidance.Validation.Service;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace CareerGuidance.BussinessLogic
{
    public class BaseBusiness
    {
        protected readonly IDataAccessFacade _context;
        protected readonly IMapper _mapper;
        protected readonly IValidationService _validation;
        protected readonly IHttpContextAccessor _httpContext;

        public BaseBusiness(IDataAccessFacade context, IMapper mapper, IValidationService validation, IHttpContextAccessor httpContextAccessor)
        {
            _context = context;
            _mapper = mapper;
            _validation = validation;
            _httpContext = httpContextAccessor;
        }
        protected Guid? CurrentUserId
        {
            get
            {
                var user = _httpContext.HttpContext?.User;
                var userIdClaim = user?.FindFirst(ClaimTypes.NameIdentifier);
                if (userIdClaim == null) return null;

                return Guid.TryParse(userIdClaim.Value, out var userId) ? userId : null;
            }
        }

        protected RoleType? CurrentUserRole
        {
            get
            {
                var user = _httpContext.HttpContext?.User;
                var roleClaim = user?.FindFirst(ClaimTypes.Role);
                if (roleClaim == null) return null;

                return Enum.TryParse<RoleType>(roleClaim.Value, out var role) ? role : null;
            }
        }

        protected IRequestCookieCollection RequestCookies => _httpContext.HttpContext?.Request.Cookies!;

        protected IResponseCookies ResponseCookies => _httpContext.HttpContext?.Response.Cookies!;

    }
}
