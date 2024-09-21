using OneOf;

using Nhtsa.SDK.Errors;
using Nhtsa.SDK.Clients.Vehicles;
using Nhtsa.SDK.Models.Vehicles;

namespace Nhtsa.SDK.Tests;

public class VehiclesClientTests
{
    [Fact]
    public async void Test_VehiclesClient_GetAllMakesAsync_ShouldReturnValidResponse()
    {
        VehiclesClient vc = new VehiclesClient();

        OneOf<GetAllMakesResponse, ApiError> result = await vc.GetAllMakesAsync();

        Assert.True(result.IsT0);

        GetAllMakesResponse makes = result.AsT0;
        Assert.NotNull(makes);

        Assert.True(makes.Count > 0, "Makes count should be greater than 0.");

        Assert.NotNull(makes.Results);
        Assert.NotEmpty(makes.Results);
    }

    [Fact]
    public async void Test_VehiclesClient_DecodeWmiAsync_ShouldFailWithEmptyWmi()
    {
        VehiclesClient vc = new VehiclesClient();

        OneOf<DecodeWmiResponse, ApiError, ValidationError> result = await vc.DecodeWmiAsync(wmi: string.Empty);

        Assert.True(result.IsT2);
    }

    [Fact]
    public async void Test_VehiclesClient_DecodeWmiAsync_ShouldReturnValidResponse()
    {
        VehiclesClient vc = new VehiclesClient();

        OneOf<DecodeWmiResponse, ApiError, ValidationError> result = await vc.DecodeWmiAsync(wmi: "1FD");

        Assert.True(result.IsT0);

        DecodeWmiResponse wmiResults = result.AsT0;
        Assert.NotNull(wmiResults);

        Assert.True(wmiResults.Count > 0, "WMI results count should be greater than 0.");

        Assert.NotNull(wmiResults.Results);
        Assert.NotEmpty(wmiResults.Results);
    }

    [Fact]
    public async void Test_VehiclesClient_GetMakesForManufacturerAndYearAsync_ShouldFailWithWrongArgs()
    {
        VehiclesClient vc1 = new VehiclesClient();
        OneOf<ManufacturerMakesResponse, ApiError, ValidationError> result1 = await vc1.GetMakesForManufacturerAndYearAsync();
        Assert.True(result1.IsT2);

        VehiclesClient vc2 = new VehiclesClient();
        OneOf<ManufacturerMakesResponse, ApiError, ValidationError> result2 = await vc2.GetMakesForManufacturerAndYearAsync(manufacturer: "988");
        Assert.True(result2.IsT2);

        VehiclesClient vc3 = new VehiclesClient();
        OneOf<ManufacturerMakesResponse, ApiError, ValidationError> result3 = await vc3.GetMakesForManufacturerAndYearAsync(year: 2015);
        Assert.True(result3.IsT2);
    }

    [Fact]
    public async void Test_VehiclesClient_GetMakesForManufacturerAndYearAsync_ShouldReturnValidResponse()
    {
        VehiclesClient vc = new VehiclesClient();

        OneOf<ManufacturerMakesResponse, ApiError, ValidationError> result = await vc.GetMakesForManufacturerAndYearAsync(manufacturer: "988", year: 2015);

        Assert.True(result.IsT0);

        ManufacturerMakesResponse mferMakes = result.AsT0;
        Assert.NotNull(mferMakes);

        Assert.True(mferMakes.Count > 0, "Manufacturer makes results count should be greater than 0.");

        Assert.NotNull(mferMakes.Results);
        Assert.NotEmpty(mferMakes.Results);
    }

    [Fact]
    public async void Test_VehiclesClient_DecodeVinValuesBatchAsync_ShouldFailWithWrongArgs()
    {
        VehiclesClient vc1 = new VehiclesClient();
        OneOf<DecodeVinFlatResponse, ApiError, ValidationError> result1 = await vc1.DecodeVinValuesBatchAsync(new List<VinData>());
        Assert.True(result1.IsT2);
    }

    [Fact]
    public async void Test_VehiclesClient_DecodeVinValuesBatchAsync_ShouldReturnValidResponse()
    {
        VehiclesClient vc = new VehiclesClient();

        List<VinData> data = new List<VinData>
        {
            new VinData { Vin = "5UXWX7C5*BA", Year = 2011 },
            new VinData { Vin = "5YJSA3DS*EF", Year = null },
        };

        OneOf<DecodeVinFlatResponse, ApiError, ValidationError> result = await vc.DecodeVinValuesBatchAsync(data);

        Assert.True(result.IsT0);

        DecodeVinFlatResponse vinFlatReponse = result.AsT0;
        Assert.NotNull(vinFlatReponse);
    }
}
