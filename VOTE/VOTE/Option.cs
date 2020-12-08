using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VOTE
{
    public class Option
    {
        public int OptionId { get; set; }
        public int QuestionId { get; set; }
        public string OptionText { get; set; }

        public Option(int OptionId, int QuestionId, string OptionText)
        {
            this.OptionId = OptionId;
            this.QuestionId = QuestionId;
            this.OptionText = OptionText;
        }

        public Option(string OptionText)
        {
            this.OptionId = 0;
            this.QuestionId = 0;
            this.OptionText = OptionText;
        }
    }
}
