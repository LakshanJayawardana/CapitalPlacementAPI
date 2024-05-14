using Newtonsoft.Json;
namespace CapitalPlacementAPI.Models;

public class BaseEntity
{
    [JsonProperty(PropertyName = "id")]
    public int Id { get; set; }
}
