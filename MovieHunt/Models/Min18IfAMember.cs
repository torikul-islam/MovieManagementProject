using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MovieHunt.Models
{
    public class Min18IfAMember : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var customer = (Customer)validationContext.ObjectInstance;
            if (customer.MembershipTypeId == MembershipType.Unknown || 
                customer.MembershipTypeId == MembershipType.PayAsYouGo)
            {
                return ValidationResult.Success;
            }
            if (customer.BirthDate == null)
            {
                return new ValidationResult("Birthdate is Required.");
            }

            var age = DateTime.Today.Year - customer.BirthDate.Value.Year;
            return (age >= 18)
                ? ValidationResult.Success
                : new ValidationResult("customer should be at least 18 years old to go on Membership");
        }
    }
}