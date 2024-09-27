namespace Nhtsa.SDK.Extensions;

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
    public static Dictionary<string, string> ConcatQueryParams(this Dictionary<string, string> queryParams, Dictionary<string, object?> newParams, bool prepend = true)
    {
        // ignore those entries where value is null
        Dictionary<string, string> newParamsStr = newParams
            .Where(x => x.Value != null)
            .ToDictionary(
                x => x.Key,
                x => x.Value?.ToString() ?? string.Empty
            );

        return prepend
            ? newParamsStr.Concat(queryParams).ToDictionary(x => x.Key, x => x.Value)
            : queryParams.Concat(newParamsStr).ToDictionary(x => x.Key, x => x.Value);
    }
}
