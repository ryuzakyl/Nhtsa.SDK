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

public class Make
{
    [JsonPropertyName("Make_ID")]
    public int MakeId { get; set; }

    [JsonPropertyName("Make_Name")]
    public string? MakeName { get; set; }
}


public class DecodeWmiResponse
{
    [JsonPropertyName("Count")]
    public int Count { get; set; }

    [JsonPropertyName("Message")]
    public string? Message { get; set; }

    [JsonPropertyName("SearchCriteria")]
    public string? SearchCriteria { get; set; }

    [JsonPropertyName("Results")]
    public List<WmiDdata> Results { get; set; } = new List<WmiDdata>();
}

public class WmiDdata
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
