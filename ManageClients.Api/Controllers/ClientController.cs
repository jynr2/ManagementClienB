using ManageClients.Service.DTOs;
using Microsoft.AspNetCore.Mvc;
using ManageClients.Service.Interfaces;

namespace ManageClients.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ClientController : Controller
    {
        private readonly IClientService _clientService;

        public ClientController(IClientService clientService)
        {
            _clientService = clientService;
        }

        [HttpGet("[action]")]
        public IActionResult SearchClient([FromQuery] ClientRequest client)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var result = _clientService.GetCustomerByTypeAndDocumentNumber(client);
                    if (result != null)
                        return Ok(result);
                    else
                        return NotFound("Client not found");
                }
                else
                    return BadRequest();
            }
            catch (Exception)
            {
                return StatusCode(500);
            }

        }
    }
}
