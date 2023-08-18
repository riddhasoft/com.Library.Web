using com.Library.Web.Models;
using System.ComponentModel.DataAnnotations;

namespace com.Library.Web.Controllers.ViewModel
{
    public class SignupViewModel : UserModel
    {
        [DataType(DataType.Password), Compare("Password")]
        public string ConfirmPassword { get; set; }
    }

    public class LoginViewModel
    {
        [Required]
        public string Username { get; set; }
        [Required]
        public string Password { get; set; }
    }
}
