using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsPasswordApplication
{
    public class UserManager
    {
        // Holds list of users
        private List<User> users;

        // Constructor
        public UserManager() { users = new List<User>(); }

        // Single user add method
        public void AddUser(User user) { users.Add(user); }

        //  Find and return user by username
        public User FindUser(string username)
        {
            return users.FirstOrDefault(u => u.Name == username);
        }

        // Find and return all users
        public List<User> GetAllUsers() { return users; }

        //  Removes a single user
        public void RemoveUser(User user) { users.Remove(user); }
    }
}
