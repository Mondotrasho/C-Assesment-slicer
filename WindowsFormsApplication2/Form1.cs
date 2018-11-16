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
            //store = new Creator();
            //store.Box = new List<int[]>();
            Cuttings = new List<Cutting>();
            InitializeComponent();
        }

        //public Cutting myCutt;
        public List<Cutting> Cuttings;

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            if (e.GetType() == typeof(MouseEventArgs))
            {

                int selected = Convert.ToInt32(this.SpriteNumberTextBox.Text);
                var cuttings = this.Cuttings;
                if (cuttings != null)
                {
                    cuttings.Add(new Cutting());
                }

                MouseEventArgs me = e as MouseEventArgs;
                this.PosXbox.Text = me.Location.X.ToString();
                this.PosYbox.Text = me.Location.Y.ToString();
                cuttings[selected].Pos = new Cutting.Vector2(me.Location.X, me.Location.Y);
                cuttings[selected].DrawPoint(this.pictureBox1);

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
                        foreach (var cutting in this.Cuttings)
                        {
                            cutting.Write(writer);

                        }

                        writer.Close();
                        myStream.Dispose();
                        myStream.Close();
                    }
                }

            }
        }

        private void SpriteNameTextBox_TextChanged(object sender, EventArgs e)
        {
            this.Cuttings[Convert.ToInt32(this.SpriteNumberTextBox.Text)].Name = this.SpriteNameTextBox.Text;
        }

        private void PosXbox_TextChanged(object sender, EventArgs e)
        {
            this.Cuttings[Convert.ToInt32(this.SpriteNumberTextBox.Text)].Pos.X = Convert.ToInt32(this.PosXbox.Text);
        }

        private void PosYbox_TextChanged(object sender, EventArgs e)
        {
            this.Cuttings[Convert.ToInt32(this.SpriteNumberTextBox.Text)].Pos.Y = Convert.ToInt32(this.PosYbox.Text);
        }

        private void SizeXbox_TextChanged(object sender, EventArgs e)
        {
            this.Cuttings[Convert.ToInt32(this.SpriteNumberTextBox.Text)].Size.X = Convert.ToInt32(this.SizeXbox.Text);
        }

        private void SizeYbox_TextChanged(object sender, EventArgs e)
        {
            this.Cuttings[Convert.ToInt32(this.SpriteNumberTextBox.Text)].Size.Y = Convert.ToInt32(this.SizeYbox.Text);
        }

        private void OffXbox_TextChanged(object sender, EventArgs e)
        {
            this.Cuttings[Convert.ToInt32(this.SpriteNumberTextBox.Text)].PivotOffset.X = Convert.ToInt32(this.OffXbox.Text);
        }

        private void OffYbox_TextChanged(object sender, EventArgs e)
        {
            this.Cuttings[Convert.ToInt32(this.SpriteNumberTextBox.Text)].PivotOffset.Y = Convert.ToInt32(this.OffYbox.Text);
        }
        
    }
}
