using System.Collections.Generic;

namespace RegistrationFormAPI.Entities
{
    public class Registration
    {
        public int Id { get; set; }
        public List<QuestionAnswer> QuestionAnswers { get; set; }
    }
}
