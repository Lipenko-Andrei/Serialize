using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serialize
{
    [Serializable]
   public class Users
    {
        public List<User> UserList { get; set; } = new List<User>();
    }
    [Serializable]
    public class User
    {
        public string UserName { get; set; }
        public string UserSurname { get; set; }
        public int Age { get; set; }
        public User() 
        {

        }
        public User(string UserName,string UserSurname,int Age)
        {
            this.UserName = UserName;
            this.UserSurname = UserSurname;
            this.Age = Age;
        }
    }
}
