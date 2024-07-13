using System.Net.Http.Json;
using System.Security.Cryptography;
using Lerbaek.NetDaemon.Apps.Integrations.Nordlux.Configuration;
using static System.Text.Encoding;
using Convert = System.Convert;

namespace Lerbaek.NetDaemon.Apps.Integrations.Nordlux;

public class RequestHandler : IRequestHandler
{
  private readonly NordluxConfig _config;
  private readonly ILogger _logger;
  private readonly HttpClient _httpClient;
  private readonly Aes _aes;

  public RequestHandler(IAppConfig<NordluxConfig> config, ILogger<NordluxConfig> logger, IHttpClientFactory httpClientFactory)
  {
    this._config = config.Value;
    this._logger = logger;
    _httpClient = httpClientFactory.CreateClient(nameof(Nordlux));

    _aes = Aes.Create();
    _aes.KeySize = 128;
    _aes.Key = config.Value.SecretKey!.Select(Convert.ToByte).ToArray();
    _aes.Mode = CipherMode.ECB;
  }

  public async Task<HttpResponseMessage> Send(string body, string apiPath = ApiPath.Controller)
  {
    var encryptedBody = _aes.EncryptEcb(UTF8.GetBytes(body), PaddingMode.PKCS7);
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
    var authorization = Convert.ToBase64String(UTF8.GetBytes($"{_config.AccessKey}:{timestamp}"));
    requestMessage.Headers.TryAddWithoutValidation("authorization", authorization);
    var contentLength = (await requestMessage.Content.ReadAsStringAsync()).Length;
    requestMessage.Content.Headers.ContentLength = contentLength;

    var sign = Convert.ToHexString(MD5.HashData(UTF8.GetBytes($"{_config.AccessKey}{_config.SecretKey}{timestamp}")));
    requestMessage.Headers.Add("sign", sign);
    _logger.LogTrace("Generated request message.");
    _logger.LogTrace("URI: {RequestUri}", requestMessage.RequestUri!.OriginalString);
    _logger.LogTrace("Cipher: {Cipher}", cipher);

    return requestMessage;
  }

  private async Task<HttpResponseMessage> SendAndLog(HttpRequestMessage requestMessage)
  {
    _logger.LogTrace("Sending request");
    var response = await _httpClient.SendAsync(requestMessage);
    _logger.LogTrace("Response: {StatusCode}({Status})", (int)response.StatusCode, response.StatusCode);
    return response;
  }
}