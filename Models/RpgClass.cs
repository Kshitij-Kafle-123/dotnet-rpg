using System.Text.Json.Serialization;

namespace dotnet_rpg.Models
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum RpgClass
    {
        Kshitij=1,
        Sky=2,
        Falcon=3,
        Rabbit=4
    }
}