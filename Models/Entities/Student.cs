using System.ComponentModel.DataAnnotations;

namespace mvc_demo.Models.Entities
{
    public class Student
    {
        public int StudentId { get; set; }
        [Required]
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
    }
    
}
