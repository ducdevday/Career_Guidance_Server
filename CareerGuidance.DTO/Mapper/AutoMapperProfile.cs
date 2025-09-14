using AutoMapper;
using CareerGuidance.Data.Entity;
using CareerGuidance.Data.Enum;
using CareerGuidance.DTO.Dtos.Nested;
using CareerGuidance.DTO.Request;
using CareerGuidance.Shared.Constant;
using CareerGuidance.Shared.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareerGuidance.DTO.Mapper
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile() {
            #region Auth
            CreateMap<SignUpRequest, User>().ForMember(dest => dest.Id, opt => opt.MapFrom(src => Guid.NewGuid()))
                                            .ForMember(dest => dest.Password, opt => opt.MapFrom(src => SecretUtil.HashPassword(src.Password)))
                                            .ForMember(dest => dest.Status, opt => opt.MapFrom(src => AccountStatusType.Unverified))
                                            .ForMember(dest => dest.Role,  opt => opt.MapFrom(src => RoleType.Student));
                                            

            CreateMap<User, EmailVerification>().ForMember(dest => dest.Id, opt => opt.MapFrom(src => Guid.NewGuid()))
                                            .ForMember(dest => dest.UserId, opt => opt.MapFrom(src => src.Id))
                                            .ForMember(dest => dest.Token, opt => opt.MapFrom(src => TokenUtil.GenerateRandomCode(ValidationConstant.EMAIL_VERIFICATION_CODE_LENGTH)))
                                            .ForMember(dest => dest.ExpiresAt, opt => opt.MapFrom(src => DateTime.UtcNow.AddMinutes(TimeConstant.EmailVerificationTokenExpiruMinutes)));

            CreateMap<string, RefreshToken>().ForMember(dest => dest.Id, opt => opt.MapFrom(src => Guid.NewGuid()))
                                            .ForMember(dest => dest.ExpiresAt, opt => opt.MapFrom(src => DateTime.UtcNow.AddDays(TimeConstant.RefreshTokenExpiryDays)))
                                            .ForMember(dest => dest.TokenHash, opt => opt.MapFrom(src => SecretUtil.HashToken(src)));
            CreateMap<RegisterMentorRequest, User>()
                                            .ForMember(dest => dest.Role, opt => opt.MapFrom(src => RoleType.Mentor));
            #endregion

            #region Industry
            CreateMap<CreateIndustryRequest, Industry>();
            CreateMap<UpdateIndustryRequest, Industry>();
            CreateMap<Industry, IndustryDto>();
            #endregion

            #region User
            CreateMap<User, UserDto>();
            CreateMap<UpdateUserRequest, User>();
            #endregion 
        }
    }
}
