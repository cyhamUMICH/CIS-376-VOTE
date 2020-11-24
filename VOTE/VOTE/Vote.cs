using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VOTE
{
    public class Vote
    {
        public int VoteID { get; set; }
        public int OptionID { get; set; }
        public int QuestionID { get; set; }
        public bool VoteStatus { get; set; }
        public string UserState { get; set; }
        public int UserAge { get; set; }
        public string UserGender { get; set; }
        public string UserRace { get; set; }

        public Vote(int OptionID, int QuestionID, bool VoteStatus, string UserState, int UserAge, string UserGender, string UserRace)
        {
            this.VoteID = 0;
            this.OptionID = OptionID;
            this.QuestionID = QuestionID;
            this.VoteStatus = VoteStatus;
            this.UserState = UserState;
            this.UserAge = UserAge;
            this.UserGender = UserGender;
            this.UserRace = UserRace;
        }

        public Vote(int VoteID, int OptionID, int QuestionID, bool VoteStatus, string UserState, int UserAge, string UserGender, string UserRace)
        {
            this.VoteID = VoteID;
            this.OptionID = OptionID;
            this.QuestionID = QuestionID;
            this.VoteStatus = VoteStatus;
            this.UserState = UserState;
            this.UserAge = UserAge;
            this.UserGender = UserGender;
            this.UserRace = UserRace;
        }
    }
}
