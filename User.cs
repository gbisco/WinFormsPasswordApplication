using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsPasswordApplication
{
    public class User
    {
        // holds username and passwords associated with them
        public string Name { get; set; }
        public List<PasswordEntry> PasswordEntries { get; private set; }

        // Constructor
        public User(string name)
        {
            Name = name;
            PasswordEntries = new List<PasswordEntry>();
        }

        // Single password entry add to list
        public void AddPasswordEntry(PasswordEntry password) { PasswordEntries.Add(password); }

        // Single password entry removal
        public void RemovePasswordEntry(PasswordEntry password)
        {
            PasswordEntries.Remove(password);
        }

        // find and return password entries of the user
        public PasswordEntry FindEntries(string accName)
        {
            return PasswordEntries.Find(entry => entry.AccName == accName);
        }
    }
}

