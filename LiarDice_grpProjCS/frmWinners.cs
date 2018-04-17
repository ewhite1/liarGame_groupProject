using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LiarDice_grpProjCS
{
    public partial class frmWinners : Form
    {
        public frmWinners()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            //close this window
            
            this.Close();
            
        }
    }
}
