using Domain.DTOs.Employees;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Applications.Validation
{
    public class NewEmployeeValidator : AbstractValidator<NewEmployee>
    {
        public NewEmployeeValidator()
        {
            RuleFor(x => x.Username)
                .NotEmpty().WithMessage("اسم المستخدم مطلوب.");

            RuleFor(x => x.PhoneNumber)
                .NotEmpty().WithMessage("رقم الهاتف مطلوب.")
                .Matches(@"^09[1-5]\d{7}$").WithMessage("رقم الهاتف غير صحيح");

            RuleFor(x => x.Salary)
                .GreaterThan(0).WithMessage("المرتب يجب أن يكون رقمًا أكبر من صفر.");

            RuleFor(x => x.PermissionId)
                .GreaterThan(0).WithMessage("الصلاحية مطلوبة.");

        }
    }
}
