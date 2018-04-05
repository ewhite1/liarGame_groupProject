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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnInstructions_Click(object sender, EventArgs e)
        {
            //form Launch- explaining rules
            Instruction frmInstruction = new Instruction();
            this.Hide();
            frmInstruction.Show();
        }

        private void btnNewGame_Click(object sender, EventArgs e)
        {
            //new form launch - new game settings
        }
    }
}
