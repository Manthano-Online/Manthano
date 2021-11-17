using System.ComponentModel.DataAnnotations;

namespace Manthano.Domain.Models.Validators;

public class IntLessThanValidator : ValidationAttribute
{
    private readonly string _propertyName;

    public bool CanBeEqual { get; set; }

    public IntLessThanValidator(string propertyName)
    {
        _propertyName = propertyName;
    }

    protected override ValidationResult IsValid(object value, ValidationContext validationContext)
    {
        ErrorMessage = ErrorMessageString;
        var currentValue = Convert.ToInt32(value);

        var property = validationContext.ObjectType.GetProperty(_propertyName);

        if (property == null)
            throw new ArgumentException("Property with this name not found");

        var objValue = property.GetValue(validationContext.ObjectInstance);

        if (objValue == null)
        {
            new ValidationResult($"{_propertyName} cannot be null");
        }

        // end page value
        var comparisonValue = Convert.ToInt32(objValue);

        if (CanBeEqual && currentValue == comparisonValue)
        {
            return ValidationResult.Success;
        }

        // if start page is larger than end page
        if (currentValue > comparisonValue)
        {
            return new ValidationResult(ErrorMessage);
        }

        return ValidationResult.Success;
    }
}