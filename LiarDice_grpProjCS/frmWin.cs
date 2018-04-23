using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace LiarDice_grpProjCS
{
    public partial class frmWin : Form
    {
        public frmWin()
        {
            InitializeComponent();
            showWinningCount();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void showWinningCount()
        {
            //read from score.txt and ouput the results
            int winnings;
            // attempt to read the current scores
            try
            {
                StreamReader fileIn;
                fileIn = File.OpenText("score.txt");
                //read the current score
                winnings = int.Parse(fileIn.ReadLine());
                fileIn.Close();
                //show the results
                lblResult.Text = winnings.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
        }
    }
}
