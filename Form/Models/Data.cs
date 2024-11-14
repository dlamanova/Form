using System.ComponentModel.DataAnnotations;

namespace Form.Models
{
    public class Data
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Enter name!")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Enter valid email!")]
        [RegularExpression(".+\\@.+\\.[a-z]{2,3}")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Provide topic")]
        public string Topic { get; set; }

        [Required(ErrorMessage = "Enter message (max lenght 50 characters)")]
        [MinLength(10), MaxLength(50)]
        public string Content { get; set; }
    }
}
