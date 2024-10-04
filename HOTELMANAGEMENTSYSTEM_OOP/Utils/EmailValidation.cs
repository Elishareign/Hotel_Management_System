using System;
using System.Text.RegularExpressions;

namespace HOTELMANAGEMENTSYSTEM_OOP.Utils
{
    public class EmailValidator
    {
        public bool IsValidEmail(string email)
        {
            // Regex pattern for basic email validation
            string pattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";

            // Check if the email matches the pattern
            return Regex.IsMatch(email, pattern);
        }
    }
}
