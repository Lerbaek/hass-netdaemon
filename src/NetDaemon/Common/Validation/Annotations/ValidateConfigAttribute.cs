using Microsoft.Extensions.Options;

namespace Lerbaek.NetDaemon.Common.Validation.Annotations;

[AttributeUsage(AttributeTargets.Class)]
public class ValidateConfigAttribute<TOptions, TValidator> : Attribute, IValidateAttribute
    where TOptions : class, new()
    where TValidator : IValidateOptions<TOptions>, new()
{
    public void Validate() => new TValidator().Validate(null, new());
}