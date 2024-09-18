using OneOf;
using System.Text.Json;

using Nhtsa.SDK.Clients.Configs;
using Nhtsa.SDK.Clients.Errors;
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
            Uri uri = Utils.GetEndpointUri(
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

            var jsonString = await httpResponse.Content.ReadAsStringAsync();

            // deserialize the JSON data
            var response = JsonSerializer.Deserialize<GetAllMakesResponse>(
                jsonString,
                new JsonSerializerOptions { PropertyNameCaseInsensitive = true }
            );

            if (response is null)
            {
                // Return an error if deserialization fails
                return new ApiError { Message = "JSON deserialization failed", Details = "None" };
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
            Uri uri = Utils.GetEndpointUri(
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

            var jsonString = await httpResponse.Content.ReadAsStringAsync();

            // deserialize the JSON data
            var response = JsonSerializer.Deserialize<DecodeWmiResponse>(
                jsonString,
                new JsonSerializerOptions { PropertyNameCaseInsensitive = true }
            );

            if (response is null)
            {
                // Return an error if deserialization fails
                return new ApiError { Message = "JSON deserialization failed", Details = "None" };
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
            Uri uri = Utils.GetEndpointUri(
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

            var jsonString = await httpResponse.Content.ReadAsStringAsync();

            // deserialize the JSON data
            var response = JsonSerializer.Deserialize<ManufacturerMakesResponse>(
                jsonString,
                new JsonSerializerOptions { PropertyNameCaseInsensitive = true }
            );

            if (response is null)
            {
                // Return an error if deserialization fails
                return new ApiError { Message = "JSON deserialization failed", Details = "None" };
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
}
