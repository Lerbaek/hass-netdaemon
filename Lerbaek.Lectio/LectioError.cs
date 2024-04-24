using FluentResults;

namespace Lerbaek.Lectio
{
  public static class LectioError
  {
    public static Error BadCredentials { get; } = new Error("Wrong username and/or password");
    public static Error AttributeNotFound { get; } = new Error("Attribute not found");
  }
}