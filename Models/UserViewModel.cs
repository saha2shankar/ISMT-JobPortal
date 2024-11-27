using System.ComponentModel.DataAnnotations;

namespace IsmtJobportal.Models
{
    public class UserViewModel
    {

        [Required(ErrorMessage ="FullName is Required !")]
        public string FullName { get; set; }
        [Required(ErrorMessage ="Email is Required !")]
        public string Email { get; set; }

        [Required(ErrorMessage ="UserName Required !")]
        public string Username { get; set; }

        [Required(ErrorMessage ="Password Required!")]
        public string Password { get; set; }
    }
}
