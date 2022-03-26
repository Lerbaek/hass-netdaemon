using Lerbaek.NetDaemon.Apps.Integrations.Nordlux.Configuration;

namespace Lerbaek.NetDaemon.Apps.Integrations.Nordlux;

public class RequestHandler : IRequestHandler
{
  private readonly NordluxConfig config;
  private readonly ILogger logger;
  private readonly HttpClient httpClient;

  public RequestHandler(IAppConfig<NordluxConfig> config, ILogger<NordluxConfig> logger, IHttpClientFactory httpClientFactory)
  {
    this.config = config.Value;
    this.logger = logger;
    httpClient = httpClientFactory.CreateClient(nameof(Nordlux));
  }

  public async Task<HttpResponseMessage> Send(string cipher, RequestType requestType = RequestType.Set)
  {
    using var requestMessage = GenerateRequestMessage(cipher, requestType);
    return await SendAndLog(requestMessage);
  }

  private HttpRequestMessage GenerateRequestMessage(string cipher, RequestType requestType = RequestType.Set)
  {
    HttpRequestMessage requestMessage = new(
      HttpMethod.Post,
      $"https://api.yankon-xm.com:443/smartLight/{(requestType == RequestType.Set ? "api/device/controllerBLE" : "v1/device/getBulbStatus")}")
    {
      Content = new FormUrlEncodedContent(new[]
      {
        new KeyValuePair<string?, string?>(
          "cipher", cipher)
      })
    };
    var headers = config.Headers!;
    requestMessage.Headers.TryAddWithoutValidation("authorization", headers.Authorization);
    requestMessage.Headers.Add("sign", headers.Sign);
    logger.LogTrace("Generated request message.");
    logger.LogTrace("URI: {RequestUri}", requestMessage.RequestUri!.OriginalString);
    logger.LogTrace("Cipher: {Cipher}", cipher);

    return requestMessage;
  }

  private async Task<HttpResponseMessage> SendAndLog(HttpRequestMessage requestMessage)
  {
    logger.LogTrace("Sending request");
    var response = await httpClient.SendAsync(requestMessage);
    logger.LogTrace("Response: {StatusCode}({Status})", (int)response.StatusCode, response.StatusCode);
    return response;
  }
}