namespace Lerbaek.NetDaemon.Common.Notifications;

public class ActionUri
{
  private readonly string _uri;

  private ActionUri(string uri) => _uri = uri;

  public static ActionUri Lovelace(string dashboard) => new($"/lovelace/{dashboard}");

  public static ActionUri Uri(string uri) => new(uri);
  public static ActionUri Uri(Uri uri) => new(uri.AbsoluteUri);

  public static class Android
  {
    public static ActionUri App(string appId) => new($"app://{appId}");
    public static ActionUri MoreInfo(string entityId) => new($"entityId:{entityId}");
  }

  public static implicit operator string(ActionUri actionUri) => actionUri._uri;
}