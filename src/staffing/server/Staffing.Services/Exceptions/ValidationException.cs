using Staffing.Models.Validation;

namespace Staffing.Services.Exceptions;
public class ValidationException : Exception
{
    public ValidationException(ValidationResult result)
        : base(result.Message) { }
}