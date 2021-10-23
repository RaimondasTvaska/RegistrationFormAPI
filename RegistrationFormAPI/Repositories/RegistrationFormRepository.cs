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
               .FirstOrDefaultAsync(r => r.Id == 4);

        }
        //public async Task<Registration> CreateRegistrationForm(Registration registration)
        //{
        //    var entity = new Registration()
        //    {
        //        Id = registration.Id,
        //        QuestionAnswers = registration.QuestionAnswers,
        //    };
        //    _dataContext.Add(entity);
        //    await _dataContext.SaveChangesAsync();
        //    return entity;
        //}
    }
}
