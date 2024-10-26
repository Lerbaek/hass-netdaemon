using System.Linq.Expressions;
using FluentValidation;

namespace Lerbaek.NetDaemon.Common.Validation;

public abstract class AbstractValidatorExtended<T> : AbstractValidator<T>
{
    public IEnumerable<IRuleBuilderInitial<T, TProperty>> RuleForMany<TProperty>(
        IEnumerable<Expression<Func<T, TProperty>>> expressions)
    {
        return expressions.Select(RuleFor);
    }
}