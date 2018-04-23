using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
        int previousDiceAmount;
        int previousDiceValue;
        int choice = 0;
        int totNumD1;
        int totNumD2;
        int totNumD3;
        int totNumD4;
        int totNumD5;
        int totNumD6;
        public frmGame()
        {
            InitializeComponent();
            //hide things based upon level
            gameSettings(frmMain.Settings);
        }

        private void gameSettings(string setting)
        {
            //making this inline, instead of a class
            
            if (setting == "medium")
            {
                //computer one hand hidden
                lblComputer1D1.Visible = false;
                lblComputer1D2.Visible = false;
                lblComputer1D3.Visible = false;
                lblComputer1D4.Visible = false;
                lblComputer1D5.Visible = false;
                lblComputer1D6.Visible = false;
                lblComputer1BetValue.Visible = false;
                //computer two items hiddden
                lblComputer2D1.Visible = false;
                lblComputer2D2.Visible = false;
                lblComputer2D3.Visible = false;
                lblComputer2D4.Visible = false;
                lblComputer2D5.Visible = false;
                lblComputer2D6.Visible = false;
                lblComputer2BetValue.Visible = false;
                //computer three items hidden
                lblComputer3D1.Visible = false;
                lblComputer3D2.Visible = false;
                lblComputer3D3.Visible = false;
                lblComputer3D4.Visible = false;
                lblComputer3D5.Visible = false;
                lblComputer3D6.Visible = false;
                lblComputer3BetValue.Visible = false;
            }

            else if (setting == "hard")
            {
                //computer one hand hidden
                lblComputer1D1.Visible = false;
                lblComputer1D2.Visible = false;
                lblComputer1D3.Visible = false;
                lblComputer1D4.Visible = false;
                lblComputer1D5.Visible = false;
                lblComputer1D6.Visible = false;
                lblComputer1BetValue.Visible = false;
                //computer two items hiddden
                lblComputer2D1.Visible = false;
                lblComputer2D2.Visible = false;
                lblComputer2D3.Visible = false;
                lblComputer2D4.Visible = false;
                lblComputer2D5.Visible = false;
                lblComputer2D6.Visible = false;
                lblComputer2BetValue.Visible = false;
                //computer three items hidden
                lblComputer3D1.Visible = false;
                lblComputer3D2.Visible = false;
                lblComputer3D3.Visible = false;
                lblComputer3D4.Visible = false;
                lblComputer3D5.Visible = false;
                lblComputer3D6.Visible = false;
                lblComputer3BetValue.Visible = false;

                //all counts invisble
                lblDie1Count.Visible = false;
                lblDie2Count.Visible = false;
                lblDie3Count.Visible = false;
                lblDie4Count.Visible = false;
                lblDie5Count.Visible = false;
                lblDie6Count.Visible = false;
            }
            else
            {
                // do nothing
            }
        }
        private void frmGame_Load(object sender, EventArgs e)
        {
            //set all dice values to true. still able to use the dice in the game
            player1.D1On = true;
            player1.D2On = true;
            player1.D3On = true;
            player1.D4On = true;
            player1.D5On = true;
            player1.D6On = true;
            computer1.D1On = true;
            computer1.D2On = true;
            computer1.D3On = true;
            computer1.D4On = true;
            computer1.D5On = true;
            computer1.D6On = true;
            computer2.D1On = true;
            computer2.D2On = true;
            computer2.D3On = true;
            computer2.D4On = true;
            computer2.D5On = true;
            computer2.D6On = true;
            computer3.D1On = true;
            computer3.D2On = true;
            computer3.D3On = true;
            computer3.D4On = true;
            computer3.D5On = true;
            computer3.D6On = true;
            
            //display all dice
            //player1
            lblDie1Out.Text = player1.D1.ToString();
            lblDie2Out.Text = player1.D2.ToString();
            lblDie3Out.Text = player1.D3.ToString();
            lblDie4Out.Text = player1.D4.ToString();
            lblDie5Out.Text = player1.D5.ToString();
            lblDie6Out.Text = player1.D6.ToString();
            //computer1
            lblComputer1D1.Text = computer1.D1.ToString();
            lblComputer1D2.Text = computer1.D2.ToString();
            lblComputer1D3.Text = computer1.D3.ToString();
            lblComputer1D4.Text = computer1.D4.ToString();
            lblComputer1D5.Text = computer1.D5.ToString();
            lblComputer1D6.Text = computer1.D6.ToString();
            //computer2
            lblComputer2D1.Text = computer2.D1.ToString();
            lblComputer2D2.Text = computer2.D2.ToString();
            lblComputer2D3.Text = computer2.D3.ToString();
            lblComputer2D4.Text = computer2.D4.ToString();
            lblComputer2D5.Text = computer2.D5.ToString();
            lblComputer2D6.Text = computer2.D6.ToString();
            //computer3
            lblComputer3D1.Text = computer3.D1.ToString();
            lblComputer3D2.Text = computer3.D2.ToString();
            lblComputer3D3.Text = computer3.D3.ToString();
            lblComputer3D4.Text = computer3.D4.ToString();
            lblComputer3D5.Text = computer3.D5.ToString();
            lblComputer3D6.Text = computer3.D6.ToString();

            player1.DiceCountLeft = 6;
            computer1.DiceCountLeft = 6;
            computer2.DiceCountLeft = 6;
            computer3.DiceCountLeft = 6;

            lblComputer1BetNum.Text = "X";
            lblComputer1BetValue.Text = "X";
            lblComputer2BetNum.Text = "X";
            lblComputer2BetValue.Text = "X";
            lblComputer3BetNum.Text = "X";
            lblComputer3BetValue.Text = "X";
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
        private void GetDieNum()
        {
            if(lstDiceBetNum.SelectedIndex == 0)
            {
                player1.BetNumOfDice = 1;
            }
            else if (lstDiceBetNum.SelectedIndex == 1)
            {
                player1.BetNumOfDice = 2;
            }
            else if (lstDiceBetNum.SelectedIndex == 2)
            {
                player1.BetNumOfDice = 3;
            }
            else if (lstDiceBetNum.SelectedIndex == 3)
            {
                player1.BetNumOfDice = 4;
            }
            else if (lstDiceBetNum.SelectedIndex == 4)
            {
                player1.BetNumOfDice = 5;
            }
            else if (lstDiceBetNum.SelectedIndex == 5)
            {
                player1.BetNumOfDice = 6;
            }
            else if (lstDiceBetNum.SelectedIndex == 6)
            {
                player1.BetNumOfDice = 7;
            }
            else if (lstDiceBetNum.SelectedIndex == 7)
            {
                player1.BetNumOfDice = 8;
            }
            else if (lstDiceBetNum.SelectedIndex == 8)
            {
                player1.BetNumOfDice = 9;
            }
            else if (lstDiceBetNum.SelectedIndex == 9)
            {
                player1.BetNumOfDice = 10;
            }
            else if (lstDiceBetNum.SelectedIndex == 10)
            {
                player1.BetNumOfDice = 11;
            }
            else if (lstDiceBetNum.SelectedIndex == 11)
            {
                player1.BetNumOfDice = 12;
            }
            else if (lstDiceBetNum.SelectedIndex == 12)
            {
                player1.BetNumOfDice = 13;
            }
            else if (lstDiceBetNum.SelectedIndex == 13)
            {
                player1.BetNumOfDice = 14;
            }
            else if (lstDiceBetNum.SelectedIndex == 14)
            {
                player1.BetNumOfDice = 15;
            }
            else if (lstDiceBetNum.SelectedIndex == 15)
            {
                player1.BetNumOfDice = 16;
            }
            else if (lstDiceBetNum.SelectedIndex == 16)
            {
                player1.BetNumOfDice = 17;
            }
            else if (lstDiceBetNum.SelectedIndex == 17)
            {
                player1.BetNumOfDice = 18;
            }
            else if (lstDiceBetNum.SelectedIndex == 18)
            {
                player1.BetNumOfDice = 19;
            }
            else if (lstDiceBetNum.SelectedIndex == 19)
            {
                player1.BetNumOfDice = 20;
            }
        }
        
        private void instructionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmInstruction instructionForm = new frmInstruction();
            instructionForm.ShowDialog();
        }

        private void titleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //confirm before exiting
            DialogResult resultAnswer = MessageBox.Show("Exiting back to the main Screen Will Cancel your current Game",
                "Do you really wish to quit?", MessageBoxButtons.YesNo);
            if (resultAnswer == DialogResult.Yes)
            {
                frmMain titleForm = new frmMain();
                titleForm.Show();
                this.Close();
            }
                
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //confirm before exiting
            DialogResult resultAnswer = MessageBox.Show("Exiting now Will Cancel your current Game",
                "Do you really wish to quit?", MessageBoxButtons.YesNo);
            if (resultAnswer == DialogResult.Yes)
            {
                Application.Exit();
            }
            
        }

        private void highScoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmWin winnersForm = new frmWin();
            winnersForm.ShowDialog();
        }
        
        private void btnBet_Click(object sender, EventArgs e)
        {
            lblComputer1BetNum.Text = "X";
            lblComputer1BetValue.Text = "X";
            lblComputer2BetNum.Text = "X";
            lblComputer2BetValue.Text = "X";
            lblComputer3BetNum.Text = "X";
            lblComputer3BetValue.Text = "X";
            CountDice();
            GetDieNum();
            ComputerBet();
        }
        private void ComputerBet()
        {
            previousDiceAmount = player1.BetNumOfDice;
            previousDiceValue = player1.BetDieValue;

            //computer1 bet
            GenerateChoice();
            if (previousDiceValue >= 5 && previousDiceAmount < 7)
            {
                computer1.BetDieValue = previousDiceValue;
                computer1.BetNumOfDice = (previousDiceAmount +choice);
            }
            else if (previousDiceAmount >= 7)
            {

                Computer1Challenge();
                computer1.BetNumOfDice = choice;
                if (choice == 2)
                {
                    computer1.BetDieValue = previousDiceValue;
                }
                else
                {
                    computer1.BetDieValue = previousDiceValue + 1;
                }
            }
            else
            {
                computer1.BetNumOfDice = previousDiceAmount + choice;
                computer1.BetDieValue = previousDiceValue + choice;
            }
            lblComputer1BetNum.Text = computer1.BetNumOfDice.ToString();
            lblComputer1BetValue.Text = computer1.BetDieValue.ToString();
            previousDiceAmount = computer1.BetNumOfDice;
            previousDiceValue = computer1.BetDieValue;
            //computer2
            GenerateChoice();
            if (previousDiceValue >= 5 && previousDiceAmount < 6)
            {
                computer2.BetDieValue = previousDiceValue;
                computer2.BetNumOfDice = (previousDiceAmount + choice);
            }
            else if (previousDiceAmount >= 6)
            {
                Computer2Challenge();
                computer2.BetNumOfDice = choice;
                if (choice == 2)
                {
                    computer2.BetDieValue = previousDiceValue;
                }
                else
                {
                    computer2.BetDieValue = previousDiceValue + 1;
                }
            }
            else
            {
                computer2.BetNumOfDice = previousDiceAmount + choice;
                computer2.BetDieValue = previousDiceValue + choice;
            }
            lblComputer2BetNum.Text = computer2.BetNumOfDice.ToString();
            lblComputer2BetValue.Text = computer2.BetDieValue.ToString();
            previousDiceAmount = computer2.BetNumOfDice;
            previousDiceValue = computer2.BetDieValue;
            //computer3
            GenerateChoice();
            if (previousDiceValue >= 5 && previousDiceAmount < 8)
            {
                computer3.BetDieValue = previousDiceValue;
                computer3.BetNumOfDice = (previousDiceAmount + choice);
            }
            else if (previousDiceAmount >= 8)
            {
                Computer3Challenge();
                computer3.BetNumOfDice = choice;
                if (choice == 2)
                {
                    computer3.BetDieValue = previousDiceValue;
                }
                else
                {
                    computer3.BetDieValue = previousDiceValue + 1;
                }
            }
            else
            {
                computer3.BetNumOfDice = previousDiceAmount + choice;
                computer3.BetDieValue = previousDiceValue + choice;
            }
            lblComputer3BetNum.Text = computer3.BetNumOfDice.ToString();
            lblComputer3BetValue.Text = computer3.BetDieValue.ToString();
            previousDiceAmount = computer3.BetNumOfDice;
            previousDiceValue = computer3.BetDieValue;
        }
        private bool CountDice()
        {
            //reset totals
            totNumD1 = 0;
            totNumD2 = 0;
            totNumD3 = 0;
            totNumD4 = 0;
            totNumD5 = 0;
            totNumD6 = 0;

            //player1
            if(player1.DiceCountLeft == 6)
            {
                switch (player1.D1)
                {
                    // player one dice
                    case 1:
                        totNumD1 += 1;
                        break;
                    case 2:
                        totNumD2 += 1;
                        break;
                    case 3:
                        totNumD3 += 1;
                        break;
                    case 4:
                        totNumD4 += 1;
                        break;
                    case 5:
                        totNumD5 += 1;
                        break;
                    case 6:
                        totNumD6 += 1;
                        break;
                }
                switch (player1.D2)
                {
                    // player one dice
                    case 1:
                        totNumD1 += 1;
                        break;
                    case 2:
                        totNumD2 += 1;
                        break;
                    case 3:
                        totNumD3 += 1;
                        break;
                    case 4:
                        totNumD4 += 1;
                        break;
                    case 5:
                        totNumD5 += 1;
                        break;
                    case 6:
                        totNumD6 += 1;
                        break;
                }
                switch (player1.D3)
                {
                    // player one dice
                    case 1:
                        totNumD1 += 1;
                        break;
                    case 2:
                        totNumD2 += 1;
                        break;
                    case 3:
                        totNumD3 += 1;
                        break;
                    case 4:
                        totNumD4 += 1;
                        break;
                    case 5:
                        totNumD5 += 1;
                        break;
                    case 6:
                        totNumD6 += 1;
                        break;
                }
                switch (player1.D4)
                {
                    // player one dice
                    case 1:
                        totNumD1 += 1;
                        break;
                    case 2:
                        totNumD2 += 1;
                        break;
                    case 3:
                        totNumD3 += 1;
                        break;
                    case 4:
                        totNumD4 += 1;
                        break;
                    case 5:
                        totNumD5 += 1;
                        break;
                    case 6:
                        totNumD6 += 1;
                        break;
                }
                switch (player1.D5)
                {
                    // player one dice
                    case 1:
                        totNumD1 += 1;
                        break;
                    case 2:
                        totNumD2 += 1;
                        break;
                    case 3:
                        totNumD3 += 1;
                        break;
                    case 4:
                        totNumD4 += 1;
                        break;
                    case 5:
                        totNumD5 += 1;
                        break;
                    case 6:
                        totNumD6 += 1;
                        break;
                }
                switch (player1.D6)
                {
                    // player one dice
                    case 1:
                        totNumD1 += 1;
                        break;
                    case 2:
                        totNumD2 += 1;
                        break;
                    case 3:
                        totNumD3 += 1;
                        break;
                    case 4:
                        totNumD4 += 1;
                        break;
                    case 5:
                        totNumD5 += 1;
                        break;
                    case 6:
                        totNumD6 += 1;
                        break;
                }
            }
            else if(player1.DiceCountLeft == 5)
            {
                switch (player1.D1)
                {
                    // player one dice
                    case 1:
                        totNumD1 += 1;
                        break;
                    case 2:
                        totNumD2 += 1;
                        break;
                    case 3:
                        totNumD3 += 1;
                        break;
                    case 4:
                        totNumD4 += 1;
                        break;
                    case 5:
                        totNumD5 += 1;
                        break;
                    case 6:
                        totNumD6 += 1;
                        break;
                }
                switch (player1.D2)
                {
                    // player one dice
                    case 1:
                        totNumD1 += 1;
                        break;
                    case 2:
                        totNumD2 += 1;
                        break;
                    case 3:
                        totNumD3 += 1;
                        break;
                    case 4:
                        totNumD4 += 1;
                        break;
                    case 5:
                        totNumD5 += 1;
                        break;
                    case 6:
                        totNumD6 += 1;
                        break;
                }
                switch (player1.D3)
                {
                    // player one dice
                    case 1:
                        totNumD1 += 1;
                        break;
                    case 2:
                        totNumD2 += 1;
                        break;
                    case 3:
                        totNumD3 += 1;
                        break;
                    case 4:
                        totNumD4 += 1;
                        break;
                    case 5:
                        totNumD5 += 1;
                        break;
                    case 6:
                        totNumD6 += 1;
                        break;
                }
                switch (player1.D4)
                {
                    // player one dice
                    case 1:
                        totNumD1 += 1;
                        break;
                    case 2:
                        totNumD2 += 1;
                        break;
                    case 3:
                        totNumD3 += 1;
                        break;
                    case 4:
                        totNumD4 += 1;
                        break;
                    case 5:
                        totNumD5 += 1;
                        break;
                    case 6:
                        totNumD6 += 1;
                        break;
                }
                switch (player1.D5)
                {
                    // player one dice
                    case 1:
                        totNumD1 += 1;
                        break;
                    case 2:
                        totNumD2 += 1;
                        break;
                    case 3:
                        totNumD3 += 1;
                        break;
                    case 4:
                        totNumD4 += 1;
                        break;
                    case 5:
                        totNumD5 += 1;
                        break;
                    case 6:
                        totNumD6 += 1;
                        break;
                }
            }
            else if(player1.DiceCountLeft == 4)
            {
                switch (player1.D1)
                {
                    // player one dice
                    case 1:
                        totNumD1 += 1;
                        break;
                    case 2:
                        totNumD2 += 1;
                        break;
                    case 3:
                        totNumD3 += 1;
                        break;
                    case 4:
                        totNumD4 += 1;
                        break;
                    case 5:
                        totNumD5 += 1;
                        break;
                    case 6:
                        totNumD6 += 1;
                        break;
                }
                switch (player1.D2)
                {
                    // player one dice
                    case 1:
                        totNumD1 += 1;
                        break;
                    case 2:
                        totNumD2 += 1;
                        break;
                    case 3:
                        totNumD3 += 1;
                        break;
                    case 4:
                        totNumD4 += 1;
                        break;
                    case 5:
                        totNumD5 += 1;
                        break;
                    case 6:
                        totNumD6 += 1;
                        break;
                }
                switch (player1.D3)
                {
                    // player one dice
                    case 1:
                        totNumD1 += 1;
                        break;
                    case 2:
                        totNumD2 += 1;
                        break;
                    case 3:
                        totNumD3 += 1;
                        break;
                    case 4:
                        totNumD4 += 1;
                        break;
                    case 5:
                        totNumD5 += 1;
                        break;
                    case 6:
                        totNumD6 += 1;
                        break;
                }
                switch (player1.D4)
                {
                    // player one dice
                    case 1:
                        totNumD1 += 1;
                        break;
                    case 2:
                        totNumD2 += 1;
                        break;
                    case 3:
                        totNumD3 += 1;
                        break;
                    case 4:
                        totNumD4 += 1;
                        break;
                    case 5:
                        totNumD5 += 1;
                        break;
                    case 6:
                        totNumD6 += 1;
                        break;
                }
            }
            else if(player1.DiceCountLeft == 3)
            {
                switch (player1.D1)
                {
                    // player one dice
                    case 1:
                        totNumD1 += 1;
                        break;
                    case 2:
                        totNumD2 += 1;
                        break;
                    case 3:
                        totNumD3 += 1;
                        break;
                    case 4:
                        totNumD4 += 1;
                        break;
                    case 5:
                        totNumD5 += 1;
                        break;
                    case 6:
                        totNumD6 += 1;
                        break;
                }
                switch (player1.D2)
                {
                    // player one dice
                    case 1:
                        totNumD1 += 1;
                        break;
                    case 2:
                        totNumD2 += 1;
                        break;
                    case 3:
                        totNumD3 += 1;
                        break;
                    case 4:
                        totNumD4 += 1;
                        break;
                    case 5:
                        totNumD5 += 1;
                        break;
                    case 6:
                        totNumD6 += 1;
                        break;
                }
                switch (player1.D3)
                {
                    // player one dice
                    case 1:
                        totNumD1 += 1;
                        break;
                    case 2:
                        totNumD2 += 1;
                        break;
                    case 3:
                        totNumD3 += 1;
                        break;
                    case 4:
                        totNumD4 += 1;
                        break;
                    case 5:
                        totNumD5 += 1;
                        break;
                    case 6:
                        totNumD6 += 1;
                        break;
                }
            }
            else if(player1.DiceCountLeft == 2)
            {
                switch (player1.D1)
                {
                    // player one dice
                    case 1:
                        totNumD1 += 1;
                        break;
                    case 2:
                        totNumD2 += 1;
                        break;
                    case 3:
                        totNumD3 += 1;
                        break;
                    case 4:
                        totNumD4 += 1;
                        break;
                    case 5:
                        totNumD5 += 1;
                        break;
                    case 6:
                        totNumD6 += 1;
                        break;
                }
                switch (player1.D2)
                {
                    // player one dice
                    case 1:
                        totNumD1 += 1;
                        break;
                    case 2:
                        totNumD2 += 1;
                        break;
                    case 3:
                        totNumD3 += 1;
                        break;
                    case 4:
                        totNumD4 += 1;
                        break;
                    case 5:
                        totNumD5 += 1;
                        break;
                    case 6:
                        totNumD6 += 1;
                        break;
                }
            }
            else if(player1.DiceCountLeft == 1)
            {
                switch (player1.D1)
                {
                    // player one dice
                    case 1:
                        totNumD1 += 1;
                        break;
                    case 2:
                        totNumD2 += 1;
                        break;
                    case 3:
                        totNumD3 += 1;
                        break;
                    case 4:
                        totNumD4 += 1;
                        break;
                    case 5:
                        totNumD5 += 1;
                        break;
                    case 6:
                        totNumD6 += 1;
                        break;
                }
            }
            //computer1
            if(computer1.DiceCountLeft == 6)
            {
                switch (computer1.D1)
                {
                    case 1:
                        totNumD1 += 1;
                        break;
                    case 2:
                        totNumD2 += 1;
                        break;
                    case 3:
                        totNumD3 += 1;
                        break;
                    case 4:
                        totNumD4 += 1;
                        break;
                    case 5:
                        totNumD5 += 1;
                        break;
                    case 6:
                        totNumD6 += 1;
                        break;
                }
                switch (computer1.D2)
                {
                    case 1:
                        totNumD1 += 1;
                        break;
                    case 2:
                        totNumD2 += 1;
                        break;
                    case 3:
                        totNumD3 += 1;
                        break;
                    case 4:
                        totNumD4 += 1;
                        break;
                    case 5:
                        totNumD5 += 1;
                        break;
                    case 6:
                        totNumD6 += 1;
                        break;
                }
                switch (computer1.D3)
                {
                    case 1:
                        totNumD1 += 1;
                        break;
                    case 2:
                        totNumD2 += 1;
                        break;
                    case 3:
                        totNumD3 += 1;
                        break;
                    case 4:
                        totNumD4 += 1;
                        break;
                    case 5:
                        totNumD5 += 1;
                        break;
                    case 6:
                        totNumD6 += 1;
                        break;
                }
                switch (computer1.D4)
                {
                    case 1:
                        totNumD1 += 1;
                        break;
                    case 2:
                        totNumD2 += 1;
                        break;
                    case 3:
                        totNumD3 += 1;
                        break;
                    case 4:
                        totNumD4 += 1;
                        break;
                    case 5:
                        totNumD5 += 1;
                        break;
                    case 6:
                        totNumD6 += 1;
                        break;
                }
                switch (computer1.D5)
                {
                    case 1:
                        totNumD1 += 1;
                        break;
                    case 2:
                        totNumD2 += 1;
                        break;
                    case 3:
                        totNumD3 += 1;
                        break;
                    case 4:
                        totNumD4 += 1;
                        break;
                    case 5:
                        totNumD5 += 1;
                        break;
                    case 6:
                        totNumD6 += 1;
                        break;
                }
                switch (computer1.D6)
                {
                    case 1:
                        totNumD1 += 1;
                        break;
                    case 2:
                        totNumD2 += 1;
                        break;
                    case 3:
                        totNumD3 += 1;
                        break;
                    case 4:
                        totNumD4 += 1;
                        break;
                    case 5:
                        totNumD5 += 1;
                        break;
                    case 6:
                        totNumD6 += 1;
                        break;
                }
            }
            else if(computer1.DiceCountLeft == 5)
            {
                switch (computer1.D1)
                {
                    case 1:
                        totNumD1 += 1;
                        break;
                    case 2:
                        totNumD2 += 1;
                        break;
                    case 3:
                        totNumD3 += 1;
                        break;
                    case 4:
                        totNumD4 += 1;
                        break;
                    case 5:
                        totNumD5 += 1;
                        break;
                    case 6:
                        totNumD6 += 1;
                        break;
                }
                switch (computer1.D2)
                {
                    case 1:
                        totNumD1 += 1;
                        break;
                    case 2:
                        totNumD2 += 1;
                        break;
                    case 3:
                        totNumD3 += 1;
                        break;
                    case 4:
                        totNumD4 += 1;
                        break;
                    case 5:
                        totNumD5 += 1;
                        break;
                    case 6:
                        totNumD6 += 1;
                        break;
                }
                switch (computer1.D3)
                {
                    case 1:
                        totNumD1 += 1;
                        break;
                    case 2:
                        totNumD2 += 1;
                        break;
                    case 3:
                        totNumD3 += 1;
                        break;
                    case 4:
                        totNumD4 += 1;
                        break;
                    case 5:
                        totNumD5 += 1;
                        break;
                    case 6:
                        totNumD6 += 1;
                        break;
                }
                switch (computer1.D4)
                {
                    case 1:
                        totNumD1 += 1;
                        break;
                    case 2:
                        totNumD2 += 1;
                        break;
                    case 3:
                        totNumD3 += 1;
                        break;
                    case 4:
                        totNumD4 += 1;
                        break;
                    case 5:
                        totNumD5 += 1;
                        break;
                    case 6:
                        totNumD6 += 1;
                        break;
                }
                switch (computer1.D5)
                {
                    case 1:
                        totNumD1 += 1;
                        break;
                    case 2:
                        totNumD2 += 1;
                        break;
                    case 3:
                        totNumD3 += 1;
                        break;
                    case 4:
                        totNumD4 += 1;
                        break;
                    case 5:
                        totNumD5 += 1;
                        break;
                    case 6:
                        totNumD6 += 1;
                        break;
                }
            }
            else if(computer1.DiceCountLeft == 4)
            {
                switch (computer1.D1)
                {
                    case 1:
                        totNumD1 += 1;
                        break;
                    case 2:
                        totNumD2 += 1;
                        break;
                    case 3:
                        totNumD3 += 1;
                        break;
                    case 4:
                        totNumD4 += 1;
                        break;
                    case 5:
                        totNumD5 += 1;
                        break;
                    case 6:
                        totNumD6 += 1;
                        break;
                }
                switch (computer1.D2)
                {
                    case 1:
                        totNumD1 += 1;
                        break;
                    case 2:
                        totNumD2 += 1;
                        break;
                    case 3:
                        totNumD3 += 1;
                        break;
                    case 4:
                        totNumD4 += 1;
                        break;
                    case 5:
                        totNumD5 += 1;
                        break;
                    case 6:
                        totNumD6 += 1;
                        break;
                }
                switch (computer1.D3)
                {
                    case 1:
                        totNumD1 += 1;
                        break;
                    case 2:
                        totNumD2 += 1;
                        break;
                    case 3:
                        totNumD3 += 1;
                        break;
                    case 4:
                        totNumD4 += 1;
                        break;
                    case 5:
                        totNumD5 += 1;
                        break;
                    case 6:
                        totNumD6 += 1;
                        break;
                }
                switch (computer1.D4)
                {
                    case 1:
                        totNumD1 += 1;
                        break;
                    case 2:
                        totNumD2 += 1;
                        break;
                    case 3:
                        totNumD3 += 1;
                        break;
                    case 4:
                        totNumD4 += 1;
                        break;
                    case 5:
                        totNumD5 += 1;
                        break;
                    case 6:
                        totNumD6 += 1;
                        break;
                }
            }
            else if(computer1.DiceCountLeft == 3)
            {
                switch (computer1.D1)
                {
                    case 1:
                        totNumD1 += 1;
                        break;
                    case 2:
                        totNumD2 += 1;
                        break;
                    case 3:
                        totNumD3 += 1;
                        break;
                    case 4:
                        totNumD4 += 1;
                        break;
                    case 5:
                        totNumD5 += 1;
                        break;
                    case 6:
                        totNumD6 += 1;
                        break;
                }
                switch (computer1.D2)
                {
                    case 1:
                        totNumD1 += 1;
                        break;
                    case 2:
                        totNumD2 += 1;
                        break;
                    case 3:
                        totNumD3 += 1;
                        break;
                    case 4:
                        totNumD4 += 1;
                        break;
                    case 5:
                        totNumD5 += 1;
                        break;
                    case 6:
                        totNumD6 += 1;
                        break;
                }
                switch (computer1.D3)
                {
                    case 1:
                        totNumD1 += 1;
                        break;
                    case 2:
                        totNumD2 += 1;
                        break;
                    case 3:
                        totNumD3 += 1;
                        break;
                    case 4:
                        totNumD4 += 1;
                        break;
                    case 5:
                        totNumD5 += 1;
                        break;
                    case 6:
                        totNumD6 += 1;
                        break;
                }
            }
            else if(computer1.DiceCountLeft == 2)
            {
                switch (computer1.D1)
                {
                    case 1:
                        totNumD1 += 1;
                        break;
                    case 2:
                        totNumD2 += 1;
                        break;
                    case 3:
                        totNumD3 += 1;
                        break;
                    case 4:
                        totNumD4 += 1;
                        break;
                    case 5:
                        totNumD5 += 1;
                        break;
                    case 6:
                        totNumD6 += 1;
                        break;
                }
                switch (computer1.D2)
                {
                    case 1:
                        totNumD1 += 1;
                        break;
                    case 2:
                        totNumD2 += 1;
                        break;
                    case 3:
                        totNumD3 += 1;
                        break;
                    case 4:
                        totNumD4 += 1;
                        break;
                    case 5:
                        totNumD5 += 1;
                        break;
                    case 6:
                        totNumD6 += 1;
                        break;
                }
            }
            else if(computer1.DiceCountLeft == 1)
            {
                switch (computer1.D1)
                {
                    case 1:
                        totNumD1 += 1;
                        break;
                    case 2:
                        totNumD2 += 1;
                        break;
                    case 3:
                        totNumD3 += 1;
                        break;
                    case 4:
                        totNumD4 += 1;
                        break;
                    case 5:
                        totNumD5 += 1;
                        break;
                    case 6:
                        totNumD6 += 1;
                        break;
                }
            }
            //computer 2 count dice
            if(computer2.DiceCountLeft == 6)
            {
                switch (computer2.D1)
                {
                    // player one dice
                    case 1:
                        totNumD1 += 1;
                        break;
                    case 2:
                        totNumD2 += 1;
                        break;
                    case 3:
                        totNumD3 += 1;
                        break;
                    case 4:
                        totNumD4 += 1;
                        break;
                    case 5:
                        totNumD5 += 1;
                        break;
                    case 6:
                        totNumD6 += 1;
                        break;
                }
                switch (computer2.D1)
                {
                    case 1:
                        totNumD1 += 1;
                        break;
                    case 2:
                        totNumD2 += 1;
                        break;
                    case 3:
                        totNumD3 += 1;
                        break;
                    case 4:
                        totNumD4 += 1;
                        break;
                    case 5:
                        totNumD5 += 1;
                        break;
                    case 6:
                        totNumD6 += 1;
                        break;
                }
                switch (computer2.D2)
                {
                    case 1:
                        totNumD1 += 1;
                        break;
                    case 2:
                        totNumD2 += 1;
                        break;
                    case 3:
                        totNumD3 += 1;
                        break;
                    case 4:
                        totNumD4 += 1;
                        break;
                    case 5:
                        totNumD5 += 1;
                        break;
                    case 6:
                        totNumD6 += 1;
                        break;
                }
                switch (computer2.D3)
                {
                    case 1:
                        totNumD1 += 1;
                        break;
                    case 2:
                        totNumD2 += 1;
                        break;
                    case 3:
                        totNumD3 += 1;
                        break;
                    case 4:
                        totNumD4 += 1;
                        break;
                    case 5:
                        totNumD5 += 1;
                        break;
                    case 6:
                        totNumD6 += 1;
                        break;
                }
                switch (computer2.D4)
                {
                    case 1:
                        totNumD1 += 1;
                        break;
                    case 2:
                        totNumD2 += 1;
                        break;
                    case 3:
                        totNumD3 += 1;
                        break;
                    case 4:
                        totNumD4 += 1;
                        break;
                    case 5:
                        totNumD5 += 1;
                        break;
                    case 6:
                        totNumD6 += 1;
                        break;
                }
                switch (computer2.D5)
                {
                    case 1:
                        totNumD1 += 1;
                        break;
                    case 2:
                        totNumD2 += 1;
                        break;
                    case 3:
                        totNumD3 += 1;
                        break;
                    case 4:
                        totNumD4 += 1;
                        break;
                    case 5:
                        totNumD5 += 1;
                        break;
                    case 6:
                        totNumD6 += 1;
                        break;
                }
                switch (computer2.D6)
                {
                    case 1:
                        totNumD1 += 1;
                        break;
                    case 2:
                        totNumD2 += 1;
                        break;
                    case 3:
                        totNumD3 += 1;
                        break;
                    case 4:
                        totNumD4 += 1;
                        break;
                    case 5:
                        totNumD5 += 1;
                        break;
                    case 6:
                        totNumD6 += 1;
                        break;
                }
            }
            else if(computer2.DiceCountLeft == 5)
            {
                switch (computer2.D1)
                {
                    case 1:
                        totNumD1 += 1;
                        break;
                    case 2:
                        totNumD2 += 1;
                        break;
                    case 3:
                        totNumD3 += 1;
                        break;
                    case 4:
                        totNumD4 += 1;
                        break;
                    case 5:
                        totNumD5 += 1;
                        break;
                    case 6:
                        totNumD6 += 1;
                        break;
                }
                switch (computer2.D2)
                {
                    case 1:
                        totNumD1 += 1;
                        break;
                    case 2:
                        totNumD2 += 1;
                        break;
                    case 3:
                        totNumD3 += 1;
                        break;
                    case 4:
                        totNumD4 += 1;
                        break;
                    case 5:
                        totNumD5 += 1;
                        break;
                    case 6:
                        totNumD6 += 1;
                        break;
                }
                switch (computer2.D3)
                {
                    case 1:
                        totNumD1 += 1;
                        break;
                    case 2:
                        totNumD2 += 1;
                        break;
                    case 3:
                        totNumD3 += 1;
                        break;
                    case 4:
                        totNumD4 += 1;
                        break;
                    case 5:
                        totNumD5 += 1;
                        break;
                    case 6:
                        totNumD6 += 1;
                        break;
                }
                switch (computer2.D4)
                {
                    case 1:
                        totNumD1 += 1;
                        break;
                    case 2:
                        totNumD2 += 1;
                        break;
                    case 3:
                        totNumD3 += 1;
                        break;
                    case 4:
                        totNumD4 += 1;
                        break;
                    case 5:
                        totNumD5 += 1;
                        break;
                    case 6:
                        totNumD6 += 1;
                        break;
                }
                switch (computer2.D5)
                {
                    case 1:
                        totNumD1 += 1;
                        break;
                    case 2:
                        totNumD2 += 1;
                        break;
                    case 3:
                        totNumD3 += 1;
                        break;
                    case 4:
                        totNumD4 += 1;
                        break;
                    case 5:
                        totNumD5 += 1;
                        break;
                    case 6:
                        totNumD6 += 1;
                        break;
                }
            }
            else if(computer2.DiceCountLeft == 4)
            {
                switch (computer2.D1)
                {
                    case 1:
                        totNumD1 += 1;
                        break;
                    case 2:
                        totNumD2 += 1;
                        break;
                    case 3:
                        totNumD3 += 1;
                        break;
                    case 4:
                        totNumD4 += 1;
                        break;
                    case 5:
                        totNumD5 += 1;
                        break;
                    case 6:
                        totNumD6 += 1;
                        break;
                }
                switch (computer2.D2)
                {
                    case 1:
                        totNumD1 += 1;
                        break;
                    case 2:
                        totNumD2 += 1;
                        break;
                    case 3:
                        totNumD3 += 1;
                        break;
                    case 4:
                        totNumD4 += 1;
                        break;
                    case 5:
                        totNumD5 += 1;
                        break;
                    case 6:
                        totNumD6 += 1;
                        break;
                }
                switch (computer2.D3)
                {
                    case 1:
                        totNumD1 += 1;
                        break;
                    case 2:
                        totNumD2 += 1;
                        break;
                    case 3:
                        totNumD3 += 1;
                        break;
                    case 4:
                        totNumD4 += 1;
                        break;
                    case 5:
                        totNumD5 += 1;
                        break;
                    case 6:
                        totNumD6 += 1;
                        break;
                }
                switch (computer2.D4)
                {
                    case 1:
                        totNumD1 += 1;
                        break;
                    case 2:
                        totNumD2 += 1;
                        break;
                    case 3:
                        totNumD3 += 1;
                        break;
                    case 4:
                        totNumD4 += 1;
                        break;
                    case 5:
                        totNumD5 += 1;
                        break;
                    case 6:
                        totNumD6 += 1;
                        break;
                }
            }
            else if(computer2.DiceCountLeft == 3)
            {
                switch (computer2.D1)
                {
                    case 1:
                        totNumD1 += 1;
                        break;
                    case 2:
                        totNumD2 += 1;
                        break;
                    case 3:
                        totNumD3 += 1;
                        break;
                    case 4:
                        totNumD4 += 1;
                        break;
                    case 5:
                        totNumD5 += 1;
                        break;
                    case 6:
                        totNumD6 += 1;
                        break;
                }
                switch (computer2.D2)
                {
                    case 1:
                        totNumD1 += 1;
                        break;
                    case 2:
                        totNumD2 += 1;
                        break;
                    case 3:
                        totNumD3 += 1;
                        break;
                    case 4:
                        totNumD4 += 1;
                        break;
                    case 5:
                        totNumD5 += 1;
                        break;
                    case 6:
                        totNumD6 += 1;
                        break;
                }
                switch (computer2.D3)
                {
                    case 1:
                        totNumD1 += 1;
                        break;
                    case 2:
                        totNumD2 += 1;
                        break;
                    case 3:
                        totNumD3 += 1;
                        break;
                    case 4:
                        totNumD4 += 1;
                        break;
                    case 5:
                        totNumD5 += 1;
                        break;
                    case 6:
                        totNumD6 += 1;
                        break;
                }
            }
            else if(computer2.DiceCountLeft == 2)
            {
                switch (computer2.D1)
                {
                    case 1:
                        totNumD1 += 1;
                        break;
                    case 2:
                        totNumD2 += 1;
                        break;
                    case 3:
                        totNumD3 += 1;
                        break;
                    case 4:
                        totNumD4 += 1;
                        break;
                    case 5:
                        totNumD5 += 1;
                        break;
                    case 6:
                        totNumD6 += 1;
                        break;
                }
                switch (computer2.D2)
                {
                    case 1:
                        totNumD1 += 1;
                        break;
                    case 2:
                        totNumD2 += 1;
                        break;
                    case 3:
                        totNumD3 += 1;
                        break;
                    case 4:
                        totNumD4 += 1;
                        break;
                    case 5:
                        totNumD5 += 1;
                        break;
                    case 6:
                        totNumD6 += 1;
                        break;
                }
            }
            else if(computer2.DiceCountLeft == 1)
            {
                switch (computer2.D1)
                {
                    case 1:
                        totNumD1 += 1;
                        break;
                    case 2:
                        totNumD2 += 1;
                        break;
                    case 3:
                        totNumD3 += 1;
                        break;
                    case 4:
                        totNumD4 += 1;
                        break;
                    case 5:
                        totNumD5 += 1;
                        break;
                    case 6:
                        totNumD6 += 1;
                        break;
                }
            }
            //computer3
            if (computer3.DiceCountLeft == 6)
            {
                switch (computer3.D1)
                {
                    // player one dice
                    case 1:
                        totNumD1 += 1;
                        break;
                    case 2:
                        totNumD2 += 1;
                        break;
                    case 3:
                        totNumD3 += 1;
                        break;
                    case 4:
                        totNumD4 += 1;
                        break;
                    case 5:
                        totNumD5 += 1;
                        break;
                    case 6:
                        totNumD6 += 1;
                        break;
                }
                switch (computer3.D1)
                {
                    case 1:
                        totNumD1 += 1;
                        break;
                    case 2:
                        totNumD2 += 1;
                        break;
                    case 3:
                        totNumD3 += 1;
                        break;
                    case 4:
                        totNumD4 += 1;
                        break;
                    case 5:
                        totNumD5 += 1;
                        break;
                    case 6:
                        totNumD6 += 1;
                        break;
                }
                switch (computer3.D2)
                {
                    case 1:
                        totNumD1 += 1;
                        break;
                    case 2:
                        totNumD2 += 1;
                        break;
                    case 3:
                        totNumD3 += 1;
                        break;
                    case 4:
                        totNumD4 += 1;
                        break;
                    case 5:
                        totNumD5 += 1;
                        break;
                    case 6:
                        totNumD6 += 1;
                        break;
                }
                switch (computer3.D3)
                {
                    case 1:
                        totNumD1 += 1;
                        break;
                    case 2:
                        totNumD2 += 1;
                        break;
                    case 3:
                        totNumD3 += 1;
                        break;
                    case 4:
                        totNumD4 += 1;
                        break;
                    case 5:
                        totNumD5 += 1;
                        break;
                    case 6:
                        totNumD6 += 1;
                        break;
                }
                switch (computer3.D4)
                {
                    case 1:
                        totNumD1 += 1;
                        break;
                    case 2:
                        totNumD2 += 1;
                        break;
                    case 3:
                        totNumD3 += 1;
                        break;
                    case 4:
                        totNumD4 += 1;
                        break;
                    case 5:
                        totNumD5 += 1;
                        break;
                    case 6:
                        totNumD6 += 1;
                        break;
                }
                switch (computer3.D5)
                {
                    case 1:
                        totNumD1 += 1;
                        break;
                    case 2:
                        totNumD2 += 1;
                        break;
                    case 3:
                        totNumD3 += 1;
                        break;
                    case 4:
                        totNumD4 += 1;
                        break;
                    case 5:
                        totNumD5 += 1;
                        break;
                    case 6:
                        totNumD6 += 1;
                        break;
                }
                switch (computer3.D6)
                {
                    case 1:
                        totNumD1 += 1;
                        break;
                    case 2:
                        totNumD2 += 1;
                        break;
                    case 3:
                        totNumD3 += 1;
                        break;
                    case 4:
                        totNumD4 += 1;
                        break;
                    case 5:
                        totNumD5 += 1;
                        break;
                    case 6:
                        totNumD6 += 1;
                        break;
                }
            }
            else if (computer3.DiceCountLeft == 5)
            {
                switch (computer3.D1)
                {
                    case 1:
                        totNumD1 += 1;
                        break;
                    case 2:
                        totNumD2 += 1;
                        break;
                    case 3:
                        totNumD3 += 1;
                        break;
                    case 4:
                        totNumD4 += 1;
                        break;
                    case 5:
                        totNumD5 += 1;
                        break;
                    case 6:
                        totNumD6 += 1;
                        break;
                }
                switch (computer3.D2)
                {
                    case 1:
                        totNumD1 += 1;
                        break;
                    case 2:
                        totNumD2 += 1;
                        break;
                    case 3:
                        totNumD3 += 1;
                        break;
                    case 4:
                        totNumD4 += 1;
                        break;
                    case 5:
                        totNumD5 += 1;
                        break;
                    case 6:
                        totNumD6 += 1;
                        break;
                }
                switch (computer3.D3)
                {
                    case 1:
                        totNumD1 += 1;
                        break;
                    case 2:
                        totNumD2 += 1;
                        break;
                    case 3:
                        totNumD3 += 1;
                        break;
                    case 4:
                        totNumD4 += 1;
                        break;
                    case 5:
                        totNumD5 += 1;
                        break;
                    case 6:
                        totNumD6 += 1;
                        break;
                }
                switch (computer3.D4)
                {
                    case 1:
                        totNumD1 += 1;
                        break;
                    case 2:
                        totNumD2 += 1;
                        break;
                    case 3:
                        totNumD3 += 1;
                        break;
                    case 4:
                        totNumD4 += 1;
                        break;
                    case 5:
                        totNumD5 += 1;
                        break;
                    case 6:
                        totNumD6 += 1;
                        break;
                }
                switch (computer3.D5)
                {
                    case 1:
                        totNumD1 += 1;
                        break;
                    case 2:
                        totNumD2 += 1;
                        break;
                    case 3:
                        totNumD3 += 1;
                        break;
                    case 4:
                        totNumD4 += 1;
                        break;
                    case 5:
                        totNumD5 += 1;
                        break;
                    case 6:
                        totNumD6 += 1;
                        break;
                }
            }
            else if (computer3.DiceCountLeft == 4)
            {
                switch (computer3.D1)
                {
                    case 1:
                        totNumD1 += 1;
                        break;
                    case 2:
                        totNumD2 += 1;
                        break;
                    case 3:
                        totNumD3 += 1;
                        break;
                    case 4:
                        totNumD4 += 1;
                        break;
                    case 5:
                        totNumD5 += 1;
                        break;
                    case 6:
                        totNumD6 += 1;
                        break;
                }
                switch (computer3.D2)
                {
                    case 1:
                        totNumD1 += 1;
                        break;
                    case 2:
                        totNumD2 += 1;
                        break;
                    case 3:
                        totNumD3 += 1;
                        break;
                    case 4:
                        totNumD4 += 1;
                        break;
                    case 5:
                        totNumD5 += 1;
                        break;
                    case 6:
                        totNumD6 += 1;
                        break;
                }
                switch (computer3.D3)
                {
                    case 1:
                        totNumD1 += 1;
                        break;
                    case 2:
                        totNumD2 += 1;
                        break;
                    case 3:
                        totNumD3 += 1;
                        break;
                    case 4:
                        totNumD4 += 1;
                        break;
                    case 5:
                        totNumD5 += 1;
                        break;
                    case 6:
                        totNumD6 += 1;
                        break;
                }
                switch (computer3.D4)
                {
                    case 1:
                        totNumD1 += 1;
                        break;
                    case 2:
                        totNumD2 += 1;
                        break;
                    case 3:
                        totNumD3 += 1;
                        break;
                    case 4:
                        totNumD4 += 1;
                        break;
                    case 5:
                        totNumD5 += 1;
                        break;
                    case 6:
                        totNumD6 += 1;
                        break;
                }
            }
            else if (computer3.DiceCountLeft == 3)
            {
                switch (computer3.D1)
                {
                    case 1:
                        totNumD1 += 1;
                        break;
                    case 2:
                        totNumD2 += 1;
                        break;
                    case 3:
                        totNumD3 += 1;
                        break;
                    case 4:
                        totNumD4 += 1;
                        break;
                    case 5:
                        totNumD5 += 1;
                        break;
                    case 6:
                        totNumD6 += 1;
                        break;
                }
                switch (computer3.D2)
                {
                    case 1:
                        totNumD1 += 1;
                        break;
                    case 2:
                        totNumD2 += 1;
                        break;
                    case 3:
                        totNumD3 += 1;
                        break;
                    case 4:
                        totNumD4 += 1;
                        break;
                    case 5:
                        totNumD5 += 1;
                        break;
                    case 6:
                        totNumD6 += 1;
                        break;
                }
                switch (computer3.D3)
                {
                    case 1:
                        totNumD1 += 1;
                        break;
                    case 2:
                        totNumD2 += 1;
                        break;
                    case 3:
                        totNumD3 += 1;
                        break;
                    case 4:
                        totNumD4 += 1;
                        break;
                    case 5:
                        totNumD5 += 1;
                        break;
                    case 6:
                        totNumD6 += 1;
                        break;
                }
            }
            else if (computer3.DiceCountLeft == 2)
            {
                switch (computer3.D1)
                {
                    case 1:
                        totNumD1 += 1;
                        break;
                    case 2:
                        totNumD2 += 1;
                        break;
                    case 3:
                        totNumD3 += 1;
                        break;
                    case 4:
                        totNumD4 += 1;
                        break;
                    case 5:
                        totNumD5 += 1;
                        break;
                    case 6:
                        totNumD6 += 1;
                        break;
                }
                switch (computer3.D2)
                {
                    case 1:
                        totNumD1 += 1;
                        break;
                    case 2:
                        totNumD2 += 1;
                        break;
                    case 3:
                        totNumD3 += 1;
                        break;
                    case 4:
                        totNumD4 += 1;
                        break;
                    case 5:
                        totNumD5 += 1;
                        break;
                    case 6:
                        totNumD6 += 1;
                        break;
                }
            }
            else if (computer3.DiceCountLeft == 1)
            {
                switch (computer3.D1)
                {
                    case 1:
                        totNumD1 += 1;
                        break;
                    case 2:
                        totNumD2 += 1;
                        break;
                    case 3:
                        totNumD3 += 1;
                        break;
                    case 4:
                        totNumD4 += 1;
                        break;
                    case 5:
                        totNumD5 += 1;
                        break;
                    case 6:
                        totNumD6 += 1;
                        break;
                }
            }
            //display totals
            lblDie1Count.Text = totNumD1.ToString();
            lblDie2Count.Text = totNumD2.ToString();
            lblDie3Count.Text = totNumD3.ToString();
            lblDie4Count.Text = totNumD4.ToString();
            lblDie5Count.Text = totNumD5.ToString();
            lblDie6Count.Text = totNumD6.ToString();
            return true;
        }
        
        //challenges
        private void Computer1Challenge()
        {
            //value for 1
            if(previousDiceValue == 1)
            {
                MessageBox.Show("Computer 1 challenged Player 1");
                if(previousDiceAmount <= totNumD1)
                {
                    MessageBox.Show("Computer 1 lost the challenge!");
                    if(computer1.DiceCountLeft == 6)
                    {
                    computer1.DiceCountLeft = 5;
                    computer1.D6On = false;
                    MessageBox.Show("Computer 1 has 5 dice remaining");
                    }
                    else if(computer1.DiceCountLeft == 5)
                    {
                    computer1.DiceCountLeft = 4;
                    computer1.D5On = false;
                    MessageBox.Show("Computer 1 has 4 dice remaining");
                    }
                    else if (computer1.DiceCountLeft == 4)
                    {
                    computer1.DiceCountLeft = 3;
                    computer1.D4On = false;
                    MessageBox.Show("Computer 1 has 3 dice remaining");
                    }
                    else if (computer1.DiceCountLeft == 3)
                    {
                    computer1.DiceCountLeft = 2;
                    computer1.D3On = false;
                    MessageBox.Show("Computer 1 has 2 dice remaining");
                    }
                    else if (computer1.DiceCountLeft == 2)
                    {
                    computer1.DiceCountLeft = 1;
                    computer1.D2On = false;
                    MessageBox.Show("Computer 1 has 1 die remaining");
                    }
                    else if (computer1.DiceCountLeft == 1)
                    {
                    computer1.DiceCountLeft = 0;
                    computer1.D1On = false;
                    MessageBox.Show("Computer 1 is out of dice");
                    }
                }
                else
                {
                    MessageBox.Show("Player 1 has lost the challenge!");
                    if (player1.DiceCountLeft == 6)
                    {
                    player1.DiceCountLeft = 5;
                    player1.D6On = false;
                    MessageBox.Show("Player 1 has 5 dice remaining");
                    }
                    else if (player1.DiceCountLeft == 5)
                    {
                    player1.DiceCountLeft = 4;
                    player1.D5On = false;
                    MessageBox.Show("Player 1 has 4 dice remaining");
                    }
                    else if (player1.DiceCountLeft == 4)
                    {
                    player1.DiceCountLeft = 3;
                    player1.D4On = false;
                    MessageBox.Show("Player 1 has 3 dice remaining");
                    }
                    else if (player1.DiceCountLeft == 3)
                    {
                    player1.DiceCountLeft = 2;
                    player1.D3On = false;
                    MessageBox.Show("Player 1 has 2 dice remaining");
                    }
                    else if (player1.DiceCountLeft == 2)
                    {
                    player1.DiceCountLeft = 1;
                    player1.D2On = false;
                    MessageBox.Show("Player 1 has 1 die remaining");
                    }
                    else if (player1.DiceCountLeft == 1)
                    {
                    player1.DiceCountLeft = 0;
                    player1.D1On = false;
                    MessageBox.Show("Player 1 is out of dice");
                    //remove player from game
                    }   
                }//end else
                DiceRollAll();
                previousDiceAmount = 0;
                previousDiceValue = 0;
            }//end if
            //value for 2
            else if(previousDiceValue == 2)
            {
                MessageBox.Show("Computer 1 challenged Player 1");
                if (previousDiceAmount <= totNumD2)
                {
                    MessageBox.Show("Computer 1 lost the challenge!");
                    if (computer1.DiceCountLeft == 6)
                    {
                        computer1.DiceCountLeft = 5;
                        computer1.D6On = false;
                        MessageBox.Show("Computer 1 has 5 dice remaining");
                    }
                    else if (computer1.DiceCountLeft == 5)
                    {
                        computer1.DiceCountLeft = 4;
                        computer1.D5On = false;
                        MessageBox.Show("Computer 1 has 4 dice remaining");
                    }
                    else if (computer1.DiceCountLeft == 4)
                    {
                        computer1.DiceCountLeft = 3;
                        computer1.D4On = false;
                        MessageBox.Show("Computer 1 has 3 dice remaining");
                    }
                    else if (computer1.DiceCountLeft == 3)
                    {
                        computer1.DiceCountLeft = 2;
                        computer1.D3On = false;
                        MessageBox.Show("Computer 1 has 2 dice remaining");
                    }
                    else if (computer1.DiceCountLeft == 2)
                    {
                        computer1.DiceCountLeft = 1;
                        computer1.D2On = false;
                        MessageBox.Show("Computer 1 has 1 die remaining");
                    }
                    else if (computer1.DiceCountLeft == 1)
                    {
                        computer1.DiceCountLeft = 0;
                        computer1.D1On = false;
                        MessageBox.Show("Computer 1 is out of dice");
                    }
                }
                else
                {
                    MessageBox.Show("Player 1 has lost the challenge!");
                    if (player1.DiceCountLeft == 6)
                    {
                        player1.DiceCountLeft = 5;
                        player1.D6On = false;
                        MessageBox.Show("Player 1 has 5 dice remaining");
                    }
                    else if (player1.DiceCountLeft == 5)
                    {
                        player1.DiceCountLeft = 4;
                        player1.D5On = false;
                        MessageBox.Show("Player 1 has 4 dice remaining");
                    }
                    else if (player1.DiceCountLeft == 4)
                    {
                        player1.DiceCountLeft = 3;
                        player1.D4On = false;
                        MessageBox.Show("Player 1 has 3 dice remaining");
                    }
                    else if (player1.DiceCountLeft == 3)
                    {
                        player1.DiceCountLeft = 2;
                        player1.D3On = false;
                        MessageBox.Show("Player 1 has 2 dice remaining");
                    }
                    else if (player1.DiceCountLeft == 2)
                    {
                        player1.DiceCountLeft = 1;
                        player1.D2On = false;
                        MessageBox.Show("Player 1 has 1 die remaining");
                    }
                    else if (player1.DiceCountLeft == 1)
                    {
                        player1.DiceCountLeft = 0;
                        player1.D1On = false;
                        MessageBox.Show("Player 1 is out of dice");
                        //remove player from game
                    }
                }//end else
                DiceRollAll();
                previousDiceAmount = 0;
                previousDiceValue = 0;
            }//end else if
            //value for 3
            else if(previousDiceValue == 3)
            {
                MessageBox.Show("Computer 1 challenged Player 1");
                if (previousDiceAmount <= totNumD3)
                {
                    MessageBox.Show("Computer 1 lost the challenge!");
                    if (computer1.DiceCountLeft == 6)
                    {
                        computer1.DiceCountLeft = 5;
                        computer1.D6On = false;
                        MessageBox.Show("Computer 1 has 5 dice remaining");
                    }
                    else if (computer1.DiceCountLeft == 5)
                    {
                        computer1.DiceCountLeft = 4;
                        computer1.D5On = false;
                        MessageBox.Show("Computer 1 has 4 dice remaining");
                    }
                    else if (computer1.DiceCountLeft == 4)
                    {
                        computer1.DiceCountLeft = 3;
                        computer1.D4On = false;
                        MessageBox.Show("Computer 1 has 3 dice remaining");
                    }
                    else if (computer1.DiceCountLeft == 3)
                    {
                        computer1.DiceCountLeft = 2;
                        computer1.D3On = false;
                        MessageBox.Show("Computer 1 has 2 dice remaining");
                    }
                    else if (computer1.DiceCountLeft == 2)
                    {
                        computer1.DiceCountLeft = 1;
                        computer1.D2On = false;
                        MessageBox.Show("Computer 1 has 1 die remaining");
                    }
                    else if (computer1.DiceCountLeft == 1)
                    {
                        computer1.DiceCountLeft = 0;
                        computer1.D1On = false;
                        MessageBox.Show("Computer 1 is out of dice");
                    }
                }
                else
                {
                    MessageBox.Show("Player 1 has lost the challenge!");
                    if (player1.DiceCountLeft == 6)
                    {
                        player1.DiceCountLeft = 5;
                        player1.D6On = false;
                        MessageBox.Show("Player 1 has 5 dice remaining");
                    }
                    else if (player1.DiceCountLeft == 5)
                    {
                        player1.DiceCountLeft = 4;
                        player1.D5On = false;
                        MessageBox.Show("Player 1 has 4 dice remaining");
                    }
                    else if (player1.DiceCountLeft == 4)
                    {
                        player1.DiceCountLeft = 3;
                        player1.D4On = false;
                        MessageBox.Show("Player 1 has 3 dice remaining");
                    }
                    else if (player1.DiceCountLeft == 3)
                    {
                        player1.DiceCountLeft = 2;
                        player1.D3On = false;
                        MessageBox.Show("Player 1 has 2 dice remaining");
                    }
                    else if (player1.DiceCountLeft == 2)
                    {
                        player1.DiceCountLeft = 1;
                        player1.D2On = false;
                        MessageBox.Show("Player 1 has 1 die remaining");
                    }
                    else if (player1.DiceCountLeft == 1)
                    {
                        player1.DiceCountLeft = 0;
                        player1.D1On = false;
                        MessageBox.Show("Player 1 is out of dice");
                        //remove player from game
                    }
                }//end else
                DiceRollAll();
                previousDiceAmount = 0;
                previousDiceValue = 0;
            }//end else if
            //value for 4
            else if(previousDiceValue == 4)
            {
                MessageBox.Show("Computer 1 challenged Player 1");
                if (previousDiceAmount <= totNumD4)
                {
                    MessageBox.Show("Computer 1 lost the challenge!");
                    if (computer1.DiceCountLeft == 6)
                    {
                        computer1.DiceCountLeft = 5;
                        computer1.D6On = false;
                        MessageBox.Show("Computer 1 has 5 dice remaining");
                    }
                    else if (computer1.DiceCountLeft == 5)
                    {
                        computer1.DiceCountLeft = 4;
                        computer1.D5On = false;
                        MessageBox.Show("Computer 1 has 4 dice remaining");
                    }
                    else if (computer1.DiceCountLeft == 4)
                    {
                        computer1.DiceCountLeft = 3;
                        computer1.D4On = false;
                        MessageBox.Show("Computer 1 has 3 dice remaining");
                    }
                    else if (computer1.DiceCountLeft == 3)
                    {
                        computer1.DiceCountLeft = 2;
                        computer1.D3On = false;
                        MessageBox.Show("Computer 1 has 2 dice remaining");
                    }
                    else if (computer1.DiceCountLeft == 2)
                    {
                        computer1.DiceCountLeft = 1;
                        computer1.D2On = false;
                        MessageBox.Show("Computer 1 has 1 die remaining");
                    }
                    else if (computer1.DiceCountLeft == 1)
                    {
                        computer1.DiceCountLeft = 0;
                        computer1.D1On = false;
                        MessageBox.Show("Computer 1 is out of dice");
                    }
                }
                else
                {
                    MessageBox.Show("Player 1 has lost the challenge!");
                    if (player1.DiceCountLeft == 6)
                    {
                        player1.DiceCountLeft = 5;
                        player1.D6On = false;
                        MessageBox.Show("Player 1 has 5 dice remaining");
                    }
                    else if (player1.DiceCountLeft == 5)
                    {
                        player1.DiceCountLeft = 4;
                        player1.D5On = false;
                        MessageBox.Show("Player 1 has 4 dice remaining");
                    }
                    else if (player1.DiceCountLeft == 4)
                    {
                        player1.DiceCountLeft = 3;
                        player1.D4On = false;
                        MessageBox.Show("Player 1 has 3 dice remaining");
                    }
                    else if (player1.DiceCountLeft == 3)
                    {
                        player1.DiceCountLeft = 2;
                        player1.D3On = false;
                        MessageBox.Show("Player 1 has 2 dice remaining");
                    }
                    else if (player1.DiceCountLeft == 2)
                    {
                        player1.DiceCountLeft = 1;
                        player1.D2On = false;
                        MessageBox.Show("Player 1 has 1 die remaining");
                    }
                    else if (player1.DiceCountLeft == 1)
                    {
                        player1.DiceCountLeft = 0;
                        player1.D1On = false;
                        MessageBox.Show("Player 1 is out of dice");
                        //remove player from game
                    }
                }//end else
                DiceRollAll();
                previousDiceAmount = 0;
                previousDiceValue = 0;
            }//end else if
            //value for 5
            else if(previousDiceValue == 5)
            {
                MessageBox.Show("Computer 1 challenged Player 1");
                if (previousDiceAmount <= totNumD5)
                {
                    MessageBox.Show("Computer 1 lost the challenge!");
                    if (computer1.DiceCountLeft == 6)
                    {
                        computer1.DiceCountLeft = 5;
                        computer1.D6On = false;
                        MessageBox.Show("Computer 1 has 5 dice remaining");
                    }
                    else if (computer1.DiceCountLeft == 5)
                    {
                        computer1.DiceCountLeft = 4;
                        computer1.D5On = false;
                        MessageBox.Show("Computer 1 has 4 dice remaining");
                    }
                    else if (computer1.DiceCountLeft == 4)
                    {
                        computer1.DiceCountLeft = 3;
                        computer1.D4On = false;
                        MessageBox.Show("Computer 1 has 3 dice remaining");
                    }
                    else if (computer1.DiceCountLeft == 3)
                    {
                        computer1.DiceCountLeft = 2;
                        computer1.D3On = false;
                        MessageBox.Show("Computer 1 has 2 dice remaining");
                    }
                    else if (computer1.DiceCountLeft == 2)
                    {
                        computer1.DiceCountLeft = 1;
                        computer1.D2On = false;
                        MessageBox.Show("Computer 1 has 1 die remaining");
                    }
                    else if (computer1.DiceCountLeft == 1)
                    {
                        computer1.DiceCountLeft = 0;
                        computer1.D1On = false;
                        MessageBox.Show("Computer 1 is out of dice");
                    }
                }
                else
                {
                    MessageBox.Show("Player 1 has lost the challenge!");
                    if (player1.DiceCountLeft == 6)
                    {
                        player1.DiceCountLeft = 5;
                        player1.D6On = false;
                        MessageBox.Show("Player 1 has 5 dice remaining");
                    }
                    else if (player1.DiceCountLeft == 5)
                    {
                        player1.DiceCountLeft = 4;
                        player1.D5On = false;
                        MessageBox.Show("Player 1 has 4 dice remaining");
                    }
                    else if (player1.DiceCountLeft == 4)
                    {
                        player1.DiceCountLeft = 3;
                        player1.D4On = false;
                        MessageBox.Show("Player 1 has 3 dice remaining");
                    }
                    else if (player1.DiceCountLeft == 3)
                    {
                        player1.DiceCountLeft = 2;
                        player1.D3On = false;
                        MessageBox.Show("Player 1 has 2 dice remaining");
                    }
                    else if (player1.DiceCountLeft == 2)
                    {
                        player1.DiceCountLeft = 1;
                        player1.D2On = false;
                        MessageBox.Show("Player 1 has 1 die remaining");
                    }
                    else if (player1.DiceCountLeft == 1)
                    {
                        player1.DiceCountLeft = 0;
                        player1.D1On = false;
                        MessageBox.Show("Player 1 is out of dice");
                        //remove player from game
                    }
                }//end else
                DiceRollAll();
                previousDiceAmount = 0;
                previousDiceValue = 0;
            }//end else if
            //value for 6
            else if(previousDiceValue == 6)
            {
                MessageBox.Show("Computer 1 challenged Player 1");
                if (previousDiceAmount <= totNumD6)
                {
                    MessageBox.Show("Computer 1 lost the challenge!");
                    if (computer1.DiceCountLeft == 6)
                    {
                        computer1.DiceCountLeft = 5;
                        computer1.D6On = false;
                        MessageBox.Show("Computer 1 has 5 dice remaining");
                    }
                    else if (computer1.DiceCountLeft == 5)
                    {
                        computer1.DiceCountLeft = 4;
                        computer1.D5On = false;
                        MessageBox.Show("Computer 1 has 4 dice remaining");
                    }
                    else if (computer1.DiceCountLeft == 4)
                    {
                        computer1.DiceCountLeft = 3;
                        computer1.D4On = false;
                        MessageBox.Show("Computer 1 has 3 dice remaining");
                    }
                    else if (computer1.DiceCountLeft == 3)
                    {
                        computer1.DiceCountLeft = 2;
                        computer1.D3On = false;
                        MessageBox.Show("Computer 1 has 2 dice remaining");
                    }
                    else if (computer1.DiceCountLeft == 2)
                    {
                        computer1.DiceCountLeft = 1;
                        computer1.D2On = false;
                        MessageBox.Show("Computer 1 has 1 die remaining");
                    }
                    else if (computer1.DiceCountLeft == 1)
                    {
                        computer1.DiceCountLeft = 0;
                        computer1.D1On = false;
                        MessageBox.Show("Computer 1 is out of dice");
                    }
                }
                else
                {
                    MessageBox.Show("Player 1 has lost the challenge!");
                    if (player1.DiceCountLeft == 6)
                    {
                        player1.DiceCountLeft = 5;
                        player1.D6On = false;
                        MessageBox.Show("Player 1 has 5 dice remaining");
                    }
                    else if (player1.DiceCountLeft == 5)
                    {
                        player1.DiceCountLeft = 4;
                        player1.D5On = false;
                        MessageBox.Show("Player 1 has 4 dice remaining");
                    }
                    else if (player1.DiceCountLeft == 4)
                    {
                        player1.DiceCountLeft = 3;
                        player1.D4On = false;
                        MessageBox.Show("Player 1 has 3 dice remaining");
                    }
                    else if (player1.DiceCountLeft == 3)
                    {
                        player1.DiceCountLeft = 2;
                        player1.D3On = false;
                        MessageBox.Show("Player 1 has 2 dice remaining");
                    }
                    else if (player1.DiceCountLeft == 2)
                    {
                        player1.DiceCountLeft = 1;
                        player1.D2On = false;
                        MessageBox.Show("Player 1 has 1 die remaining");
                    }
                    else if (player1.DiceCountLeft == 1)
                    {
                        player1.DiceCountLeft = 0;
                        player1.D1On = false;
                        MessageBox.Show("Player 1 is out of dice");
                        //remove player from game
                    }
                }//end else
                DiceRollAll();
                previousDiceAmount = 0;
                previousDiceValue = 0;
            }//end else if
        }
        private void Computer2Challenge()
        {
            //value for 1
            if (previousDiceValue == 1)
            {
                MessageBox.Show("Computer 2 challenged Computer 1");
                if (previousDiceAmount <= totNumD1)
                {
                    MessageBox.Show("Computer 2 lost the challenge!");
                    if (computer2.DiceCountLeft == 6)
                    {
                        computer2.DiceCountLeft = 5;
                        computer2.D6On = false;
                        MessageBox.Show("Computer 2 has 5 dice remaining");
                    }
                    else if (computer2.DiceCountLeft == 5)
                    {
                        computer2.DiceCountLeft = 4;
                        computer2.D5On = false;
                        MessageBox.Show("Computer 2 has 4 dice remaining");
                    }
                    else if (computer2.DiceCountLeft == 4)
                    {
                        computer2.DiceCountLeft = 3;
                        computer2.D4On = false;
                        MessageBox.Show("Computer 2 has 3 dice remaining");
                    }
                    else if (computer2.DiceCountLeft == 3)
                    {
                        computer2.DiceCountLeft = 2;
                        computer2.D3On = false;
                        MessageBox.Show("Computer 2 has 2 dice remaining");
                    }
                    else if (computer2.DiceCountLeft == 2)
                    {
                        computer2.DiceCountLeft = 1;
                        computer2.D2On = false;
                        MessageBox.Show("Computer 2 has 1 die remaining");
                    }
                    else if (computer2.DiceCountLeft == 1)
                    {
                        computer2.DiceCountLeft = 0;
                        computer2.D1On = false;
                        MessageBox.Show("Computer 2 is out of dice");
                    }
                }
                else
                {
                    MessageBox.Show("Computer 1 has lost the challenge!");
                    if (computer1.DiceCountLeft == 6)
                    {
                        computer1.DiceCountLeft = 5;
                        computer1.D6On = false;
                        MessageBox.Show("Computer 1 has 5 dice remaining");
                    }
                    else if (player1.DiceCountLeft == 5)
                    {
                        computer1.DiceCountLeft = 4;
                        computer1.D5On = false;
                        MessageBox.Show("Computer 1 has 4 dice remaining");
                    }
                    else if (computer1.DiceCountLeft == 4)
                    {
                        computer1.DiceCountLeft = 3;
                        computer1.D4On = false;
                        MessageBox.Show("Computer 1 has 3 dice remaining");
                    }
                    else if (computer1.DiceCountLeft == 3)
                    {
                        computer1.DiceCountLeft = 2;
                        computer1.D3On = false;
                        MessageBox.Show("Computer 1 has 2 dice remaining");
                    }
                    else if (computer1.DiceCountLeft == 2)
                    {
                        computer1.DiceCountLeft = 1;
                        computer1.D2On = false;
                        MessageBox.Show("Computer 1 has 1 die remaining");
                    }
                    else if (computer1.DiceCountLeft == 1)
                    {
                        computer1.DiceCountLeft = 0;
                        computer1.D1On = false;
                        MessageBox.Show("Computer 1 is out of dice");
                        //remove player from game
                    }
                }
                DiceRollAll();
                previousDiceAmount = 0;
                previousDiceValue = 0;
            }//end if
            //value for 2
            else if (previousDiceValue == 2)
            {
                MessageBox.Show("Computer 2 challenged Computer 1");
                if (previousDiceAmount <= totNumD2)
                {
                    MessageBox.Show("Computer 2 lost the challenge!");
                    if (computer2.DiceCountLeft == 6)
                    {
                        computer2.DiceCountLeft = 5;
                        computer2.D6On = false;
                        MessageBox.Show("Computer 2 has 5 dice remaining");
                    }
                    else if (computer2.DiceCountLeft == 5)
                    {
                        computer2.DiceCountLeft = 4;
                        computer2.D5On = false;
                        MessageBox.Show("Computer 2 has 4 dice remaining");
                    }
                    else if (computer2.DiceCountLeft == 4)
                    {
                        computer2.DiceCountLeft = 3;
                        computer2.D4On = false;
                        MessageBox.Show("Computer 2 has 3 dice remaining");
                    }
                    else if (computer2.DiceCountLeft == 3)
                    {
                        computer2.DiceCountLeft = 2;
                        computer2.D3On = false;
                        MessageBox.Show("Computer 2 has 2 dice remaining");
                    }
                    else if (computer2.DiceCountLeft == 2)
                    {
                        computer2.DiceCountLeft = 1;
                        computer2.D2On = false;
                        MessageBox.Show("Computer 2 has 1 die remaining");
                    }
                    else if (computer2.DiceCountLeft == 1)
                    {
                        computer2.DiceCountLeft = 0;
                        computer2.D1On = false;
                        MessageBox.Show("Computer 2 is out of dice");
                    }
                }
                else
                {
                    MessageBox.Show("Computer 1 has lost the challenge!");
                    if (computer1.DiceCountLeft == 6)
                    {
                        computer1.DiceCountLeft = 5;
                        computer1.D6On = false;
                        MessageBox.Show("Computer 1 has 5 dice remaining");
                    }
                    else if (player1.DiceCountLeft == 5)
                    {
                        computer1.DiceCountLeft = 4;
                        computer1.D5On = false;
                        MessageBox.Show("Computer 1 has 4 dice remaining");
                    }
                    else if (computer1.DiceCountLeft == 4)
                    {
                        computer1.DiceCountLeft = 3;
                        computer1.D4On = false;
                        MessageBox.Show("Computer 1 has 3 dice remaining");
                    }
                    else if (computer1.DiceCountLeft == 3)
                    {
                        computer1.DiceCountLeft = 2;
                        computer1.D3On = false;
                        MessageBox.Show("Computer 1 has 2 dice remaining");
                    }
                    else if (computer1.DiceCountLeft == 2)
                    {
                        computer1.DiceCountLeft = 1;
                        computer1.D2On = false;
                        MessageBox.Show("Computer 1 has 1 die remaining");
                    }
                    else if (computer1.DiceCountLeft == 1)
                    {
                        computer1.DiceCountLeft = 0;
                        computer1.D1On = false;
                        MessageBox.Show("Computer 1 is out of dice");
                        //remove player from game
                    }
                }
                DiceRollAll();
                previousDiceAmount = 0;
                previousDiceValue = 0;
            }//end else if
            //value for 3
            else if (previousDiceValue == 3)
            {
                MessageBox.Show("Computer 2 challenged Computer 1");
                if (previousDiceAmount <= totNumD3)
                {
                    MessageBox.Show("Computer 2 lost the challenge!");
                    if (computer2.DiceCountLeft == 6)
                    {
                        computer2.DiceCountLeft = 5;
                        computer2.D6On = false;
                        MessageBox.Show("Computer 2 has 5 dice remaining");
                    }
                    else if (computer2.DiceCountLeft == 5)
                    {
                        computer2.DiceCountLeft = 4;
                        computer2.D5On = false;
                        MessageBox.Show("Computer 2 has 4 dice remaining");
                    }
                    else if (computer2.DiceCountLeft == 4)
                    {
                        computer2.DiceCountLeft = 3;
                        computer2.D4On = false;
                        MessageBox.Show("Computer 2 has 3 dice remaining");
                    }
                    else if (computer2.DiceCountLeft == 3)
                    {
                        computer2.DiceCountLeft = 2;
                        computer2.D3On = false;
                        MessageBox.Show("Computer 2 has 2 dice remaining");
                    }
                    else if (computer2.DiceCountLeft == 2)
                    {
                        computer2.DiceCountLeft = 1;
                        computer2.D2On = false;
                        MessageBox.Show("Computer 2 has 1 die remaining");
                    }
                    else if (computer2.DiceCountLeft == 1)
                    {
                        computer2.DiceCountLeft = 0;
                        computer2.D1On = false;
                        MessageBox.Show("Computer 2 is out of dice");
                    }
                }
                else
                {
                    MessageBox.Show("Computer 1 has lost the challenge!");
                    if (computer1.DiceCountLeft == 6)
                    {
                        computer1.DiceCountLeft = 5;
                        computer1.D6On = false;
                        MessageBox.Show("Computer 1 has 5 dice remaining");
                    }
                    else if (player1.DiceCountLeft == 5)
                    {
                        computer1.DiceCountLeft = 4;
                        computer1.D5On = false;
                        MessageBox.Show("Computer 1 has 4 dice remaining");
                    }
                    else if (computer1.DiceCountLeft == 4)
                    {
                        computer1.DiceCountLeft = 3;
                        computer1.D4On = false;
                        MessageBox.Show("Computer 1 has 3 dice remaining");
                    }
                    else if (computer1.DiceCountLeft == 3)
                    {
                        computer1.DiceCountLeft = 2;
                        computer1.D3On = false;
                        MessageBox.Show("Computer 1 has 2 dice remaining");
                    }
                    else if (computer1.DiceCountLeft == 2)
                    {
                        computer1.DiceCountLeft = 1;
                        computer1.D2On = false;
                        MessageBox.Show("Computer 1 has 1 die remaining");
                    }
                    else if (computer1.DiceCountLeft == 1)
                    {
                        computer1.DiceCountLeft = 0;
                        computer1.D1On = false;
                        MessageBox.Show("Computer 1 is out of dice");
                        //remove player from game
                    }
                }
                DiceRollAll();
                previousDiceAmount = 0;
                previousDiceValue = 0;
            }//end else if
            //value for 4
            else if(previousDiceValue == 4)
            {
                MessageBox.Show("Computer 2 challenged Computer 1");
                if (previousDiceAmount <= totNumD4)
                {
                    MessageBox.Show("Computer 2 lost the challenge!");
                    if (computer2.DiceCountLeft == 6)
                    {
                        computer2.DiceCountLeft = 5;
                        computer2.D6On = false;
                        MessageBox.Show("Computer 2 has 5 dice remaining");
                    }
                    else if (computer2.DiceCountLeft == 5)
                    {
                        computer2.DiceCountLeft = 4;
                        computer2.D5On = false;
                        MessageBox.Show("Computer 2 has 4 dice remaining");
                    }
                    else if (computer2.DiceCountLeft == 4)
                    {
                        computer2.DiceCountLeft = 3;
                        computer2.D4On = false;
                        MessageBox.Show("Computer 2 has 3 dice remaining");
                    }
                    else if (computer2.DiceCountLeft == 3)
                    {
                        computer2.DiceCountLeft = 2;
                        computer2.D3On = false;
                        MessageBox.Show("Computer 2 has 2 dice remaining");
                    }
                    else if (computer2.DiceCountLeft == 2)
                    {
                        computer2.DiceCountLeft = 1;
                        computer2.D2On = false;
                        MessageBox.Show("Computer 2 has 1 die remaining");
                    }
                    else if (computer2.DiceCountLeft == 1)
                    {
                        computer2.DiceCountLeft = 0;
                        computer2.D1On = false;
                        MessageBox.Show("Computer 2 is out of dice");
                    }
                }
                else
                {
                    MessageBox.Show("Computer 1 has lost the challenge!");
                    if (computer1.DiceCountLeft == 6)
                    {
                        computer1.DiceCountLeft = 5;
                        computer1.D6On = false;
                        MessageBox.Show("Computer 1 has 5 dice remaining");
                    }
                    else if (player1.DiceCountLeft == 5)
                    {
                        computer1.DiceCountLeft = 4;
                        computer1.D5On = false;
                        MessageBox.Show("Computer 1 has 4 dice remaining");
                    }
                    else if (computer1.DiceCountLeft == 4)
                    {
                        computer1.DiceCountLeft = 3;
                        computer1.D4On = false;
                        MessageBox.Show("Computer 1 has 3 dice remaining");
                    }
                    else if (computer1.DiceCountLeft == 3)
                    {
                        computer1.DiceCountLeft = 2;
                        computer1.D3On = false;
                        MessageBox.Show("Computer 1 has 2 dice remaining");
                    }
                    else if (computer1.DiceCountLeft == 2)
                    {
                        computer1.DiceCountLeft = 1;
                        computer1.D2On = false;
                        MessageBox.Show("Computer 1 has 1 die remaining");
                    }
                    else if (computer1.DiceCountLeft == 1)
                    {
                        computer1.DiceCountLeft = 0;
                        computer1.D1On = false;
                        MessageBox.Show("Computer 1 is out of dice");
                        //remove player from game
                    }
                }
                DiceRollAll();
                previousDiceAmount = 0;
                previousDiceValue = 0;
            }//end else if
            //value for 5
            else if(previousDiceValue == 5)
            {
                MessageBox.Show("Computer 2 challenged Computer 1");
                if (previousDiceAmount <= totNumD5)
                {
                    MessageBox.Show("Computer 2 lost the challenge!");
                    if (computer2.DiceCountLeft == 6)
                    {
                        computer2.DiceCountLeft = 5;
                        computer2.D6On = false;
                        MessageBox.Show("Computer 2 has 5 dice remaining");
                    }
                    else if (computer2.DiceCountLeft == 5)
                    {
                        computer2.DiceCountLeft = 4;
                        computer2.D5On = false;
                        MessageBox.Show("Computer 2 has 4 dice remaining");
                    }
                    else if (computer2.DiceCountLeft == 4)
                    {
                        computer2.DiceCountLeft = 3;
                        computer2.D4On = false;
                        MessageBox.Show("Computer 2 has 3 dice remaining");
                    }
                    else if (computer2.DiceCountLeft == 3)
                    {
                        computer2.DiceCountLeft = 2;
                        computer2.D3On = false;
                        MessageBox.Show("Computer 2 has 2 dice remaining");
                    }
                    else if (computer2.DiceCountLeft == 2)
                    {
                        computer2.DiceCountLeft = 1;
                        computer2.D2On = false;
                        MessageBox.Show("Computer 2 has 1 die remaining");
                    }
                    else if (computer2.DiceCountLeft == 1)
                    {
                        computer2.DiceCountLeft = 0;
                        computer2.D1On = false;
                        MessageBox.Show("Computer 2 is out of dice");
                    }
                }
                else
                {
                    MessageBox.Show("Computer 1 has lost the challenge!");
                    if (computer1.DiceCountLeft == 6)
                    {
                        computer1.DiceCountLeft = 5;
                        computer1.D6On = false;
                        MessageBox.Show("Computer 1 has 5 dice remaining");
                    }
                    else if (player1.DiceCountLeft == 5)
                    {
                        computer1.DiceCountLeft = 4;
                        computer1.D5On = false;
                        MessageBox.Show("Computer 1 has 4 dice remaining");
                    }
                    else if (computer1.DiceCountLeft == 4)
                    {
                        computer1.DiceCountLeft = 3;
                        computer1.D4On = false;
                        MessageBox.Show("Computer 1 has 3 dice remaining");
                    }
                    else if (computer1.DiceCountLeft == 3)
                    {
                        computer1.DiceCountLeft = 2;
                        computer1.D3On = false;
                        MessageBox.Show("Computer 1 has 2 dice remaining");
                    }
                    else if (computer1.DiceCountLeft == 2)
                    {
                        computer1.DiceCountLeft = 1;
                        computer1.D2On = false;
                        MessageBox.Show("Computer 1 has 1 die remaining");
                    }
                    else if (computer1.DiceCountLeft == 1)
                    {
                        computer1.DiceCountLeft = 0;
                        computer1.D1On = false;
                        MessageBox.Show("Computer 1 is out of dice");
                        //remove player from game
                    }
                }
                DiceRollAll();
                previousDiceAmount = 0;
                previousDiceValue = 0;
            }//end else if
            //value for 6
            else if(previousDiceValue == 6)
            {
                MessageBox.Show("Computer 2 challenged Computer 1");
                if (previousDiceAmount <= totNumD6)
                {
                    MessageBox.Show("Computer 2 lost the challenge!");
                    if (computer2.DiceCountLeft == 6)
                    {
                        computer2.DiceCountLeft = 5;
                        computer2.D6On = false;
                        MessageBox.Show("Computer 2 has 5 dice remaining");
                    }
                    else if (computer2.DiceCountLeft == 5)
                    {
                        computer2.DiceCountLeft = 4;
                        computer2.D5On = false;
                        MessageBox.Show("Computer 2 has 4 dice remaining");
                    }
                    else if (computer2.DiceCountLeft == 4)
                    {
                        computer2.DiceCountLeft = 3;
                        computer2.D4On = false;
                        MessageBox.Show("Computer 2 has 3 dice remaining");
                    }
                    else if (computer2.DiceCountLeft == 3)
                    {
                        computer2.DiceCountLeft = 2;
                        computer2.D3On = false;
                        MessageBox.Show("Computer 2 has 2 dice remaining");
                    }
                    else if (computer2.DiceCountLeft == 2)
                    {
                        computer2.DiceCountLeft = 1;
                        computer2.D2On = false;
                        MessageBox.Show("Computer 2 has 1 die remaining");
                    }
                    else if (computer2.DiceCountLeft == 1)
                    {
                        computer2.DiceCountLeft = 0;
                        computer2.D1On = false;
                        MessageBox.Show("Computer 2 is out of dice");
                    }
                }
                else
                {
                    MessageBox.Show("Computer 1 has lost the challenge!");
                    if (computer1.DiceCountLeft == 6)
                    {
                        computer1.DiceCountLeft = 5;
                        computer1.D6On = false;
                        MessageBox.Show("Computer 1 has 5 dice remaining");
                    }
                    else if (player1.DiceCountLeft == 5)
                    {
                        computer1.DiceCountLeft = 4;
                        computer1.D5On = false;
                        MessageBox.Show("Computer 1 has 4 dice remaining");
                    }
                    else if (computer1.DiceCountLeft == 4)
                    {
                        computer1.DiceCountLeft = 3;
                        computer1.D4On = false;
                        MessageBox.Show("Computer 1 has 3 dice remaining");
                    }
                    else if (computer1.DiceCountLeft == 3)
                    {
                        computer1.DiceCountLeft = 2;
                        computer1.D3On = false;
                        MessageBox.Show("Computer 1 has 2 dice remaining");
                    }
                    else if (computer1.DiceCountLeft == 2)
                    {
                        computer1.DiceCountLeft = 1;
                        computer1.D2On = false;
                        MessageBox.Show("Computer 1 has 1 die remaining");
                    }
                    else if (computer1.DiceCountLeft == 1)
                    {
                        computer1.DiceCountLeft = 0;
                        computer1.D1On = false;
                        MessageBox.Show("Computer 1 is out of dice");
                        //remove player from game
                    }
                }
                DiceRollAll();
                previousDiceAmount = 0;
                previousDiceValue = 0;
            }//end else if

        }
        private void Computer3Challenge()
        {
            //value for 1
            if(previousDiceValue == 1)
            {
                MessageBox.Show("Computer 3 challenged Computer 2");
                if (previousDiceAmount <= totNumD1)
                {
                    MessageBox.Show("Computer 3 lost the challenge!");
                    if (computer3.DiceCountLeft == 6)
                    {
                        computer3.DiceCountLeft = 5;
                        computer3.D6On = false;
                        MessageBox.Show("Computer 3 has 5 dice remaining");
                    }
                    else if (computer3.DiceCountLeft == 5)
                    {
                        computer3.DiceCountLeft = 4;
                        computer3.D5On = false;
                        MessageBox.Show("Computer 3 has 4 dice remaining");
                    }
                    else if (computer3.DiceCountLeft == 4)
                    {
                        computer3.DiceCountLeft = 3;
                        computer3.D4On = false;
                        MessageBox.Show("Computer 3 has 3 dice remaining");
                    }
                    else if (computer3.DiceCountLeft == 3)
                    {
                        computer3.DiceCountLeft = 2;
                        computer3.D3On = false;
                        MessageBox.Show("Computer 3 has 2 dice remaining");
                    }
                    else if (computer3.DiceCountLeft == 2)
                    {
                        computer3.DiceCountLeft = 1;
                        computer3.D2On = false;
                        MessageBox.Show("Computer 3 has 1 die remaining");
                    }
                    else if (computer3.DiceCountLeft == 1)
                    {
                        computer3.DiceCountLeft = 0;
                        computer3.D1On = false;
                        MessageBox.Show("Computer 3 is out of dice");
                    }
                }
                else
                {
                    MessageBox.Show("Computer 2 has lost the challenge!");
                    if (computer2.DiceCountLeft == 6)
                    {
                        computer2.DiceCountLeft = 5;
                        computer2.D6On = false;
                        MessageBox.Show("Computer 2 has 5 dice remaining");
                    }
                    else if (computer2.DiceCountLeft == 5)
                    {
                        computer2.DiceCountLeft = 4;
                        computer2.D5On = false;
                        MessageBox.Show("Computer 2 has 4 dice remaining");
                    }
                    else if (computer2.DiceCountLeft == 4)
                    {
                        computer2.DiceCountLeft = 3;
                        computer2.D4On = false;
                        MessageBox.Show("Computer 2 has 3 dice remaining");
                    }
                    else if (computer2.DiceCountLeft == 3)
                    {
                        computer2.DiceCountLeft = 2;
                        computer2.D3On = false;
                        MessageBox.Show("Computer 2 has 2 dice remaining");
                    }
                    else if (computer2.DiceCountLeft == 2)
                    {
                        computer2.DiceCountLeft = 1;
                        computer2.D2On = false;
                        MessageBox.Show("Computer 2 has 1 die remaining");
                    }
                    else if (computer2.DiceCountLeft == 1)
                    {
                        computer2.DiceCountLeft = 0;
                        computer2.D1On = false;
                        MessageBox.Show("Computer 2 is out of dice");
                        //remove player from game
                    }
                }
                DiceRollAll();
                previousDiceAmount = 0;
                previousDiceValue = 0;
            }//end if
            //value for 2
            else if(previousDiceValue == 2)
            {
                MessageBox.Show("Computer 3 challenged Computer 2");
                if (previousDiceAmount <= totNumD2)
                {
                    MessageBox.Show("Computer 3 lost the challenge!");
                    if (computer3.DiceCountLeft == 6)
                    {
                        computer3.DiceCountLeft = 5;
                        computer3.D6On = false;
                        MessageBox.Show("Computer 3 has 5 dice remaining");
                    }
                    else if (computer3.DiceCountLeft == 5)
                    {
                        computer3.DiceCountLeft = 4;
                        computer3.D5On = false;
                        MessageBox.Show("Computer 3 has 4 dice remaining");
                    }
                    else if (computer3.DiceCountLeft == 4)
                    {
                        computer3.DiceCountLeft = 3;
                        computer3.D4On = false;
                        MessageBox.Show("Computer 3 has 3 dice remaining");
                    }
                    else if (computer3.DiceCountLeft == 3)
                    {
                        computer3.DiceCountLeft = 2;
                        computer3.D3On = false;
                        MessageBox.Show("Computer 3 has 2 dice remaining");
                    }
                    else if (computer3.DiceCountLeft == 2)
                    {
                        computer3.DiceCountLeft = 1;
                        computer3.D2On = false;
                        MessageBox.Show("Computer 3 has 1 die remaining");
                    }
                    else if (computer3.DiceCountLeft == 1)
                    {
                        computer3.DiceCountLeft = 0;
                        computer3.D1On = false;
                        MessageBox.Show("Computer 3 is out of dice");
                    }
                }
                else
                {
                    MessageBox.Show("Computer 2 has lost the challenge!");
                    if (computer2.DiceCountLeft == 6)
                    {
                        computer2.DiceCountLeft = 5;
                        computer2.D6On = false;
                        MessageBox.Show("Computer 2 has 5 dice remaining");
                    }
                    else if (computer2.DiceCountLeft == 5)
                    {
                        computer2.DiceCountLeft = 4;
                        computer2.D5On = false;
                        MessageBox.Show("Computer 2 has 4 dice remaining");
                    }
                    else if (computer2.DiceCountLeft == 4)
                    {
                        computer2.DiceCountLeft = 3;
                        computer2.D4On = false;
                        MessageBox.Show("Computer 2 has 3 dice remaining");
                    }
                    else if (computer2.DiceCountLeft == 3)
                    {
                        computer2.DiceCountLeft = 2;
                        computer2.D3On = false;
                        MessageBox.Show("Computer 2 has 2 dice remaining");
                    }
                    else if (computer2.DiceCountLeft == 2)
                    {
                        computer2.DiceCountLeft = 1;
                        computer2.D2On = false;
                        MessageBox.Show("Computer 2 has 1 die remaining");
                    }
                    else if (computer2.DiceCountLeft == 1)
                    {
                        computer2.DiceCountLeft = 0;
                        computer2.D1On = false;
                        MessageBox.Show("Computer 2 is out of dice");
                        //remove player from game
                    }
                }
                DiceRollAll();
                previousDiceAmount = 0;
            }//end else if
            //value for 3
            else if(previousDiceValue == 3)
            {
                MessageBox.Show("Computer 3 challenged Computer 2");
                if (previousDiceAmount <= totNumD3)
                {
                    MessageBox.Show("Computer 3 lost the challenge!");
                    if (computer3.DiceCountLeft == 6)
                    {
                        computer3.DiceCountLeft = 5;
                        computer3.D6On = false;
                        MessageBox.Show("Computer 3 has 5 dice remaining");
                    }
                    else if (computer3.DiceCountLeft == 5)
                    {
                        computer3.DiceCountLeft = 4;
                        computer3.D5On = false;
                        MessageBox.Show("Computer 3 has 4 dice remaining");
                    }
                    else if (computer3.DiceCountLeft == 4)
                    {
                        computer3.DiceCountLeft = 3;
                        computer3.D4On = false;
                        MessageBox.Show("Computer 3 has 3 dice remaining");
                    }
                    else if (computer3.DiceCountLeft == 3)
                    {
                        computer3.DiceCountLeft = 2;
                        computer3.D3On = false;
                        MessageBox.Show("Computer 3 has 2 dice remaining");
                    }
                    else if (computer3.DiceCountLeft == 2)
                    {
                        computer3.DiceCountLeft = 1;
                        computer3.D2On = false;
                        MessageBox.Show("Computer 3 has 1 die remaining");
                    }
                    else if (computer3.DiceCountLeft == 1)
                    {
                        computer3.DiceCountLeft = 0;
                        computer3.D1On = false;
                        MessageBox.Show("Computer 3 is out of dice");
                    }
                }
                else
                {
                    MessageBox.Show("Computer 2 has lost the challenge!");
                    if (computer2.DiceCountLeft == 6)
                    {
                        computer2.DiceCountLeft = 5;
                        computer2.D6On = false;
                        MessageBox.Show("Computer 2 has 5 dice remaining");
                    }
                    else if (computer2.DiceCountLeft == 5)
                    {
                        computer2.DiceCountLeft = 4;
                        computer2.D5On = false;
                        MessageBox.Show("Computer 2 has 4 dice remaining");
                    }
                    else if (computer2.DiceCountLeft == 4)
                    {
                        computer2.DiceCountLeft = 3;
                        computer2.D4On = false;
                        MessageBox.Show("Computer 2 has 3 dice remaining");
                    }
                    else if (computer2.DiceCountLeft == 3)
                    {
                        computer2.DiceCountLeft = 2;
                        computer2.D3On = false;
                        MessageBox.Show("Computer 2 has 2 dice remaining");
                    }
                    else if (computer2.DiceCountLeft == 2)
                    {
                        computer2.DiceCountLeft = 1;
                        computer2.D2On = false;
                        MessageBox.Show("Computer 2 has 1 die remaining");
                    }
                    else if (computer2.DiceCountLeft == 1)
                    {
                        computer2.DiceCountLeft = 0;
                        computer2.D1On = false;
                        MessageBox.Show("Computer 2 is out of dice");
                        //remove player from game
                    }
                }
                DiceRollAll();
                previousDiceAmount = 0;
            }//end else if
            //value for 4
            else if(previousDiceValue == 4)
            {
                MessageBox.Show("Computer 3 challenged Computer 2");
                if (previousDiceAmount <= totNumD4)
                {
                    MessageBox.Show("Computer 3 lost the challenge!");
                    if (computer3.DiceCountLeft == 6)
                    {
                        computer3.DiceCountLeft = 5;
                        computer3.D6On = false;
                        MessageBox.Show("Computer 3 has 5 dice remaining");
                    }
                    else if (computer3.DiceCountLeft == 5)
                    {
                        computer3.DiceCountLeft = 4;
                        computer3.D5On = false;
                        MessageBox.Show("Computer 3 has 4 dice remaining");
                    }
                    else if (computer3.DiceCountLeft == 4)
                    {
                        computer3.DiceCountLeft = 3;
                        computer3.D4On = false;
                        MessageBox.Show("Computer 3 has 3 dice remaining");
                    }
                    else if (computer3.DiceCountLeft == 3)
                    {
                        computer3.DiceCountLeft = 2;
                        computer3.D3On = false;
                        MessageBox.Show("Computer 3 has 2 dice remaining");
                    }
                    else if (computer3.DiceCountLeft == 2)
                    {
                        computer3.DiceCountLeft = 1;
                        computer3.D2On = false;
                        MessageBox.Show("Computer 3 has 1 die remaining");
                    }
                    else if (computer3.DiceCountLeft == 1)
                    {
                        computer3.DiceCountLeft = 0;
                        computer3.D1On = false;
                        MessageBox.Show("Computer 3 is out of dice");
                    }
                }
                else
                {
                    MessageBox.Show("Computer 2 has lost the challenge!");
                    if (computer2.DiceCountLeft == 6)
                    {
                        computer2.DiceCountLeft = 5;
                        computer2.D6On = false;
                        MessageBox.Show("Computer 2 has 5 dice remaining");
                    }
                    else if (computer2.DiceCountLeft == 5)
                    {
                        computer2.DiceCountLeft = 4;
                        computer2.D5On = false;
                        MessageBox.Show("Computer 2 has 4 dice remaining");
                    }
                    else if (computer2.DiceCountLeft == 4)
                    {
                        computer2.DiceCountLeft = 3;
                        computer2.D4On = false;
                        MessageBox.Show("Computer 2 has 3 dice remaining");
                    }
                    else if (computer2.DiceCountLeft == 3)
                    {
                        computer2.DiceCountLeft = 2;
                        computer2.D3On = false;
                        MessageBox.Show("Computer 2 has 2 dice remaining");
                    }
                    else if (computer2.DiceCountLeft == 2)
                    {
                        computer2.DiceCountLeft = 1;
                        computer2.D2On = false;
                        MessageBox.Show("Computer 2 has 1 die remaining");
                    }
                    else if (computer2.DiceCountLeft == 1)
                    {
                        computer2.DiceCountLeft = 0;
                        computer2.D1On = false;
                        MessageBox.Show("Computer 2 is out of dice");
                        //remove player from game
                    }
                }
                DiceRollAll();
                previousDiceAmount = 0;
            }//end else if
            //value for 5
            else if(previousDiceValue == 5)
            {
                MessageBox.Show("Computer 3 challenged Computer 2");
                if (previousDiceAmount <= totNumD5)
                {
                    MessageBox.Show("Computer 3 lost the challenge!");
                    if (computer3.DiceCountLeft == 6)
                    {
                        computer3.DiceCountLeft = 5;
                        computer3.D6On = false;
                        MessageBox.Show("Computer 3 has 5 dice remaining");
                    }
                    else if (computer3.DiceCountLeft == 5)
                    {
                        computer3.DiceCountLeft = 4;
                        computer3.D5On = false;
                        MessageBox.Show("Computer 3 has 4 dice remaining");
                    }
                    else if (computer3.DiceCountLeft == 4)
                    {
                        computer3.DiceCountLeft = 3;
                        computer3.D4On = false;
                        MessageBox.Show("Computer 3 has 3 dice remaining");
                    }
                    else if (computer3.DiceCountLeft == 3)
                    {
                        computer3.DiceCountLeft = 2;
                        computer3.D3On = false;
                        MessageBox.Show("Computer 3 has 2 dice remaining");
                    }
                    else if (computer3.DiceCountLeft == 2)
                    {
                        computer3.DiceCountLeft = 1;
                        computer3.D2On = false;
                        MessageBox.Show("Computer 3 has 1 die remaining");
                    }
                    else if (computer3.DiceCountLeft == 1)
                    {
                        computer3.DiceCountLeft = 0;
                        computer3.D1On = false;
                        MessageBox.Show("Computer 3 is out of dice");
                    }
                }
                else
                {
                    MessageBox.Show("Computer 2 has lost the challenge!");
                    if (computer2.DiceCountLeft == 6)
                    {
                        computer2.DiceCountLeft = 5;
                        computer2.D6On = false;
                        MessageBox.Show("Computer 2 has 5 dice remaining");
                    }
                    else if (computer2.DiceCountLeft == 5)
                    {
                        computer2.DiceCountLeft = 4;
                        computer2.D5On = false;
                        MessageBox.Show("Computer 2 has 4 dice remaining");
                    }
                    else if (computer2.DiceCountLeft == 4)
                    {
                        computer2.DiceCountLeft = 3;
                        computer2.D4On = false;
                        MessageBox.Show("Computer 2 has 3 dice remaining");
                    }
                    else if (computer2.DiceCountLeft == 3)
                    {
                        computer2.DiceCountLeft = 2;
                        computer2.D3On = false;
                        MessageBox.Show("Computer 2 has 2 dice remaining");
                    }
                    else if (computer2.DiceCountLeft == 2)
                    {
                        computer2.DiceCountLeft = 1;
                        computer2.D2On = false;
                        MessageBox.Show("Computer 2 has 1 die remaining");
                    }
                    else if (computer2.DiceCountLeft == 1)
                    {
                        computer2.DiceCountLeft = 0;
                        computer2.D1On = false;
                        MessageBox.Show("Computer 2 is out of dice");
                        //remove player from game
                    }
                }
                DiceRollAll();
                previousDiceAmount = 0;
            }//end else if
            //value for 6
            else if(previousDiceValue == 6)
            {
                MessageBox.Show("Computer 3 challenged Computer 2");
                if (previousDiceAmount <= totNumD6)
                {
                    MessageBox.Show("Computer 3 lost the challenge!");
                    if (computer3.DiceCountLeft == 6)
                    {
                        computer3.DiceCountLeft = 5;
                        computer3.D6On = false;
                        MessageBox.Show("Computer 3 has 5 dice remaining");
                    }
                    else if (computer3.DiceCountLeft == 5)
                    {
                        computer3.DiceCountLeft = 4;
                        computer3.D5On = false;
                        MessageBox.Show("Computer 3 has 4 dice remaining");
                    }
                    else if (computer3.DiceCountLeft == 4)
                    {
                        computer3.DiceCountLeft = 3;
                        computer3.D4On = false;
                        MessageBox.Show("Computer 3 has 3 dice remaining");
                    }
                    else if (computer3.DiceCountLeft == 3)
                    {
                        computer3.DiceCountLeft = 2;
                        computer3.D3On = false;
                        MessageBox.Show("Computer 3 has 2 dice remaining");
                    }
                    else if (computer3.DiceCountLeft == 2)
                    {
                        computer3.DiceCountLeft = 1;
                        computer3.D2On = false;
                        MessageBox.Show("Computer 3 has 1 die remaining");
                    }
                    else if (computer3.DiceCountLeft == 1)
                    {
                        computer3.DiceCountLeft = 0;
                        computer3.D1On = false;
                        MessageBox.Show("Computer 3 is out of dice");
                    }
                }
                else
                {
                    MessageBox.Show("Computer 2 has lost the challenge!");
                    if (computer2.DiceCountLeft == 6)
                    {
                        computer2.DiceCountLeft = 5;
                        computer2.D6On = false;
                        MessageBox.Show("Computer 2 has 5 dice remaining");
                    }
                    else if (computer2.DiceCountLeft == 5)
                    {
                        computer2.DiceCountLeft = 4;
                        computer2.D5On = false;
                        MessageBox.Show("Computer 2 has 4 dice remaining");
                    }
                    else if (computer2.DiceCountLeft == 4)
                    {
                        computer2.DiceCountLeft = 3;
                        computer2.D4On = false;
                        MessageBox.Show("Computer 2 has 3 dice remaining");
                    }
                    else if (computer2.DiceCountLeft == 3)
                    {
                        computer2.DiceCountLeft = 2;
                        computer2.D3On = false;
                        MessageBox.Show("Computer 2 has 2 dice remaining");
                    }
                    else if (computer2.DiceCountLeft == 2)
                    {
                        computer2.DiceCountLeft = 1;
                        computer2.D2On = false;
                        MessageBox.Show("Computer 2 has 1 die remaining");
                    }
                    else if (computer2.DiceCountLeft == 1)
                    {
                        computer2.DiceCountLeft = 0;
                        computer2.D1On = false;
                        MessageBox.Show("Computer 2 is out of dice");
                        //remove player from game
                    }
                }
                DiceRollAll();
                previousDiceAmount = 0;
            }//end else if
        }
        private void btnPlayer1Challenge_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Player1 challenged Computer 3");
            //value for 1
            if(previousDiceValue == 1)
            {
                if (previousDiceAmount <= totNumD1)
                {
                    MessageBox.Show("You lost the challenge!");
                    if (player1.DiceCountLeft == 6)
                    {
                        player1.DiceCountLeft = 5;
                        player1.D6On = false;
                        MessageBox.Show("You have 5 dice remaining");
                    }
                    else if (player1.DiceCountLeft == 5)
                    {
                        player1.DiceCountLeft = 4;
                        player1.D5On = false;
                        MessageBox.Show("You have 4 dice remaining");
                    }
                    else if (player1.DiceCountLeft == 4)
                    {
                        player1.DiceCountLeft = 3;
                        player1.D4On = false;
                        MessageBox.Show("You have 3 dice remaining");
                    }
                    else if (player1.DiceCountLeft == 3)
                    {
                        player1.DiceCountLeft = 2;
                        player1.D3On = false;
                        MessageBox.Show("You have 2 dice remaining");
                    }
                    else if (player1.DiceCountLeft == 2)
                    {
                        player1.DiceCountLeft = 1;
                        player1.D2On = false;
                        MessageBox.Show("You have 1 die remaining");
                    }
                    else if (player1.DiceCountLeft == 1)
                    {
                        player1.DiceCountLeft = 0;
                        player1.D1On = false;
                        MessageBox.Show("You are out of dice");
                    }
                }
                else
                {
                    MessageBox.Show("Computer 3 lost the challenge!");
                    if (computer3.DiceCountLeft == 6)
                    {
                        computer3.DiceCountLeft = 5;
                        computer3.D6On = false;
                        MessageBox.Show("Computer 3 has 5 dice remaining");
                    }
                    else if (computer3.DiceCountLeft == 5)
                    {
                        computer3.DiceCountLeft = 4;
                        computer3.D5On = false;
                        MessageBox.Show("Computer 3 has 4 dice remaining");
                    }
                    else if (computer3.DiceCountLeft == 4)
                    {
                        computer3.DiceCountLeft = 3;
                        computer3.D4On = false;
                        MessageBox.Show("Computer 3 has 3 dice remaining");
                    }
                    else if (computer3.DiceCountLeft == 3)
                    {
                        computer3.DiceCountLeft = 2;
                        computer3.D3On = false;
                        MessageBox.Show("Computer 3 has 2 dice remaining");
                    }
                    else if (computer3.DiceCountLeft == 2)
                    {
                        computer3.DiceCountLeft = 1;
                        computer3.D2On = false;
                        MessageBox.Show("Computer 3 has 1 die remaining");
                    }
                    else if (computer3.DiceCountLeft == 1)
                    {
                        computer3.DiceCountLeft = 0;
                        computer3.D1On = false;
                        MessageBox.Show("Computer 3 is out of dice");
                    }
                }
                DiceRollAll();
                previousDiceAmount = 0;
                previousDiceValue = 0;
            }//end if
            //value for 2
            else if(previousDiceValue == 2)
            {
                if (previousDiceAmount <= totNumD2)
                {
                    MessageBox.Show("You lost the challenge!");
                    if (player1.DiceCountLeft == 6)
                    {
                        player1.DiceCountLeft = 5;
                        player1.D6On = false;
                        MessageBox.Show("You have 5 dice remaining");
                    }
                    else if (player1.DiceCountLeft == 5)
                    {
                        player1.DiceCountLeft = 4;
                        player1.D5On = false;
                        MessageBox.Show("You have 4 dice remaining");
                    }
                    else if (player1.DiceCountLeft == 4)
                    {
                        player1.DiceCountLeft = 3;
                        player1.D4On = false;
                        MessageBox.Show("You have 3 dice remaining");
                    }
                    else if (player1.DiceCountLeft == 3)
                    {
                        player1.DiceCountLeft = 2;
                        player1.D3On = false;
                        MessageBox.Show("You have 2 dice remaining");
                    }
                    else if (player1.DiceCountLeft == 2)
                    {
                        player1.DiceCountLeft = 1;
                        player1.D2On = false;
                        MessageBox.Show("You have 1 die remaining");
                    }
                    else if (player1.DiceCountLeft == 1)
                    {
                        player1.DiceCountLeft = 0;
                        player1.D1On = false;
                        MessageBox.Show("You are out of dice");
                    }
                }
                else
                {
                    MessageBox.Show("Computer 3 lost the challenge!");
                    if (computer3.DiceCountLeft == 6)
                    {
                        computer3.DiceCountLeft = 5;
                        computer3.D6On = false;
                        MessageBox.Show("Computer 3 has 5 dice remaining");
                    }
                    else if (computer3.DiceCountLeft == 5)
                    {
                        computer3.DiceCountLeft = 4;
                        computer3.D5On = false;
                        MessageBox.Show("Computer 3 has 4 dice remaining");
                    }
                    else if (computer3.DiceCountLeft == 4)
                    {
                        computer3.DiceCountLeft = 3;
                        computer3.D4On = false;
                        MessageBox.Show("Computer 3 has 3 dice remaining");
                    }
                    else if (computer3.DiceCountLeft == 3)
                    {
                        computer3.DiceCountLeft = 2;
                        computer3.D3On = false;
                        MessageBox.Show("Computer 3 has 2 dice remaining");
                    }
                    else if (computer3.DiceCountLeft == 2)
                    {
                        computer3.DiceCountLeft = 1;
                        computer3.D2On = false;
                        MessageBox.Show("Computer 3 has 1 die remaining");
                    }
                    else if (computer3.DiceCountLeft == 1)
                    {
                        computer3.DiceCountLeft = 0;
                        computer3.D1On = false;
                        MessageBox.Show("Computer 3 is out of dice");
                    }
                }
                DiceRollAll();
                previousDiceAmount = 0;
                previousDiceValue = 0;
            }//end else if
            //value for 3
            else if(previousDiceValue == 3)
            {
                if (previousDiceAmount <= totNumD3)
                {
                    MessageBox.Show("You lost the challenge!");
                    if (player1.DiceCountLeft == 6)
                    {
                        player1.DiceCountLeft = 5;
                        player1.D6On = false;
                        MessageBox.Show("You have 5 dice remaining");
                    }
                    else if (player1.DiceCountLeft == 5)
                    {
                        player1.DiceCountLeft = 4;
                        player1.D5On = false;
                        MessageBox.Show("You have 4 dice remaining");
                    }
                    else if (player1.DiceCountLeft == 4)
                    {
                        player1.DiceCountLeft = 3;
                        player1.D4On = false;
                        MessageBox.Show("You have 3 dice remaining");
                    }
                    else if (player1.DiceCountLeft == 3)
                    {
                        player1.DiceCountLeft = 2;
                        player1.D3On = false;
                        MessageBox.Show("You have 2 dice remaining");
                    }
                    else if (player1.DiceCountLeft == 2)
                    {
                        player1.DiceCountLeft = 1;
                        player1.D2On = false;
                        MessageBox.Show("You have 1 die remaining");
                    }
                    else if (player1.DiceCountLeft == 1)
                    {
                        player1.DiceCountLeft = 0;
                        player1.D1On = false;
                        MessageBox.Show("You are out of dice");
                    }
                }
                else
                {
                    MessageBox.Show("Computer 3 lost the challenge!");
                    if (computer3.DiceCountLeft == 6)
                    {
                        computer3.DiceCountLeft = 5;
                        computer3.D6On = false;
                        MessageBox.Show("Computer 3 has 5 dice remaining");
                    }
                    else if (computer3.DiceCountLeft == 5)
                    {
                        computer3.DiceCountLeft = 4;
                        computer3.D5On = false;
                        MessageBox.Show("Computer 3 has 4 dice remaining");
                    }
                    else if (computer3.DiceCountLeft == 4)
                    {
                        computer3.DiceCountLeft = 3;
                        computer3.D4On = false;
                        MessageBox.Show("Computer 3 has 3 dice remaining");
                    }
                    else if (computer3.DiceCountLeft == 3)
                    {
                        computer3.DiceCountLeft = 2;
                        computer3.D3On = false;
                        MessageBox.Show("Computer 3 has 2 dice remaining");
                    }
                    else if (computer3.DiceCountLeft == 2)
                    {
                        computer3.DiceCountLeft = 1;
                        computer3.D2On = false;
                        MessageBox.Show("Computer 3 has 1 die remaining");
                    }
                    else if (computer3.DiceCountLeft == 1)
                    {
                        computer3.DiceCountLeft = 0;
                        computer3.D1On = false;
                        MessageBox.Show("Computer 3 is out of dice");
                    }
                }
                DiceRollAll();
                previousDiceAmount = 0;
                previousDiceValue = 0;
            }//end else if
            //value for 4
            else if(previousDiceValue == 4)
            {
                if (previousDiceAmount <= totNumD4)
                {
                    MessageBox.Show("You lost the challenge!");
                    if (player1.DiceCountLeft == 6)
                    {
                        player1.DiceCountLeft = 5;
                        player1.D6On = false;
                        MessageBox.Show("You have 5 dice remaining");
                    }
                    else if (player1.DiceCountLeft == 5)
                    {
                        player1.DiceCountLeft = 4;
                        player1.D5On = false;
                        MessageBox.Show("You have 4 dice remaining");
                    }
                    else if (player1.DiceCountLeft == 4)
                    {
                        player1.DiceCountLeft = 3;
                        player1.D4On = false;
                        MessageBox.Show("You have 3 dice remaining");
                    }
                    else if (player1.DiceCountLeft == 3)
                    {
                        player1.DiceCountLeft = 2;
                        player1.D3On = false;
                        MessageBox.Show("You have 2 dice remaining");
                    }
                    else if (player1.DiceCountLeft == 2)
                    {
                        player1.DiceCountLeft = 1;
                        player1.D2On = false;
                        MessageBox.Show("You have 1 die remaining");
                    }
                    else if (player1.DiceCountLeft == 1)
                    {
                        player1.DiceCountLeft = 0;
                        player1.D1On = false;
                        MessageBox.Show("You are out of dice");
                    }
                }
                else
                {
                    MessageBox.Show("Computer 3 lost the challenge!");
                    if (computer3.DiceCountLeft == 6)
                    {
                        computer3.DiceCountLeft = 5;
                        computer3.D6On = false;
                        MessageBox.Show("Computer 3 has 5 dice remaining");
                    }
                    else if (computer3.DiceCountLeft == 5)
                    {
                        computer3.DiceCountLeft = 4;
                        computer3.D5On = false;
                        MessageBox.Show("Computer 3 has 4 dice remaining");
                    }
                    else if (computer3.DiceCountLeft == 4)
                    {
                        computer3.DiceCountLeft = 3;
                        computer3.D4On = false;
                        MessageBox.Show("Computer 3 has 3 dice remaining");
                    }
                    else if (computer3.DiceCountLeft == 3)
                    {
                        computer3.DiceCountLeft = 2;
                        computer3.D3On = false;
                        MessageBox.Show("Computer 3 has 2 dice remaining");
                    }
                    else if (computer3.DiceCountLeft == 2)
                    {
                        computer3.DiceCountLeft = 1;
                        computer3.D2On = false;
                        MessageBox.Show("Computer 3 has 1 die remaining");
                    }
                    else if (computer3.DiceCountLeft == 1)
                    {
                        computer3.DiceCountLeft = 0;
                        computer3.D1On = false;
                        MessageBox.Show("Computer 3 is out of dice");
                    }
                }
                DiceRollAll();
                previousDiceAmount = 0;
                previousDiceValue = 0;
            }//end else if
            //value for 5
            else if(previousDiceValue == 5)
            {
                if (previousDiceAmount <= totNumD5)
                {
                    MessageBox.Show("You lost the challenge!");
                    if (player1.DiceCountLeft == 6)
                    {
                        player1.DiceCountLeft = 5;
                        player1.D6On = false;
                        MessageBox.Show("You have 5 dice remaining");
                    }
                    else if (player1.DiceCountLeft == 5)
                    {
                        player1.DiceCountLeft = 4;
                        player1.D5On = false;
                        MessageBox.Show("You have 4 dice remaining");
                    }
                    else if (player1.DiceCountLeft == 4)
                    {
                        player1.DiceCountLeft = 3;
                        player1.D4On = false;
                        MessageBox.Show("You have 3 dice remaining");
                    }
                    else if (player1.DiceCountLeft == 3)
                    {
                        player1.DiceCountLeft = 2;
                        player1.D3On = false;
                        MessageBox.Show("You have 2 dice remaining");
                    }
                    else if (player1.DiceCountLeft == 2)
                    {
                        player1.DiceCountLeft = 1;
                        player1.D2On = false;
                        MessageBox.Show("You have 1 die remaining");
                    }
                    else if (player1.DiceCountLeft == 1)
                    {
                        player1.DiceCountLeft = 0;
                        player1.D1On = false;
                        MessageBox.Show("You are out of dice");
                    }
                }
                else
                {
                    MessageBox.Show("Computer 3 lost the challenge!");
                    if (computer3.DiceCountLeft == 6)
                    {
                        computer3.DiceCountLeft = 5;
                        computer3.D6On = false;
                        MessageBox.Show("Computer 3 has 5 dice remaining");
                    }
                    else if (computer3.DiceCountLeft == 5)
                    {
                        computer3.DiceCountLeft = 4;
                        computer3.D5On = false;
                        MessageBox.Show("Computer 3 has 4 dice remaining");
                    }
                    else if (computer3.DiceCountLeft == 4)
                    {
                        computer3.DiceCountLeft = 3;
                        computer3.D4On = false;
                        MessageBox.Show("Computer 3 has 3 dice remaining");
                    }
                    else if (computer3.DiceCountLeft == 3)
                    {
                        computer3.DiceCountLeft = 2;
                        computer3.D3On = false;
                        MessageBox.Show("Computer 3 has 2 dice remaining");
                    }
                    else if (computer3.DiceCountLeft == 2)
                    {
                        computer3.DiceCountLeft = 1;
                        computer3.D2On = false;
                        MessageBox.Show("Computer 3 has 1 die remaining");
                    }
                    else if (computer3.DiceCountLeft == 1)
                    {
                        computer3.DiceCountLeft = 0;
                        computer3.D1On = false;
                        MessageBox.Show("Computer 3 is out of dice");
                    }
                }
                DiceRollAll();
                previousDiceAmount = 0;
                previousDiceValue = 0;
            }//end else if
            //value for 6
            else if(previousDiceValue == 6)
            {
                if (previousDiceAmount <= totNumD6)
                {
                    MessageBox.Show("You lost the challenge!");
                    if (player1.DiceCountLeft == 6)
                    {
                        player1.DiceCountLeft = 5;
                        player1.D6On = false;
                        MessageBox.Show("You have 5 dice remaining");
                    }
                    else if (player1.DiceCountLeft == 5)
                    {
                        player1.DiceCountLeft = 4;
                        player1.D5On = false;
                        MessageBox.Show("You have 4 dice remaining");
                    }
                    else if (player1.DiceCountLeft == 4)
                    {
                        player1.DiceCountLeft = 3;
                        player1.D4On = false;
                        MessageBox.Show("You have 3 dice remaining");
                    }
                    else if (player1.DiceCountLeft == 3)
                    {
                        player1.DiceCountLeft = 2;
                        player1.D3On = false;
                        MessageBox.Show("You have 2 dice remaining");
                    }
                    else if (player1.DiceCountLeft == 2)
                    {
                        player1.DiceCountLeft = 1;
                        player1.D2On = false;
                        MessageBox.Show("You have 1 die remaining");
                    }
                    else if (player1.DiceCountLeft == 1)
                    {
                        player1.DiceCountLeft = 0;
                        player1.D1On = false;
                        MessageBox.Show("You are out of dice");
                    }
                }
                else
                {
                    MessageBox.Show("Computer 3 lost the challenge!");
                    if (computer3.DiceCountLeft == 6)
                    {
                        computer3.DiceCountLeft = 5;
                        computer3.D6On = false;
                        MessageBox.Show("Computer 3 has 5 dice remaining");
                    }
                    else if (computer3.DiceCountLeft == 5)
                    {
                        computer3.DiceCountLeft = 4;
                        computer3.D5On = false;
                        MessageBox.Show("Computer 3 has 4 dice remaining");
                    }
                    else if (computer3.DiceCountLeft == 4)
                    {
                        computer3.DiceCountLeft = 3;
                        computer3.D4On = false;
                        MessageBox.Show("Computer 3 has 3 dice remaining");
                    }
                    else if (computer3.DiceCountLeft == 3)
                    {
                        computer3.DiceCountLeft = 2;
                        computer3.D3On = false;
                        MessageBox.Show("Computer 3 has 2 dice remaining");
                    }
                    else if (computer3.DiceCountLeft == 2)
                    {
                        computer3.DiceCountLeft = 1;
                        computer3.D2On = false;
                        MessageBox.Show("Computer 3 has 1 die remaining");
                    }
                    else if (computer3.DiceCountLeft == 1)
                    {
                        computer3.DiceCountLeft = 0;
                        computer3.D1On = false;
                        MessageBox.Show("Computer 3 is out of dice");
                    }
                }
                DiceRollAll();
                previousDiceAmount = 0;
                previousDiceValue = 0;
            }//end else if
            lblComputer1BetNum.Text = "X";
            lblComputer1BetValue.Text = "X";
            lblComputer2BetNum.Text = "X";
            lblComputer2BetValue.Text = "X";
            lblComputer3BetNum.Text = "X";
            lblComputer3BetValue.Text = "X";
        }
        private int GenerateChoice()
        {
            Random rand = new Random();
            choice = rand.Next(1,2);
            return choice;
        }
        //roll all dice function
        private void DiceRollAll()
        {
            Random rand = new Random();

            //ACCOUNT FOR PLAYERS THAT HAVE LOST DICE
            //roll player 1 dice
            if (player1.D1On == true && player1.D2On == true && player1.D3On == true && player1.D4On == true && player1.D5On == true && player1.D6On == true)
            {
                player1.D1 = rand.Next(6) + 1;
                player1.D2 = rand.Next(6) + 1;
                player1.D3 = rand.Next(6) + 1;
                player1.D4 = rand.Next(6) + 1;
                player1.D5 = rand.Next(6) + 1;
                player1.D6 = rand.Next(6) + 1;
                lblDie1Out.Text = player1.D1.ToString();
                lblDie2Out.Text = player1.D2.ToString();
                lblDie3Out.Text = player1.D3.ToString();
                lblDie4Out.Text = player1.D4.ToString();
                lblDie5Out.Text = player1.D5.ToString();
                lblDie6Out.Text = player1.D6.ToString();
            }
            else if(player1.D1On == true && player1.D2On == true && player1.D3On == true && player1.D4On == true && player1.D5On == true)
            {
                player1.D1 = rand.Next(6) + 1;
                player1.D2 = rand.Next(6) + 1;
                player1.D3 = rand.Next(6) + 1;
                player1.D4 = rand.Next(6) + 1;
                player1.D5 = rand.Next(6) + 1;
                lblDie1Out.Text = player1.D1.ToString();
                lblDie2Out.Text = player1.D2.ToString();
                lblDie3Out.Text = player1.D3.ToString();
                lblDie4Out.Text = player1.D4.ToString();
                lblDie5Out.Text = player1.D5.ToString();
                lblDie6Out.Text = "X";
            }
            else if (player1.D1On == true && player1.D2On == true && player1.D3On == true && player1.D4On == true)
            {
                player1.D1 = rand.Next(6) + 1;
                player1.D2 = rand.Next(6) + 1;
                player1.D3 = rand.Next(6) + 1;
                player1.D4 = rand.Next(6) + 1;
                lblDie1Out.Text = player1.D1.ToString();
                lblDie2Out.Text = player1.D2.ToString();
                lblDie3Out.Text = player1.D3.ToString();
                lblDie4Out.Text = player1.D4.ToString();
                lblDie5Out.Text = "X";
                lblDie6Out.Text = "X";
            }
            else if (player1.D1On == true && player1.D2On == true && player1.D3On == true)
            {
                player1.D1 = rand.Next(6) + 1;
                player1.D2 = rand.Next(6) + 1;
                player1.D3 = rand.Next(6) + 1;
                lblDie1Out.Text = player1.D1.ToString();
                lblDie2Out.Text = player1.D2.ToString();
                lblDie3Out.Text = player1.D3.ToString();
                lblDie4Out.Text = "X";
                lblDie5Out.Text = "X";
                lblDie6Out.Text = "X";
            }
            else if (player1.D1On == true && player1.D2On == true)
            {
                player1.D1 = rand.Next(6) + 1;
                player1.D2 = rand.Next(6) + 1;
                lblDie1Out.Text = player1.D1.ToString();
                lblDie2Out.Text = player1.D2.ToString();
                lblDie3Out.Text = "X";
                lblDie4Out.Text = "X";
                lblDie5Out.Text = "X";
                lblDie6Out.Text = "X";

            }
            else if (player1.D1On == true)
            {
                player1.D1 = rand.Next(6) + 1;
                lblDie1Out.Text = player1.D1.ToString();
                lblDie2Out.Text = "X";
                lblDie3Out.Text = "X";
                lblDie4Out.Text = "X";
                lblDie5Out.Text = "X";
                lblDie6Out.Text = "X";
            }
            else if(player1.D1On == false && player1.D2On == false && player1.D3On == false && player1.D4On == false && player1.D5On == false && player1.D6On == false)
            {
                MessageBox.Show("Player 1 is out of dice. Player 1 has lost");
                player1.Lost = true;
                lblDie1Out.Text = "X";
                lblDie2Out.Text = "X";
                lblDie3Out.Text = "X";
                lblDie4Out.Text = "X";
                lblDie5Out.Text = "X";
                lblDie6Out.Text = "X";
            }

            //roll computer 1 dice
            if (computer1.D1On == true && computer1.D2On == true && computer1.D3On == true && computer1.D4On == true && computer1.D5On == true && computer1.D6On == true)
            {
                computer1.D1 = rand.Next(6) + 1;
                computer1.D2 = rand.Next(6) + 1;
                computer1.D3 = rand.Next(6) + 1;
                computer1.D4 = rand.Next(6) + 1;
                computer1.D5 = rand.Next(6) + 1;
                computer1.D6 = rand.Next(6) + 1;
                lblComputer1D1.Text = computer1.D1.ToString();
                lblComputer1D2.Text = computer1.D2.ToString();
                lblComputer1D3.Text = computer1.D3.ToString();
                lblComputer1D4.Text = computer1.D4.ToString();
                lblComputer1D5.Text = computer1.D5.ToString();
                lblComputer1D6.Text = computer1.D6.ToString();
            }
            else if (computer1.D1On == true && computer1.D2On == true && computer1.D3On == true && computer1.D4On == true && computer1.D5On == true)
            {
                computer1.D1 = rand.Next(6) + 1;
                computer1.D2 = rand.Next(6) + 1;
                computer1.D3 = rand.Next(6) + 1;
                computer1.D4 = rand.Next(6) + 1;
                computer1.D5 = rand.Next(6) + 1;
                lblComputer1D1.Text = computer1.D1.ToString();
                lblComputer1D2.Text = computer1.D2.ToString();
                lblComputer1D3.Text = computer1.D3.ToString();
                lblComputer1D4.Text = computer1.D4.ToString();
                lblComputer1D5.Text = computer1.D5.ToString();
                lblComputer1D6.Text = "X";
            }
            else if (computer1.D1On == true && computer1.D2On == true && computer1.D3On == true && computer1.D4On == true)
            {
                computer1.D1 = rand.Next(6) + 1;
                computer1.D2 = rand.Next(6) + 1;
                computer1.D3 = rand.Next(6) + 1;
                computer1.D4 = rand.Next(6) + 1;
                lblComputer1D1.Text = computer1.D1.ToString();
                lblComputer1D2.Text = computer1.D2.ToString();
                lblComputer1D3.Text = computer1.D3.ToString();
                lblComputer1D4.Text = computer1.D4.ToString();
                lblComputer1D5.Text = "X";
                lblComputer1D6.Text = "X";
            }
            else if (computer1.D1On == true && computer1.D2On == true && computer1.D3On == true)
            {
                computer1.D1 = rand.Next(6) + 1;
                computer1.D2 = rand.Next(6) + 1;
                computer1.D3 = rand.Next(6) + 1;
                lblComputer1D1.Text = computer1.D1.ToString();
                lblComputer1D2.Text = computer1.D2.ToString();
                lblComputer1D3.Text = computer1.D3.ToString();
                lblComputer1D4.Text = "X";
                lblComputer1D5.Text = "X";
                lblComputer1D6.Text = "X";
            }
            else if (computer1.D1On == true && computer1.D2On == true)
            {
                computer1.D1 = rand.Next(6) + 1;
                computer1.D2 = rand.Next(6) + 1;
                lblComputer1D1.Text = computer1.D1.ToString();
                lblComputer1D2.Text = computer1.D2.ToString();
                lblComputer1D3.Text = "X";
                lblComputer1D4.Text = "X";
                lblComputer1D5.Text = "X";
                lblComputer1D6.Text = "X";
            }
            else if (computer1.D1On == true)
            {
                computer1.D1 = rand.Next(6) + 1;
                lblComputer1D1.Text = computer1.D1.ToString();
                lblComputer1D2.Text = "X";
                lblComputer1D3.Text = "X";
                lblComputer1D4.Text = "X";
                lblComputer1D5.Text = "X";
                lblComputer1D6.Text = "X";
            }
            else if (computer1.D1On == false && computer1.D2On == false && computer1.D3On == false && computer1.D4On == false && computer1.D5On == false && computer1.D6On == false)
            {
                MessageBox.Show("Computer 1 is out of dice. Computer 1 has lost");
                computer1.Lost = true;
                lblComputer1D1.Text = "X";
                lblComputer1D2.Text = "X";
                lblComputer1D3.Text = "X";
                lblComputer1D4.Text = "X";
                lblComputer1D5.Text = "X";
                lblComputer1D6.Text = "X";
            }

            //roll computer 2 dice
            if (computer2.D1On == true && computer2.D2On == true && computer2.D3On == true && computer2.D4On == true && computer2.D5On == true && computer2.D6On == true)
            {
                computer2.D1 = rand.Next(6) + 1;
                computer2.D2 = rand.Next(6) + 1;
                computer2.D3 = rand.Next(6) + 1;
                computer2.D4 = rand.Next(6) + 1;
                computer2.D5 = rand.Next(6) + 1;
                computer2.D6 = rand.Next(6) + 1;
                lblComputer2D1.Text = computer2.D1.ToString();
                lblComputer2D2.Text = computer2.D2.ToString();
                lblComputer2D3.Text = computer2.D3.ToString();
                lblComputer2D4.Text = computer2.D4.ToString();
                lblComputer2D5.Text = computer2.D5.ToString();
                lblComputer2D6.Text = computer2.D6.ToString();
            }
            else if (computer2.D1On == true && computer2.D2On == true && computer2.D3On == true && computer2.D4On == true && computer2.D5On == true)
            {
                computer2.D1 = rand.Next(6) + 1;
                computer2.D2 = rand.Next(6) + 1;
                computer2.D3 = rand.Next(6) + 1;
                computer2.D4 = rand.Next(6) + 1;
                computer2.D5 = rand.Next(6) + 1;
                lblComputer2D1.Text = computer2.D1.ToString();
                lblComputer2D2.Text = computer2.D2.ToString();
                lblComputer2D3.Text = computer2.D3.ToString();
                lblComputer2D4.Text = computer2.D4.ToString();
                lblComputer2D5.Text = computer2.D5.ToString();
                lblComputer2D6.Text = "X";
            }
            else if (computer2.D1On == true && computer2.D2On == true && computer2.D3On == true && computer2.D4On == true)
            {
                computer2.D1 = rand.Next(6) + 1;
                computer2.D2 = rand.Next(6) + 1;
                computer2.D3 = rand.Next(6) + 1;
                computer2.D4 = rand.Next(6) + 1;
                lblComputer2D1.Text = computer2.D1.ToString();
                lblComputer2D2.Text = computer2.D2.ToString();
                lblComputer2D3.Text = computer2.D3.ToString();
                lblComputer2D4.Text = computer2.D4.ToString();
                lblComputer2D5.Text = "X";
                lblComputer2D6.Text = "X";
            }
            else if (computer2.D1On == true && computer2.D2On == true && computer2.D3On == true)
            {
                computer2.D1 = rand.Next(6) + 1;
                computer2.D2 = rand.Next(6) + 1;
                computer2.D3 = rand.Next(6) + 1;
                lblComputer2D1.Text = computer2.D1.ToString();
                lblComputer2D2.Text = computer2.D2.ToString();
                lblComputer2D3.Text = computer2.D3.ToString();
                lblComputer2D4.Text = "X";
                lblComputer2D5.Text = "X";
                lblComputer2D6.Text = "X";
            }
            else if (computer2.D1On == true && computer2.D2On == true)
            {
                computer2.D1 = rand.Next(6) + 1;
                computer2.D2 = rand.Next(6) + 1;
                lblComputer2D1.Text = computer2.D1.ToString();
                lblComputer2D2.Text = computer2.D2.ToString();
                lblComputer2D3.Text = "X";
                lblComputer2D4.Text = "X";
                lblComputer2D5.Text = "X";
                lblComputer2D6.Text = "X";
            }
            else if (computer2.D1On == true)
            {
                computer2.D1 = rand.Next(6) + 1;
                lblComputer2D1.Text = computer2.D1.ToString();
                lblComputer2D2.Text = "X";
                lblComputer2D3.Text = "X";
                lblComputer2D4.Text = "X";
                lblComputer2D5.Text = "X";
                lblComputer2D6.Text = "X";
            }
            else if (computer2.D1On == false && computer2.D2On == false && computer2.D3On == false && computer2.D4On == false && computer2.D5On == false && computer2.D6On == false)
            {
                MessageBox.Show("Computer 2 is out of dice. Computer 2 has lost");
                computer2.Lost = true;
                lblComputer2D1.Text = "X";
                lblComputer2D2.Text = "X";
                lblComputer2D3.Text = "X";
                lblComputer2D4.Text = "X";
                lblComputer2D5.Text = "X";
                lblComputer2D6.Text = "X";
            }

            //roll computer 3 dice
            if (computer3.D1On == true && computer3.D2On == true && computer3.D3On == true && computer3.D4On == true && computer3.D5On == true && computer3.D6On == true)
            {
                computer3.D1 = rand.Next(6) + 1;
                computer3.D2 = rand.Next(6) + 1;
                computer3.D3 = rand.Next(6) + 1;
                computer3.D4 = rand.Next(6) + 1;
                computer3.D5 = rand.Next(6) + 1;
                computer3.D6 = rand.Next(6) + 1;
                lblComputer3D1.Text = computer2.D1.ToString();
                lblComputer3D2.Text = computer2.D2.ToString();
                lblComputer3D3.Text = computer2.D3.ToString();
                lblComputer3D4.Text = computer2.D4.ToString();
                lblComputer3D5.Text = computer2.D5.ToString();
                lblComputer3D6.Text = computer2.D6.ToString();
            }
            else if (computer3.D1On == true && computer3.D2On == true && computer3.D3On == true && computer3.D4On == true && computer3.D5On == true)
            {
                computer3.D1 = rand.Next(6) + 1;
                computer3.D2 = rand.Next(6) + 1;
                computer3.D3 = rand.Next(6) + 1;
                computer3.D4 = rand.Next(6) + 1;
                computer3.D5 = rand.Next(6) + 1;
                lblComputer3D1.Text = computer2.D1.ToString();
                lblComputer3D2.Text = computer2.D2.ToString();
                lblComputer3D3.Text = computer2.D3.ToString();
                lblComputer3D4.Text = computer2.D4.ToString();
                lblComputer3D5.Text = computer2.D5.ToString();
                lblComputer3D6.Text = "X";
            }
            else if (computer3.D1On == true && computer3.D2On == true && computer3.D3On == true && computer3.D4On == true)
            {
                computer3.D1 = rand.Next(6) + 1;
                computer3.D2 = rand.Next(6) + 1;
                computer3.D3 = rand.Next(6) + 1;
                computer3.D4 = rand.Next(6) + 1;
                lblComputer3D1.Text = computer2.D1.ToString();
                lblComputer3D2.Text = computer2.D2.ToString();
                lblComputer3D3.Text = computer2.D3.ToString();
                lblComputer3D4.Text = computer2.D4.ToString();
                lblComputer3D5.Text = "X";
                lblComputer3D6.Text = "X";
            }
            else if (computer3.D1On == true && computer3.D2On == true && computer3.D3On == true)
            {
                computer3.D1 = rand.Next(6) + 1;
                computer3.D2 = rand.Next(6) + 1;
                computer3.D3 = rand.Next(6) + 1;
                lblComputer3D1.Text = computer2.D1.ToString();
                lblComputer3D2.Text = computer2.D2.ToString();
                lblComputer3D3.Text = computer2.D3.ToString();
                lblComputer3D4.Text = "X";
                lblComputer3D5.Text = "X";
                lblComputer3D6.Text = "X";
            }
            else if (computer3.D1On == true && computer3.D2On == true)
            {
                computer3.D1 = rand.Next(6) + 1;
                computer3.D2 = rand.Next(6) + 1;
                lblComputer3D1.Text = computer2.D1.ToString();
                lblComputer3D2.Text = computer2.D2.ToString();
                lblComputer3D3.Text = "X";
                lblComputer3D4.Text = "X";
                lblComputer3D5.Text = "X";
                lblComputer3D6.Text = "X";
            }
            else if (computer3.D1On == true)
            {
                computer3.D1 = rand.Next(6) + 1;
                lblComputer3D1.Text = computer2.D1.ToString();
                lblComputer3D2.Text = "X";
                lblComputer3D3.Text = "X";
                lblComputer3D4.Text = "X";
                lblComputer3D5.Text = "X";
                lblComputer3D6.Text = "X";
            }
            else if (computer3.D1On == false && computer3.D2On == false && computer3.D3On == false && computer3.D4On == false && computer3.D5On == false && computer3.D6On == false)
            {
                MessageBox.Show("Computer 3 is out of dice. Computer 3 has lost");
                computer3.Lost = true;
                lblComputer3D1.Text = "X";
                lblComputer3D2.Text = "X";
                lblComputer3D3.Text = "X";
                lblComputer3D4.Text = "X";
                lblComputer3D5.Text = "X";
                lblComputer3D6.Text = "X";
            }

            if (CountDice() == true)
            {
                //to fix the issue with this showing on launch.
                MessageBox.Show("All dice have been rolled");
            }

            

           // to add the winnings
            if (computer1.Lost == true || computer2.Lost == true || computer3.Lost == true)
            {
                //add you wins up
               GameWin();
                //prompt user to start a new game
               MessageBox.Show("You won! Close the window to start a new game");

            }
        }



        private void GameWin()
        {
            int winnings = 0;
            // attempt to read the current scores
            try
            {
                StreamReader fileIn;
                fileIn = File.OpenText("score.txt");
                //read the current score
                winnings = int.Parse(fileIn.ReadLine());
                winnings += 1;
                fileIn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
            
            // now attempt to write the score back to the file
            try
            {
                StreamWriter fileOut;
                fileOut = File.CreateText("score.txt");
                fileOut.WriteLine(winnings);
                fileOut.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
        }



        //button used to check stuff
        private void btnRoll_Click(object sender, EventArgs e)
        {
            //DiceRollAll();
            //Display All Dice again
            //player1
            //lblDie1Out.Text = player1.D1.ToString();
            //lblDie2Out.Text = player1.D2.ToString();
            //lblDie3Out.Text = player1.D3.ToString();
            //lblDie4Out.Text = player1.D4.ToString();
            //lblDie5Out.Text = player1.D5.ToString();
            //lblDie6Out.Text = player1.D6.ToString();
            //computer1
            //lblComputer1D1.Text = computer1.D1.ToString();
            //lblComputer1D2.Text = computer1.D2.ToString();
            //lblComputer1D3.Text = computer1.D3.ToString();
            //lblComputer1D4.Text = computer1.D4.ToString();
            //lblComputer1D5.Text = computer1.D5.ToString();
            //lblComputer1D6.Text = computer1.D6.ToString();
            //computer2
            //lblComputer2D1.Text = computer2.D1.ToString();
            //lblComputer2D2.Text = computer2.D2.ToString();
            //lblComputer2D3.Text = computer2.D3.ToString();
            //lblComputer2D4.Text = computer2.D4.ToString();
            //lblComputer2D5.Text = computer2.D5.ToString();
            //lblComputer2D6.Text = computer2.D6.ToString();
            //computer3
            //lblComputer3D1.Text = computer3.D1.ToString();
            //lblComputer3D2.Text = computer3.D2.ToString();
            //lblComputer3D3.Text = computer3.D3.ToString();
            //lblComputer3D4.Text = computer3.D4.ToString();
            //lblComputer3D5.Text = computer3.D5.ToString();
            //lblComputer3D6.Text = computer3.D6.ToString();
        }
    }
}
