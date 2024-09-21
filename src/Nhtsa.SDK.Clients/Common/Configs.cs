namespace Nhtsa.SDK.Configs;

public class ApiConfigs
{
    public static string JsonContentType = "json";

    public static string CsvContentType = "csv";

    public static string XmlContentType = "xml";

    public static string DefaultContentType = JsonContentType;

    public static List<string> AllowedContentTypes = new List<string> { JsonContentType, CsvContentType, XmlContentType };

    private static string _contentType = DefaultContentType;

    public static string ContentTypeFmt
    {
        get => _contentType;
        set
        {
            // validate it is one of supported formats
            if (!AllowedContentTypes.Contains(value))
            {
                throw new ArgumentException($"Invalid content type. Only ({string.Join(",", AllowedContentTypes)}) are allowed.");
            }

            _contentType = value;
        }
    }

    public static Dictionary<string, string> EmptyQueryDict => new Dictionary<string, string>();

    public static Dictionary<string, string> DefaultQueryDict => new Dictionary<string, string>
    {
        {"format", ContentTypeFmt}
    };
}