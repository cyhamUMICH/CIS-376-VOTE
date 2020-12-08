using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VOTE
{
    public class Ballot
    {
        public int BallotId { get; set; }
        public string Name { get; set; }
        public DateTime OpenDate { get; set; }
        public DateTime DueDate { get; set; }

        public List<Question> Questions { get; set; }

        public Ballot(int ballotId, string name, DateTime openDate, DateTime dueDate)
        {
            this.BallotId = ballotId;
            this.Name = name;
            this.OpenDate = openDate;
            this.DueDate = dueDate;

            this.Questions = new List<Question>();
        }

        public Ballot()
        {
            this.BallotId = 0;
            this.Name = "";
            this.OpenDate = DateTime.UtcNow;
            this.DueDate = DateTime.UtcNow;

            this.Questions = new List<Question>();
        }
    }
}
