using FluentValidation;
using FluentValidation.Validators;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoDomain.Validadores
{
    public static class RuleBuilderExtension
    {
        public static IRuleBuilderOptions<T, string> IsValidName<T>(this IRuleBuilder<T, string> ruleBuilder)
        {
            return ruleBuilder.SetValidator(new RegularExpressionValidator(@"[a-z]|[A-Z]|\s"));
        }
        public static IRuleBuilderOptions<T, string> IsValidCpf<T>(this IRuleBuilder<T, string> ruleBuilder)
        {
            return ruleBuilder.SetValidator(new RegularExpressionValidator(@"^\d{3}\.?\d{3}\.?\d{3}\-?\d{2}$"));
        }
        public static IRuleBuilderOptions<T, string> IsValidDateBirth<T>(this IRuleBuilder<T, string> ruleBuilder)
        {
            return ruleBuilder.SetValidator(new RegularExpressionValidator(@"^((0?[1-9]|[12][0-9]|3[01])[\/\-](0?[1-9]|1[012])[\/\-]((19)\d\d))|((0?[1-9]|[12][0-9]|3[01])[\/\-](0?[1-9]|1[012])[\/\-](20[01]{2}))|((0?[1])[\/\-](0?1)[\/\-](2002))"));
        }
        public static IRuleBuilderOptions<T, DateTime> IsValidDate<T>(this IRuleBuilder<T, DateTime> ruleBuilder)
        {
            return ruleBuilder.Must(q=>q.Date>=DateTime.Now);
        }
        public static IRuleBuilderOptions<T, int> IsValidNote<T>(this IRuleBuilder<T, int> ruleBuilder)
        {
            return ruleBuilder.Must(q => q >= 0 && q<=100);
        }
    }
}
