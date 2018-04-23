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
        // level to pass to game main I know we are not suppose to autoset, 

        private static string settings;

        public frmMain()
        {
            InitializeComponent();
        }

        public static string Settings { get => settings; set => settings = value; }

        //Instruction frmInstruction = new Instruction();


        private void btnExit_Click(object sender, EventArgs e)
        {
            frmGame gameForm = new frmGame();
            frmWin winForm = new frmWin();
            frmInstruction instructionForm = new frmInstruction();
            Application.Exit();
            gameForm.Close();
            winForm.Close();
            instructionForm.Close();
        }

        private void btnInstructions_Click(object sender, EventArgs e)
        {
            //form Launch- explaining rules
            frmInstruction instructionForm = new frmInstruction();
            instructionForm.ShowDialog();
        }

        private void btnNewGame_Click(object sender, EventArgs e)
        { 
            //new form launch - new game settings
            
            //set the settings
            if (!rdoEasy.Checked && !rdoMedium.Checked && !rdoHard.Checked)
            {
                MessageBox.Show("Please Select a level level first before playing.");
            }
            else
            {
                if (rdoEasy.Checked)
                {
                    Settings = "easy";
                }
                else if (rdoMedium.Checked)
                {
                    Settings = "medium";
                }
                else if (rdoHard.Checked)
                {
                    Settings = "hard";
                }
                frmGame gameForm = new frmGame();
                this.Hide();
                gameForm.Show();
            }
          
           
        }

        private void btnWinners_Click(object sender, EventArgs e)
        {
            frmWin winForm = new frmWin();
            winForm.ShowDialog();
        }

    }
}
