using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class PortfolioValidator : AbstractValidator<Portfolio>
    {
        public PortfolioValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Kitap adı boş geçilemez");
            RuleFor(x => x.ImageUrl).NotEmpty().WithMessage("Görsel alanı boş geçilemez");
            RuleFor(x => x.ImageUrl2).NotEmpty().WithMessage("Görsel2 alanı boş geçilemez");
            RuleFor(x => x.Sayfa).NotEmpty().WithMessage("Sayfa alanı boş geçilemez");
            RuleFor(x => x.Konu).NotEmpty().WithMessage("Konu alanı boş geçilemez");
            RuleFor(x => x.Value).NotEmpty().WithMessage("Tamamlanma oranı boş geçilemez");
            RuleFor(x => x.BookUrl).NotEmpty().WithMessage("Kitap Url boş geçilemez");
            RuleFor(x => x.Name).MinimumLength(5).WithMessage("Kitap adı en az 5 karakterden oluşmak zorundadır");
            RuleFor(x => x.Name).MaximumLength(100).WithMessage("Kitap adı en fazla 100 karakterden oluşmak zorundadır");
        }
    }
}
