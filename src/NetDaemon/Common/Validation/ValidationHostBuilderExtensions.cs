using Lerbaek.NetDaemon.Common.Validation.Annotations;

namespace Lerbaek.NetDaemon.Common.Validation;

public static class ValidationHostBuilderExtensions
{
    public static IHostBuilder ValidateConfig(this IHostBuilder host, Assembly? assembly = null)
    {
        assembly ??= Assembly.GetCallingAssembly();
        var types = assembly.GetTypes();
        foreach (var validateConfig in GetValidateConfigAttributes(types))
        {
            validateConfig.Validate();
        }

        return host;
    }

    private static IEnumerable<IValidateAttribute> GetValidateConfigAttributes(Type[] types)
    {
        foreach (var type in types)
        {
            if(type.GetCustomAttribute(typeof(ValidateConfigAttribute<,>)) is IValidateAttribute attribute)
                yield return attribute;
        }
    }
}