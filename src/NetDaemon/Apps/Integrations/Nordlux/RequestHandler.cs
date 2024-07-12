using System.Net.Http.Json;
using System.Security.Cryptography;
using Lerbaek.NetDaemon.Apps.Integrations.Nordlux.Configuration;
using static System.Text.Encoding;
using Convert = System.Convert;

namespace Lerbaek.NetDaemon.Apps.Integrations.Nordlux;

public class RequestHandler : IRequestHandler
{
  private readonly NordluxConfig config;
  private readonly ILogger logger;
  private readonly HttpClient httpClient;
  private readonly Aes aes;

  public RequestHandler(IAppConfig<NordluxConfig> config, ILogger<NordluxConfig> logger, IHttpClientFactory httpClientFactory)
  {
    this.config = config.Value;
    this.logger = logger;
    httpClient = httpClientFactory.CreateClient(nameof(Nordlux));

    aes = Aes.Create();
    aes.KeySize = 128;
    aes.Key = config.Value.SecretKey!.Select(Convert.ToByte).ToArray();
    aes.Mode = CipherMode.ECB;
  }

  public async Task<HttpResponseMessage> Send(string body, string apiPath = ApiPath.Controller)
  {
    var encryptedBody = aes.EncryptEcb(UTF8.GetBytes(body), PaddingMode.PKCS7);
    var cipher = Convert.ToHexString(encryptedBody);
    using var requestMessage = await GenerateRequestMessage(cipher, apiPath);
    return await SendAndLog(requestMessage);
  }

  private async Task<HttpRequestMessage> GenerateRequestMessage(string cipher, string apiPath = ApiPath.Controller)
  {
    HttpRequestMessage requestMessage = new(
      HttpMethod.Post,
      $"https://api.yankon-xm.com:443/smartLight/{apiPath}")
    {
      Content = JsonContent.Create(new
      {
        cipher
      })
    };
    requestMessage.Headers.Host = "api.yankon-xm.com";
    var timestamp = DateTime.Now.ToString("yyyyMMddHHmmss");
    // ZDc4MGQ1ZjNjNzA2ODUxYWQzODZlN2Q3YWNkYWY2Zjc6MjAyMzExMTIyMjA2MjE=
    var authorization = Convert.ToBase64String(UTF8.GetBytes($"{config.AccessKey}:{timestamp}"));
    requestMessage.Headers.TryAddWithoutValidation("authorization", authorization);
    var contentLength = (await requestMessage.Content.ReadAsStringAsync()).Length;
    requestMessage.Content.Headers.ContentLength = contentLength;

    var sign = Convert.ToHexString(MD5.HashData(UTF8.GetBytes($"{config.AccessKey}{config.SecretKey}{timestamp}")));
    requestMessage.Headers.Add("sign", sign);
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