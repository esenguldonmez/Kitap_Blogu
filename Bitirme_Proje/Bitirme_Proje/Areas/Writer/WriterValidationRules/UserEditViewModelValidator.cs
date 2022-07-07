using Bitirme_Proje.Areas.Writer.Models;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bitirme_Proje.Areas.Writer.WriterValidationRules
{
    public class UserEditViewModelValidator: AbstractValidator<UserEditViewModel>
    {
        public UserEditViewModelValidator()
        {
            RuleFor(x => x.Password).NotEmpty().WithMessage("Şifre alanı boş geçilemez!");
            RuleFor(x => x.PasswordConfirm).NotEmpty().WithMessage("Şifre alanı boş geçilemez!");
        }
    }
}
