using DTOLayer.DTOs.AnnouncementDTOs;
using FluentValidation;

namespace BusinessLayer.ValidationRules
{
    public class AmouncementValidator : AbstractValidator<AnnouncementAddDTO>
    {
        public AmouncementValidator()
        {
            RuleFor(x => x.Title).NotEmpty().WithMessage("Lütfen Başlığı boş geçmeyiniz");
            RuleFor(x => x.Content).NotEmpty().WithMessage("Lütfen Duyuruyu boş geçmeyiniz");
            RuleFor(x => x.Title).MinimumLength(5).WithMessage("Lütfen En az 5 karekter giriniz");
            RuleFor(x => x.Content).MinimumLength(5).WithMessage("Lütfen En az 5 karekter giriniz");
            RuleFor(x => x.Title).MaximumLength(50).WithMessage("Lütfen En fazla 20 karekter giriniz");
            RuleFor(x => x.Content).MaximumLength(500).WithMessage("Lütfen En fazla 20 karekter giriniz");
        }
    }
}
