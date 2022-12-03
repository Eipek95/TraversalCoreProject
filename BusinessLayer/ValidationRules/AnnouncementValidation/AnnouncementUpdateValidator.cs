using DTOLayer.DTOs.AnnouncementDTOs;
using FluentValidation;

namespace BusinessLayer.ValidationRules.AnnouncementValidation
{
    public class AnnouncementUpdateValidator : AbstractValidator<AnnoucementUpdateDto>
    {
        public AnnouncementUpdateValidator()
        {
            RuleFor(x => x.Content).NotEmpty().WithMessage("İçerik Boş Geçilemez");
            RuleFor(x => x.Title).NotEmpty().WithMessage("Başlık Boş Geçilemez");
            RuleFor(x => x.Content).MinimumLength(5).WithMessage("Lütfen en az 5 karekter giriniz.");
            RuleFor(x => x.Title).MinimumLength(5).WithMessage("Lütfen en az 5 karekter giriniz.");
            RuleFor(x => x.Content).MaximumLength(500).WithMessage("Lütfen en fazla 500 karekter giriniz.");
            RuleFor(x => x.Title).MaximumLength(50).WithMessage("Lütfen en fazla 50 karekter giriniz.");
        }
    }
}
