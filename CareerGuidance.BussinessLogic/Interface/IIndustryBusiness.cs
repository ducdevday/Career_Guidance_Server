using CareerGuidance.DTO.Request;
using CareerGuidance.DTO.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareerGuidance.BussinessLogic.Interface
{
    public interface IIndustryBusiness 
    {
        public Task<CreateIndustryResponse> CreateIndustryAsync(CreateIndustryRequest request);    
        public Task<GetIndustryByIdResponse> GetIndustryAsync(GetIndustryRequest request);
        public Task<UpdateIndustryResponse> UpdateIndustryAsync(UpdateIndustryRequest request);
        public Task<DeleteIndustryResponse> SoftDeleteIndustryAsync(DeleteIndustryRequest request);
        public Task<DeleteIndustryResponse> HardDeleteIndustryAsync(DeleteIndustryRequest request);
        public Task<SearchIndustryResponse> SearchAsync(SearchIndustryRequest request);
        public Task<GetHomeIndustryResposne> GetHomeIndustryAsync();
    }
}
