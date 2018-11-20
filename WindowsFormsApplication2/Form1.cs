using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    using System.IO;

    using WindowsFormstutorial;

    public partial class Form1 : Form
    {
        //public Creator store;
        public Form1()
        {
            Slicing = new SpriteSlice();
            InitializeComponent();
        }

        private SpriteSlice Slicing;

        public int ActiveIndex;
        //public Cutting myCutt;
        //public List<Cutting> Cuttings;

        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = this.pictureBox1.CreateGraphics();
            this.Slicing.Draw(g);
        }
        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            //if clicked
            if (e.GetType() == typeof(MouseEventArgs))
            {
                MouseEventArgs me = e as MouseEventArgs;
                this.PosXbox.Text = me.Location.X.ToString();
                this.PosYbox.Text = me.Location.Y.ToString();
            }
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            Stream myStream;
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            saveFileDialog1.FilterIndex = 2;
            saveFileDialog1.RestoreDirectory = true;
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if ((myStream = saveFileDialog1.OpenFile()) != null)
                {
                    // myStream = saveFileDialog1.OpenFile();
                    var writer = new StreamWriter(myStream);
                    {
                        this.Slicing.Write(writer);

                        writer.Close();
                        myStream.Dispose();
                        myStream.Close();
                    }
                }

            }
        }

        private void SpriteNumberTextBox_TextChanged(object sender, EventArgs e)
        {
            ActiveIndex = Convert.ToInt32(this.SpriteNumberTextBox.Text);
            this.Slicing.checkAndAdd(this.ActiveIndex);
            this.Slicing.Cuttings[ActiveIndex].Number = ActiveIndex;

            //Updates the other text fields as slave to 
            this.SpriteNameTextBox.Text = this.Slicing.Cuttings[ActiveIndex].Name;
            this.PosXbox.Text = this.Slicing.Cuttings[ActiveIndex].Pos.X.ToString();
            this.PosYbox.Text = this.Slicing.Cuttings[ActiveIndex].Pos.Y.ToString();
            this.SizeXbox.Text = this.Slicing.Cuttings[ActiveIndex].Size.X.ToString();
            this.SizeYbox.Text = this.Slicing.Cuttings[ActiveIndex].Size.Y.ToString();
            this.OffXbox.Text = this.Slicing.Cuttings[ActiveIndex].PivotOffset.X.ToString();
            this.OffYbox.Text = this.Slicing.Cuttings[ActiveIndex].PivotOffset.Y.ToString();
        }

        private void SpriteNameTextBox_TextChanged(object sender, EventArgs e)
        {
            this.Slicing.Cuttings[ActiveIndex].Name = this.SpriteNameTextBox.Text;
        }

        private void PosXbox_TextChanged(object sender, EventArgs e)
        {
            this.Slicing.Cuttings[ActiveIndex].Pos.X = Convert.ToInt32(this.PosXbox.Text);
        }

        private void PosYbox_TextChanged(object sender, EventArgs e)
        {
            this.Slicing.Cuttings[ActiveIndex].Pos.Y = Convert.ToInt32(this.PosYbox.Text);
        }

        private void SizeXbox_TextChanged(object sender, EventArgs e)
        {
            this.Slicing.Cuttings[ActiveIndex].Size.X = Convert.ToInt32(this.SizeXbox.Text);
        }

        private void SizeYbox_TextChanged(object sender, EventArgs e)
        {
            this.Slicing.Cuttings[ActiveIndex].Size.Y = Convert.ToInt32(this.SizeYbox.Text);
        }

        private void OffXbox_TextChanged(object sender, EventArgs e)
        {
            this.Slicing.Cuttings[ActiveIndex].PivotOffset.X = Convert.ToInt32(this.OffXbox.Text);
        }

        private void OffYbox_TextChanged(object sender, EventArgs e)
        {
            this.Slicing.Cuttings[ActiveIndex].PivotOffset.Y = Convert.ToInt32(this.OffYbox.Text);
        }

        private void LoadSheetButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.Filter = "bmp files (*.bmp)|*.bmp";

            openFileDialog.FilterIndex = 2;
            openFileDialog.RestoreDirectory = true;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                this.pictureBox1.Image = new Bitmap(openFileDialog.FileName);
                this.AddressTextBox.Text = openFileDialog.FileName;
            }

        }
    }
}
