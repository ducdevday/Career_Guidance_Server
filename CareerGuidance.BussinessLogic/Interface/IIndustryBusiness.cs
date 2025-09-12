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
        public Task<GetIndustryByIdResponse> GetIndustryByIdAsync(int id);
        public Task<UpdateIndustryResponse> UpdateIndustryAsync(UpdateIndustryRequest request);
        public Task<DeleteIndustryResponse> SoftDeleteIndustryAsync(int id);
        public Task<DeleteIndustryResponse> HardDeleteIndustryAsync(int id);
        public Task<SearchIndustryResponse> SearchAsync(SearchIndustryRequest request);
        public Task<GetHomeIndustryResposne> GetHomeIndustryAsync();
    }
}
