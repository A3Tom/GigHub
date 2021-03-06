﻿namespace GigHub.ViewModels
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.Globalization;

    public class FutureDate : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            DateTime result;
            var isValid = DateTime.TryParseExact(Convert.ToString(value), 
                "d MMM yyyy", 
                CultureInfo.CurrentCulture, 
                DateTimeStyles.None, 
                out result);

            return (isValid && result > DateTime.Now);
        }
    }
}