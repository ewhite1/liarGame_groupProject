namespace LiarDice_grpProjCS
{
    partial class frmPlayerSelect
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
            this.btnStart = new System.Windows.Forms.Button();
            this.rdoThreeCPU = new System.Windows.Forms.RadioButton();
            this.rdoTwoCPU = new System.Windows.Forms.RadioButton();
            this.tbxPlayerName = new System.Windows.Forms.TextBox();
            this.rdoOneCPU = new System.Windows.Forms.RadioButton();
            this.lblPlayerName = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("Broadway", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Location = new System.Drawing.Point(257, 624);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(346, 102);
            this.btnStart.TabIndex = 2;
            this.btnStart.Text = "S&tart Game!";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // rdoThreeCPU
            // 
            this.rdoThreeCPU.AutoSize = true;
            this.rdoThreeCPU.Font = new System.Drawing.Font("Broadway", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoThreeCPU.Location = new System.Drawing.Point(257, 279);
            this.rdoThreeCPU.Name = "rdoThreeCPU";
            this.rdoThreeCPU.Size = new System.Drawing.Size(683, 52);
            this.rdoThreeCPU.TabIndex = 8;
            this.rdoThreeCPU.TabStop = true;
            this.rdoThreeCPU.Text = "Two Cpu Players (medium)";
            this.rdoThreeCPU.UseVisualStyleBackColor = true;
            // 
            // rdoTwoCPU
            // 
            this.rdoTwoCPU.AutoSize = true;
            this.rdoTwoCPU.Font = new System.Drawing.Font("Broadway", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoTwoCPU.Location = new System.Drawing.Point(257, 365);
            this.rdoTwoCPU.Name = "rdoTwoCPU";
            this.rdoTwoCPU.Size = new System.Drawing.Size(640, 52);
            this.rdoTwoCPU.TabIndex = 7;
            this.rdoTwoCPU.TabStop = true;
            this.rdoTwoCPU.Text = "Three Cpu Players (Hard)";
            this.rdoTwoCPU.UseVisualStyleBackColor = true;
            // 
            // tbxPlayerName
            // 
            this.tbxPlayerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxPlayerName.Location = new System.Drawing.Point(512, 466);
            this.tbxPlayerName.Name = "tbxPlayerName";
            this.tbxPlayerName.Size = new System.Drawing.Size(396, 40);
            this.tbxPlayerName.TabIndex = 6;
            // 
            // rdoOneCPU
            // 
            this.rdoOneCPU.AutoSize = true;
            this.rdoOneCPU.Font = new System.Drawing.Font("Broadway", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoOneCPU.Location = new System.Drawing.Point(257, 193);
            this.rdoOneCPU.Name = "rdoOneCPU";
            this.rdoOneCPU.Size = new System.Drawing.Size(557, 52);
            this.rdoOneCPU.TabIndex = 4;
            this.rdoOneCPU.TabStop = true;
            this.rdoOneCPU.Text = "One Cpu Player (easy)";
            this.rdoOneCPU.UseVisualStyleBackColor = true;
            // 
            // lblPlayerName
            // 
            this.lblPlayerName.AutoSize = true;
            this.lblPlayerName.Font = new System.Drawing.Font("Broadway", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerName.Location = new System.Drawing.Point(250, 464);
            this.lblPlayerName.Name = "lblPlayerName";
            this.lblPlayerName.Size = new System.Drawing.Size(256, 42);
            this.lblPlayerName.TabIndex = 5;
            this.lblPlayerName.Text = "Your Name:";
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Broadway", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(665, 624);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(275, 102);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "C&ancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // frmPlayerSelect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Goldenrod;
            this.ClientSize = new System.Drawing.Size(1190, 813);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.rdoThreeCPU);
            this.Controls.Add(this.rdoTwoCPU);
            this.Controls.Add(this.tbxPlayerName);
            this.Controls.Add(this.rdoOneCPU);
            this.Controls.Add(this.lblPlayerName);
            this.Controls.Add(this.btnStart);
            this.Name = "frmPlayerSelect";
            this.Text = "New Game";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.RadioButton rdoThreeCPU;
        private System.Windows.Forms.RadioButton rdoTwoCPU;
        private System.Windows.Forms.TextBox tbxPlayerName;
        private System.Windows.Forms.RadioButton rdoOneCPU;
        private System.Windows.Forms.Label lblPlayerName;
        private System.Windows.Forms.Button btnCancel;
    }
}