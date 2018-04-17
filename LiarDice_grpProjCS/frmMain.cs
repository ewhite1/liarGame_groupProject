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
            // this.hide();
            instructionForm.ShowDialog();
        }

        private void btnNewGame_Click(object sender, EventArgs e)
        { 
            //new form launch - new game settings
            frmGame gameForm = new frmGame();
            //get player name
            //player1.Name
            //show player select screen
            //frmPlayerSelect myPlayerSelect = new frmPlayerSelect();
            this.Hide();
            gameForm.Show();
        }

        private void btnWinners_Click(object sender, EventArgs e)
        {
            frmWinners myFrmWinner = new frmWinners();
            //Not doing this due I cant seem to bring the main window back
            //this.Hide();

            myFrmWinner.ShowDialog();
            
        }

    }
}
