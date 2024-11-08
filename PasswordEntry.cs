using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsPasswordApplication
{
    public class PasswordEntry
    {
        // Holds account, description, and actual password associated with entry
        public string AccName { get; set; }
        public string Password { get; private set; }
        public string Description { get; set; }


        // Default constructor
        public PasswordEntry()
        {
            AccName = string.Empty;
            Password = string.Empty;
            Description = string.Empty;
        }

        // Custom constructor
        public PasswordEntry(string accountName, string password, string description)
        {
            AccName = accountName;
            Password = password;
            Description = description;
        }

        // Generates a random password and return a string
        public static string GeneratePassword(int length, bool includeSymbols, bool includeUppercase)
        {
            // Character option
            const string lowerCase = "abcdefghijklmnopqrstuvwxyz";
            const string upperCase = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            const string symbols = "!@#$%^&*()_+[]{}|;:,.<>?";

            StringBuilder password = new StringBuilder();
            Random random = new Random();

            string validChars = lowerCase;

            if (includeUppercase) validChars += upperCase;
            if (includeSymbols) validChars += symbols;

            for (int i = 0; i < length; i++)
            {
                password.Append(validChars[random.Next(validChars.Length)]);
            }

            return password.ToString();
        }

    }
}

