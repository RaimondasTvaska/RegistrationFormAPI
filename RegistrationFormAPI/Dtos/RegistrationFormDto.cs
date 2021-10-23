using RegistrationFormAPI.Entities;

namespace RegistrationFormAPI.Dtos
{
    public class RegistrationFormDto
    {
        public int RegistrationId { get; set; }
        public int QuestionId { get; set; }
        public Question Question { get; set; }
        public int AnswerId { get; set; }
    }
}
