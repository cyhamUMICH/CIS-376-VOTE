using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VOTE
{
    class User
    {
        private String username;
        private String password;
        private String state;
        private String dateOfBirth;
        private String gender;
        private String race;

        public User(String username, String password, String state, String dateOfBirth, String gender, String race)
        {
            this.username = username;
            this.password = password;
            this.state = state;
            this.dateOfBirth = dateOfBirth;
            this.gender = gender;
            this.race = race;
        }
    }
}
