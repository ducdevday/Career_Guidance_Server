using CareerGuidance.BussinessLogic.Interface;
using CareerGuidance.DTO.Request;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CareerGuidance.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class IndustryController : ControllerBase
    {
        private readonly IIndustryBusiness _industryBusiness;
        public IndustryController(IIndustryBusiness industryBusiness)
        {
            _industryBusiness = industryBusiness;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById([FromRoute] int id)
        {
            var result = await _industryBusiness.GetIndustryByIdAsync(id);
            HttpContext.Response.StatusCode = (int)result.StatusCode;
            return new JsonResult(result);
        }

        [HttpGet("Home")]
        public async Task<IActionResult> GetHomeIndustry()
        {
            var result = await _industryBusiness.GetHomeIndustryAsync();
            HttpContext.Response.StatusCode = (int)result.StatusCode;
            return new JsonResult(result);
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] CreateIndustryRequest request)
        {
            var result = await _industryBusiness.CreateIndustryAsync(request);
            HttpContext.Response.StatusCode = (int)result.StatusCode;
            return new JsonResult(result);
        }

        [HttpPut("{id:int}")]
        public async Task<IActionResult> Update([FromRoute] int id, [FromBody] UpdateIndustryRequest request)
        {
            request.Id = id;
            var result = await _industryBusiness.UpdateIndustryAsync(request);
            HttpContext.Response.StatusCode = (int)result.StatusCode;
            return new JsonResult(result);
        }

        [HttpDelete("{id:int}")]
        public async Task<IActionResult> SoftDelete([FromRoute] int id)
        {
            var result = await _industryBusiness.SoftDeleteIndustryAsync(id);
            HttpContext.Response.StatusCode = (int)result.StatusCode;
            return new JsonResult(result);
        }

        [HttpDelete("{id:int}/permanent")]
        public async Task<IActionResult> HardDelete([FromRoute] int id)
        {
            var result = await _industryBusiness.HardDeleteIndustryAsync(id);
            HttpContext.Response.StatusCode = (int)result.StatusCode;
            return new JsonResult(result);
        }

        [HttpGet("Search")]
        public async Task<IActionResult> Search([FromQuery] SearchIndustryRequest request)
        {
            var result = await _industryBusiness.SearchAsync(request);
            HttpContext.Response.StatusCode = (int)result.StatusCode;
            return new JsonResult(result);
        }
    }
}
