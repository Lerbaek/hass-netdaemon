namespace Lerbaek.NetDaemon.Apps.Integrations.Nordlux;

public interface IRequestHandler
{
  Task<HttpResponseMessage> Send(string body, string apiPath = ApiPath.Controller);
}