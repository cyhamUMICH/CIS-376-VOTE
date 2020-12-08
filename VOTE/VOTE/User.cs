using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VOTE
{
    public class User
    {
        public int UserID { get; set; }
        public String Username { get; set; }
        public String Password { get; set; }
        public String State { get; set; }
        public String DateOfBirth { get; set; }
        public String Gender { get; set; }
        public String Race { get; set; }
        public Boolean Administrator { get; set; }

        public User(String username, String password, String state, string dateOfBirth, String gender, String race)
        {
            this.Username = username;
            this.Password = password;
            this.State = state;
            this.DateOfBirth = dateOfBirth;
            this.Gender = gender;
            this.Race = race;
            this.Administrator = false;

            this.UserID = 0;
        }

        public User(int UserID, String username, String password, String state, String dateOfBirth, String gender, String race)
        {
            this.Username = username;
            this.Password = password;
            this.State = state;
            this.DateOfBirth = dateOfBirth;
            this.Gender = gender;
            this.Race = race;
            this.Administrator = false;

            this.UserID = UserID;
        }

        public User(int UserID, String username, String password, String state, String dateOfBirth, String gender, String race, Boolean administrator)
        {
            this.Username = username;
            this.Password = password;
            this.State = state;
            this.DateOfBirth = dateOfBirth;
            this.Gender = gender;
            this.Race = race;
            this.Administrator = administrator;

            this.UserID = UserID;
        }
    }
}
