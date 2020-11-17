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

        public Ballot(int ballotId, string name, DateTime openDate, DateTime dueDate)
        {
            this.BallotId = ballotId;
            this.Name = name;
            this.OpenDate = openDate;
            this.DueDate = dueDate;
        }
    }
}
