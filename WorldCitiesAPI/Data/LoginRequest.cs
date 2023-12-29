using System.ComponentModel.DataAnnotations;

namespace WorldCitiesAPI.Data
{
    public class LoginRequest
    {
        [Required(ErrorMessage = "Email is Required.")]
        public string Email { get; set; } = null!;

        [Required(ErrorMessage = "Password is Required.")]
        public string Password { get; set; } = null!;
    }
}
