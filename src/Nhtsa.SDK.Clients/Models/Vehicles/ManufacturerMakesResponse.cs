using System.Text.Json.Serialization;

namespace Nhtsa.SDK.Models.Vehicles;

public class ManufacturerMakesResponse
{
    [JsonPropertyName("Count")]
    public int Count { get; set; }

    [JsonPropertyName("Message")]
    public string? Message { get; set; }

    [JsonPropertyName("SearchCriteria")]
    public string? SearchCriteria { get; set; }

    [JsonPropertyName("Results")]
    public List<ManufacturerMake> Results { get; set; } = new List<ManufacturerMake>();
}
