using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks.Dataflow;
using ApiAuth.Models;

namespace ApiAuth.Repositories
{
    public static class UserRepository
    {
        public static User Get(string username, string password)
        {
            var users = new List<User>
            {
                new() {Id = 1, Username = "bat", Password = "bat", Role = "manager"},
                new() {Id = 1, Username = "rob", Password = "rob", Role = "employee"}
            };

            return users.FirstOrDefault(x => 
                x.Username == username
                && x.Password == password);
        }
    }
}