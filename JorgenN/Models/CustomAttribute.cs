using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace JorgenN.Models
{
    public class CustomAttribute : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            if (value == null)
            {
                return false;
            }
            else
            {
                var check = value.ToString().ToLower();
                return check.StartsWith("p-");
            }
        }

        public override string FormatErrorMessage(string name)
        {
            return "Felaktig inmatning, måste börja på \"p-\" och avslutas med 3 siffror ";
        }
    }
}