using System.Text.Json.Serialization;

namespace Nhtsa.SDK.Models.Vehicles;

public class VinVariable
{
    [JsonPropertyName("Value")]
    public string? Value { get; set; }

    [JsonPropertyName("ValueId")]
    public string? ValueId { get; set; }

    [JsonPropertyName("Variable")]
    public string? Variable { get; set; }

    [JsonPropertyName("VariableId")]
    public int? VariableId { get; set; }
}
