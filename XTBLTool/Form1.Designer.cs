namespace XTBLTool
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabselect_Other = new System.Windows.Forms.Label();
            this.tabselect_Settings = new System.Windows.Forms.Label();
            this.tabselect_Mods = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.mod_AuthorText = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.mod_NameText = new System.Windows.Forms.Label();
            this.mod_DescriptionText = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.activateMods = new System.Windows.Forms.Button();
            this.bunifuSeparator1 = new ns1.BunifuSeparator();
            this.restoreFiles = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.runGame = new System.Windows.Forms.Button();
            this.modList = new System.Windows.Forms.CheckedListBox();
            this.Tabs = new MaterialSkin.Controls.MaterialTabControl();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.game_DirectoryText = new System.Windows.Forms.TextBox();
            this.browseForGameDirectory = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.bunifuSeparator2 = new ns1.BunifuSeparator();
            this.label9 = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.Tabs.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(12, 7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(54, 51);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(32)))), ((int)(((byte)(37)))));
            this.panel1.Controls.Add(this.tabselect_Other);
            this.panel1.Controls.Add(this.tabselect_Settings);
            this.panel1.Controls.Add(this.tabselect_Mods);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(765, 66);
            this.panel1.TabIndex = 1;
            // 
            // tabselect_Other
            // 
            this.tabselect_Other.AutoSize = true;
            this.tabselect_Other.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tabselect_Other.Font = new System.Drawing.Font("Montserrat", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabselect_Other.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(105)))), ((int)(((byte)(0)))));
            this.tabselect_Other.Location = new System.Drawing.Point(287, 16);
            this.tabselect_Other.Name = "tabselect_Other";
            this.tabselect_Other.Size = new System.Drawing.Size(87, 33);
            this.tabselect_Other.TabIndex = 7;
            this.tabselect_Other.Text = "Other";
            this.tabselect_Other.Click += new System.EventHandler(this.tabselect_Other_Click);
            // 
            // tabselect_Settings
            // 
            this.tabselect_Settings.AutoSize = true;
            this.tabselect_Settings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tabselect_Settings.Font = new System.Drawing.Font("Montserrat", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabselect_Settings.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(105)))), ((int)(((byte)(0)))));
            this.tabselect_Settings.Location = new System.Drawing.Point(162, 16);
            this.tabselect_Settings.Name = "tabselect_Settings";
            this.tabselect_Settings.Size = new System.Drawing.Size(119, 33);
            this.tabselect_Settings.TabIndex = 6;
            this.tabselect_Settings.Text = "Settings";
            this.tabselect_Settings.Click += new System.EventHandler(this.tabselect_Settings_Click);
            // 
            // tabselect_Mods
            // 
            this.tabselect_Mods.AutoSize = true;
            this.tabselect_Mods.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tabselect_Mods.Font = new System.Drawing.Font("Montserrat", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabselect_Mods.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(146)))), ((int)(((byte)(0)))));
            this.tabselect_Mods.Location = new System.Drawing.Point(72, 16);
            this.tabselect_Mods.Name = "tabselect_Mods";
            this.tabselect_Mods.Size = new System.Drawing.Size(84, 33);
            this.tabselect_Mods.TabIndex = 5;
            this.tabselect_Mods.Text = "Mods";
            this.tabselect_Mods.Click += new System.EventHandler(this.tabselect_Mods_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Montserrat", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(134)))), ((int)(((byte)(148)))));
            this.label8.Location = new System.Drawing.Point(223, 149);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(130, 16);
            this.label8.TabIndex = 9;
            this.label8.Text = "MOD DESCRIPTION";
            // 
            // mod_AuthorText
            // 
            this.mod_AuthorText.AutoSize = true;
            this.mod_AuthorText.Font = new System.Drawing.Font("Montserrat", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mod_AuthorText.ForeColor = System.Drawing.Color.White;
            this.mod_AuthorText.Location = new System.Drawing.Point(221, 114);
            this.mod_AuthorText.Name = "mod_AuthorText";
            this.mod_AuthorText.Size = new System.Drawing.Size(103, 21);
            this.mod_AuthorText.TabIndex = 8;
            this.mod_AuthorText.Text = "Placeholder";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Montserrat", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(134)))), ((int)(((byte)(148)))));
            this.label6.Location = new System.Drawing.Point(222, 96);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 16);
            this.label6.TabIndex = 7;
            this.label6.Text = "MOD AUTHOR";
            // 
            // mod_NameText
            // 
            this.mod_NameText.AutoSize = true;
            this.mod_NameText.Font = new System.Drawing.Font("Montserrat", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mod_NameText.ForeColor = System.Drawing.Color.White;
            this.mod_NameText.Location = new System.Drawing.Point(221, 63);
            this.mod_NameText.Name = "mod_NameText";
            this.mod_NameText.Size = new System.Drawing.Size(103, 21);
            this.mod_NameText.TabIndex = 6;
            this.mod_NameText.Text = "Placeholder";
            // 
            // mod_DescriptionText
            // 
            this.mod_DescriptionText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(37)))), ((int)(((byte)(44)))));
            this.mod_DescriptionText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mod_DescriptionText.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.mod_DescriptionText.Font = new System.Drawing.Font("Montserrat", 11.25F, System.Drawing.FontStyle.Bold);
            this.mod_DescriptionText.ForeColor = System.Drawing.Color.White;
            this.mod_DescriptionText.Location = new System.Drawing.Point(226, 170);
            this.mod_DescriptionText.Name = "mod_DescriptionText";
            this.mod_DescriptionText.ReadOnly = true;
            this.mod_DescriptionText.Size = new System.Drawing.Size(483, 261);
            this.mod_DescriptionText.TabIndex = 13;
            this.mod_DescriptionText.Text = "Placeholder";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Montserrat", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(134)))), ((int)(((byte)(148)))));
            this.label3.Location = new System.Drawing.Point(222, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "MOD NAME";
            // 
            // activateMods
            // 
            this.activateMods.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.activateMods.Font = new System.Drawing.Font("Montserrat", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.activateMods.Location = new System.Drawing.Point(221, 437);
            this.activateMods.Name = "activateMods";
            this.activateMods.Size = new System.Drawing.Size(169, 36);
            this.activateMods.TabIndex = 14;
            this.activateMods.Text = "Activate Mod";
            this.activateMods.UseVisualStyleBackColor = true;
            this.activateMods.Click += new System.EventHandler(this.activateMods_Click);
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bunifuSeparator1.LineThickness = 1;
            this.bunifuSeparator1.Location = new System.Drawing.Point(225, 32);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(517, 10);
            this.bunifuSeparator1.TabIndex = 4;
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = false;
            // 
            // restoreFiles
            // 
            this.restoreFiles.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.restoreFiles.Font = new System.Drawing.Font("Montserrat", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.restoreFiles.Location = new System.Drawing.Point(396, 437);
            this.restoreFiles.Name = "restoreFiles";
            this.restoreFiles.Size = new System.Drawing.Size(169, 36);
            this.restoreFiles.TabIndex = 15;
            this.restoreFiles.Text = "Restore Files";
            this.restoreFiles.UseVisualStyleBackColor = true;
            this.restoreFiles.Click += new System.EventHandler(this.restoreFiles_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(167)))), ((int)(((byte)(179)))));
            this.label1.Location = new System.Drawing.Point(221, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 26);
            this.label1.TabIndex = 3;
            this.label1.Text = "MOD INFO";
            // 
            // runGame
            // 
            this.runGame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.runGame.Font = new System.Drawing.Font("Montserrat", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.runGame.Location = new System.Drawing.Point(571, 437);
            this.runGame.Name = "runGame";
            this.runGame.Size = new System.Drawing.Size(169, 36);
            this.runGame.TabIndex = 16;
            this.runGame.Text = "Run Game";
            this.runGame.UseVisualStyleBackColor = true;
            this.runGame.Click += new System.EventHandler(this.runGame_Click);
            // 
            // modList
            // 
            this.modList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(37)))), ((int)(((byte)(44)))));
            this.modList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.modList.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modList.ForeColor = System.Drawing.Color.White;
            this.modList.FormattingEnabled = true;
            this.modList.HorizontalScrollbar = true;
            this.modList.Location = new System.Drawing.Point(3, 3);
            this.modList.Name = "modList";
            this.modList.Size = new System.Drawing.Size(212, 470);
            this.modList.TabIndex = 2;
            this.modList.SelectedIndexChanged += new System.EventHandler(this.modList_SelectedIndexChanged);
            // 
            // Tabs
            // 
            this.Tabs.Controls.Add(this.tabPage4);
            this.Tabs.Controls.Add(this.tabPage5);
            this.Tabs.Controls.Add(this.tabPage1);
            this.Tabs.Depth = 0;
            this.Tabs.Location = new System.Drawing.Point(12, 72);
            this.Tabs.MouseState = MaterialSkin.MouseState.HOVER;
            this.Tabs.Name = "Tabs";
            this.Tabs.SelectedIndex = 0;
            this.Tabs.Size = new System.Drawing.Size(741, 489);
            this.Tabs.TabIndex = 18;
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(37)))), ((int)(((byte)(44)))));
            this.tabPage4.Controls.Add(this.modList);
            this.tabPage4.Controls.Add(this.runGame);
            this.tabPage4.Controls.Add(this.label8);
            this.tabPage4.Controls.Add(this.label1);
            this.tabPage4.Controls.Add(this.mod_AuthorText);
            this.tabPage4.Controls.Add(this.restoreFiles);
            this.tabPage4.Controls.Add(this.bunifuSeparator1);
            this.tabPage4.Controls.Add(this.label6);
            this.tabPage4.Controls.Add(this.activateMods);
            this.tabPage4.Controls.Add(this.label3);
            this.tabPage4.Controls.Add(this.mod_NameText);
            this.tabPage4.Controls.Add(this.mod_DescriptionText);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(733, 463);
            this.tabPage4.TabIndex = 0;
            this.tabPage4.Text = "Mods";
            // 
            // tabPage5
            // 
            this.tabPage5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(37)))), ((int)(((byte)(44)))));
            this.tabPage5.Controls.Add(this.game_DirectoryText);
            this.tabPage5.Controls.Add(this.browseForGameDirectory);
            this.tabPage5.Controls.Add(this.label7);
            this.tabPage5.Controls.Add(this.bunifuSeparator2);
            this.tabPage5.Controls.Add(this.label9);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(733, 463);
            this.tabPage5.TabIndex = 1;
            this.tabPage5.Text = "Settings";
            // 
            // game_DirectoryText
            // 
            this.game_DirectoryText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(37)))), ((int)(((byte)(44)))));
            this.game_DirectoryText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.game_DirectoryText.Font = new System.Drawing.Font("Montserrat", 11.25F, System.Drawing.FontStyle.Bold);
            this.game_DirectoryText.ForeColor = System.Drawing.Color.White;
            this.game_DirectoryText.Location = new System.Drawing.Point(101, 60);
            this.game_DirectoryText.Name = "game_DirectoryText";
            this.game_DirectoryText.Size = new System.Drawing.Size(623, 19);
            this.game_DirectoryText.TabIndex = 17;
            this.game_DirectoryText.Text = "C:\\Program Files (x86)\\Steam\\steamapps\\common\\Red Faction Guerrilla Re-MARS-tered" +
    "";
            // 
            // browseForGameDirectory
            // 
            this.browseForGameDirectory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.browseForGameDirectory.Font = new System.Drawing.Font("Montserrat", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.browseForGameDirectory.Location = new System.Drawing.Point(10, 50);
            this.browseForGameDirectory.Name = "browseForGameDirectory";
            this.browseForGameDirectory.Size = new System.Drawing.Size(82, 32);
            this.browseForGameDirectory.TabIndex = 16;
            this.browseForGameDirectory.Text = "Browse";
            this.browseForGameDirectory.UseVisualStyleBackColor = true;
            this.browseForGameDirectory.Click += new System.EventHandler(this.button5_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(167)))), ((int)(((byte)(179)))));
            this.label7.Location = new System.Drawing.Point(6, 3);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(220, 26);
            this.label7.TabIndex = 7;
            this.label7.Text = "PROGRAM SETTINGS";
            // 
            // bunifuSeparator2
            // 
            this.bunifuSeparator2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator2.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bunifuSeparator2.LineThickness = 1;
            this.bunifuSeparator2.Location = new System.Drawing.Point(10, 32);
            this.bunifuSeparator2.Name = "bunifuSeparator2";
            this.bunifuSeparator2.Size = new System.Drawing.Size(714, 10);
            this.bunifuSeparator2.TabIndex = 8;
            this.bunifuSeparator2.Transparency = 255;
            this.bunifuSeparator2.Vertical = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Montserrat", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(134)))), ((int)(((byte)(148)))));
            this.label9.Location = new System.Drawing.Point(98, 45);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(122, 16);
            this.label9.TabIndex = 9;
            this.label9.Text = "GAME DIRECTORY";
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(37)))), ((int)(((byte)(44)))));
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(733, 463);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "Other";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(37)))), ((int)(((byte)(44)))));
            this.ClientSize = new System.Drawing.Size(765, 571);
            this.Controls.Add(this.Tabs);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(146)))), ((int)(((byte)(0)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RF:G RE-MARS-TERED // Mod Manager";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.Tabs.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label tabselect_Other;
        private System.Windows.Forms.Label tabselect_Settings;
        private System.Windows.Forms.Label tabselect_Mods;
        private System.Windows.Forms.CheckedListBox modList;
        private System.Windows.Forms.Button runGame;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button restoreFiles;
        private ns1.BunifuSeparator bunifuSeparator1;
        private System.Windows.Forms.Button activateMods;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox mod_DescriptionText;
        private System.Windows.Forms.Label mod_NameText;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label mod_AuthorText;
        private System.Windows.Forms.Label label8;
        private MaterialSkin.Controls.MaterialTabControl Tabs;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label7;
        private ns1.BunifuSeparator bunifuSeparator2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button browseForGameDirectory;
        private System.Windows.Forms.TextBox game_DirectoryText;
    }
}

