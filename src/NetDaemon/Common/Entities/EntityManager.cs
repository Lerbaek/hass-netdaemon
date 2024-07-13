namespace Lerbaek.NetDaemon.Common.Entities;

public class EntityManager(IHaContext haContext) : IEntityManager
{
  public void CreateOrUpdate(string entityId, string state, string? friendlyName, string? icon = null,
    IDictionary<string, string?>? attributes = null)
  {
    attributes ??= new Dictionary<string, string?>();
    attributes["friendly_name"] = friendlyName;
    var data = new Dictionary<string, object?>
    {
      { "entity_id", entityId },
      { "state", state },
      { "icon", icon },
      { "attributes", attributes },
      { "unique_id", Guid.NewGuid() }
    };

    var action = haContext.GetAllEntities().Any(e => e.EntityId.Equals(entityId)) ? "update" : "create";
    haContext.CallService(
      "netdaemon",
      $"entity_{action}",
      null,
      data);

    haContext.SetEntityState(entityId, state, attributes);
  }

  public void Remove(string entityId)
  {
    haContext.CallService(
      "netdaemon",
      "entity_remove",
      null,
      new { entity_id = entityId });
  }
}