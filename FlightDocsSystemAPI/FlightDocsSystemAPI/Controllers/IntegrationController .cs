using FlightDocsSystemAPI.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FlightDocsSystemAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class IntegrationController : ControllerBase
    {
        private readonly IntegrationService _integrationService;

        public IntegrationController(IntegrationService integrationService)
        {
            _integrationService = integrationService;
        }

        [HttpPost]
        public async Task<IActionResult> Integrate([FromBody] IntegrationRequest request)
        {
            var result = await _integrationService.IntegrateAsync(request);
            if (!result.Success) return BadRequest(result.Message);
            return Ok(result);
        }
    }

}
