using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hrleavemanagement.application.Execeptions
{
    public class ValidationException:ApplicationException
    {
        public List<string> errors { get; set; }
        public ValidationException(ValidationResult validationResult)
        {
            foreach(var error in validationResult.Errors)
            {
                errors.Add(error.ToString());
            }
        }
    }
}
