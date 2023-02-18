using Enterprise.Models.Validation;

namespace Enterprise.Services.Exceptions;
public class ValidationException : Exception
{
    public ValidationException(ValidationResult result)
        : base(result.Message) { }
}