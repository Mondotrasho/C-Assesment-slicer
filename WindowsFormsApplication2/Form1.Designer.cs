namespace WindowsFormsApplication2
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
            pictureBox1 = new System.Windows.Forms.PictureBox();
            panel2 = new System.Windows.Forms.Panel();
            textBox2 = new System.Windows.Forms.TextBox();
            panel1 = new System.Windows.Forms.Panel();
            textBox1 = new System.Windows.Forms.TextBox();
            SpriteNameTextBox = new System.Windows.Forms.TextBox();
            Title1 = new System.Windows.Forms.TextBox();
            OffYbox = new System.Windows.Forms.TextBox();
            SaveButton = new System.Windows.Forms.Button();
            textBox20 = new System.Windows.Forms.TextBox();
            LoadSheetButton = new System.Windows.Forms.Button();
            LoadSavedButton = new System.Windows.Forms.Button();
            AddressTextBox = new System.Windows.Forms.TextBox();
            ModeCombo = new System.Windows.Forms.ComboBox();
            textBox3 = new System.Windows.Forms.TextBox();
            textBox18 = new System.Windows.Forms.TextBox();
            textBox4 = new System.Windows.Forms.TextBox();
            OffXbox = new System.Windows.Forms.TextBox();
            SpriteNumberTextBox = new System.Windows.Forms.TextBox();
            textBox17 = new System.Windows.Forms.TextBox();
            textBox6 = new System.Windows.Forms.TextBox();
            SizeYbox = new System.Windows.Forms.TextBox();
            textBox7 = new System.Windows.Forms.TextBox();
            textBox15 = new System.Windows.Forms.TextBox();
            textBox8 = new System.Windows.Forms.TextBox();
            SizeXbox = new System.Windows.Forms.TextBox();
            PosYbox = new System.Windows.Forms.TextBox();
            textBox13 = new System.Windows.Forms.TextBox();
            textBox11 = new System.Windows.Forms.TextBox();
            PosXbox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(pictureBox1)).BeginInit();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            pictureBox1.Location = new System.Drawing.Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(695, 546);
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            pictureBox1.Click += new System.EventHandler(pictureBox1_Click_1);
            // 
            // panel2
            // 
            panel2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            panel2.Controls.Add(textBox2);
            panel2.Controls.Add(panel1);
            panel2.Location = new System.Drawing.Point(713, 12);
            panel2.Name = "panel2";
            panel2.Size = new System.Drawing.Size(271, 547);
            panel2.TabIndex = 27;
            // 
            // textBox2
            // 
            textBox2.Location = new System.Drawing.Point(3, 3);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new System.Drawing.Size(14, 89);
            textBox2.TabIndex = 26;
            textBox2.Text = "POINTS";
            textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel1
            // 
            panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(SpriteNameTextBox);
            panel1.Controls.Add(Title1);
            panel1.Controls.Add(OffYbox);
            panel1.Controls.Add(SaveButton);
            panel1.Controls.Add(textBox20);
            panel1.Controls.Add(LoadSheetButton);
            panel1.Controls.Add(LoadSavedButton);
            panel1.Controls.Add(AddressTextBox);
            panel1.Controls.Add(ModeCombo);
            panel1.Controls.Add(textBox3);
            panel1.Controls.Add(textBox18);
            panel1.Controls.Add(textBox4);
            panel1.Controls.Add(OffXbox);
            panel1.Controls.Add(SpriteNumberTextBox);
            panel1.Controls.Add(textBox17);
            panel1.Controls.Add(textBox6);
            panel1.Controls.Add(SizeYbox);
            panel1.Controls.Add(textBox7);
            panel1.Controls.Add(textBox15);
            panel1.Controls.Add(textBox8);
            panel1.Controls.Add(SizeXbox);
            panel1.Controls.Add(PosYbox);
            panel1.Controls.Add(textBox13);
            panel1.Controls.Add(textBox11);
            panel1.Controls.Add(PosXbox);
            panel1.Location = new System.Drawing.Point(23, 3);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(245, 541);
            panel1.TabIndex = 27;
            // 
            // textBox1
            // 
            textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            textBox1.Location = new System.Drawing.Point(10, 220);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new System.Drawing.Size(34, 13);
            textBox1.TabIndex = 26;
            textBox1.Text = "Name :";
            // 
            // SpriteNameTextBox
            // 
            SpriteNameTextBox.Location = new System.Drawing.Point(50, 220);
            SpriteNameTextBox.Name = "SpriteNameTextBox";
            SpriteNameTextBox.Size = new System.Drawing.Size(188, 20);
            SpriteNameTextBox.TabIndex = 27;
            SpriteNameTextBox.TextChanged += new System.EventHandler(SpriteNameTextBox_TextChanged);
            // 
            // Title1
            // 
            Title1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            Title1.Location = new System.Drawing.Point(10, 45);
            Title1.Name = "Title1";
            Title1.ReadOnly = true;
            Title1.Size = new System.Drawing.Size(108, 13);
            Title1.TabIndex = 4;
            Title1.Text = "Loaded Sprite Sheet:";
            // 
            // OffYbox
            // 
            OffYbox.AllowDrop = true;
            OffYbox.Location = new System.Drawing.Point(50, 422);
            OffYbox.Name = "OffYbox";
            OffYbox.Size = new System.Drawing.Size(41, 20);
            OffYbox.TabIndex = 25;
            OffYbox.TextChanged += new System.EventHandler(OffYbox_TextChanged);
            // 
            // SaveButton
            // 
            SaveButton.Location = new System.Drawing.Point(10, 468);
            SaveButton.Name = "SaveButton";
            SaveButton.Size = new System.Drawing.Size(90, 46);
            SaveButton.TabIndex = 0;
            SaveButton.Text = "Export Cutting";
            SaveButton.UseVisualStyleBackColor = true;
            SaveButton.Click += new System.EventHandler(SaveButton_Click);
            // 
            // textBox20
            // 
            textBox20.BorderStyle = System.Windows.Forms.BorderStyle.None;
            textBox20.Location = new System.Drawing.Point(30, 425);
            textBox20.Name = "textBox20";
            textBox20.ReadOnly = true;
            textBox20.Size = new System.Drawing.Size(14, 13);
            textBox20.TabIndex = 24;
            textBox20.Text = "Y :";
            // 
            // LoadSheetButton
            // 
            LoadSheetButton.Location = new System.Drawing.Point(175, 468);
            LoadSheetButton.Name = "LoadSheetButton";
            LoadSheetButton.Size = new System.Drawing.Size(63, 46);
            LoadSheetButton.TabIndex = 2;
            LoadSheetButton.Text = "Load Sheet";
            LoadSheetButton.UseVisualStyleBackColor = true;
            LoadSheetButton.Click += new System.EventHandler(LoadSheetButton_Click);
            // 
            // LoadSavedButton
            // 
            LoadSavedButton.Location = new System.Drawing.Point(106, 468);
            LoadSavedButton.Name = "LoadSavedButton";
            LoadSavedButton.Size = new System.Drawing.Size(63, 46);
            LoadSavedButton.TabIndex = 23;
            LoadSavedButton.Text = "Load Cutting";
            LoadSavedButton.UseVisualStyleBackColor = true;
            // 
            // AddressTextBox
            // 
            AddressTextBox.Location = new System.Drawing.Point(14, 69);
            AddressTextBox.Name = "AddressTextBox";
            AddressTextBox.Size = new System.Drawing.Size(228, 20);
            AddressTextBox.TabIndex = 5;
            // 
            // ModeCombo
            // 
            ModeCombo.FormattingEnabled = true;
            ModeCombo.Location = new System.Drawing.Point(97, 395);
            ModeCombo.Name = "ModeCombo";
            ModeCombo.Size = new System.Drawing.Size(141, 21);
            ModeCombo.TabIndex = 22;
            // 
            // textBox3
            // 
            textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            textBox3.Location = new System.Drawing.Point(9, 138);
            textBox3.Name = "textBox3";
            textBox3.ReadOnly = true;
            textBox3.Size = new System.Drawing.Size(100, 13);
            textBox3.TabIndex = 6;
            textBox3.Text = "Selected Sprite";
            // 
            // textBox18
            // 
            textBox18.BorderStyle = System.Windows.Forms.BorderStyle.None;
            textBox18.Location = new System.Drawing.Point(10, 369);
            textBox18.Name = "textBox18";
            textBox18.ReadOnly = true;
            textBox18.Size = new System.Drawing.Size(228, 13);
            textBox18.TabIndex = 21;
            textBox18.Text = "Pivot Offset";
            // 
            // textBox4
            // 
            textBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            textBox4.Location = new System.Drawing.Point(9, 177);
            textBox4.Name = "textBox4";
            textBox4.ReadOnly = true;
            textBox4.Size = new System.Drawing.Size(72, 13);
            textBox4.TabIndex = 7;
            textBox4.Text = "Sprite number :";
            // 
            // OffXbox
            // 
            OffXbox.AllowDrop = true;
            OffXbox.Location = new System.Drawing.Point(50, 396);
            OffXbox.Name = "OffXbox";
            OffXbox.Size = new System.Drawing.Size(41, 20);
            OffXbox.TabIndex = 20;
            OffXbox.TextChanged += new System.EventHandler(OffXbox_TextChanged);
            // 
            // SpriteNumberTextBox
            // 
            SpriteNumberTextBox.Location = new System.Drawing.Point(87, 177);
            SpriteNumberTextBox.Name = "SpriteNumberTextBox";
            SpriteNumberTextBox.Size = new System.Drawing.Size(31, 20);
            SpriteNumberTextBox.TabIndex = 8;
            SpriteNumberTextBox.Text = "0";
            SpriteNumberTextBox.TextChanged += new System.EventHandler(SpriteNumberTextBox_TextChanged);
            // 
            // textBox17
            // 
            textBox17.BorderStyle = System.Windows.Forms.BorderStyle.None;
            textBox17.Location = new System.Drawing.Point(30, 399);
            textBox17.Name = "textBox17";
            textBox17.ReadOnly = true;
            textBox17.Size = new System.Drawing.Size(14, 13);
            textBox17.TabIndex = 19;
            textBox17.Text = "X :";
            // 
            // textBox6
            // 
            textBox6.BorderStyle = System.Windows.Forms.BorderStyle.None;
            textBox6.Location = new System.Drawing.Point(10, 258);
            textBox6.Name = "textBox6";
            textBox6.ReadOnly = true;
            textBox6.Size = new System.Drawing.Size(100, 13);
            textBox6.TabIndex = 9;
            textBox6.Text = "Position";
            // 
            // SizeYbox
            // 
            SizeYbox.AllowDrop = true;
            SizeYbox.Location = new System.Drawing.Point(117, 329);
            SizeYbox.Name = "SizeYbox";
            SizeYbox.Size = new System.Drawing.Size(41, 20);
            SizeYbox.TabIndex = 18;
            SizeYbox.TextChanged += new System.EventHandler(SizeYbox_TextChanged);
            // 
            // textBox7
            // 
            textBox7.BorderStyle = System.Windows.Forms.BorderStyle.None;
            textBox7.Location = new System.Drawing.Point(97, 280);
            textBox7.Name = "textBox7";
            textBox7.ReadOnly = true;
            textBox7.Size = new System.Drawing.Size(14, 13);
            textBox7.TabIndex = 10;
            textBox7.Text = "Y : ";
            // 
            // textBox15
            // 
            textBox15.BorderStyle = System.Windows.Forms.BorderStyle.None;
            textBox15.Location = new System.Drawing.Point(97, 332);
            textBox15.Name = "textBox15";
            textBox15.ReadOnly = true;
            textBox15.Size = new System.Drawing.Size(14, 13);
            textBox15.TabIndex = 17;
            textBox15.Text = "H :";
            // 
            // textBox8
            // 
            textBox8.BorderStyle = System.Windows.Forms.BorderStyle.None;
            textBox8.Location = new System.Drawing.Point(30, 306);
            textBox8.Name = "textBox8";
            textBox8.ReadOnly = true;
            textBox8.Size = new System.Drawing.Size(100, 13);
            textBox8.TabIndex = 11;
            textBox8.Text = "Size";
            // 
            // SizeXbox
            // 
            SizeXbox.AllowDrop = true;
            SizeXbox.Location = new System.Drawing.Point(50, 329);
            SizeXbox.Name = "SizeXbox";
            SizeXbox.Size = new System.Drawing.Size(41, 20);
            SizeXbox.TabIndex = 16;
            SizeXbox.TextChanged += new System.EventHandler(SizeXbox_TextChanged);
            // 
            // PosYbox
            // 
            PosYbox.AllowDrop = true;
            PosYbox.Location = new System.Drawing.Point(117, 277);
            PosYbox.Name = "PosYbox";
            PosYbox.Size = new System.Drawing.Size(41, 20);
            PosYbox.TabIndex = 12;
            PosYbox.TextChanged += new System.EventHandler(PosYbox_TextChanged);
            // 
            // textBox13
            // 
            textBox13.BorderStyle = System.Windows.Forms.BorderStyle.None;
            textBox13.Location = new System.Drawing.Point(30, 332);
            textBox13.Name = "textBox13";
            textBox13.ReadOnly = true;
            textBox13.Size = new System.Drawing.Size(24, 13);
            textBox13.TabIndex = 15;
            textBox13.Text = "W :";
            // 
            // textBox11
            // 
            textBox11.BorderStyle = System.Windows.Forms.BorderStyle.None;
            textBox11.Location = new System.Drawing.Point(30, 280);
            textBox11.Name = "textBox11";
            textBox11.ReadOnly = true;
            textBox11.Size = new System.Drawing.Size(14, 13);
            textBox11.TabIndex = 13;
            textBox11.Text = "X :";
            // 
            // PosXbox
            // 
            PosXbox.AllowDrop = true;
            PosXbox.Location = new System.Drawing.Point(50, 277);
            PosXbox.Name = "PosXbox";
            PosXbox.Size = new System.Drawing.Size(41, 20);
            PosXbox.TabIndex = 14;
            PosXbox.TextChanged += new System.EventHandler(PosXbox_TextChanged);
            // 
            // Form1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(996, 571);
            Controls.Add(panel2);
            Controls.Add(pictureBox1);
            Name = "Form1";
            Text = "Sprite Slicer.exe";
            Load += new System.EventHandler(Form1_Load);
            Paint += new System.Windows.Forms.PaintEventHandler(Form1_Paint);
            ((System.ComponentModel.ISupportInitialize)(pictureBox1)).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox Title1;
        private System.Windows.Forms.TextBox OffYbox;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.TextBox textBox20;
        private System.Windows.Forms.Button LoadSheetButton;
        private System.Windows.Forms.Button LoadSavedButton;
        private System.Windows.Forms.TextBox AddressTextBox;
        private System.Windows.Forms.ComboBox ModeCombo;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox18;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox OffXbox;
        private System.Windows.Forms.TextBox SpriteNumberTextBox;
        private System.Windows.Forms.TextBox textBox17;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox SizeYbox;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox15;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox SizeXbox;
        private System.Windows.Forms.TextBox PosYbox;
        private System.Windows.Forms.TextBox textBox13;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.TextBox PosXbox;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox SpriteNameTextBox;
    }
}

