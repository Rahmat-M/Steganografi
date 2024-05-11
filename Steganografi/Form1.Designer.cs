namespace Steganography
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
            this.imageBox = new System.Windows.Forms.PictureBox();
            this.lblEncode = new System.Windows.Forms.Label();
            this.loadDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveDialog = new System.Windows.Forms.SaveFileDialog();
            this.console = new System.Windows.Forms.ListBox();
            this.loadFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.textBox = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.loadWav = new System.Windows.Forms.OpenFileDialog();
            this.saveWav = new System.Windows.Forms.SaveFileDialog();
            this.audioLabel = new System.Windows.Forms.Label();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnAbout = new FontAwesome.Sharp.IconButton();
            this.btnHome = new FontAwesome.Sharp.IconButton();
            this.btnEncode = new FontAwesome.Sharp.IconButton();
            this.btnDecode = new FontAwesome.Sharp.IconButton();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.decryptButton = new FontAwesome.Sharp.IconButton();
            this.loadWavFile2 = new FontAwesome.Sharp.IconButton();
            this.loadWavFile = new FontAwesome.Sharp.IconButton();
            this.encryptButton = new FontAwesome.Sharp.IconButton();
            this.bunifuCards3 = new Bunifu.Framework.UI.BunifuCards();
            this.lblDecode = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.RichTextBox();
            this.bunifuCards2 = new Bunifu.Framework.UI.BunifuCards();
            this.console2 = new System.Windows.Forms.ListBox();
            this.bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
            this.audioLabel2 = new System.Windows.Forms.Label();
            this.imageBox2 = new System.Windows.Forms.PictureBox();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.panelAbout = new Steganography.About();
            this.panelHome = new Steganography.Home();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox)).BeginInit();
            this.panelMenu.SuspendLayout();
            this.mainPanel.SuspendLayout();
            this.bunifuCards3.SuspendLayout();
            this.bunifuCards2.SuspendLayout();
            this.bunifuCards1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // imageBox
            // 
            this.imageBox.Location = new System.Drawing.Point(24, 19);
            this.imageBox.Name = "imageBox";
            this.imageBox.Size = new System.Drawing.Size(359, 152);
            this.imageBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imageBox.TabIndex = 0;
            this.imageBox.TabStop = false;
            // 
            // lblEncode
            // 
            this.lblEncode.AutoSize = true;
            this.lblEncode.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEncode.Location = new System.Drawing.Point(36, 15);
            this.lblEncode.Name = "lblEncode";
            this.lblEncode.Size = new System.Drawing.Size(106, 20);
            this.lblEncode.TabIndex = 2;
            this.lblEncode.Text = "Masukkan Teks";
            // 
            // loadDialog
            // 
            this.loadDialog.FileName = ".*";
            this.loadDialog.Filter = "Image Files (*.bmp,*.jpg,*.png)|*.bmp,*.jpg,*.png";
            // 
            // saveDialog
            // 
            this.saveDialog.Filter = "Image Files (*.bmp,*.png)|*.bmp,*.png";
            // 
            // console
            // 
            this.console.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.console.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.console.FormattingEnabled = true;
            this.console.ItemHeight = 20;
            this.console.Location = new System.Drawing.Point(30, 57);
            this.console.Name = "console";
            this.console.Size = new System.Drawing.Size(286, 360);
            this.console.TabIndex = 6;
            this.console.KeyDown += new System.Windows.Forms.KeyEventHandler(this.console_KeyDown);
            this.console.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.console_MouseDoubleClick);
            // 
            // loadFileDialog
            // 
            this.loadFileDialog.FileName = ".*";
            this.loadFileDialog.Filter = "Any file (*.*) | *.*";
            // 
            // textBox
            // 
            this.textBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox.Location = new System.Drawing.Point(40, 50);
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(343, 128);
            this.textBox.TabIndex = 12;
            this.textBox.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(26, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 20);
            this.label2.TabIndex = 13;
            this.label2.Text = "Log";
            // 
            // loadWav
            // 
            this.loadWav.FileName = "*.wav";
            this.loadWav.Filter = "Wav File (*.wav) | *.wav";
            // 
            // saveWav
            // 
            this.saveWav.FileName = "*.wav";
            this.saveWav.Filter = "Wav File (*.wav) | *.wav";
            // 
            // audioLabel
            // 
            this.audioLabel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.audioLabel.Location = new System.Drawing.Point(36, 32);
            this.audioLabel.Name = "audioLabel";
            this.audioLabel.Size = new System.Drawing.Size(333, 127);
            this.audioLabel.TabIndex = 15;
            this.audioLabel.Text = "Using Wav File";
            this.audioLabel.Visible = false;
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(33)))), ((int)(((byte)(253)))));
            this.panelMenu.Controls.Add(this.btnAbout);
            this.panelMenu.Controls.Add(this.btnHome);
            this.panelMenu.Controls.Add(this.btnEncode);
            this.panelMenu.Controls.Add(this.btnDecode);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelMenu.Location = new System.Drawing.Point(0, 671);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(1064, 80);
            this.panelMenu.TabIndex = 16;
            // 
            // btnAbout
            // 
            this.btnAbout.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnAbout.FlatAppearance.BorderSize = 0;
            this.btnAbout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAbout.ForeColor = System.Drawing.Color.White;
            this.btnAbout.IconChar = FontAwesome.Sharp.IconChar.PeopleGroup;
            this.btnAbout.IconColor = System.Drawing.Color.White;
            this.btnAbout.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAbout.IconSize = 32;
            this.btnAbout.Location = new System.Drawing.Point(798, 0);
            this.btnAbout.Margin = new System.Windows.Forms.Padding(4);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Padding = new System.Windows.Forms.Padding(13, 0, 27, 0);
            this.btnAbout.Size = new System.Drawing.Size(266, 80);
            this.btnAbout.TabIndex = 27;
            this.btnAbout.Text = "About";
            this.btnAbout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnAbout.UseVisualStyleBackColor = true;
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
            // 
            // btnHome
            // 
            this.btnHome.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.ForeColor = System.Drawing.Color.White;
            this.btnHome.IconChar = FontAwesome.Sharp.IconChar.House;
            this.btnHome.IconColor = System.Drawing.Color.White;
            this.btnHome.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnHome.IconSize = 32;
            this.btnHome.Location = new System.Drawing.Point(532, 0);
            this.btnHome.Margin = new System.Windows.Forms.Padding(4);
            this.btnHome.Name = "btnHome";
            this.btnHome.Padding = new System.Windows.Forms.Padding(13, 0, 27, 0);
            this.btnHome.Size = new System.Drawing.Size(266, 80);
            this.btnHome.TabIndex = 24;
            this.btnHome.Text = "Home";
            this.btnHome.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // btnEncode
            // 
            this.btnEncode.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnEncode.FlatAppearance.BorderSize = 0;
            this.btnEncode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEncode.ForeColor = System.Drawing.Color.White;
            this.btnEncode.IconChar = FontAwesome.Sharp.IconChar.Lock;
            this.btnEncode.IconColor = System.Drawing.Color.White;
            this.btnEncode.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEncode.IconSize = 32;
            this.btnEncode.Location = new System.Drawing.Point(266, 0);
            this.btnEncode.Margin = new System.Windows.Forms.Padding(4);
            this.btnEncode.Name = "btnEncode";
            this.btnEncode.Padding = new System.Windows.Forms.Padding(13, 0, 27, 0);
            this.btnEncode.Size = new System.Drawing.Size(266, 80);
            this.btnEncode.TabIndex = 26;
            this.btnEncode.Text = "Encode";
            this.btnEncode.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnEncode.UseVisualStyleBackColor = true;
            this.btnEncode.Click += new System.EventHandler(this.btnEncode_Click);
            // 
            // btnDecode
            // 
            this.btnDecode.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnDecode.FlatAppearance.BorderSize = 0;
            this.btnDecode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDecode.ForeColor = System.Drawing.Color.White;
            this.btnDecode.IconChar = FontAwesome.Sharp.IconChar.LockOpen;
            this.btnDecode.IconColor = System.Drawing.Color.White;
            this.btnDecode.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDecode.IconSize = 32;
            this.btnDecode.Location = new System.Drawing.Point(0, 0);
            this.btnDecode.Margin = new System.Windows.Forms.Padding(4);
            this.btnDecode.Name = "btnDecode";
            this.btnDecode.Padding = new System.Windows.Forms.Padding(13, 0, 27, 0);
            this.btnDecode.Size = new System.Drawing.Size(266, 80);
            this.btnDecode.TabIndex = 25;
            this.btnDecode.Text = "Decode";
            this.btnDecode.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnDecode.UseVisualStyleBackColor = true;
            this.btnDecode.Click += new System.EventHandler(this.btnDecode_Click);
            // 
            // mainPanel
            // 
            this.mainPanel.BackColor = System.Drawing.SystemColors.Control;
            this.mainPanel.Controls.Add(this.decryptButton);
            this.mainPanel.Controls.Add(this.loadWavFile2);
            this.mainPanel.Controls.Add(this.loadWavFile);
            this.mainPanel.Controls.Add(this.encryptButton);
            this.mainPanel.Controls.Add(this.bunifuCards3);
            this.mainPanel.Controls.Add(this.bunifuCards2);
            this.mainPanel.Controls.Add(this.bunifuCards1);
            this.mainPanel.Location = new System.Drawing.Point(0, 35);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(1064, 637);
            this.mainPanel.TabIndex = 17;
            // 
            // decryptButton
            // 
            this.decryptButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(76)))), ((int)(((byte)(239)))));
            this.decryptButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.decryptButton.FlatAppearance.BorderSize = 0;
            this.decryptButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.decryptButton.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.decryptButton.ForeColor = System.Drawing.Color.White;
            this.decryptButton.IconChar = FontAwesome.Sharp.IconChar.LockOpen;
            this.decryptButton.IconColor = System.Drawing.Color.White;
            this.decryptButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.decryptButton.IconSize = 25;
            this.decryptButton.Location = new System.Drawing.Point(345, 252);
            this.decryptButton.Name = "decryptButton";
            this.decryptButton.Size = new System.Drawing.Size(105, 34);
            this.decryptButton.TabIndex = 30;
            this.decryptButton.Text = "Decode";
            this.decryptButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.decryptButton.UseVisualStyleBackColor = false;
            this.decryptButton.Click += new System.EventHandler(this.decryptButton_Click);
            // 
            // loadWavFile2
            // 
            this.loadWavFile2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(76)))), ((int)(((byte)(239)))));
            this.loadWavFile2.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.loadWavFile2.FlatAppearance.BorderSize = 0;
            this.loadWavFile2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loadWavFile2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loadWavFile2.ForeColor = System.Drawing.Color.White;
            this.loadWavFile2.IconChar = FontAwesome.Sharp.IconChar.Upload;
            this.loadWavFile2.IconColor = System.Drawing.Color.White;
            this.loadWavFile2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.loadWavFile2.IconSize = 25;
            this.loadWavFile2.Location = new System.Drawing.Point(187, 252);
            this.loadWavFile2.Name = "loadWavFile2";
            this.loadWavFile2.Size = new System.Drawing.Size(143, 34);
            this.loadWavFile2.TabIndex = 29;
            this.loadWavFile2.Text = "Load WAV File";
            this.loadWavFile2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.loadWavFile2.UseVisualStyleBackColor = false;
            this.loadWavFile2.Click += new System.EventHandler(this.loadWavFile2_Click);
            // 
            // loadWavFile
            // 
            this.loadWavFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(76)))), ((int)(((byte)(239)))));
            this.loadWavFile.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.loadWavFile.FlatAppearance.BorderSize = 0;
            this.loadWavFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loadWavFile.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loadWavFile.ForeColor = System.Drawing.Color.White;
            this.loadWavFile.IconChar = FontAwesome.Sharp.IconChar.Upload;
            this.loadWavFile.IconColor = System.Drawing.Color.White;
            this.loadWavFile.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.loadWavFile.IconSize = 25;
            this.loadWavFile.Location = new System.Drawing.Point(187, 252);
            this.loadWavFile.Name = "loadWavFile";
            this.loadWavFile.Size = new System.Drawing.Size(143, 34);
            this.loadWavFile.TabIndex = 28;
            this.loadWavFile.Text = "Load WAV File";
            this.loadWavFile.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.loadWavFile.UseVisualStyleBackColor = false;
            this.loadWavFile.Click += new System.EventHandler(this.loadWavFile_Click);
            // 
            // encryptButton
            // 
            this.encryptButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(76)))), ((int)(((byte)(239)))));
            this.encryptButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.encryptButton.FlatAppearance.BorderSize = 0;
            this.encryptButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.encryptButton.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.encryptButton.ForeColor = System.Drawing.Color.White;
            this.encryptButton.IconChar = FontAwesome.Sharp.IconChar.Lock;
            this.encryptButton.IconColor = System.Drawing.Color.White;
            this.encryptButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.encryptButton.IconSize = 25;
            this.encryptButton.Location = new System.Drawing.Point(191, 519);
            this.encryptButton.Name = "encryptButton";
            this.encryptButton.Size = new System.Drawing.Size(104, 34);
            this.encryptButton.TabIndex = 27;
            this.encryptButton.Text = "Encode";
            this.encryptButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.encryptButton.UseVisualStyleBackColor = false;
            this.encryptButton.Click += new System.EventHandler(this.encryptButton_Click);
            // 
            // bunifuCards3
            // 
            this.bunifuCards3.BackColor = System.Drawing.Color.White;
            this.bunifuCards3.BorderRadius = 50;
            this.bunifuCards3.BottomSahddow = false;
            this.bunifuCards3.BottomShadow = false;
            this.bunifuCards3.color = System.Drawing.Color.White;
            this.bunifuCards3.Controls.Add(this.lblDecode);
            this.bunifuCards3.Controls.Add(this.textBox);
            this.bunifuCards3.Controls.Add(this.lblEncode);
            this.bunifuCards3.Controls.Add(this.textBox2);
            this.bunifuCards3.IndicatorColor = System.Drawing.Color.White;
            this.bunifuCards3.LeftSahddow = false;
            this.bunifuCards3.LeftShadow = false;
            this.bunifuCards3.Location = new System.Drawing.Point(163, 305);
            this.bunifuCards3.Name = "bunifuCards3";
            this.bunifuCards3.RightSahddow = false;
            this.bunifuCards3.RightShadow = false;
            this.bunifuCards3.ShadowDepth = 100;
            this.bunifuCards3.Size = new System.Drawing.Size(411, 206);
            this.bunifuCards3.TabIndex = 23;
            // 
            // lblDecode
            // 
            this.lblDecode.AutoSize = true;
            this.lblDecode.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDecode.Location = new System.Drawing.Point(36, 15);
            this.lblDecode.Name = "lblDecode";
            this.lblDecode.Size = new System.Drawing.Size(96, 20);
            this.lblDecode.TabIndex = 17;
            this.lblDecode.Text = "Hasil decode";
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.White;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(40, 50);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(343, 128);
            this.textBox2.TabIndex = 16;
            this.textBox2.Text = "";
            // 
            // bunifuCards2
            // 
            this.bunifuCards2.BackColor = System.Drawing.Color.White;
            this.bunifuCards2.BorderRadius = 50;
            this.bunifuCards2.BottomSahddow = false;
            this.bunifuCards2.BottomShadow = false;
            this.bunifuCards2.color = System.Drawing.Color.White;
            this.bunifuCards2.Controls.Add(this.console2);
            this.bunifuCards2.Controls.Add(this.console);
            this.bunifuCards2.Controls.Add(this.label2);
            this.bunifuCards2.IndicatorColor = System.Drawing.Color.White;
            this.bunifuCards2.LeftSahddow = false;
            this.bunifuCards2.LeftShadow = false;
            this.bunifuCards2.Location = new System.Drawing.Point(606, 53);
            this.bunifuCards2.Name = "bunifuCards2";
            this.bunifuCards2.RightSahddow = false;
            this.bunifuCards2.RightShadow = false;
            this.bunifuCards2.ShadowDepth = 20;
            this.bunifuCards2.Size = new System.Drawing.Size(339, 458);
            this.bunifuCards2.TabIndex = 23;
            // 
            // console2
            // 
            this.console2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.console2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.console2.FormattingEnabled = true;
            this.console2.ItemHeight = 20;
            this.console2.Location = new System.Drawing.Point(30, 57);
            this.console2.Name = "console2";
            this.console2.Size = new System.Drawing.Size(286, 360);
            this.console2.TabIndex = 21;
            // 
            // bunifuCards1
            // 
            this.bunifuCards1.BackColor = System.Drawing.Color.White;
            this.bunifuCards1.BorderRadius = 50;
            this.bunifuCards1.BottomSahddow = false;
            this.bunifuCards1.BottomShadow = false;
            this.bunifuCards1.color = System.Drawing.Color.White;
            this.bunifuCards1.Controls.Add(this.audioLabel2);
            this.bunifuCards1.Controls.Add(this.audioLabel);
            this.bunifuCards1.Controls.Add(this.imageBox);
            this.bunifuCards1.Controls.Add(this.imageBox2);
            this.bunifuCards1.IndicatorColor = System.Drawing.Color.White;
            this.bunifuCards1.LeftSahddow = false;
            this.bunifuCards1.LeftShadow = false;
            this.bunifuCards1.Location = new System.Drawing.Point(163, 53);
            this.bunifuCards1.Name = "bunifuCards1";
            this.bunifuCards1.RightSahddow = false;
            this.bunifuCards1.RightShadow = false;
            this.bunifuCards1.ShadowDepth = 100;
            this.bunifuCards1.Size = new System.Drawing.Size(411, 193);
            this.bunifuCards1.TabIndex = 22;
            // 
            // audioLabel2
            // 
            this.audioLabel2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.audioLabel2.Location = new System.Drawing.Point(36, 32);
            this.audioLabel2.Name = "audioLabel2";
            this.audioLabel2.Size = new System.Drawing.Size(333, 127);
            this.audioLabel2.TabIndex = 18;
            this.audioLabel2.Text = "Using Wav File";
            this.audioLabel2.Visible = false;
            // 
            // imageBox2
            // 
            this.imageBox2.Location = new System.Drawing.Point(24, 19);
            this.imageBox2.Name = "imageBox2";
            this.imageBox2.Size = new System.Drawing.Size(359, 152);
            this.imageBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imageBox2.TabIndex = 20;
            this.imageBox2.TabStop = false;
            // 
            // iconButton1
            // 
            this.iconButton1.BackColor = System.Drawing.SystemColors.Control;
            this.iconButton1.FlatAppearance.BorderSize = 0;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.PowerOff;
            this.iconButton1.IconColor = System.Drawing.Color.Black;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 32;
            this.iconButton1.Location = new System.Drawing.Point(999, 3);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(53, 37);
            this.iconButton1.TabIndex = 19;
            this.iconButton1.UseVisualStyleBackColor = false;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // panelAbout
            // 
            this.panelAbout.BackColor = System.Drawing.SystemColors.Control;
            this.panelAbout.Location = new System.Drawing.Point(0, 35);
            this.panelAbout.Name = "panelAbout";
            this.panelAbout.Size = new System.Drawing.Size(1064, 637);
            this.panelAbout.TabIndex = 0;
            // 
            // panelHome
            // 
            this.panelHome.BackColor = System.Drawing.SystemColors.Control;
            this.panelHome.Location = new System.Drawing.Point(0, 35);
            this.panelHome.Name = "panelHome";
            this.panelHome.Size = new System.Drawing.Size(1064, 637);
            this.panelHome.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1064, 751);
            this.Controls.Add(this.iconButton1);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.panelAbout);
            this.Controls.Add(this.panelHome);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Steganography";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.imageBox)).EndInit();
            this.panelMenu.ResumeLayout(false);
            this.mainPanel.ResumeLayout(false);
            this.bunifuCards3.ResumeLayout(false);
            this.bunifuCards3.PerformLayout();
            this.bunifuCards2.ResumeLayout(false);
            this.bunifuCards2.PerformLayout();
            this.bunifuCards1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imageBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox imageBox;
        private System.Windows.Forms.Label lblEncode;
        private System.Windows.Forms.OpenFileDialog loadDialog;
        private System.Windows.Forms.SaveFileDialog saveDialog;
        private System.Windows.Forms.ListBox console;
        private System.Windows.Forms.OpenFileDialog loadFileDialog;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.RichTextBox textBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.OpenFileDialog loadWav;
        private System.Windows.Forms.SaveFileDialog saveWav;
        private System.Windows.Forms.Label audioLabel;
        private System.Windows.Forms.Panel panelMenu;
        private About panelAbout;
        private Home panelHome;
        private FontAwesome.Sharp.IconButton btnHome;
        private FontAwesome.Sharp.IconButton btnAbout;
        private FontAwesome.Sharp.IconButton btnEncode;
        private FontAwesome.Sharp.IconButton btnDecode;
        private System.Windows.Forms.Panel mainPanel;
        private FontAwesome.Sharp.IconButton iconButton1;
        private System.Windows.Forms.RichTextBox textBox2;
        private System.Windows.Forms.Label audioLabel2;
        private System.Windows.Forms.PictureBox imageBox2;
        private System.Windows.Forms.ListBox console2;
        private Bunifu.Framework.UI.BunifuCards bunifuCards1;
        private Bunifu.Framework.UI.BunifuCards bunifuCards2;
        private Bunifu.Framework.UI.BunifuCards bunifuCards3;
        private System.Windows.Forms.Label lblDecode;
        private FontAwesome.Sharp.IconButton encryptButton;
        private FontAwesome.Sharp.IconButton decryptButton;
        private FontAwesome.Sharp.IconButton loadWavFile2;
        private FontAwesome.Sharp.IconButton loadWavFile;
    }
}

