using Microsoft.EntityFrameworkCore;
using RegistrationFormAPI.Data;
using RegistrationFormAPI.Entities;
using System.Threading.Tasks;

namespace RegistrationFormAPI.Repositories
{

    public class RegistrationFormRepository
    {
        private readonly DataContext _dataContext;

        public RegistrationFormRepository(DataContext context)
        {
            _dataContext = context;
        }
        public async Task<Registration> GetRegistrationForm()
        {
            return await _dataContext.Registrations
               .Include(r => r.QuestionAnswers)
               .ThenInclude(qa => qa.Question)
                   .ThenInclude(q => q.Assortment)
               .FirstOrDefaultAsync(r => r.Id == 1);

        }
    }
}
