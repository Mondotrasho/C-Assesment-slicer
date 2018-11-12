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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Title1 = new System.Windows.Forms.TextBox();
            this.OffYbox = new System.Windows.Forms.TextBox();
            this.SaveButton = new System.Windows.Forms.Button();
            this.textBox20 = new System.Windows.Forms.TextBox();
            this.LoadSheetButton = new System.Windows.Forms.Button();
            this.LoadSavedButton = new System.Windows.Forms.Button();
            this.AdressTextBox = new System.Windows.Forms.TextBox();
            this.ModeCombo = new System.Windows.Forms.ComboBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox18 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.OffXbox = new System.Windows.Forms.TextBox();
            this.SpriteNumberTextBox = new System.Windows.Forms.TextBox();
            this.textBox17 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.SizeYbox = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox15 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.SizeXbox = new System.Windows.Forms.TextBox();
            this.PosYbox = new System.Windows.Forms.TextBox();
            this.textBox13 = new System.Windows.Forms.TextBox();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.PosXbox = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SpriteNameTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(695, 546);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel2.Controls.Add(this.textBox2);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Location = new System.Drawing.Point(713, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(271, 547);
            this.panel2.TabIndex = 27;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(3, 3);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(14, 89);
            this.textBox2.TabIndex = 26;
            this.textBox2.Text = "POINTS";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.SpriteNameTextBox);
            this.panel1.Controls.Add(this.Title1);
            this.panel1.Controls.Add(this.OffYbox);
            this.panel1.Controls.Add(this.SaveButton);
            this.panel1.Controls.Add(this.textBox20);
            this.panel1.Controls.Add(this.LoadSheetButton);
            this.panel1.Controls.Add(this.LoadSavedButton);
            this.panel1.Controls.Add(this.AdressTextBox);
            this.panel1.Controls.Add(this.ModeCombo);
            this.panel1.Controls.Add(this.textBox3);
            this.panel1.Controls.Add(this.textBox18);
            this.panel1.Controls.Add(this.textBox4);
            this.panel1.Controls.Add(this.OffXbox);
            this.panel1.Controls.Add(this.SpriteNumberTextBox);
            this.panel1.Controls.Add(this.textBox17);
            this.panel1.Controls.Add(this.textBox6);
            this.panel1.Controls.Add(this.SizeYbox);
            this.panel1.Controls.Add(this.textBox7);
            this.panel1.Controls.Add(this.textBox15);
            this.panel1.Controls.Add(this.textBox8);
            this.panel1.Controls.Add(this.SizeXbox);
            this.panel1.Controls.Add(this.PosYbox);
            this.panel1.Controls.Add(this.textBox13);
            this.panel1.Controls.Add(this.textBox11);
            this.panel1.Controls.Add(this.PosXbox);
            this.panel1.Location = new System.Drawing.Point(23, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(245, 541);
            this.panel1.TabIndex = 27;
            // 
            // Title1
            // 
            this.Title1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Title1.Location = new System.Drawing.Point(10, 45);
            this.Title1.Name = "Title1";
            this.Title1.ReadOnly = true;
            this.Title1.Size = new System.Drawing.Size(108, 13);
            this.Title1.TabIndex = 4;
            this.Title1.Text = "Loaded Sprite Sheet:";
            // 
            // OffYbox
            // 
            this.OffYbox.AllowDrop = true;
            this.OffYbox.Location = new System.Drawing.Point(50, 422);
            this.OffYbox.Name = "OffYbox";
            this.OffYbox.Size = new System.Drawing.Size(41, 20);
            this.OffYbox.TabIndex = 25;
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(10, 468);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(90, 46);
            this.SaveButton.TabIndex = 0;
            this.SaveButton.Text = "Export Cutting";
            this.SaveButton.UseVisualStyleBackColor = true;
            // 
            // textBox20
            // 
            this.textBox20.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox20.Location = new System.Drawing.Point(30, 425);
            this.textBox20.Name = "textBox20";
            this.textBox20.ReadOnly = true;
            this.textBox20.Size = new System.Drawing.Size(14, 13);
            this.textBox20.TabIndex = 24;
            this.textBox20.Text = "Y :";
            // 
            // LoadSheetButton
            // 
            this.LoadSheetButton.Location = new System.Drawing.Point(175, 468);
            this.LoadSheetButton.Name = "LoadSheetButton";
            this.LoadSheetButton.Size = new System.Drawing.Size(63, 46);
            this.LoadSheetButton.TabIndex = 2;
            this.LoadSheetButton.Text = "Load Sheet";
            this.LoadSheetButton.UseVisualStyleBackColor = true;
            // 
            // LoadSavedButton
            // 
            this.LoadSavedButton.Location = new System.Drawing.Point(106, 468);
            this.LoadSavedButton.Name = "LoadSavedButton";
            this.LoadSavedButton.Size = new System.Drawing.Size(63, 46);
            this.LoadSavedButton.TabIndex = 23;
            this.LoadSavedButton.Text = "Load Cutting";
            this.LoadSavedButton.UseVisualStyleBackColor = true;
            // 
            // AdressTextBox
            // 
            this.AdressTextBox.Location = new System.Drawing.Point(10, 72);
            this.AdressTextBox.Name = "AdressTextBox";
            this.AdressTextBox.Size = new System.Drawing.Size(228, 20);
            this.AdressTextBox.TabIndex = 5;
            // 
            // ModeCombo
            // 
            this.ModeCombo.FormattingEnabled = true;
            this.ModeCombo.Location = new System.Drawing.Point(97, 395);
            this.ModeCombo.Name = "ModeCombo";
            this.ModeCombo.Size = new System.Drawing.Size(141, 21);
            this.ModeCombo.TabIndex = 22;
            // 
            // textBox3
            // 
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.Location = new System.Drawing.Point(9, 138);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(100, 13);
            this.textBox3.TabIndex = 6;
            this.textBox3.Text = "Selected Sprite";
            // 
            // textBox18
            // 
            this.textBox18.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox18.Location = new System.Drawing.Point(10, 369);
            this.textBox18.Name = "textBox18";
            this.textBox18.ReadOnly = true;
            this.textBox18.Size = new System.Drawing.Size(228, 13);
            this.textBox18.TabIndex = 21;
            this.textBox18.Text = "Pivot Offset";
            // 
            // textBox4
            // 
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox4.Location = new System.Drawing.Point(9, 177);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(72, 13);
            this.textBox4.TabIndex = 7;
            this.textBox4.Text = "Sprite number :";
            // 
            // OffXbox
            // 
            this.OffXbox.AllowDrop = true;
            this.OffXbox.Location = new System.Drawing.Point(50, 396);
            this.OffXbox.Name = "OffXbox";
            this.OffXbox.Size = new System.Drawing.Size(41, 20);
            this.OffXbox.TabIndex = 20;
            // 
            // SpriteNumberTextBox
            // 
            this.SpriteNumberTextBox.Location = new System.Drawing.Point(87, 177);
            this.SpriteNumberTextBox.Name = "SpriteNumberTextBox";
            this.SpriteNumberTextBox.Size = new System.Drawing.Size(31, 20);
            this.SpriteNumberTextBox.TabIndex = 8;
            // 
            // textBox17
            // 
            this.textBox17.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox17.Location = new System.Drawing.Point(30, 399);
            this.textBox17.Name = "textBox17";
            this.textBox17.ReadOnly = true;
            this.textBox17.Size = new System.Drawing.Size(14, 13);
            this.textBox17.TabIndex = 19;
            this.textBox17.Text = "X :";
            // 
            // textBox6
            // 
            this.textBox6.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox6.Location = new System.Drawing.Point(10, 258);
            this.textBox6.Name = "textBox6";
            this.textBox6.ReadOnly = true;
            this.textBox6.Size = new System.Drawing.Size(100, 13);
            this.textBox6.TabIndex = 9;
            this.textBox6.Text = "Position";
            // 
            // SizeYbox
            // 
            this.SizeYbox.AllowDrop = true;
            this.SizeYbox.Location = new System.Drawing.Point(117, 329);
            this.SizeYbox.Name = "SizeYbox";
            this.SizeYbox.Size = new System.Drawing.Size(41, 20);
            this.SizeYbox.TabIndex = 18;
            // 
            // textBox7
            // 
            this.textBox7.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox7.Location = new System.Drawing.Point(97, 280);
            this.textBox7.Name = "textBox7";
            this.textBox7.ReadOnly = true;
            this.textBox7.Size = new System.Drawing.Size(14, 13);
            this.textBox7.TabIndex = 10;
            this.textBox7.Text = "Y : ";
            // 
            // textBox15
            // 
            this.textBox15.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox15.Location = new System.Drawing.Point(97, 332);
            this.textBox15.Name = "textBox15";
            this.textBox15.ReadOnly = true;
            this.textBox15.Size = new System.Drawing.Size(14, 13);
            this.textBox15.TabIndex = 17;
            this.textBox15.Text = "H :";
            // 
            // textBox8
            // 
            this.textBox8.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox8.Location = new System.Drawing.Point(30, 306);
            this.textBox8.Name = "textBox8";
            this.textBox8.ReadOnly = true;
            this.textBox8.Size = new System.Drawing.Size(100, 13);
            this.textBox8.TabIndex = 11;
            this.textBox8.Text = "Size";
            // 
            // SizeXbox
            // 
            this.SizeXbox.AllowDrop = true;
            this.SizeXbox.Location = new System.Drawing.Point(50, 329);
            this.SizeXbox.Name = "SizeXbox";
            this.SizeXbox.Size = new System.Drawing.Size(41, 20);
            this.SizeXbox.TabIndex = 16;
            // 
            // PosYbox
            // 
            this.PosYbox.AllowDrop = true;
            this.PosYbox.Location = new System.Drawing.Point(117, 277);
            this.PosYbox.Name = "PosYbox";
            this.PosYbox.Size = new System.Drawing.Size(41, 20);
            this.PosYbox.TabIndex = 12;
            // 
            // textBox13
            // 
            this.textBox13.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox13.Location = new System.Drawing.Point(30, 332);
            this.textBox13.Name = "textBox13";
            this.textBox13.ReadOnly = true;
            this.textBox13.Size = new System.Drawing.Size(24, 13);
            this.textBox13.TabIndex = 15;
            this.textBox13.Text = "W :";
            // 
            // textBox11
            // 
            this.textBox11.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox11.Location = new System.Drawing.Point(30, 280);
            this.textBox11.Name = "textBox11";
            this.textBox11.ReadOnly = true;
            this.textBox11.Size = new System.Drawing.Size(14, 13);
            this.textBox11.TabIndex = 13;
            this.textBox11.Text = "X :";
            // 
            // PosXbox
            // 
            this.PosXbox.AllowDrop = true;
            this.PosXbox.Location = new System.Drawing.Point(50, 277);
            this.PosXbox.Name = "PosXbox";
            this.PosXbox.Size = new System.Drawing.Size(41, 20);
            this.PosXbox.TabIndex = 14;
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Location = new System.Drawing.Point(10, 220);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(34, 13);
            this.textBox1.TabIndex = 26;
            this.textBox1.Text = "Name :";
            // 
            // SpriteNameTextBox
            // 
            this.SpriteNameTextBox.Location = new System.Drawing.Point(50, 220);
            this.SpriteNameTextBox.Name = "SpriteNameTextBox";
            this.SpriteNameTextBox.Size = new System.Drawing.Size(188, 20);
            this.SpriteNameTextBox.TabIndex = 27;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(996, 571);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Sprite Slicer.exe";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.TextBox AdressTextBox;
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

