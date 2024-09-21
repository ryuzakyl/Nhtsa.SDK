using System.Text.Json;
using Nhtsa.SDK.Configs;

namespace Nhtsa.SDK.Clients.Parsing;

public class NhtsaResponseParser
{
    public static T? Parse<T>(string content, string contentType)
    {
        if (contentType == ApiConfigs.JsonContentType)
        {
            // deserialize the JSON data
            return JsonSerializer.Deserialize<T>(
                content,
                new JsonSerializerOptions { PropertyNameCaseInsensitive = true }
            );
        }

        if (contentType == ApiConfigs.CsvContentType)
        {
            throw new InvalidOperationException($"Unsupported content type format '{contentType}'");
        }

        if (contentType == ApiConfigs.XmlContentType)
        {
            throw new InvalidOperationException($"Unsupported content type format '{contentType}'");
        }

        return default(T);
    }
}
