using EntityLayer.Concrete;
using FluentValidation;

namespace BusinessLayer.ValidationRules
{
    public class GuideValidator : AbstractValidator<Guide>
    {
        public GuideValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Lütfen rehber adını giriniz");
            RuleFor(x => x.Description).NotEmpty().WithMessage("Lütfen rehber açıklamasını giriniz");
            RuleFor(x => x.Image).NotEmpty().WithMessage("Lütfen rehber görselini giriniz");
            RuleFor(x => x.Name).MaximumLength(30).WithMessage("Lütfen 30 Karekterden oluşan daha kısa bir isism giriniz");
            RuleFor(x => x.Name).MinimumLength(8).WithMessage("Lütfen 8 Karekterden oluşan daha uzun bir isism giriniz");
        }
    }
}
