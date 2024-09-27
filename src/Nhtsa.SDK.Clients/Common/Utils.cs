namespace Nhtsa.SDK.Utils;

public static class UriUtils
{
    public static Uri GetEndpointUri(string basePath, string endpointPath, Dictionary<string, string> queryParams)
    {
        Uri baseUri = new Uri(basePath);
        Uri uri = new Uri(baseUri, endpointPath.TrimStart('/'));
        UriBuilder uriBuilder = new UriBuilder(uri);

        List<string> queryParamsList = queryParams
            .Where(x =>
                !string.IsNullOrEmpty(x.Key) &&
                !string.IsNullOrEmpty(x.Value)
            )
            .Select(x => $"{Uri.EscapeDataString(x.Key)}={Uri.EscapeDataString(x.Value)}")
            .ToList();

        uriBuilder.Query = string.Join("&", queryParamsList);

        return uriBuilder.Uri;
    }
}
