using RegistrationFormAPI.Entities;
using RegistrationFormAPI.Repositories;
using System.Threading.Tasks;

namespace RegistrationFormAPI.Services
{

    public class RegistrationFormService
    {
        private RegistrationFormRepository _registrationFormRepository;

        public RegistrationFormService(RegistrationFormRepository registrationFormRepository)
        {
            _registrationFormRepository = registrationFormRepository;
        }
        public async Task<Registration> GetAllAsync()
        {
            return await _registrationFormRepository.GetRegistrationForm();
        }
    }
}
