using System.Text.Json.Serialization;

namespace Nhtsa.SDK.Models.Vehicles;

public class ManufacturerMake
{
    [JsonPropertyName("MakeId")]
    public int MakeId { get; set; }

    [JsonPropertyName("MakeName")]
    public string? MakeName { get; set; }

    [JsonPropertyName("MfrId")]
    public int MfrId { get; set; }

    [JsonPropertyName("MfrName")]
    public string? MfrName { get; set; }
}