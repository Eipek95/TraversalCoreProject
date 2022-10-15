using Core;
using System.ComponentModel.DataAnnotations;

namespace EntityLayer.Dtos
{
    public class UserSignInViewModelDto : IDto
    {
        [Required(ErrorMessage = "Lütfen Kullanıcı Adını Giriniz")]
        public string UserName { get; set; }
        [Required(ErrorMessage = "Lütfen Şifrenizi Giriniz")]
        public string Password { get; set; }
    }
}
