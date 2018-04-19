namespace LiarDice_grpProjCS
{
    partial class frmWinners
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
            this.lblPlayer = new System.Windows.Forms.Label();
            this.lblcpu1 = new System.Windows.Forms.Label();
            this.lblcpu2 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblcpu3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblPlayerResult = new System.Windows.Forms.Label();
            this.lblCpu2Result = new System.Windows.Forms.Label();
            this.lblCpu1Result = new System.Windows.Forms.Label();
            this.lblCpu3Result = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblPlayer
            // 
            this.lblPlayer.AutoSize = true;
            this.lblPlayer.Font = new System.Drawing.Font("Broadway", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayer.ForeColor = System.Drawing.SystemColors.Control;
            this.lblPlayer.Location = new System.Drawing.Point(194, 152);
            this.lblPlayer.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPlayer.Name = "lblPlayer";
            this.lblPlayer.Size = new System.Drawing.Size(343, 41);
            this.lblPlayer.TabIndex = 0;
            this.lblPlayer.Text = "Games You Won:";
            // 
            // lblcpu1
            // 
            this.lblcpu1.AutoSize = true;
            this.lblcpu1.Font = new System.Drawing.Font("Broadway", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcpu1.ForeColor = System.Drawing.SystemColors.Control;
            this.lblcpu1.Location = new System.Drawing.Point(28, 249);
            this.lblcpu1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblcpu1.Name = "lblcpu1";
            this.lblcpu1.Size = new System.Drawing.Size(509, 41);
            this.lblcpu1.TabIndex = 1;
            this.lblcpu1.Text = "Games Cpu player 1 won:";
            // 
            // lblcpu2
            // 
            this.lblcpu2.AutoSize = true;
            this.lblcpu2.Font = new System.Drawing.Font("Broadway", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcpu2.ForeColor = System.Drawing.SystemColors.Control;
            this.lblcpu2.Location = new System.Drawing.Point(28, 346);
            this.lblcpu2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblcpu2.Name = "lblcpu2";
            this.lblcpu2.Size = new System.Drawing.Size(510, 41);
            this.lblcpu2.TabIndex = 2;
            this.lblcpu2.Text = "Games Cpu Player 2 won:";
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Broadway", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(310, 579);
            this.btnClose.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(138, 58);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "D&ismiss";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblcpu3
            // 
            this.lblcpu3.AutoSize = true;
            this.lblcpu3.Font = new System.Drawing.Font("Broadway", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcpu3.ForeColor = System.Drawing.SystemColors.Control;
            this.lblcpu3.Location = new System.Drawing.Point(33, 443);
            this.lblcpu3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblcpu3.Name = "lblcpu3";
            this.lblcpu3.Size = new System.Drawing.Size(510, 41);
            this.lblcpu3.TabIndex = 5;
            this.lblcpu3.Text = "Games Cpu Player 3 won:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.NavajoWhite;
            this.label1.Font = new System.Drawing.Font("Broadway", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(116, 53);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(560, 41);
            this.label1.TabIndex = 6;
            this.label1.Text = "Rounds Won by Each Player";
            // 
            // lblPlayerResult
            // 
            this.lblPlayerResult.AutoSize = true;
            this.lblPlayerResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblPlayerResult.Font = new System.Drawing.Font("Broadway", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerResult.ForeColor = System.Drawing.SystemColors.Control;
            this.lblPlayerResult.Location = new System.Drawing.Point(560, 152);
            this.lblPlayerResult.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPlayerResult.Name = "lblPlayerResult";
            this.lblPlayerResult.Size = new System.Drawing.Size(43, 43);
            this.lblPlayerResult.TabIndex = 7;
            this.lblPlayerResult.Text = "0";
            // 
            // lblCpu2Result
            // 
            this.lblCpu2Result.AutoSize = true;
            this.lblCpu2Result.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCpu2Result.Font = new System.Drawing.Font("Broadway", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCpu2Result.ForeColor = System.Drawing.SystemColors.Control;
            this.lblCpu2Result.Location = new System.Drawing.Point(560, 346);
            this.lblCpu2Result.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCpu2Result.Name = "lblCpu2Result";
            this.lblCpu2Result.Size = new System.Drawing.Size(43, 43);
            this.lblCpu2Result.TabIndex = 8;
            this.lblCpu2Result.Text = "0";
            // 
            // lblCpu1Result
            // 
            this.lblCpu1Result.AutoSize = true;
            this.lblCpu1Result.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCpu1Result.Font = new System.Drawing.Font("Broadway", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCpu1Result.ForeColor = System.Drawing.SystemColors.Control;
            this.lblCpu1Result.Location = new System.Drawing.Point(560, 249);
            this.lblCpu1Result.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCpu1Result.Name = "lblCpu1Result";
            this.lblCpu1Result.Size = new System.Drawing.Size(43, 43);
            this.lblCpu1Result.TabIndex = 9;
            this.lblCpu1Result.Text = "0";
            // 
            // lblCpu3Result
            // 
            this.lblCpu3Result.AutoSize = true;
            this.lblCpu3Result.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCpu3Result.Font = new System.Drawing.Font("Broadway", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCpu3Result.ForeColor = System.Drawing.SystemColors.Control;
            this.lblCpu3Result.Location = new System.Drawing.Point(560, 443);
            this.lblCpu3Result.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCpu3Result.Name = "lblCpu3Result";
            this.lblCpu3Result.Size = new System.Drawing.Size(43, 43);
            this.lblCpu3Result.TabIndex = 10;
            this.lblCpu3Result.Text = "0";
            // 
            // frmWinners
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Goldenrod;
            this.ClientSize = new System.Drawing.Size(790, 665);
            this.Controls.Add(this.lblCpu3Result);
            this.Controls.Add(this.lblCpu1Result);
            this.Controls.Add(this.lblCpu2Result);
            this.Controls.Add(this.lblPlayerResult);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblcpu3);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblcpu2);
            this.Controls.Add(this.lblcpu1);
            this.Controls.Add(this.lblPlayer);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmWinners";
            this.Text = "Wins All Time";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPlayer;
        private System.Windows.Forms.Label lblcpu1;
        private System.Windows.Forms.Label lblcpu2;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblcpu3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblPlayerResult;
        private System.Windows.Forms.Label lblCpu2Result;
        private System.Windows.Forms.Label lblCpu1Result;
        private System.Windows.Forms.Label lblCpu3Result;
    }
}