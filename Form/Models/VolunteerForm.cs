using System.ComponentModel.DataAnnotations;

namespace Form.Models
{
    public class VolunteerForm
    {
        [Required(ErrorMessage = "Imię jest wymagane.")]
        [MinLength(2, ErrorMessage = "Imię musi mieć co najmniej 2 znaki.")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Nazwisko jest wymagane.")]
        [MinLength(2, ErrorMessage = "Nazwisko musi mieć co najmniej 2 znaki.")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Adres e-mail jest wymagany.")]
        [EmailAddress(ErrorMessage = "Podaj poprawny adres e-mail.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Hasło jest wymagane.")]
        [DataType(DataType.Password)]
        [RegularExpression(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d).{8,}$", ErrorMessage = "Hasło musi mieć co najmniej 8 znaków, jedną cyfrę, jedną dużą i jedną małą literę.")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Potwierdzenie hasła jest wymagane.")]
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "Hasła muszą być takie same.")]
        public string ConfirmPassword { get; set; }

        [Phone(ErrorMessage = "Podaj poprawny numer telefonu.")]
        [RegularExpression(@"^\d{9}$", ErrorMessage = "Numer telefonu musi składać się z dokładnie 9 cyfr.")]
        public string Phone { get; set; }

        [Range(11, 80, ErrorMessage = "Wiek musi być między 11 a 80.")]
        public int Age { get; set; }

        [Required(ErrorMessage = "Miasto jest wymagane.")]
        public Cities City { get; set; }

        public enum Cities
        {
            Warsaw,
            Krakow,
            Gdansk,
            Wroclaw,
            Poznan
        }
    }
}
