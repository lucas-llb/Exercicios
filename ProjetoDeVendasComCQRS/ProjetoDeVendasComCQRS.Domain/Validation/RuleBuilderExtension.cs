using FluentValidation;
using FluentValidation.Validators;
using System;

namespace ProjetoDeVendasComCQRS.Domain.Validation
{
    public static class RuleBuilderExtension
    {
        public static IRuleBuilderOptions<T, double> IsValidPrice<T>(this IRuleBuilder<T, double> ruleBuilder)
        {
            return ruleBuilder.Must(q => q > 0.00);
        }
        public static IRuleBuilderOptions<T, int> IsValidInteger<T>(this IRuleBuilder<T, int> ruleBuilder)
        {
            return ruleBuilder.Must(q => q > 0);
        }
        public static IRuleBuilderOptions<T, DateTime> IsValidDate<T>(this IRuleBuilder<T, DateTime> ruleBuilder)
        {
            return ruleBuilder.Must(q => q.Date >= DateTime.Now);
        }
    }
}
