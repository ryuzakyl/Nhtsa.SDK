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

public static class StringExtensions
{
    public static string UriReplace(this string uri, Dictionary<string, object> kwargs)
    {
        if (string.IsNullOrEmpty(uri))
        {
            return string.Empty;
        }

        foreach (var kvp in kwargs)
        {
            uri = uri.Replace($"{{{kvp.Key.ToUpper()}}}", kvp.Value.ToString());
        }

        return uri;
    }
}

public static class DictionaryExtensions
{
    public static Dictionary<string, string> ConcatQueryParams(this Dictionary<string, string> queryParams, Dictionary<string, object> newParams, bool prepend = true)
    {
        Dictionary<string, string> newParamsStr = newParams.ToDictionary(
            x => x.Key,
            x => x.Value?.ToString() ?? string.Empty
        );

        return prepend
            ? newParamsStr.Concat(queryParams).ToDictionary(x => x.Key, x => x.Value)
            : queryParams.Concat(newParamsStr).ToDictionary(x => x.Key, x => x.Value);
    }
}
