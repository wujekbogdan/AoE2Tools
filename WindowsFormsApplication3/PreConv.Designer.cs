﻿namespace WindowsFormsApplication3
{
    partial class PreConv
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PreConv));
            this.kryptonLabel1 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.VoobAuto = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.VoobManual = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.GameDir = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.GameCustom = new System.Windows.Forms.RadioButton();
            this.GameAuto = new System.Windows.Forms.RadioButton();
            this.kryptonLabel3 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.boldtext = new System.Windows.Forms.CheckBox();
            this.blueberries = new System.Windows.Forms.CheckBox();
            this.hugenumber = new System.Windows.Forms.CheckBox();
            this.advidle = new System.Windows.Forms.CheckBox();
            this.shortwalls = new System.Windows.Forms.CheckBox();
            this.smalltrees = new System.Windows.Forms.CheckBox();
            this.kryptonLabel2 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.radioButton6 = new System.Windows.Forms.RadioButton();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.kryptonComboBox1 = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.kryptonLabel4 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonButton1 = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kryptonLabel5 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel6 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel7 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.LangTxt = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.FixSteam = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.SteamBox = new System.Windows.Forms.PictureBox();
            this.kryptonLabel9 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.SteamLabel = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker3 = new System.ComponentModel.BackgroundWorker();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonComboBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SteamBox)).BeginInit();
            this.SuspendLayout();
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.BoldPanel;
            this.kryptonLabel1.Location = new System.Drawing.Point(5, 19);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Blue;
            this.kryptonLabel1.Size = new System.Drawing.Size(111, 24);
            this.kryptonLabel1.TabIndex = 0;
            this.kryptonLabel1.Values.Text = "Install Voobly";
            // 
            // VoobAuto
            // 
            this.VoobAuto.AutoSize = true;
            this.VoobAuto.Checked = true;
            this.VoobAuto.Location = new System.Drawing.Point(127, 19);
            this.VoobAuto.Name = "VoobAuto";
            this.VoobAuto.Size = new System.Drawing.Size(58, 21);
            this.VoobAuto.TabIndex = 1;
            this.VoobAuto.TabStop = true;
            this.VoobAuto.Text = "Auto";
            this.VoobAuto.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.VoobManual);
            this.groupBox1.Controls.Add(this.kryptonLabel1);
            this.groupBox1.Controls.Add(this.VoobAuto);
            this.groupBox1.Location = new System.Drawing.Point(4, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(272, 55);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // VoobManual
            // 
            this.VoobManual.AutoSize = true;
            this.VoobManual.Location = new System.Drawing.Point(191, 19);
            this.VoobManual.Name = "VoobManual";
            this.VoobManual.Size = new System.Drawing.Size(71, 21);
            this.VoobManual.TabIndex = 3;
            this.VoobManual.Text = "Manual";
            this.VoobManual.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.GameDir);
            this.groupBox2.Controls.Add(this.GameCustom);
            this.groupBox2.Controls.Add(this.GameAuto);
            this.groupBox2.Controls.Add(this.kryptonLabel3);
            this.groupBox2.Location = new System.Drawing.Point(4, 79);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(272, 82);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            // 
            // GameDir
            // 
            this.GameDir.Location = new System.Drawing.Point(9, 46);
            this.GameDir.Name = "GameDir";
            this.GameDir.ReadOnly = true;
            this.GameDir.Size = new System.Drawing.Size(258, 24);
            this.GameDir.TabIndex = 5;
            // 
            // GameCustom
            // 
            this.GameCustom.AutoSize = true;
            this.GameCustom.Location = new System.Drawing.Point(191, 19);
            this.GameCustom.Name = "GameCustom";
            this.GameCustom.Size = new System.Drawing.Size(77, 21);
            this.GameCustom.TabIndex = 3;
            this.GameCustom.Text = "Custom";
            this.GameCustom.UseVisualStyleBackColor = true;
            this.GameCustom.CheckedChanged += new System.EventHandler(this.GameCustom_CheckedChanged);
            // 
            // GameAuto
            // 
            this.GameAuto.AutoSize = true;
            this.GameAuto.Checked = true;
            this.GameAuto.Location = new System.Drawing.Point(126, 19);
            this.GameAuto.Name = "GameAuto";
            this.GameAuto.Size = new System.Drawing.Size(58, 21);
            this.GameAuto.TabIndex = 1;
            this.GameAuto.TabStop = true;
            this.GameAuto.Text = "Auto";
            this.GameAuto.UseVisualStyleBackColor = true;
            this.GameAuto.CheckedChanged += new System.EventHandler(this.GameAuto_CheckedChanged);
            // 
            // kryptonLabel3
            // 
            this.kryptonLabel3.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.BoldPanel;
            this.kryptonLabel3.Location = new System.Drawing.Point(5, 16);
            this.kryptonLabel3.Name = "kryptonLabel3";
            this.kryptonLabel3.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Blue;
            this.kryptonLabel3.Size = new System.Drawing.Size(125, 24);
            this.kryptonLabel3.TabIndex = 4;
            this.kryptonLabel3.Values.Text = "Game Directory";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.boldtext);
            this.groupBox3.Controls.Add(this.blueberries);
            this.groupBox3.Controls.Add(this.hugenumber);
            this.groupBox3.Controls.Add(this.advidle);
            this.groupBox3.Controls.Add(this.shortwalls);
            this.groupBox3.Controls.Add(this.smalltrees);
            this.groupBox3.Controls.Add(this.kryptonLabel2);
            this.groupBox3.Controls.Add(this.radioButton6);
            this.groupBox3.Location = new System.Drawing.Point(4, 257);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(396, 83);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            // 
            // boldtext
            // 
            this.boldtext.AutoSize = true;
            this.boldtext.Location = new System.Drawing.Point(295, 18);
            this.boldtext.Name = "boldtext";
            this.boldtext.Size = new System.Drawing.Size(88, 21);
            this.boldtext.TabIndex = 10;
            this.boldtext.Text = "Light Grid";
            this.boldtext.UseVisualStyleBackColor = true;
            // 
            // blueberries
            // 
            this.blueberries.AutoSize = true;
            this.blueberries.Location = new System.Drawing.Point(292, 49);
            this.blueberries.Name = "blueberries";
            this.blueberries.Size = new System.Drawing.Size(99, 21);
            this.blueberries.TabIndex = 9;
            this.blueberries.Text = "Blue Berries";
            this.blueberries.UseVisualStyleBackColor = true;
            // 
            // hugenumber
            // 
            this.hugenumber.AutoSize = true;
            this.hugenumber.Location = new System.Drawing.Point(169, 49);
            this.hugenumber.Name = "hugenumber";
            this.hugenumber.Size = new System.Drawing.Size(115, 21);
            this.hugenumber.TabIndex = 8;
            this.hugenumber.Text = "Huge Number";
            this.hugenumber.UseVisualStyleBackColor = true;
            // 
            // advidle
            // 
            this.advidle.AutoSize = true;
            this.advidle.Location = new System.Drawing.Point(8, 50);
            this.advidle.Name = "advidle";
            this.advidle.Size = new System.Drawing.Size(163, 21);
            this.advidle.TabIndex = 7;
            this.advidle.Text = "Advanced Idle Pointer";
            this.advidle.UseVisualStyleBackColor = true;
            // 
            // shortwalls
            // 
            this.shortwalls.AutoSize = true;
            this.shortwalls.Checked = true;
            this.shortwalls.CheckState = System.Windows.Forms.CheckState.Checked;
            this.shortwalls.Location = new System.Drawing.Point(196, 18);
            this.shortwalls.Name = "shortwalls";
            this.shortwalls.Size = new System.Drawing.Size(99, 21);
            this.shortwalls.TabIndex = 6;
            this.shortwalls.Text = "Short Walls";
            this.shortwalls.UseVisualStyleBackColor = true;
            // 
            // smalltrees
            // 
            this.smalltrees.AutoSize = true;
            this.smalltrees.Checked = true;
            this.smalltrees.CheckState = System.Windows.Forms.CheckState.Checked;
            this.smalltrees.Location = new System.Drawing.Point(100, 18);
            this.smalltrees.Name = "smalltrees";
            this.smalltrees.Size = new System.Drawing.Size(98, 21);
            this.smalltrees.TabIndex = 5;
            this.smalltrees.Text = "Small Trees";
            this.smalltrees.UseVisualStyleBackColor = true;
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.BoldPanel;
            this.kryptonLabel2.Location = new System.Drawing.Point(0, 15);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Blue;
            this.kryptonLabel2.Size = new System.Drawing.Size(106, 24);
            this.kryptonLabel2.TabIndex = 4;
            this.kryptonLabel2.Values.Text = "Offline Mods";
            // 
            // radioButton6
            // 
            this.radioButton6.AutoSize = true;
            this.radioButton6.Location = new System.Drawing.Point(56, 18);
            this.radioButton6.Name = "radioButton6";
            this.radioButton6.Size = new System.Drawing.Size(41, 21);
            this.radioButton6.TabIndex = 1;
            this.radioButton6.TabStop = true;
            this.radioButton6.Text = "All";
            this.radioButton6.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.kryptonComboBox1);
            this.groupBox4.Controls.Add(this.kryptonLabel4);
            this.groupBox4.Location = new System.Drawing.Point(4, 202);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(272, 55);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            // 
            // kryptonComboBox1
            // 
            this.kryptonComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.kryptonComboBox1.DropDownWidth = 161;
            this.kryptonComboBox1.Items.AddRange(new object[] {
            "Default (Recommended)",
            "===Pro Hotkeys===",
            "TheViper",
            "Tatoh",
            "Riut",
            "Spring",
            "St4rk",
            "Cloud",
            "===Game Default===",
            "AoE2 HD Hotkeys",
            "AoC2 Hotkeys"});
            this.kryptonComboBox1.Location = new System.Drawing.Point(77, 18);
            this.kryptonComboBox1.Name = "kryptonComboBox1";
            this.kryptonComboBox1.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Blue;
            this.kryptonComboBox1.Size = new System.Drawing.Size(190, 25);
            this.kryptonComboBox1.TabIndex = 1;
            this.kryptonComboBox1.Text = "Default (Recommended)";
            this.kryptonComboBox1.SelectedIndexChanged += new System.EventHandler(this.kryptonComboBox1_SelectedIndexChanged);
            this.kryptonComboBox1.SelectedValueChanged += new System.EventHandler(this.kryptonComboBox1_SelectedValueChanged);
            // 
            // kryptonLabel4
            // 
            this.kryptonLabel4.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.BoldPanel;
            this.kryptonLabel4.Location = new System.Drawing.Point(5, 19);
            this.kryptonLabel4.Name = "kryptonLabel4";
            this.kryptonLabel4.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Blue;
            this.kryptonLabel4.Size = new System.Drawing.Size(71, 24);
            this.kryptonLabel4.TabIndex = 0;
            this.kryptonLabel4.Values.Text = "Hotkeys";
            // 
            // kryptonButton1
            // 
            this.kryptonButton1.Enabled = false;
            this.kryptonButton1.Location = new System.Drawing.Point(70, 346);
            this.kryptonButton1.Name = "kryptonButton1";
            this.kryptonButton1.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.SparkleBlue;
            this.kryptonButton1.Size = new System.Drawing.Size(229, 33);
            this.kryptonButton1.StateCommon.Content.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonButton1.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonButton1.StateNormal.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.kryptonButton1.StatePressed.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.kryptonButton1.TabIndex = 6;
            this.kryptonButton1.Values.Text = "I\'m Ready! Let\'s Go";
            this.kryptonButton1.Click += new System.EventHandler(this.kryptonButton1_Click);
            // 
            // kryptonLabel5
            // 
            this.kryptonLabel5.Location = new System.Drawing.Point(296, 101);
            this.kryptonLabel5.Name = "kryptonLabel5";
            this.kryptonLabel5.Size = new System.Drawing.Size(78, 24);
            this.kryptonLabel5.StateCommon.ShortText.Color1 = System.Drawing.Color.DarkGray;
            this.kryptonLabel5.TabIndex = 7;
            this.kryptonLabel5.Values.Text = "Detecting";
            // 
            // kryptonLabel6
            // 
            this.kryptonLabel6.Location = new System.Drawing.Point(11, 6);
            this.kryptonLabel6.Name = "kryptonLabel6";
            this.kryptonLabel6.Size = new System.Drawing.Size(139, 24);
            this.kryptonLabel6.StateCommon.ShortText.Color1 = System.Drawing.Color.Maroon;
            this.kryptonLabel6.TabIndex = 7;
            this.kryptonLabel6.Values.Text = "Pre-Install Settings";
            // 
            // kryptonLabel7
            // 
            this.kryptonLabel7.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.SuperTip;
            this.kryptonLabel7.Location = new System.Drawing.Point(299, 131);
            this.kryptonLabel7.Name = "kryptonLabel7";
            this.kryptonLabel7.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Blue;
            this.kryptonLabel7.Size = new System.Drawing.Size(53, 30);
            this.kryptonLabel7.TabIndex = 9;
            this.kryptonLabel7.Values.Text = "Lang:";
            // 
            // LangTxt
            // 
            this.LangTxt.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.ToolTip;
            this.LangTxt.Location = new System.Drawing.Point(345, 133);
            this.LangTxt.Name = "LangTxt";
            this.LangTxt.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Blue;
            this.LangTxt.Size = new System.Drawing.Size(16, 26);
            this.LangTxt.TabIndex = 9;
            this.LangTxt.Values.Text = "-";
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerReportsProgress = true;
            this.backgroundWorker1.WorkerSupportsCancellation = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApplication3.Properties.Resources.AoE2ToolsLogo;
            this.pictureBox1.Location = new System.Drawing.Point(299, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(74, 83);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.FixSteam);
            this.groupBox5.Controls.Add(this.SteamBox);
            this.groupBox5.Controls.Add(this.kryptonLabel9);
            this.groupBox5.Controls.Add(this.SteamLabel);
            this.groupBox5.Location = new System.Drawing.Point(4, 161);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(272, 40);
            this.groupBox5.TabIndex = 10;
            this.groupBox5.TabStop = false;
            // 
            // FixSteam
            // 
            this.FixSteam.AutoSize = true;
            this.FixSteam.Location = new System.Drawing.Point(218, 11);
            this.FixSteam.Name = "FixSteam";
            this.FixSteam.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Blue;
            this.FixSteam.Size = new System.Drawing.Size(49, 25);
            this.FixSteam.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Tahoma", 7.5F, System.Drawing.FontStyle.Bold);
            this.FixSteam.StateNormal.Content.ShortText.Font = new System.Drawing.Font("Tahoma", 7.5F, System.Drawing.FontStyle.Bold);
            this.FixSteam.StatePressed.Content.ShortText.Font = new System.Drawing.Font("Tahoma", 7.5F, System.Drawing.FontStyle.Bold);
            this.FixSteam.TabIndex = 10;
            this.FixSteam.Values.Text = "Fix it!";
            this.FixSteam.Click += new System.EventHandler(this.FixSteam_Click);
            // 
            // SteamBox
            // 
            this.SteamBox.BackColor = System.Drawing.Color.Transparent;
            this.SteamBox.Image = global::WindowsFormsApplication3.Properties.Resources.check;
            this.SteamBox.Location = new System.Drawing.Point(106, 11);
            this.SteamBox.Name = "SteamBox";
            this.SteamBox.Size = new System.Drawing.Size(19, 22);
            this.SteamBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.SteamBox.TabIndex = 4;
            this.SteamBox.TabStop = false;
            // 
            // kryptonLabel9
            // 
            this.kryptonLabel9.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.BoldPanel;
            this.kryptonLabel9.Location = new System.Drawing.Point(3, 11);
            this.kryptonLabel9.Name = "kryptonLabel9";
            this.kryptonLabel9.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Blue;
            this.kryptonLabel9.Size = new System.Drawing.Size(107, 24);
            this.kryptonLabel9.TabIndex = 0;
            this.kryptonLabel9.Values.Text = "Steam Assets";
            // 
            // SteamLabel
            // 
            this.SteamLabel.Location = new System.Drawing.Point(124, 12);
            this.SteamLabel.Name = "SteamLabel";
            this.SteamLabel.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Blue;
            this.SteamLabel.Size = new System.Drawing.Size(92, 21);
            this.SteamLabel.StateCommon.LongText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.SteamLabel.StateCommon.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.SteamLabel.StateNormal.ShortText.Color1 = System.Drawing.Color.ForestGreen;
            this.SteamLabel.StateNormal.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SteamLabel.TabIndex = 9;
            this.SteamLabel.Values.Text = "Checking...";
            // 
            // backgroundWorker2
            // 
            this.backgroundWorker2.WorkerReportsProgress = true;
            this.backgroundWorker2.WorkerSupportsCancellation = true;
            this.backgroundWorker2.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker2_DoWork);
            // 
            // backgroundWorker3
            // 
            this.backgroundWorker3.WorkerReportsProgress = true;
            this.backgroundWorker3.WorkerSupportsCancellation = true;
            this.backgroundWorker3.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker3_DoWork);
            // 
            // PreConv
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(405, 392);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.LangTxt);
            this.Controls.Add(this.kryptonLabel7);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.kryptonLabel6);
            this.Controls.Add(this.kryptonLabel5);
            this.Controls.Add(this.kryptonButton1);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PreConv";
            this.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Blue;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ready To Convert HD? - AoE2Tools";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PreConv_FormClosing);
            this.Load += new System.EventHandler(this.PreConv_Load);
            this.Shown += new System.EventHandler(this.PreConv_Shown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonComboBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SteamBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private System.Windows.Forms.RadioButton VoobAuto;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton VoobManual;
        private System.Windows.Forms.GroupBox groupBox2;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox GameDir;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel3;
        private System.Windows.Forms.RadioButton GameCustom;
        private System.Windows.Forms.RadioButton GameAuto;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox blueberries;
        private System.Windows.Forms.CheckBox hugenumber;
        private System.Windows.Forms.CheckBox advidle;
        private System.Windows.Forms.CheckBox shortwalls;
        private System.Windows.Forms.CheckBox smalltrees;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private System.Windows.Forms.RadioButton radioButton6;
        private System.Windows.Forms.CheckBox boldtext;
        private System.Windows.Forms.GroupBox groupBox4;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel4;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox kryptonComboBox1;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kryptonButton1;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel6;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel7;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel LangTxt;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.GroupBox groupBox5;
        private ComponentFactory.Krypton.Toolkit.KryptonButton FixSteam;
        private System.Windows.Forms.PictureBox SteamBox;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel9;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel SteamLabel;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.ComponentModel.BackgroundWorker backgroundWorker3;
    }
}