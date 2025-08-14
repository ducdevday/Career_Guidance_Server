using CareerGuidance.BussinessLogic.Business;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CareerGuidance.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AddressController : ControllerBase
    {
        private readonly LocationSyncService _sync;
        
        public AddressController(LocationSyncService sync)
        {
            _sync = sync;
        }

        [HttpPost("Async")]
        public async Task<IActionResult> SyncAll(CancellationToken ct)
        {
            var provinces = await _sync.SyncAllAsync(ct);
            return Ok(new { message = "Sync done", provinces });
        }
    }
}
