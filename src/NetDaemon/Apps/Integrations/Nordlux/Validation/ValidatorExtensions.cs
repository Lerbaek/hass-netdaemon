using FluentValidation;

namespace Lerbaek.NetDaemon.Apps.Integrations.Nordlux.Validation;

public static class ValidatorExtensions
{
    public static IEnumerable<IRuleBuilderOptions<T, Version>> GreaterThanZero<T>(this IEnumerable<IRuleBuilderInitial<T, Version>> ruleBuilders)
        => ruleBuilders.Select(GreaterThanZero);

    public static IRuleBuilderOptions<T, Version> GreaterThanZero<T>(this IRuleBuilderInitial<T, Version> ruleBuilder) =>
        ruleBuilder.GreaterThan(new Version(0, 0));
}