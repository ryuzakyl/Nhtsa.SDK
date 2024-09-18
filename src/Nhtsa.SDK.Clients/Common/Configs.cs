namespace Nhtsa.SDK.Clients.Configs;

public class ApiConfigs
{
    public static string ContentTypeFmt => "json";

    public static Dictionary<string, string> DefaultQueryDict => new Dictionary<string, string>
    {
        {"format", ContentTypeFmt}
    };
}