namespace LiarDice_grpProjCS
{
    partial class frmGame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGame));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.gameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.titleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.highScoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.instructionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Label1 = new System.Windows.Forms.Label();
            this.lstDiceBetNum = new System.Windows.Forms.ListBox();
            this.btnBet = new System.Windows.Forms.Button();
            this.pbxDie6 = new System.Windows.Forms.PictureBox();
            this.pbxDie5 = new System.Windows.Forms.PictureBox();
            this.pbxDie3 = new System.Windows.Forms.PictureBox();
            this.pbxDie4 = new System.Windows.Forms.PictureBox();
            this.pbxDie2 = new System.Windows.Forms.PictureBox();
            this.pbxDie1 = new System.Windows.Forms.PictureBox();
            this.lblDie1Out = new System.Windows.Forms.Label();
            this.lblDie2Out = new System.Windows.Forms.Label();
            this.lblDie3Out = new System.Windows.Forms.Label();
            this.lblDie4Out = new System.Windows.Forms.Label();
            this.lblDie5Out = new System.Windows.Forms.Label();
            this.lblDie6Out = new System.Windows.Forms.Label();
            this.btnRoll = new System.Windows.Forms.Button();
            this.lblComputer1BetNum = new System.Windows.Forms.Label();
            this.lblComputer1BetValue = new System.Windows.Forms.Label();
            this.lblComputer2BetNum = new System.Windows.Forms.Label();
            this.lblComputer2BetValue = new System.Windows.Forms.Label();
            this.lblComputer3BetNum = new System.Windows.Forms.Label();
            this.lblComputer3BetValue = new System.Windows.Forms.Label();
            this.lblComputer1D1 = new System.Windows.Forms.Label();
            this.lblComputer1D2 = new System.Windows.Forms.Label();
            this.lblComputer1D3 = new System.Windows.Forms.Label();
            this.lblComputer1D4 = new System.Windows.Forms.Label();
            this.lblComputer1D5 = new System.Windows.Forms.Label();
            this.lblComputer1D6 = new System.Windows.Forms.Label();
            this.lblComputer2D6 = new System.Windows.Forms.Label();
            this.lblComputer2D5 = new System.Windows.Forms.Label();
            this.lblComputer2D4 = new System.Windows.Forms.Label();
            this.lblComputer2D3 = new System.Windows.Forms.Label();
            this.lblComputer2D2 = new System.Windows.Forms.Label();
            this.lblComputer2D1 = new System.Windows.Forms.Label();
            this.lblComputer3D6 = new System.Windows.Forms.Label();
            this.lblComputer3D5 = new System.Windows.Forms.Label();
            this.lblComputer3D4 = new System.Windows.Forms.Label();
            this.lblComputer3D3 = new System.Windows.Forms.Label();
            this.lblComputer3D2 = new System.Windows.Forms.Label();
            this.lblComputer3D1 = new System.Windows.Forms.Label();
            this.lblDie1Count = new System.Windows.Forms.Label();
            this.lblDie2Count = new System.Windows.Forms.Label();
            this.lblDie3Count = new System.Windows.Forms.Label();
            this.lblDie4Count = new System.Windows.Forms.Label();
            this.lblDie5Count = new System.Windows.Forms.Label();
            this.lblDie6Count = new System.Windows.Forms.Label();
            this.btnPlayer1Challenge = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxDie6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxDie5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxDie3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxDie4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxDie2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxDie1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gameToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1126, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // gameToolStripMenuItem
            // 
            this.gameToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.titleToolStripMenuItem,
            this.highScoresToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.gameToolStripMenuItem.Name = "gameToolStripMenuItem";
            this.gameToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.gameToolStripMenuItem.Text = "&Game";
            // 
            // titleToolStripMenuItem
            // 
            this.titleToolStripMenuItem.Name = "titleToolStripMenuItem";
            this.titleToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.titleToolStripMenuItem.Text = "&Title";
            this.titleToolStripMenuItem.Click += new System.EventHandler(this.titleToolStripMenuItem_Click);
            // 
            // highScoresToolStripMenuItem
            // 
            this.highScoresToolStripMenuItem.Name = "highScoresToolStripMenuItem";
            this.highScoresToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.highScoresToolStripMenuItem.Text = "&High Scores";
            this.highScoresToolStripMenuItem.Click += new System.EventHandler(this.highScoresToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.exitToolStripMenuItem.Text = "&Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.instructionsToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // instructionsToolStripMenuItem
            // 
            this.instructionsToolStripMenuItem.Name = "instructionsToolStripMenuItem";
            this.instructionsToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.instructionsToolStripMenuItem.Text = "&Instructions";
            this.instructionsToolStripMenuItem.Click += new System.EventHandler(this.instructionsToolStripMenuItem_Click);
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(454, 578);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(219, 26);
            this.Label1.TabIndex = 12;
            this.Label1.Text = "Select a die value and number of dice to bet.\r\nClick bet when finished";
            this.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lstDiceBetNum
            // 
            this.lstDiceBetNum.BackColor = System.Drawing.Color.Goldenrod;
            this.lstDiceBetNum.FormattingEnabled = true;
            this.lstDiceBetNum.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20"});
            this.lstDiceBetNum.Location = new System.Drawing.Point(254, 593);
            this.lstDiceBetNum.Name = "lstDiceBetNum";
            this.lstDiceBetNum.ScrollAlwaysVisible = true;
            this.lstDiceBetNum.Size = new System.Drawing.Size(78, 95);
            this.lstDiceBetNum.TabIndex = 13;
            // 
            // btnBet
            // 
            this.btnBet.Location = new System.Drawing.Point(462, 679);
            this.btnBet.Name = "btnBet";
            this.btnBet.Size = new System.Drawing.Size(89, 49);
            this.btnBet.TabIndex = 14;
            this.btnBet.Text = "&Bet";
            this.btnBet.UseVisualStyleBackColor = true;
            this.btnBet.Click += new System.EventHandler(this.btnBet_Click);
            // 
            // pbxDie6
            // 
            this.pbxDie6.Image = global::LiarDice_grpProjCS.Properties.Resources.Die6;
            this.pbxDie6.Location = new System.Drawing.Point(733, 607);
            this.pbxDie6.Name = "pbxDie6";
            this.pbxDie6.Size = new System.Drawing.Size(55, 55);
            this.pbxDie6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxDie6.TabIndex = 11;
            this.pbxDie6.TabStop = false;
            this.pbxDie6.Click += new System.EventHandler(this.pbxDie6_Click);
            // 
            // pbxDie5
            // 
            this.pbxDie5.Image = global::LiarDice_grpProjCS.Properties.Resources.Die5;
            this.pbxDie5.Location = new System.Drawing.Point(654, 607);
            this.pbxDie5.Name = "pbxDie5";
            this.pbxDie5.Size = new System.Drawing.Size(55, 55);
            this.pbxDie5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxDie5.TabIndex = 10;
            this.pbxDie5.TabStop = false;
            this.pbxDie5.Click += new System.EventHandler(this.pbxDie5_Click);
            // 
            // pbxDie3
            // 
            this.pbxDie3.Image = global::LiarDice_grpProjCS.Properties.Resources.Die3;
            this.pbxDie3.Location = new System.Drawing.Point(496, 607);
            this.pbxDie3.Name = "pbxDie3";
            this.pbxDie3.Size = new System.Drawing.Size(55, 55);
            this.pbxDie3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxDie3.TabIndex = 9;
            this.pbxDie3.TabStop = false;
            this.pbxDie3.Click += new System.EventHandler(this.pbxDie3_Click);
            // 
            // pbxDie4
            // 
            this.pbxDie4.Image = global::LiarDice_grpProjCS.Properties.Resources.Die4;
            this.pbxDie4.Location = new System.Drawing.Point(575, 607);
            this.pbxDie4.Name = "pbxDie4";
            this.pbxDie4.Size = new System.Drawing.Size(55, 55);
            this.pbxDie4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxDie4.TabIndex = 8;
            this.pbxDie4.TabStop = false;
            this.pbxDie4.Click += new System.EventHandler(this.pbxDie4_Click);
            // 
            // pbxDie2
            // 
            this.pbxDie2.Image = global::LiarDice_grpProjCS.Properties.Resources.Die2;
            this.pbxDie2.Location = new System.Drawing.Point(417, 607);
            this.pbxDie2.Name = "pbxDie2";
            this.pbxDie2.Size = new System.Drawing.Size(55, 55);
            this.pbxDie2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxDie2.TabIndex = 7;
            this.pbxDie2.TabStop = false;
            this.pbxDie2.Click += new System.EventHandler(this.pbxDie2_Click);
            // 
            // pbxDie1
            // 
            this.pbxDie1.Image = ((System.Drawing.Image)(resources.GetObject("pbxDie1.Image")));
            this.pbxDie1.Location = new System.Drawing.Point(338, 607);
            this.pbxDie1.Name = "pbxDie1";
            this.pbxDie1.Size = new System.Drawing.Size(55, 55);
            this.pbxDie1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxDie1.TabIndex = 6;
            this.pbxDie1.TabStop = false;
            this.pbxDie1.Click += new System.EventHandler(this.pbxDie1_Click);
            // 
            // lblDie1Out
            // 
            this.lblDie1Out.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblDie1Out.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblDie1Out.Location = new System.Drawing.Point(723, 679);
            this.lblDie1Out.Name = "lblDie1Out";
            this.lblDie1Out.Size = new System.Drawing.Size(54, 23);
            this.lblDie1Out.TabIndex = 15;
            // 
            // lblDie2Out
            // 
            this.lblDie2Out.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblDie2Out.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblDie2Out.Location = new System.Drawing.Point(783, 679);
            this.lblDie2Out.Name = "lblDie2Out";
            this.lblDie2Out.Size = new System.Drawing.Size(54, 23);
            this.lblDie2Out.TabIndex = 16;
            // 
            // lblDie3Out
            // 
            this.lblDie3Out.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblDie3Out.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblDie3Out.Location = new System.Drawing.Point(843, 679);
            this.lblDie3Out.Name = "lblDie3Out";
            this.lblDie3Out.Size = new System.Drawing.Size(54, 23);
            this.lblDie3Out.TabIndex = 17;
            // 
            // lblDie4Out
            // 
            this.lblDie4Out.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblDie4Out.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblDie4Out.Location = new System.Drawing.Point(903, 679);
            this.lblDie4Out.Name = "lblDie4Out";
            this.lblDie4Out.Size = new System.Drawing.Size(54, 23);
            this.lblDie4Out.TabIndex = 18;
            // 
            // lblDie5Out
            // 
            this.lblDie5Out.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblDie5Out.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblDie5Out.Location = new System.Drawing.Point(963, 679);
            this.lblDie5Out.Name = "lblDie5Out";
            this.lblDie5Out.Size = new System.Drawing.Size(54, 23);
            this.lblDie5Out.TabIndex = 19;
            // 
            // lblDie6Out
            // 
            this.lblDie6Out.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblDie6Out.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblDie6Out.Location = new System.Drawing.Point(1023, 679);
            this.lblDie6Out.Name = "lblDie6Out";
            this.lblDie6Out.Size = new System.Drawing.Size(54, 23);
            this.lblDie6Out.TabIndex = 20;
            // 
            // btnRoll
            // 
            this.btnRoll.Location = new System.Drawing.Point(855, 718);
            this.btnRoll.Name = "btnRoll";
            this.btnRoll.Size = new System.Drawing.Size(75, 23);
            this.btnRoll.TabIndex = 21;
            this.btnRoll.Text = "&ShowDice";
            this.btnRoll.UseVisualStyleBackColor = true;
            this.btnRoll.Click += new System.EventHandler(this.btnRoll_Click);
            // 
            // lblComputer1BetNum
            // 
            this.lblComputer1BetNum.AutoSize = true;
            this.lblComputer1BetNum.Location = new System.Drawing.Point(270, 310);
            this.lblComputer1BetNum.Name = "lblComputer1BetNum";
            this.lblComputer1BetNum.Size = new System.Drawing.Size(96, 13);
            this.lblComputer1BetNum.TabIndex = 22;
            this.lblComputer1BetNum.Text = "Computer1BetNum";
            // 
            // lblComputer1BetValue
            // 
            this.lblComputer1BetValue.AutoSize = true;
            this.lblComputer1BetValue.Location = new System.Drawing.Point(372, 310);
            this.lblComputer1BetValue.Name = "lblComputer1BetValue";
            this.lblComputer1BetValue.Size = new System.Drawing.Size(89, 13);
            this.lblComputer1BetValue.TabIndex = 23;
            this.lblComputer1BetValue.Text = "Computer1BetVal";
            // 
            // lblComputer2BetNum
            // 
            this.lblComputer2BetNum.AutoSize = true;
            this.lblComputer2BetNum.Location = new System.Drawing.Point(481, 137);
            this.lblComputer2BetNum.Name = "lblComputer2BetNum";
            this.lblComputer2BetNum.Size = new System.Drawing.Size(96, 13);
            this.lblComputer2BetNum.TabIndex = 24;
            this.lblComputer2BetNum.Text = "Computer2BetNum";
            // 
            // lblComputer2BetValue
            // 
            this.lblComputer2BetValue.AutoSize = true;
            this.lblComputer2BetValue.Location = new System.Drawing.Point(584, 137);
            this.lblComputer2BetValue.Name = "lblComputer2BetValue";
            this.lblComputer2BetValue.Size = new System.Drawing.Size(89, 13);
            this.lblComputer2BetValue.TabIndex = 25;
            this.lblComputer2BetValue.Text = "Computer2BetVal";
            // 
            // lblComputer3BetNum
            // 
            this.lblComputer3BetNum.AutoSize = true;
            this.lblComputer3BetNum.Location = new System.Drawing.Point(692, 310);
            this.lblComputer3BetNum.Name = "lblComputer3BetNum";
            this.lblComputer3BetNum.Size = new System.Drawing.Size(96, 13);
            this.lblComputer3BetNum.TabIndex = 26;
            this.lblComputer3BetNum.Text = "Computer3BetNum";
            // 
            // lblComputer3BetValue
            // 
            this.lblComputer3BetValue.AutoSize = true;
            this.lblComputer3BetValue.Location = new System.Drawing.Point(794, 310);
            this.lblComputer3BetValue.Name = "lblComputer3BetValue";
            this.lblComputer3BetValue.Size = new System.Drawing.Size(89, 13);
            this.lblComputer3BetValue.TabIndex = 27;
            this.lblComputer3BetValue.Text = "Computer3BetVal";
            // 
            // lblComputer1D1
            // 
            this.lblComputer1D1.AutoSize = true;
            this.lblComputer1D1.Location = new System.Drawing.Point(51, 265);
            this.lblComputer1D1.Name = "lblComputer1D1";
            this.lblComputer1D1.Size = new System.Drawing.Size(71, 13);
            this.lblComputer1D1.TabIndex = 28;
            this.lblComputer1D1.Text = "computer1D1";
            // 
            // lblComputer1D2
            // 
            this.lblComputer1D2.AutoSize = true;
            this.lblComputer1D2.Location = new System.Drawing.Point(51, 287);
            this.lblComputer1D2.Name = "lblComputer1D2";
            this.lblComputer1D2.Size = new System.Drawing.Size(71, 13);
            this.lblComputer1D2.TabIndex = 29;
            this.lblComputer1D2.Text = "computer1D2";
            // 
            // lblComputer1D3
            // 
            this.lblComputer1D3.AutoSize = true;
            this.lblComputer1D3.Location = new System.Drawing.Point(51, 310);
            this.lblComputer1D3.Name = "lblComputer1D3";
            this.lblComputer1D3.Size = new System.Drawing.Size(71, 13);
            this.lblComputer1D3.TabIndex = 30;
            this.lblComputer1D3.Text = "computer1D3";
            // 
            // lblComputer1D4
            // 
            this.lblComputer1D4.AutoSize = true;
            this.lblComputer1D4.Location = new System.Drawing.Point(51, 332);
            this.lblComputer1D4.Name = "lblComputer1D4";
            this.lblComputer1D4.Size = new System.Drawing.Size(71, 13);
            this.lblComputer1D4.TabIndex = 31;
            this.lblComputer1D4.Text = "computer1D4";
            // 
            // lblComputer1D5
            // 
            this.lblComputer1D5.AutoSize = true;
            this.lblComputer1D5.Location = new System.Drawing.Point(51, 354);
            this.lblComputer1D5.Name = "lblComputer1D5";
            this.lblComputer1D5.Size = new System.Drawing.Size(71, 13);
            this.lblComputer1D5.TabIndex = 32;
            this.lblComputer1D5.Text = "computer1D5";
            // 
            // lblComputer1D6
            // 
            this.lblComputer1D6.AutoSize = true;
            this.lblComputer1D6.Location = new System.Drawing.Point(51, 377);
            this.lblComputer1D6.Name = "lblComputer1D6";
            this.lblComputer1D6.Size = new System.Drawing.Size(71, 13);
            this.lblComputer1D6.TabIndex = 33;
            this.lblComputer1D6.Text = "computer1D6";
            // 
            // lblComputer2D6
            // 
            this.lblComputer2D6.AutoSize = true;
            this.lblComputer2D6.Location = new System.Drawing.Point(527, 102);
            this.lblComputer2D6.Name = "lblComputer2D6";
            this.lblComputer2D6.Size = new System.Drawing.Size(71, 13);
            this.lblComputer2D6.TabIndex = 39;
            this.lblComputer2D6.Text = "computer2D6";
            // 
            // lblComputer2D5
            // 
            this.lblComputer2D5.AutoSize = true;
            this.lblComputer2D5.Location = new System.Drawing.Point(527, 89);
            this.lblComputer2D5.Name = "lblComputer2D5";
            this.lblComputer2D5.Size = new System.Drawing.Size(71, 13);
            this.lblComputer2D5.TabIndex = 38;
            this.lblComputer2D5.Text = "computer2D5";
            // 
            // lblComputer2D4
            // 
            this.lblComputer2D4.AutoSize = true;
            this.lblComputer2D4.Location = new System.Drawing.Point(527, 76);
            this.lblComputer2D4.Name = "lblComputer2D4";
            this.lblComputer2D4.Size = new System.Drawing.Size(71, 13);
            this.lblComputer2D4.TabIndex = 37;
            this.lblComputer2D4.Text = "computer2D4";
            // 
            // lblComputer2D3
            // 
            this.lblComputer2D3.AutoSize = true;
            this.lblComputer2D3.Location = new System.Drawing.Point(527, 63);
            this.lblComputer2D3.Name = "lblComputer2D3";
            this.lblComputer2D3.Size = new System.Drawing.Size(71, 13);
            this.lblComputer2D3.TabIndex = 36;
            this.lblComputer2D3.Text = "computer2D3";
            // 
            // lblComputer2D2
            // 
            this.lblComputer2D2.AutoSize = true;
            this.lblComputer2D2.Location = new System.Drawing.Point(527, 50);
            this.lblComputer2D2.Name = "lblComputer2D2";
            this.lblComputer2D2.Size = new System.Drawing.Size(71, 13);
            this.lblComputer2D2.TabIndex = 35;
            this.lblComputer2D2.Text = "computer2D2";
            // 
            // lblComputer2D1
            // 
            this.lblComputer2D1.AutoSize = true;
            this.lblComputer2D1.Location = new System.Drawing.Point(527, 37);
            this.lblComputer2D1.Name = "lblComputer2D1";
            this.lblComputer2D1.Size = new System.Drawing.Size(72, 13);
            this.lblComputer2D1.TabIndex = 34;
            this.lblComputer2D1.Text = "Computer2D1";
            // 
            // lblComputer3D6
            // 
            this.lblComputer3D6.AutoSize = true;
            this.lblComputer3D6.Location = new System.Drawing.Point(981, 370);
            this.lblComputer3D6.Name = "lblComputer3D6";
            this.lblComputer3D6.Size = new System.Drawing.Size(71, 13);
            this.lblComputer3D6.TabIndex = 45;
            this.lblComputer3D6.Text = "computer3D6";
            // 
            // lblComputer3D5
            // 
            this.lblComputer3D5.AutoSize = true;
            this.lblComputer3D5.Location = new System.Drawing.Point(981, 349);
            this.lblComputer3D5.Name = "lblComputer3D5";
            this.lblComputer3D5.Size = new System.Drawing.Size(71, 13);
            this.lblComputer3D5.TabIndex = 44;
            this.lblComputer3D5.Text = "computer3D5";
            // 
            // lblComputer3D4
            // 
            this.lblComputer3D4.AutoSize = true;
            this.lblComputer3D4.Location = new System.Drawing.Point(981, 328);
            this.lblComputer3D4.Name = "lblComputer3D4";
            this.lblComputer3D4.Size = new System.Drawing.Size(71, 13);
            this.lblComputer3D4.TabIndex = 43;
            this.lblComputer3D4.Text = "computer3D4";
            // 
            // lblComputer3D3
            // 
            this.lblComputer3D3.AutoSize = true;
            this.lblComputer3D3.Location = new System.Drawing.Point(981, 307);
            this.lblComputer3D3.Name = "lblComputer3D3";
            this.lblComputer3D3.Size = new System.Drawing.Size(71, 13);
            this.lblComputer3D3.TabIndex = 42;
            this.lblComputer3D3.Text = "computer3D3";
            // 
            // lblComputer3D2
            // 
            this.lblComputer3D2.AutoSize = true;
            this.lblComputer3D2.Location = new System.Drawing.Point(981, 286);
            this.lblComputer3D2.Name = "lblComputer3D2";
            this.lblComputer3D2.Size = new System.Drawing.Size(71, 13);
            this.lblComputer3D2.TabIndex = 41;
            this.lblComputer3D2.Text = "computer3D2";
            // 
            // lblComputer3D1
            // 
            this.lblComputer3D1.AutoSize = true;
            this.lblComputer3D1.Location = new System.Drawing.Point(981, 265);
            this.lblComputer3D1.Name = "lblComputer3D1";
            this.lblComputer3D1.Size = new System.Drawing.Size(72, 13);
            this.lblComputer3D1.TabIndex = 40;
            this.lblComputer3D1.Text = "Computer3D1";
            // 
            // lblDie1Count
            // 
            this.lblDie1Count.AutoSize = true;
            this.lblDie1Count.Location = new System.Drawing.Point(951, 50);
            this.lblDie1Count.Name = "lblDie1Count";
            this.lblDie1Count.Size = new System.Drawing.Size(67, 13);
            this.lblDie1Count.TabIndex = 46;
            this.lblDie1Count.Text = "lblDie1Count";
            // 
            // lblDie2Count
            // 
            this.lblDie2Count.AutoSize = true;
            this.lblDie2Count.Location = new System.Drawing.Point(951, 63);
            this.lblDie2Count.Name = "lblDie2Count";
            this.lblDie2Count.Size = new System.Drawing.Size(67, 13);
            this.lblDie2Count.TabIndex = 47;
            this.lblDie2Count.Text = "lblDie2Count";
            // 
            // lblDie3Count
            // 
            this.lblDie3Count.AutoSize = true;
            this.lblDie3Count.Location = new System.Drawing.Point(951, 76);
            this.lblDie3Count.Name = "lblDie3Count";
            this.lblDie3Count.Size = new System.Drawing.Size(67, 13);
            this.lblDie3Count.TabIndex = 48;
            this.lblDie3Count.Text = "lblDie3Count";
            // 
            // lblDie4Count
            // 
            this.lblDie4Count.AutoSize = true;
            this.lblDie4Count.Location = new System.Drawing.Point(951, 89);
            this.lblDie4Count.Name = "lblDie4Count";
            this.lblDie4Count.Size = new System.Drawing.Size(67, 13);
            this.lblDie4Count.TabIndex = 49;
            this.lblDie4Count.Text = "lblDie4Count";
            // 
            // lblDie5Count
            // 
            this.lblDie5Count.AutoSize = true;
            this.lblDie5Count.Location = new System.Drawing.Point(951, 102);
            this.lblDie5Count.Name = "lblDie5Count";
            this.lblDie5Count.Size = new System.Drawing.Size(67, 13);
            this.lblDie5Count.TabIndex = 50;
            this.lblDie5Count.Text = "lblDie5Count";
            // 
            // lblDie6Count
            // 
            this.lblDie6Count.AutoSize = true;
            this.lblDie6Count.Location = new System.Drawing.Point(951, 115);
            this.lblDie6Count.Name = "lblDie6Count";
            this.lblDie6Count.Size = new System.Drawing.Size(67, 13);
            this.lblDie6Count.TabIndex = 51;
            this.lblDie6Count.Text = "lblDie6Count";
            // 
            // btnPlayer1Challenge
            // 
            this.btnPlayer1Challenge.Location = new System.Drawing.Point(575, 679);
            this.btnPlayer1Challenge.Name = "btnPlayer1Challenge";
            this.btnPlayer1Challenge.Size = new System.Drawing.Size(89, 49);
            this.btnPlayer1Challenge.TabIndex = 52;
            this.btnPlayer1Challenge.Text = "&Challenge Previous Bet";
            this.btnPlayer1Challenge.UseVisualStyleBackColor = true;
            this.btnPlayer1Challenge.Click += new System.EventHandler(this.btnPlayer1Challenge_Click);
            // 
            // frmGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Goldenrod;
            this.BackgroundImage = global::LiarDice_grpProjCS.Properties.Resources.q02th;
            this.ClientSize = new System.Drawing.Size(1126, 753);
            this.Controls.Add(this.btnPlayer1Challenge);
            this.Controls.Add(this.lblDie6Count);
            this.Controls.Add(this.lblDie5Count);
            this.Controls.Add(this.lblDie4Count);
            this.Controls.Add(this.lblDie3Count);
            this.Controls.Add(this.lblDie2Count);
            this.Controls.Add(this.lblDie1Count);
            this.Controls.Add(this.lblComputer3D6);
            this.Controls.Add(this.lblComputer3D5);
            this.Controls.Add(this.lblComputer3D4);
            this.Controls.Add(this.lblComputer3D3);
            this.Controls.Add(this.lblComputer3D2);
            this.Controls.Add(this.lblComputer3D1);
            this.Controls.Add(this.lblComputer2D6);
            this.Controls.Add(this.lblComputer2D5);
            this.Controls.Add(this.lblComputer2D4);
            this.Controls.Add(this.lblComputer2D3);
            this.Controls.Add(this.lblComputer2D2);
            this.Controls.Add(this.lblComputer2D1);
            this.Controls.Add(this.lblComputer1D6);
            this.Controls.Add(this.lblComputer1D5);
            this.Controls.Add(this.lblComputer1D4);
            this.Controls.Add(this.lblComputer1D3);
            this.Controls.Add(this.lblComputer1D2);
            this.Controls.Add(this.lblComputer1D1);
            this.Controls.Add(this.lblComputer3BetValue);
            this.Controls.Add(this.lblComputer3BetNum);
            this.Controls.Add(this.lblComputer2BetValue);
            this.Controls.Add(this.lblComputer2BetNum);
            this.Controls.Add(this.lblComputer1BetValue);
            this.Controls.Add(this.lblComputer1BetNum);
            this.Controls.Add(this.btnRoll);
            this.Controls.Add(this.lblDie6Out);
            this.Controls.Add(this.lblDie5Out);
            this.Controls.Add(this.lblDie4Out);
            this.Controls.Add(this.lblDie3Out);
            this.Controls.Add(this.lblDie2Out);
            this.Controls.Add(this.lblDie1Out);
            this.Controls.Add(this.btnBet);
            this.Controls.Add(this.lstDiceBetNum);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.pbxDie6);
            this.Controls.Add(this.pbxDie5);
            this.Controls.Add(this.pbxDie3);
            this.Controls.Add(this.pbxDie4);
            this.Controls.Add(this.pbxDie2);
            this.Controls.Add(this.pbxDie1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmGame";
            this.Text = "Liar\'s Dice";
            this.Load += new System.EventHandler(this.frmGame_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxDie6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxDie5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxDie3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxDie4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxDie2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxDie1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem gameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem titleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem highScoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem instructionsToolStripMenuItem;
        internal System.Windows.Forms.PictureBox pbxDie6;
        internal System.Windows.Forms.PictureBox pbxDie5;
        internal System.Windows.Forms.PictureBox pbxDie3;
        internal System.Windows.Forms.PictureBox pbxDie4;
        internal System.Windows.Forms.PictureBox pbxDie2;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.ListBox lstDiceBetNum;
        private System.Windows.Forms.Button btnBet;
        private System.Windows.Forms.Label lblDie2Out;
        private System.Windows.Forms.Label lblDie3Out;
        private System.Windows.Forms.Label lblDie4Out;
        private System.Windows.Forms.Label lblDie5Out;
        private System.Windows.Forms.Label lblDie6Out;
        private System.Windows.Forms.Button btnRoll;
        public System.Windows.Forms.PictureBox pbxDie1;
        public System.Windows.Forms.Label lblDie1Out;
        private System.Windows.Forms.Label lblComputer1BetNum;
        private System.Windows.Forms.Label lblComputer1BetValue;
        private System.Windows.Forms.Label lblComputer2BetNum;
        private System.Windows.Forms.Label lblComputer2BetValue;
        private System.Windows.Forms.Label lblComputer3BetNum;
        private System.Windows.Forms.Label lblComputer3BetValue;
        private System.Windows.Forms.Label lblComputer1D1;
        private System.Windows.Forms.Label lblComputer1D2;
        private System.Windows.Forms.Label lblComputer1D3;
        private System.Windows.Forms.Label lblComputer1D4;
        private System.Windows.Forms.Label lblComputer1D5;
        private System.Windows.Forms.Label lblComputer1D6;
        private System.Windows.Forms.Label lblComputer2D6;
        private System.Windows.Forms.Label lblComputer2D5;
        private System.Windows.Forms.Label lblComputer2D4;
        private System.Windows.Forms.Label lblComputer2D3;
        private System.Windows.Forms.Label lblComputer2D2;
        private System.Windows.Forms.Label lblComputer2D1;
        private System.Windows.Forms.Label lblComputer3D6;
        private System.Windows.Forms.Label lblComputer3D5;
        private System.Windows.Forms.Label lblComputer3D4;
        private System.Windows.Forms.Label lblComputer3D3;
        private System.Windows.Forms.Label lblComputer3D2;
        private System.Windows.Forms.Label lblComputer3D1;
        private System.Windows.Forms.Label lblDie1Count;
        private System.Windows.Forms.Label lblDie2Count;
        private System.Windows.Forms.Label lblDie3Count;
        private System.Windows.Forms.Label lblDie4Count;
        private System.Windows.Forms.Label lblDie5Count;
        private System.Windows.Forms.Label lblDie6Count;
        private System.Windows.Forms.Button btnPlayer1Challenge;
    }
}