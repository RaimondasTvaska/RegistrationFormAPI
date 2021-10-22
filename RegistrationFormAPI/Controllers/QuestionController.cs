using Microsoft.AspNetCore.Mvc;
using RegistrationFormAPI.Entities;
using RegistrationFormAPI.Services;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace RegistrationFormAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class QuestionController : Controller
    {
        private readonly QuestionService _questionService;

        public QuestionController(QuestionService questionService)
        {
            _questionService = questionService;
        }

        [HttpGet]
        public async Task<ActionResult<List<Question>>> GetAllQuestions()
        {
            return Ok(await _questionService.GetAllAsync());
        }
    }
}
