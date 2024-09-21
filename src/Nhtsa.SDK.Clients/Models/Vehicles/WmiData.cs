using System.Text.Json.Serialization;

namespace Nhtsa.SDK.Models.Vehicles;

public class WmiData
{
    [JsonPropertyName("CommonName")]
    public string? CommonName { get; set; }

    [JsonPropertyName("CreatedOn")]
    public DateTime? CreatedOn { get; set; }

    [JsonPropertyName("DateAvailableToPublic")]
    public DateTime? DateAvailableToPublic { get; set; }

    [JsonPropertyName("Make")]
    public string? Make { get; set; }

    [JsonPropertyName("ManufacturerName")]
    public string? ManufacturerName { get; set; }

    [JsonPropertyName("ParentCompanyName")]
    public string? ParentCompanyName { get; set; }

    [JsonPropertyName("URL")]
    public string? URL { get; set; }

    [JsonPropertyName("UpdatedOn")]
    public DateTime? UpdatedOn { get; set; }

    [JsonPropertyName("VehicleType")]
    public string? VehicleType { get; set; }
}