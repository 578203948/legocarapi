using System.Text.Json.Serialization;

namespace legocarapi.Models
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum Direction
    {
        forward = 1,
        forward_right = 2,
        forward_left = 3,
        backwards = 4,
        backwards_right = 5,
        backwards_left = 6,
    }
}