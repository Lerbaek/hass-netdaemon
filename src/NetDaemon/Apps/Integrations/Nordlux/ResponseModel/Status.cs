namespace Lerbaek.NetDaemon.Apps.Integrations.Nordlux.ResponseModel;

public record Status(
    string? Msg,
    Data? Data,
    int? IsSuccess
);