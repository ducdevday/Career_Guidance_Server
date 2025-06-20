using AutoMapper;
using CareerGuidance.Data.Entity;
using CareerGuidance.DTO.Request;
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
                                            .ForMember(dest => dest.Password, opt => opt.MapFrom(src => PasswordUtil.HashPassword(src.Password)));
            #endregion

        }
    }
}
