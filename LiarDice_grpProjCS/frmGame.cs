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
    public partial class frmGame : Form
    {
        //Declare all players-- 1 player 3 computers
        Player player1 = new Player();
        Player computer1 = new Player();
        Player computer2 = new Player();
        Player computer3 = new Player();
        public frmGame()
        {
            InitializeComponent();
            //roll all dice whe game starts
            DiceRollAll();
        }
        //gets the die
        private void pbxDie1_Click(object sender, EventArgs e)
        {
            player1.BetDieValue = 1;
        }
        private void pbxDie2_Click(object sender, EventArgs e)
        {
            player1.BetDieValue = 2;
        }
        private void pbxDie3_Click(object sender, EventArgs e)
        {
            player1.BetDieValue = 3;
        }
        private void pbxDie4_Click(object sender, EventArgs e)
        {
            player1.BetDieValue = 4;
        }
        private void pbxDie5_Click(object sender, EventArgs e)
        {
            player1.BetDieValue = 5;
        }
        private void pbxDie6_Click(object sender, EventArgs e)
        {
            player1.BetDieValue = 6;
        }
       
        
        private void instructionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmInstruction instructionForm = new frmInstruction();
            instructionForm.ShowDialog();
        }

        private void titleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMain titleForm = new frmMain();
            titleForm.Show();
            this.Hide();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void highScoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmWin winnersForm = new frmWin();
            winnersForm.ShowDialog();
        }


        

        private void btnBet_Click(object sender, EventArgs e)
        {
            //if ()
            //{

            //}
        }




        //roll all dice function
        private void DiceRollAll()
        {
            Random rand = new Random();

            //roll player 1 dice
            player1.D1 = rand.Next(6) + 1;
            player1.D2 = rand.Next(6) + 1;
            player1.D3 = rand.Next(6) + 1;
            player1.D4 = rand.Next(6) + 1;
            player1.D5 = rand.Next(6) + 1;
            player1.D6 = rand.Next(6) + 1;
            //roll computer 1 dice
            computer1.D1 = rand.Next(6) + 1;
            computer1.D2 = rand.Next(6) + 1;
            computer1.D3 = rand.Next(6) + 1;
            computer1.D4 = rand.Next(6) + 1;
            computer1.D5 = rand.Next(6) + 1;
            computer1.D6 = rand.Next(6) + 1;
            //roll computer 2 dice
            computer2.D1 = rand.Next(6) + 1;
            computer2.D2 = rand.Next(6) + 1;
            computer2.D3 = rand.Next(6) + 1;
            computer2.D4 = rand.Next(6) + 1;
            computer2.D5 = rand.Next(6) + 1;
            computer2.D6 = rand.Next(6) + 1;
            //roll computer 3 dice
            computer3.D1 = rand.Next(6) + 1;
            computer3.D2 = rand.Next(6) + 1;
            computer3.D3 = rand.Next(6) + 1;
            computer3.D4 = rand.Next(6) + 1;
            computer3.D5 = rand.Next(6) + 1;
            computer3.D6 = rand.Next(6) + 1;
        }

        private void btnRoll_Click(object sender, EventArgs e)
        {
            DiceRollAll();
            lblDie1Out.Text = player1.D1.ToString();
            lblDie2Out.Text = player1.D2.ToString();
            lblDie3Out.Text = player1.D3.ToString();
            lblDie4Out.Text = player1.D4.ToString();
            lblDie5Out.Text = player1.D5.ToString();
            lblDie6Out.Text = player1.D6.ToString();

        }

        
    }
}
