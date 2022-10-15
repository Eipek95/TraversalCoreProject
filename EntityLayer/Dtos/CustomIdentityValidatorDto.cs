using Core;
using Microsoft.AspNetCore.Identity;

namespace EntityLayer.Dtos
{
    public class CustomIdentityValidatorDto : IdentityErrorDescriber, IDto
    {
        //add startup in add
        public override IdentityError PasswordTooShort(int length)
        {
            return new IdentityError()
            {
                Code = "PasswordTooShort",
                Description = $"Parola Minimum {length} Karekter Olmalıdır"
            };
        }
        public override IdentityError PasswordRequiresDigit()
        {
            return new IdentityError
            {
                Code = "PasswordRequiresDigit",
                Description = $"Parolaa en az 1 tane rakam içermelidir('0'.'9')"
            };
        }
        public override IdentityError PasswordRequiresLower() => new IdentityError { Code = "PasswordRequiresLower", Description = $"Parola en az 1  tane küçük karekter içermelidir('a'.'z')" };
        public override IdentityError PasswordRequiresUpper() => new IdentityError
        {
            Code = "PasswordRequiresUpper",
            Description = $"Parola en az 1  tane büyük karekter içermelidir('A'.'Z')"
        };
        public override IdentityError PasswordRequiresNonAlphanumeric() => new IdentityError
        {
            Code = "PasswordRequiresNonAlphanumeric",
            Description = $"Parola en az 1  tane sembol içermelidir('.'.',','!','&')"
        };
    }
}
