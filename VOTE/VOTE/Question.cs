using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VOTE
{
    public class Question
    {
        public int QuestionId { get; set; }
        public int BallotId { get; set; }
        public string QuestionText { get; set; }

        public List<Option> Options { get; set; }

        public Question(int questionId, int ballotId, string questionText)
        {
            this.QuestionId = questionId;
            this.BallotId = ballotId;
            this.QuestionText = questionText;

            this.Options = new List<Option>();
        }

        public Question(string questionText)
        {
            this.QuestionId = 0;
            this.BallotId = 0;
            this.QuestionText = questionText;

            this.Options = new List<Option>();
        }
    }
}
