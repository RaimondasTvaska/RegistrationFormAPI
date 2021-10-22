using Microsoft.EntityFrameworkCore;
using RegistrationFormAPI.Data;
using RegistrationFormAPI.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace RegistrationFormAPI.Repositories
{
    public class QuestionRepository
    {
        private readonly DataContext _dataContext;

        public QuestionRepository(DataContext context)
        {
            _dataContext = context;
        }
        public async Task<List<Question>> GetAllQuestions()
        {
            return await _dataContext.Questions.ToListAsync();
        }
    }
}
