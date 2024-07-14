namespace Lerbaek.NetDaemon.Common.Reflection;

public static class ReflectionExtensions
{
  public static IEnumerable<TPropertyType> GetPropertiesOfType<TPropertyType>(this object entities)
    => entities
      .GetType()
      .GetProperties()
      .Select(propertyInfo => 
        propertyInfo
          .GetMethod!
          .Invoke(
            entities,
            [])!)
      .OfType<TPropertyType>();
}