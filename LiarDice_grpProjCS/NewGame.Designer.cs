namespace LiarDice_grpProjCS
{
    partial class NewGame
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
            this.GpPlayerCount = new System.Windows.Forms.Panel();
            this.btnNewGame = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.rdoSingle = new System.Windows.Forms.RadioButton();
            this.rdoTwo = new System.Windows.Forms.RadioButton();
            this.rdoThree = new System.Windows.Forms.RadioButton();
            this.GpPlayerCount.SuspendLayout();
            this.SuspendLayout();
            // 
            // GpPlayerCount
            // 
            this.GpPlayerCount.Controls.Add(this.rdoThree);
            this.GpPlayerCount.Controls.Add(this.rdoTwo);
            this.GpPlayerCount.Controls.Add(this.rdoSingle);
            this.GpPlayerCount.Controls.Add(this.label1);
            this.GpPlayerCount.Location = new System.Drawing.Point(70, 166);
            this.GpPlayerCount.Name = "GpPlayerCount";
            this.GpPlayerCount.Size = new System.Drawing.Size(661, 288);
            this.GpPlayerCount.TabIndex = 1;
            // 
            // btnNewGame
            // 
            this.btnNewGame.Font = new System.Drawing.Font("Broadway", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewGame.Location = new System.Drawing.Point(557, 500);
            this.btnNewGame.Name = "btnNewGame";
            this.btnNewGame.Size = new System.Drawing.Size(174, 83);
            this.btnNewGame.TabIndex = 3;
            this.btnNewGame.Text = "&Start!";
            this.btnNewGame.UseVisualStyleBackColor = true;
            this.btnNewGame.Click += new System.EventHandler(this.btnNewGame_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Broadway", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(70, 500);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(174, 83);
            this.button1.TabIndex = 4;
            this.button1.Text = "C&ancel";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(321, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "How Many Players(Difficulty):";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Broadway", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(84, 45);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(607, 72);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "New Game Setup";
            // 
            // rdoSingle
            // 
            this.rdoSingle.AutoSize = true;
            this.rdoSingle.Font = new System.Drawing.Font("Arial Narrow", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoSingle.Location = new System.Drawing.Point(26, 109);
            this.rdoSingle.Name = "rdoSingle";
            this.rdoSingle.Size = new System.Drawing.Size(197, 35);
            this.rdoSingle.TabIndex = 5;
            this.rdoSingle.TabStop = true;
            this.rdoSingle.Text = "You Vs 1(Easy)";
            this.rdoSingle.UseVisualStyleBackColor = true;
            // 
            // rdoTwo
            // 
            this.rdoTwo.AutoSize = true;
            this.rdoTwo.Font = new System.Drawing.Font("Arial Narrow", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoTwo.Location = new System.Drawing.Point(225, 109);
            this.rdoTwo.Name = "rdoTwo";
            this.rdoTwo.Size = new System.Drawing.Size(225, 35);
            this.rdoTwo.TabIndex = 6;
            this.rdoTwo.TabStop = true;
            this.rdoTwo.Text = "You Vs 2(Medium)";
            this.rdoTwo.UseVisualStyleBackColor = true;
            // 
            // rdoThree
            // 
            this.rdoThree.AutoSize = true;
            this.rdoThree.Font = new System.Drawing.Font("Arial Narrow", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoThree.Location = new System.Drawing.Point(456, 109);
            this.rdoThree.Name = "rdoThree";
            this.rdoThree.Size = new System.Drawing.Size(195, 35);
            this.rdoThree.TabIndex = 7;
            this.rdoThree.TabStop = true;
            this.rdoThree.Text = "You Vs 3(Hard)";
            this.rdoThree.UseVisualStyleBackColor = true;
            // 
            // NewGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 634);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnNewGame);
            this.Controls.Add(this.GpPlayerCount);
            this.Name = "NewGame";
            this.Text = "New Game";
            this.GpPlayerCount.ResumeLayout(false);
            this.GpPlayerCount.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel GpPlayerCount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnNewGame;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton rdoThree;
        private System.Windows.Forms.RadioButton rdoTwo;
        private System.Windows.Forms.RadioButton rdoSingle;
        private System.Windows.Forms.Label lblTitle;
    }
}