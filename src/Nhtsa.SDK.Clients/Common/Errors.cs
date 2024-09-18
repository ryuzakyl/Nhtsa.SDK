namespace Nhtsa.SDK.Clients.Errors;

public class ValidationError
{
    public string? Message { get; set; }
}

public class ApiError
{
    public string? Message { get; set; }

    public string? Details { get; set; }
}