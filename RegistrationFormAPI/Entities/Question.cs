using System.Collections.Generic;

namespace RegistrationFormAPI.Entities
{
    public class Question
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Answer> Assortment { get; set; }
    }
}
