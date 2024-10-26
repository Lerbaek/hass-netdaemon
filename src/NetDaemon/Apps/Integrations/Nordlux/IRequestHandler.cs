using Lerbaek.NetDaemon.Apps.Integrations.Nordlux.Model;

namespace Lerbaek.NetDaemon.Apps.Integrations.Nordlux;

public interface IRequestHandler
{
  Task<HttpResponseMessage> Send<T>(T body, string apiService = ApiPathConstants.ControllerBle) where T : RequestBase;
}