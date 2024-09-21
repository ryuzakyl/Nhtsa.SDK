using OneOf;
using System.Text.Json;

using Nhtsa.SDK.Configs;
using Nhtsa.SDK.Errors;
using Nhtsa.SDK.Utils;
using Nhtsa.SDK.Routes;
using Nhtsa.SDK.Clients.Parsing;


using Nhtsa.SDK.Models.Vehicles;

namespace Nhtsa.SDK.Clients.Vehicles;

public class VehiclesClient
{
    private readonly HttpClient _httpClient;

    public VehiclesClient()
    {
        _httpClient = new HttpClient
        {
            DefaultRequestHeaders = { { "Accept", "application/json" } }
        };
    }

    public async Task<OneOf<GetAllMakesResponse, ApiError>> GetAllMakesAsync()
    {
        try
        {
            // get full url
            Uri uri = UriUtils.GetEndpointUri(
                Urls.VehiclesApi.BaseUrl,
                Urls.VehiclesApi.GetAllMakes,
                ApiConfigs.DefaultQueryDict
            );

            var httpResponse = await _httpClient.GetAsync(uri.ToString());

            if (!httpResponse.IsSuccessStatusCode)
            {
                return new ApiError
                {
                    Message = "Failed to fetch 'GetAllMakes' data",
                    Details = $"Status code: {httpResponse.StatusCode}"
                };
            }

            // deserialize the API data
            var content = await httpResponse.Content.ReadAsStringAsync();
            GetAllMakesResponse? response = NhtsaResponseParser.Parse<GetAllMakesResponse>(content, ApiConfigs.ContentTypeFmt);

            if (response is null)
            {
                // Return an error if deserialization fails
                return new ApiError { Message = "Content deserialization failed", Details = "None" };
            }

            return response;
        }
        catch (HttpRequestException ex)
        {
            ApiError error = new ApiError
            {
                Message = "Unexpected error fetching 'GetAllMakes' API data",
                Details = ex.Message
            };

            return error;
        }
    }

    public async Task<OneOf<DecodeWmiResponse, ApiError, ValidationError>> DecodeWmiAsync(string wmi = "1FD")
    {
        try
        {
            if (string.IsNullOrEmpty(wmi))
            {
                return new ValidationError { Message = "Parameter 'WMI' must be specified" };
            }

            // get full url
            Uri uri = UriUtils.GetEndpointUri(
                Urls.VehiclesApi.BaseUrl,
                Urls.VehiclesApi.DecodeWMI.UriReplace(new Dictionary<string, object> {
                    { "WMI", wmi }
                }),
                ApiConfigs.DefaultQueryDict
            );

            var httpResponse = await _httpClient.GetAsync(uri.ToString());

            if (!httpResponse.IsSuccessStatusCode)
            {
                return new ApiError
                {
                    Message = "Failed to fetch 'DecodeWMI' data",
                    Details = $"Status code: {httpResponse.StatusCode}"
                };
            }

            // deserialize the API data
            var content = await httpResponse.Content.ReadAsStringAsync();
            DecodeWmiResponse? response = NhtsaResponseParser.Parse<DecodeWmiResponse>(content, ApiConfigs.ContentTypeFmt);

            if (response is null)
            {
                // Return an error if deserialization fails
                return new ApiError { Message = "Content deserialization failed", Details = "None" };
            }

            return response;
        }
        catch (HttpRequestException ex)
        {
            ApiError error = new ApiError
            {
                Message = "Unexpected error fetching 'DecodeWMI' API data",
                Details = ex.Message
            };

            return error;
        }
    }

