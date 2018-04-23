namespace LiarDice_grpProjCS
{
    partial class frmMain
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblCreators = new System.Windows.Forms.Label();
            this.btnNewGame = new System.Windows.Forms.Button();
            this.btnInstructions = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnWinners = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTitle.Font = new System.Drawing.Font("Broadway", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.DimGray;
            this.lblTitle.Location = new System.Drawing.Point(38, 142);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(576, 111);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Liar\'s Dice";
            // 
            // lblCreators
            // 
            this.lblCreators.Font = new System.Drawing.Font("Arial Narrow", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreators.ForeColor = System.Drawing.Color.DimGray;
            this.lblCreators.Location = new System.Drawing.Point(177, 282);
            this.lblCreators.Name = "lblCreators";
            this.lblCreators.Size = new System.Drawing.Size(308, 114);
            this.lblCreators.TabIndex = 1;
            this.lblCreators.Text = "A Game By \r\nEdward W and Michael E\r\n";
            this.lblCreators.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnNewGame
            // 
            this.btnNewGame.Font = new System.Drawing.Font("Broadway", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewGame.Location = new System.Drawing.Point(66, 412);
            this.btnNewGame.Name = "btnNewGame";
            this.btnNewGame.Size = new System.Drawing.Size(102, 66);
            this.btnNewGame.TabIndex = 2;
            this.btnNewGame.Text = "&New Game";
            this.btnNewGame.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnNewGame.UseVisualStyleBackColor = true;
            this.btnNewGame.Click += new System.EventHandler(this.btnNewGame_Click);
            // 
            // btnInstructions
            // 
            this.btnInstructions.Font = new System.Drawing.Font("Broadway", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInstructions.Location = new System.Drawing.Point(174, 412);
            this.btnInstructions.Name = "btnInstructions";
            this.btnInstructions.Size = new System.Drawing.Size(177, 66);
            this.btnInstructions.TabIndex = 3;
            this.btnInstructions.Text = "&Instructions";
            this.btnInstructions.UseVisualStyleBackColor = true;
            this.btnInstructions.Click += new System.EventHandler(this.btnInstructions_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Broadway", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(488, 412);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(102, 66);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnWinners
            // 
            this.btnWinners.Font = new System.Drawing.Font("Broadway", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWinners.Location = new System.Drawing.Point(357, 412);
            this.btnWinners.Name = "btnWinners";
            this.btnWinners.Size = new System.Drawing.Size(124, 66);
            this.btnWinners.TabIndex = 5;
            this.btnWinners.Text = "&Winners";
            this.btnWinners.UseVisualStyleBackColor = true;
            this.btnWinners.Click += new System.EventHandler(this.btnWinners_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Goldenrod;
            this.ClientSize = new System.Drawing.Size(654, 571);
            this.Controls.Add(this.btnWinners);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnInstructions);
            this.Controls.Add(this.btnNewGame);
            this.Controls.Add(this.lblCreators);
            this.Controls.Add(this.lblTitle);
            this.Name = "frmMain";
            this.Text = "Lair\'s Dice";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblCreators;
        private System.Windows.Forms.Button btnNewGame;
        private System.Windows.Forms.Button btnInstructions;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnWinners;
    }
}

