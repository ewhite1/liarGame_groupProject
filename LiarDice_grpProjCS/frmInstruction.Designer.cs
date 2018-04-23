namespace LiarDice_grpProjCS
{
    partial class frmInstruction
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Items.AddRange(new object[] {
            "Each player starts with 5 dice and something to hide their dice (usually a cup). " +
                " ",
            "The dice are rolled and left hidden and the players can only see their own dice. " +
                " ",
            "Each player playing is given a turn to bet/bluff the total number of dice and the" +
                " value of the die",
            "they think that everyone playing has.",
            "The player may bid a higher quantity of the same value or the same quantity of a " +
                "higher value.",
            "The player is welcome to bet as low or high as they want to attempt to outsmart t" +
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
            this.listBox1.Location = new System.Drawing.Point(84, 111);
            this.listBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listBox1.Name = "listBox1";
            this.listBox1.ScrollAlwaysVisible = true;
            this.listBox1.Size = new System.Drawing.Size(754, 304);
            this.listBox1.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 55);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 29);
            this.label1.TabIndex = 4;
            this.label1.Text = "How to Play";
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Broadway", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(413, 448);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(101, 51);
            this.btnClose.TabIndex = 6;
            this.btnClose.Text = "&Ok";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmInstruction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Goldenrod;
            this.ClientSize = new System.Drawing.Size(926, 528);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmInstruction";
            this.Text = "Instructions";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnClose;
    }
}