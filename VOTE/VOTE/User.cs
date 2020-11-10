using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VOTE
{
    class User
    {
        public String Username { get; set; }
        public String Password { get; set; }
        public String State { get; set; }
        public String DateOfBirth { get; set; }
        public String Gender { get; set; }
        public String Race { get; set; }

        public User(String username, String password, String state, String dateOfBirth, String gender, String race)
        {
            this.Username = username;
            this.Password = password;
            this.State = state;
            this.DateOfBirth = dateOfBirth;
            this.Gender = gender;
            this.Race = race;
        }
    }
}