    public async Task<OneOf<ManufacturerMakesResponse, ApiError, ValidationError>> GetMakesForManufacturerAndYearAsync(string manufacturer = "", int year = 0)
    {
        try
        {
            if (string.IsNullOrEmpty(manufacturer))
            {
                return new ValidationError { Message = "Parameter 'Manufacturer' must be specified" };
            }

            if (year <= 0)
            {
                return new ValidationError { Message = "Parameter 'year' must be specified" };
            }

            // get full url
            Uri uri = UriUtils.GetEndpointUri(
                Urls.VehiclesApi.BaseUrl,
                Urls.VehiclesApi.GetMakesForManufacturerAndYear.UriReplace(new Dictionary<string, object> {
                    { "MANUFACTURER", manufacturer }
                }),
                ApiConfigs.DefaultQueryDict.ConcatQueryParams(new Dictionary<string, object>
                {
                    {"year", year}
                })
            );

            var httpResponse = await _httpClient.GetAsync(uri.ToString());

            if (!httpResponse.IsSuccessStatusCode)
            {
                return new ApiError
                {
                    Message = "Failed to fetch 'GetMakesForManufacturerAndYear' data",
                    Details = $"Status code: {httpResponse.StatusCode}"
                };
            }

            // deserialize the API data
            var content = await httpResponse.Content.ReadAsStringAsync();
            ManufacturerMakesResponse? response = NhtsaResponseParser.Parse<ManufacturerMakesResponse>(content, ApiConfigs.ContentTypeFmt);

            if (response is null)
            {
                // Return an error if deserialization fails
                return new ApiError { Message = "Content deserialization failed", Details = "None" };
            }

            return response;
        }
        catch (HttpRequestException ex)
        {
            ApiError error = new ApiError
            {
                Message = "Unexpected error fetching 'GetMakesForManufacturerAndYear' API data",
                Details = ex.Message
            };

            return error;
        }
    }

    public async Task<OneOf<DecodeVinFlatResponse, ApiError, ValidationError>> DecodeVinValuesBatchAsync(IEnumerable<VinData> vinsData)
    {
        if (vinsData is null || !vinsData.Any())
        {
            return new ValidationError { Message = "Some VIN related data is required" };
        }

        IEnumerable<(string? Vin, int? Year)> vinsDataTuples = vinsData.Select(vd => (vd.Vin, vd.Year));

        return await DecodeVinValuesBatchAsync(vinsDataTuples);
    }

    public async Task<OneOf<DecodeVinFlatResponse, ApiError, ValidationError>> DecodeVinValuesBatchAsync(IEnumerable<(string? Vin, int? Year)> vinsData)
    {
        if (vinsData is null || !vinsData.Any())
        {
            return new ValidationError { Message = "Some VIN related data is required" };
        }

        // get full url
        Uri uri = UriUtils.GetEndpointUri(
            Urls.VehiclesApi.BaseUrl,
            Urls.VehiclesApi.DecodeVinValuesBatch,
            ApiConfigs.EmptyQueryDict
        );

        // build form url data (no extra validation here since API does it already)
        string data = string.Join(";", vinsData.Select(x => $"{x.Vin},{x.Year}"));

        FormUrlEncodedContent formData = new FormUrlEncodedContent(new[]
        {
            new KeyValuePair<string, string>("data", data),
            new KeyValuePair<string, string>("format", ApiConfigs.ContentTypeFmt)
        });

        try
        {
            var httpResponse = await _httpClient.PostAsync(uri.ToString(), formData);

            if (!httpResponse.IsSuccessStatusCode)
            {
                return new ApiError
                {
                    Message = "Failed to fetch 'DecodeVinValuesBatch' data",
                    Details = $"Status code: {httpResponse.StatusCode}"
                };
            }

            // deserialize the API data
            var content = await httpResponse.Content.ReadAsStringAsync();
            DecodeVinFlatResponse? response = NhtsaResponseParser.Parse<DecodeVinFlatResponse>(content, ApiConfigs.ContentTypeFmt);

            if (response is null)
            {
                // Return an error if deserialization fails
                return new ApiError { Message = "Content deserialization failed", Details = "None" };
            }

            return response;
        }
        catch (HttpRequestException ex)
        {
            ApiError error = new ApiError
            {
                Message = "Unexpected decoding 'DecodeVinValuesBatch' API data",
                Details = ex.Message
            };

            return error;
        }
    }
}
