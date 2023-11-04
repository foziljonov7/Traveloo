using API.Data;
using API.Entities;
using System.ComponentModel.DataAnnotations;

namespace API.Validation
{
    public class HumanValidation : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            Human human = (Human)validationContext.ObjectInstance;

            if (human.Firstname == null)
                return new ValidationResult(FormatErrorMessage(validationContext.MemberName));

            else if (human.Lastname == null)
                return new ValidationResult(FormatErrorMessage(validationContext.MemberName));

            else if(human.Age < 16)
                return new ValidationResult(FormatErrorMessage(validationContext.MemberName));

            else if(human.CategoryId <= 0)
                return new ValidationResult(FormatErrorMessage(validationContext.MemberName));              

            return ValidationResult.Success;
        }
    }
}
