namespace Lerbaek.NetDaemon.Common.Entities;

public static class EntityExtensions
{
  public static LightAttributes Set(this LightAttributes attributes,
    double? brightness          = null,
    string? colorMode           = null,
    double? colorTemp           = null,
    object? effectList          = null,
    object? entityId            = null,
    string? entityPicture       = null,
    string? friendlyName        = null,
    object? hsColor             = null,
    string? icon                = null,
    double? linkquality         = null,
    double? maxMireds           = null,
    double? minMireds           = null,
    string? powerOnBehavior     = null,
    object? rgbColor            = null,
    object? supportedColorModes = null,
    double? supportedFeatures   = null,
    object? update              = null,
    bool?   updateAvailable     = null,
    object? xyColor             = null) =>
    new()
    {
      Brightness          = brightness          ?? attributes.Brightness,
      ColorMode           = colorMode           ?? attributes.ColorMode,
      //ColorTemp           = colorTemp           ?? attributes.ColorTemp,
      EffectList          = effectList          ?? attributes.EffectList,
      EntityId            = entityId            ?? attributes.EntityId,
      EntityPicture       = entityPicture       ?? attributes.EntityPicture,
      FriendlyName        = friendlyName        ?? attributes.FriendlyName,
      //HsColor             = hsColor             ?? attributes.HsColor,
      Icon                = icon                ?? attributes.Icon,
      //Linkquality         = linkquality         ?? attributes.Linkquality,
      MaxMireds           = maxMireds           ?? attributes.MaxMireds,
      MinMireds           = minMireds           ?? attributes.MinMireds,
      //PowerOnBehavior     = powerOnBehavior     ?? attributes.PowerOnBehavior,
      //RgbColor            = rgbColor            ?? attributes.RgbColor,
      SupportedColorModes = supportedColorModes ?? attributes.SupportedColorModes,
      SupportedFeatures   = supportedFeatures   ?? attributes.SupportedFeatures,
      //Update              = update              ?? attributes.Update,
      //UpdateAvailable     = updateAvailable     ?? attributes.UpdateAvailable,
      //XyColor             = xyColor             ?? attributes.XyColor,
    };
}