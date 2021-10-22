using Microsoft.AspNetCore.Mvc;
using RegistrationFormAPI.Services;
using System.Threading.Tasks;

namespace RegistrationFormAPI.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class RegistrationFormController : ControllerBase
    {
        private readonly RegistrationFormService _registrationFormService;

        public RegistrationFormController(RegistrationFormService registrationFormService)
        {
            _registrationFormService = registrationFormService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {

            return Ok(await _registrationFormService.GetAllAsync());
        }
    }
}
