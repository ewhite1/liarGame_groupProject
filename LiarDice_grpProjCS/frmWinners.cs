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
   


    public partial class frmWinners : Form
    {
  
        public frmWinners()
        {
            InitializeComponent();
            //call score function
           ReturnScores();
        }

        struct Scores
        {
            //really not needed to perform this task, 
            // but using it for orgaization anyways. -Edward
            public int player1Score;
            public int cpuPlayer1Score;
            public int cpuPlayer2Score;
            public int cpuPlayer3Score;

        }
        private void ReturnScores()
        {
            Scores myScores = new Scores();
            StreamReader fileIn;
            // open the stream to look at the contents of a file
            fileIn = File.OpenText("scores.txt");
            //read each line for each score
            int line = 0;
            while(!fileIn.EndOfStream)
            {
                //depending on what line is the file reader is on, parse it to a certian item 
                switch (line)
                {
                    case 1:
                        myScores.player1Score = int.Parse(fileIn.ReadLine());
                        line++;
                       break;
                    case 2:
                        myScores.cpuPlayer1Score = int.Parse(fileIn.ReadLine());
                        line++;
                        break;
                    case 3:
                        myScores.cpuPlayer2Score = int.Parse(fileIn.ReadLine());
                        line++;
                        break;
                    case 4:
                        myScores.cpuPlayer3Score = int.Parse(fileIn.ReadLine());
                        line++;
                        break;
                }
            }
            //close file
            fileIn.Close();
            // output each item to the form
            lblPlayerResult.Text = myScores.player1Score.ToString();
            lblCpu1Result.Text = myScores.cpuPlayer2Score.ToString();
            lblCpu2Result.Text = myScores.cpuPlayer2Score.ToString();
            lblCpu3Result.Text = myScores.cpuPlayer3Score.ToString();
            
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            //close this window
            
            this.Close();
            
        }
    }
}
