using Microsoft.AspNetCore.Mvc;
using RegistrationFormAPI.Services;

namespace RegistrationFormAPI.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class AnswerController : Controller
    {
        private readonly AnswerService _answerService;

        public AnswerController(AnswerService answerService)
        {
            _answerService = answerService;
        }

        //[HttpGet]
        //public async Task<ActionResult<List<Answer>>> GetAllAnswers()
        //{
        //    return Ok(await _answerService.GetAllAsync());
        //}
    }

}
