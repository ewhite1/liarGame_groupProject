﻿using System;
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
        int previousDiceAmount;
        int previousDiceValue;
        int choice = 0;
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
            GetDieNum();
            ComputerBet();
        }

        private void ComputerBet()
        {
            previousDiceAmount = player1.BetNumOfDice;
            previousDiceValue = player1.BetDieValue;

            //computer1 bet
            GenerateChoice();
            if(previousDiceValue >= 5)
            {
               //use challenge function here
                computer1.BetNumOfDice = previousDiceAmount + choice;
            }
            else if(previousDiceAmount >= 13)
            {
                computer1.BetNumOfDice = choice;
                computer1.BetDieValue = previousDiceValue + 1;
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
            if (previousDiceValue >= 5)
            {
                computer2.BetDieValue = choice;
                computer2.BetNumOfDice = previousDiceAmount + choice;
            }
            else if (previousDiceAmount >= 11)
            {
                computer2.BetNumOfDice = choice;
                computer2.BetDieValue = previousDiceValue + 1;
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
            if (previousDiceValue >= 5)
            {
                computer3.BetDieValue = choice;
                computer3.BetNumOfDice = previousDiceAmount + choice;
            }
            else if (previousDiceAmount >= 13)
            {
                computer3.BetNumOfDice = choice;
                computer3.BetDieValue = previousDiceValue + 1;
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
        private void CountDice()
        {
            //was this supposed to take in a player and then generate a count for each player?
            // if thats the case, change it to:
            /* 
                private (int, int, int, int, int, int) CountDice(Player countPlayer)
              
                
              Then instead of player1.d1, it would be countPlayer.d1, countPlayer.d2, etc.

              At the end:
                 Tuple totalNumDiceValues = new Tuple<int, int, int, int, int, int>(totNumD1, totNumD2, totNumD3..);
              
                 return totalNumDiceValues; 
              
            Or without generating the totalNumDiceValues:

                return (totNumD1, TotNumD2..etc);
                
            Then of course, the count has to be recived somewhere, and parsed back out. Into, well another tuple, that can be parsed out.
            There another option without using a tuple, and just do out statements in the top, but Im not a huge fan 
            of cluttering up parameter statements, it makes things ugly, and possibly unreadable logic wise.
            But then again, possibly are tuples are too. 
                -Edward
            */

            //leaving this here if the switch is creating errors
            //if (player1.D1 == 1 )
            //{

            //    totNumD1 += 1;
            //}
            //else if (player1.D1 == 2)
            //{
            // totNumD2 += 1;
            //}
            //what is totnumD1?? I don't see it generated or activated anywhere. Creating locally. Edward

            int totNumD1 = 0;
            int totNumD2 = 0;
            int totNumD3 = 0;
            int totNumD4 = 0;
            int totNumD5 = 0;
            int totNumD6 = 0;
            
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
                // player one dice 2
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
                // player one dice 3
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
                // player one dice 4
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
                 // player one dice 5
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
                // player one dice 6
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
            
        //send out total counts..to somewhere
            //total toNumD1 etc;
            //or return totNumD1, totNumD2, etc
  
        }
        private int GenerateChoice(/*ref Player com*/)
        {
            Random rand = new Random();
            choice = rand.Next(1,2);
            return choice;
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
