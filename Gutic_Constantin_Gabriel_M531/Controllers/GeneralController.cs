using Gutic_Constantin_Gabriel_M531.Contracts;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Gutic_Constantin_Gabriel_M531.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GeneralController : ControllerBase
    {
        private readonly IGeneralService _generalService;

        public GeneralController(IGeneralService generalService)
        {
            _generalService = generalService;
        }

        [HttpPost("MoveClient")]
        public IActionResult MoveClient(Guid oldBankId, Guid newBankId, Guid clientId)
        {
            try
            {
                _generalService.MoveClient(oldBankId, newBankId, clientId);
                return Ok("Client moved successufully");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("SameClient")]
        public IActionResult SameClient(Guid clientId)
        {
            if (_generalService.SameClient(clientId))
            {
                return Ok("Yes, the client is present at different banks");
            }
            return Ok("No, the client is not present at different banks");
        }
    }
}
