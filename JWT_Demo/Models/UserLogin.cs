using System.ComponentModel.DataAnnotations;

namespace JWT_Demo.Models
{
    public class UserLogin
    {
        [Required]
        public string UserName
        {
            get;
            set;
        }
        [Required]
        public string Password
        {
            get;
            set;
        }
        public UserLogin() { }
    }
}
