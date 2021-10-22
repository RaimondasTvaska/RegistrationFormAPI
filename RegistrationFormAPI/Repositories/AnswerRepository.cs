using Microsoft.EntityFrameworkCore;
using RegistrationFormAPI.Data;
using RegistrationFormAPI.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace RegistrationFormAPI.Repositories
{
    public class AnswerRepository
    {
        private readonly DataContext _dataContext;

        public AnswerRepository(DataContext context)
        {
            _dataContext = context;
        }
        public async Task<List<Answer>> GetAllAnswers()
        {
            return await _dataContext.Answers.ToListAsync();
        }
    }
}
