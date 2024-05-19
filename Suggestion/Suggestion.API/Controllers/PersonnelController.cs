using Microsoft.AspNetCore.Mvc;
using Suggestion.Business.Abstract.PersonnelService;
using Suggestion.Domain.Entities.PersonnelEntity;

namespace Suggestion.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PersonnelController : ControllerBase
    {
        private IPersonnelService _personnelService;

        public PersonnelController(IPersonnelService personnelService)
        {
            _personnelService = personnelService;
        }

        [HttpPost]
        public void Add([FromBody] PersonnelEntity personnelEntity)
        {
            _personnelService.Add(personnelEntity);
        }

        [HttpGet("Login")]
        public IActionResult Login([FromQuery] string email, [FromQuery] string password)
        {
            return Ok(_personnelService.Login(email, password));
        }
    }
}
