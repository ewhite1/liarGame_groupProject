﻿namespace LiarDice_grpProjCS
{
    partial class Instruction
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.backToGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.backToGameToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(528, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // backToGameToolStripMenuItem
            // 
            this.backToGameToolStripMenuItem.Name = "backToGameToolStripMenuItem";
            this.backToGameToolStripMenuItem.Size = new System.Drawing.Size(92, 20);
            this.backToGameToolStripMenuItem.Text = "&Back to Game";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.exitToolStripMenuItem.Text = "E&xit";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "How to Play";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Items.AddRange(new object[] {
            "Each player starts with 5 dice and something to hide their dice (usually a cup). " +
                " ",
            "The dice are rolled and left hidden and the players can only see their own dice. " +
                " ",
            "Each person playing is given a turn to bet/bluff the total number of dice and the" +
                " value of the die",
            "they think that everyone playing has.  ",
            "The person is welcome to bet as low or high as they want to attempt to outsmart t" +
                "he opponent.  ",
            "The game becomes more difficult as each player has to bet/bluff either a higher d" +
                "ie value or higher ",
            "die number than the previous player.  ",
            "If a player does not have a die or the desired number of die he/she would like to" +
                " bet, he/she can bluff",
            "to try and get past their turn. ",
            "If nobody calls their bluff, the game continues on to the next player. ",
            "If the next player thinks their die number or value from their bet/bluff is wrong" +
                " they can challenge",
            "or call them a liar.  ",
            "Only the next player can challenge the previous person bet/bluff.  ",
            "When someone challenges a bet/bluff all players reveal their dice and count them." +
                " ",
            "If the player’s bet/bluff was less than or equal to the number of die, the player" +
                " wins the challenge",
            "and the challenger loses a die.  ",
            "If the bet/bluff was indeed a lie, the player betting loses a die. ",
            "All players dice are then re-rolled and hidden again under their cups.  ",
            "The loser of the challenge starts the next round of play. ",
            " When a player loses all their dice, they are out of the game.  ",
            "A player wins when they are the last one with dice."});
            this.listBox1.Location = new System.Drawing.Point(12, 90);
            this.listBox1.Name = "listBox1";
            this.listBox1.ScrollAlwaysVisible = true;
            this.listBox1.Size = new System.Drawing.Size(504, 199);
            this.listBox1.TabIndex = 3;
            // 
            // Instruction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Goldenrod;
            this.ClientSize = new System.Drawing.Size(528, 350);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Instruction";
            this.Text = "Instruction";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem backToGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBox1;
    }
}