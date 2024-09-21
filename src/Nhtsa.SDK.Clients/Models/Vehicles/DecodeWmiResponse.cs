using System.Text.Json.Serialization;

namespace Nhtsa.SDK.Models.Vehicles;


public class DecodeWmiResponse
{
    [JsonPropertyName("Count")]
    public int Count { get; set; }

    [JsonPropertyName("Message")]
    public string? Message { get; set; }

    [JsonPropertyName("SearchCriteria")]
    public string? SearchCriteria { get; set; }

    [JsonPropertyName("Results")]
    public List<WmiData> Results { get; set; } = new List<WmiData>();
}