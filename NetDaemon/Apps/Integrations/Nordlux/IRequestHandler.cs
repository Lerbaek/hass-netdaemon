namespace Lerbaek.NetDaemon.Apps.Integrations.Nordlux;

public interface IRequestHandler
{
  Task<HttpResponseMessage> Send(string cipher, RequestType requestType = RequestType.Set);
}