using Gutic_Constantin_Gabriel_M531.Classes;
using Gutic_Constantin_Gabriel_M531.Contracts;
using Gutic_Constantin_Gabriel_M531.Dto;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Gutic_Constantin_Gabriel_M531.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BankController : ControllerBase
    {
        private readonly IBankService _bankService;

        public BankController(IBankService bankService)
        {
            _bankService = bankService;
        }

        [HttpPost("AddClient")]
        public IActionResult AddClient(Guid bankId, ClientDto clientDto)
        {
            try
            {
                _bankService.AddClient(bankId, new Client()
                {
                    LastName = clientDto.LastName,
                    FirstName = clientDto.FirstName,
                    Birthdate = clientDto.Birthdate,
                    Address = new Address()
                    {
                        Street = clientDto.AddressStreet,
                        Number = clientDto.AddressNumber,
                        Apartment = clientDto.AddressApartment,
                    },
                    CreditType = clientDto.CreditType,
                });
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

            return Ok("Client added successfully");
        }

        [HttpDelete("RemoveClient")]
        public IActionResult RemoveClient(Guid bankId, Guid clientId)
        {
            try
            {
                _bankService.RemoveClient(bankId, clientId);
                return Ok("Client removed successfully");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut("UpdatedData")]
        public IActionResult UpdatedData(Guid bankId, BankDto bankDto)
        {
            try
            {
                _bankService.UpdatedData(bankId, bankDto.Name, new Address()
                {
                    Street = bankDto.AddressStreet,
                    Number = bankDto.AddressNumber,
                    Apartment = bankDto.AddressApartment,
                });
                return Ok("Data updated successfully");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("DisplayClients")]
        public IActionResult DisplayClients(Guid bankId)
        {
            try
            {
                return Ok(_bankService.DisplayClients(bankId));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost("FilterClients")]
        public IActionResult FilterClients(Guid bankId, ClientFilterDto clientFilter)
        {
            try
            {
                return Ok(_bankService.FilterClients(bankId, clientFilter.Name, clientFilter.AddressId, clientFilter.CreditType));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
