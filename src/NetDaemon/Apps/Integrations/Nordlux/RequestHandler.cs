using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Security.Cryptography;
using Lerbaek.NetDaemon.Apps.Integrations.Nordlux.Configuration;
using Lerbaek.NetDaemon.Apps.Integrations.Nordlux.Model;
using static System.Text.Encoding;
using Convert = System.Convert;
using JsonSerializer = System.Text.Json.JsonSerializer;

namespace Lerbaek.NetDaemon.Apps.Integrations.Nordlux;

public class RequestHandler : IRequestHandler
{
    private readonly NordluxConfig _config;
    private readonly ILogger _logger;
    private readonly HttpClient _httpClient;
    private readonly Aes _aes;

    public RequestHandler(
      IAppConfig<NordluxConfig> config,
      ILogger<NordluxConfig> logger,
      IHttpClientFactory httpClientFactory)
    {
        _config = config.Value;
        _logger = logger;
        _httpClient = httpClientFactory.CreateClient(nameof(Nordlux));

        _aes = Aes.Create();
        _aes.KeySize = 128;
        _aes.Key = config.Value.SecretKey.Select(Convert.ToByte).ToArray();
        _aes.Mode = CipherMode.ECB;
    }

    public async Task<HttpResponseMessage> Send<T>(
      T body,
      string apiService = ApiServiceConstants.ControllerBle) where T : RequestBase
    {
        var serializedBody = JsonSerializer.Serialize(body);
        var encryptedBody = _aes.EncryptEcb(UTF8.GetBytes(serializedBody), PaddingMode.PKCS7);
        var cipher = Convert.ToHexString(encryptedBody);
        using var requestMessage = await GenerateRequestMessage(cipher, apiService);
        return await SendAndLog(requestMessage);
    }

    private async Task<HttpRequestMessage> GenerateRequestMessage(
      string cipher,
      string apiService)
    {
        HttpRequestMessage requestMessage = new(
          HttpMethod.Post,
          $"https://api.yankon-xm.com:443/smartLight/api/device/{apiService}")
        {
            Content = JsonContent.Create(new
            {
                cipher
            })
        };

        requestMessage.Headers.Host = "api.yankon-xm.com";
        var timestamp = DateTime.Now.ToString("yyyyMMddHHmmss");

        var authorization = Convert.ToBase64String(
          UTF8.GetBytes($"{_config.AccessKey}:{timestamp}"));

        requestMessage.Headers.TryAddWithoutValidation(nameof(HttpRequestHeaders.Authorization), authorization);
        var contentLength = (await requestMessage.Content.ReadAsStringAsync()).Length;
        requestMessage.Content.Headers.ContentLength = contentLength;

        var sign = Convert.ToHexString(
          MD5.HashData(
            UTF8.GetBytes(
              $"{_config.AccessKey}{_config.SecretKey}{timestamp}")));

        requestMessage.Headers.Add("sign", sign);

        using var logScope = _logger.BeginScope(new Dictionary<string, object?>
        {
            ["URI"] = requestMessage.RequestUri!.OriginalString,
            ["Cipher"] = cipher
        });

        _logger.LogTrace("Request message generated.");

        return requestMessage;
    }

    private async Task<HttpResponseMessage> SendAndLog(HttpRequestMessage requestMessage)
    {
        _logger.LogTrace("Sending request");
        var response = await _httpClient.SendAsync(requestMessage);

        _logger.LogTrace(
            "Response: {StatusCode}({Status})",
            (int)response.StatusCode,
            response.StatusCode);

        return response;
    }
}