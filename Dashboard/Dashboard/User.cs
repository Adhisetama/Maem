using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dashboard
{
    public class User
    {
        public User(int userId, string name, string username, string password)
        {
            this.UserId = userId;
            this.Name = name;
            this.Username = username;
            this.Password = password;
        }
        public int UserId { get; set; }
        public string Name { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
    }
}
