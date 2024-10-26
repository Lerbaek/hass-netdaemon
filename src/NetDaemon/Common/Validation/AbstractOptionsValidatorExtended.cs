using Microsoft.Extensions.Options;

namespace Lerbaek.NetDaemon.Common.Validation;

public abstract class AbstractOptionsValidatorExtended<TOptions> : AbstractValidatorExtended<TOptions>, IValidateOptions<TOptions> where TOptions : class, new()
{
    public ValidateOptionsResult Validate(string? name, TOptions options)
    {
        var validateResult = Validate(options);
        return validateResult.IsValid
            ? ValidateOptionsResult.Success
            : ValidateOptionsResult.Fail(validateResult.Errors.Select(x => x.ErrorMessage));
    }
}