namespace Lerbaek.NetDaemon.Common.Entities;

public static class EntityExtensions
{
  public static LightAttributes Set(this LightAttributes attributes,
    int? brightness                            = null,
    string? colorMode                          = null,
    IReadOnlyList<double>? colorTemp           = null,
    IReadOnlyList<string>? effectList          = null,
    IReadOnlyList<string>? entityId            = null,
    string? entityPicture                      = null,
    string? friendlyName                       = null,
    IReadOnlyList<double>? hsColor             = null,
    string? icon                               = null,
    double? linkquality                        = null,
    double? maxMireds                          = null,
    double? minMireds                          = null,
    string? powerOnBehavior                    = null,
    IReadOnlyList<double>? rgbColor            = null,
    IReadOnlyList<string>? supportedColorModes = null,
    double? supportedFeatures                  = null,
    object? update                             = null,
    bool?   updateAvailable                    = null,
    IReadOnlyList<double>? xyColor             = null) =>
    new()
    {
      Brightness          = brightness          ?? attributes.Brightness,
      ColorMode           = colorMode           ?? attributes.ColorMode,
      //ColorTemp           = colorTemp           ?? attributes.ColorTemp,
      EffectList          = effectList          ?? attributes.EffectList,
      EntityId            = entityId            ?? attributes.EntityId,
      EntityPicture       = entityPicture       ?? attributes.EntityPicture,
      FriendlyName        = friendlyName        ?? attributes.FriendlyName,
      HsColor             = hsColor             ?? attributes.HsColor,
      Icon                = icon                ?? attributes.Icon,
      Linkquality         = linkquality         ?? attributes.Linkquality,
      MaxMireds           = maxMireds           ?? attributes.MaxMireds,
      MinMireds           = minMireds           ?? attributes.MinMireds,
      PowerOnBehavior     = powerOnBehavior     ?? attributes.PowerOnBehavior,
      RgbColor            = rgbColor            ?? attributes.RgbColor,
      SupportedColorModes = supportedColorModes ?? attributes.SupportedColorModes,
      SupportedFeatures   = supportedFeatures   ?? attributes.SupportedFeatures,
      Update              = update              ?? attributes.Update,
      UpdateAvailable     = updateAvailable     ?? attributes.UpdateAvailable,
      XyColor             = xyColor             ?? attributes.XyColor,
    };
}