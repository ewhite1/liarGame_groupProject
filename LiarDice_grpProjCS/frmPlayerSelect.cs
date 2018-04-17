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
    public partial class frmPlayerSelect : Form
    {
        public frmPlayerSelect()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            //take player 1 name, pass it to the new form
            // launch main game
            // gameForm.Show();
        }
    }
}
