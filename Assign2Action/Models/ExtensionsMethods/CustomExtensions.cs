using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Assign2Action.Models.ExtensionsMethods
{
    public static class CustomExtensions
    {
        public static int ToAge(this DateTimeOffset dateOfBirth)
        {
            var day = DateTime.Today;
            var day1 = (day.Year * 100 + day.Month) * 100 + day.Day;
            var day2 = (dateOfBirth.Year * 100 + dateOfBirth.Month) * 100 + dateOfBirth.Day;
            return (day1 - day2) / 1000;
        }



        public static String ToDigitsOnly(this string str)
        {
            var s = "";
            foreach (var p in str)
            {
                if (char.IsDigit(p))
                {
                    s = s + p;
                }
            }
                return s;
            
        }
    }
}
        
