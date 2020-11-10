using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VOTE
{
    public partial class ViewBallot : Form
    {
        public ViewBallot()
        {
            InitializeComponent();
            DatabaseInterface db = DatabaseInterface.getInstance();
        }
    }
}
