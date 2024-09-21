namespace Nhtsa.SDK.Errors;

public class ValidationError
{
    public string? Message { get; set; }
}

public class ApiError
{
    public string? Message { get; set; }

    public string? Details { get; set; }
}