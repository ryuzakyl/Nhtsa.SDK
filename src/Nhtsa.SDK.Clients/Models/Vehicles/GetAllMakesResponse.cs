using System.Text.Json.Serialization;

namespace Nhtsa.SDK.Models.Vehicles;

public class GetAllMakesResponse
{
    [JsonPropertyName("Count")]
    public int Count { get; set; }

    [JsonPropertyName("Message")]
    public string? Message { get; set; }

    [JsonPropertyName("SearchCriteria")]
    public string? SearchCriteria { get; set; }

    [JsonPropertyName("Results")]
    public List<Make> Results { get; set; } = new List<Make>();
}