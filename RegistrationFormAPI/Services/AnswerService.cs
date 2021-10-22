using RegistrationFormAPI.Entities;
using RegistrationFormAPI.Repositories;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RegistrationFormAPI.Services
{
    public class AnswerService
    {
        private AnswerRepository _answerRepository;

        public AnswerService(AnswerRepository answerRepository)
        {
            _answerRepository = answerRepository;
        }

        public async Task<List<Answer>> GetAllAsync()
        {
            var answerEntity = await _answerRepository.GetAllAnswers();
            return answerEntity.ToList();
        }
    }
}
