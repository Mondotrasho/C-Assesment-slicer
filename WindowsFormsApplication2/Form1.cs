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
    using System.Diagnostics;
    using System.IO;

    using WindowsFormstutorial;

    public partial class Form1 : Form
    {
        //public Creator store;
        public Form1()
        {
            InitializeComponent();
            resetTextFields();

            image = new Bitmap(pictureBox1.BackgroundImage);
        }

        private SpriteSlice Slicing = new SpriteSlice();

        public int ActiveIndex = 0;

        private Image image;

        //public Cutting myCutt;
        //public List<Cutting> Cuttings;

        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(Form1_Paint);
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = pictureBox1.CreateGraphics();
            g.DrawImage(image ,new Point(0,0));
            Slicing.Draw(g,this.ActiveIndex);
        }
        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            //if clicked
            if (e.GetType() == typeof(MouseEventArgs))
            {
                MouseEventArgs me = e as MouseEventArgs;
                PosXbox.Text = me.Location.X.ToString();
                PosYbox.Text = me.Location.Y.ToString();
                this.Invalidate();
            }
        }


        private void SpriteNumberTextBox_TextChanged(object sender, EventArgs e)
        {
            ActiveIndex = Convert.ToInt32(SpriteNumberTextBox.Text);
            Slicing.checkAndAdd(ActiveIndex);
            Slicing.Cuttings[ActiveIndex].Number = ActiveIndex;

            //Invalidates the other text fields as slave to 
            SpriteNameTextBox.Text = Slicing.Cuttings[ActiveIndex].Name;
            PosXbox.Text = Slicing.Cuttings[ActiveIndex].Pos.X.ToString();
            PosYbox.Text = Slicing.Cuttings[ActiveIndex].Pos.Y.ToString();
            SizeXbox.Text = Slicing.Cuttings[ActiveIndex].Size.X.ToString();
            SizeYbox.Text = Slicing.Cuttings[ActiveIndex].Size.Y.ToString();
            OffXbox.Text = Slicing.Cuttings[ActiveIndex].PivotOffset.X.ToString();
            OffYbox.Text = Slicing.Cuttings[ActiveIndex].PivotOffset.Y.ToString();
            this.Invalidate();
        }

        private void SpriteNameTextBox_TextChanged(object sender, EventArgs e)
        {
            Slicing.Cuttings[ActiveIndex].Name = SpriteNameTextBox.Text;
        }

        private void PosXbox_TextChanged(object sender, EventArgs e)
        {
            Slicing.Cuttings[ActiveIndex].Pos.X = Convert.ToInt32(PosXbox.Text);
            this.Invalidate();
        }

        private void PosYbox_TextChanged(object sender, EventArgs e)
        {
            Slicing.Cuttings[ActiveIndex].Pos.Y = Convert.ToInt32(PosYbox.Text);
            this.Invalidate();
        }

        private void SizeXbox_TextChanged(object sender, EventArgs e)
        {
            Slicing.Cuttings[ActiveIndex].Size.X = Convert.ToInt32(SizeXbox.Text);
            this.Invalidate();
        }

        private void SizeYbox_TextChanged(object sender, EventArgs e)
        {
            Slicing.Cuttings[ActiveIndex].Size.Y = Convert.ToInt32(SizeYbox.Text);
            this.Invalidate();
        }

        private void OffXbox_TextChanged(object sender, EventArgs e)
        {
            Slicing.Cuttings[ActiveIndex].PivotOffset.X = Convert.ToInt32(OffXbox.Text);
            this.Invalidate();
        }

        private void OffYbox_TextChanged(object sender, EventArgs e)
        {
            Slicing.Cuttings[ActiveIndex].PivotOffset.Y = Convert.ToInt32(OffYbox.Text);
            this.Invalidate();
        }

        private void LoadSheetButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.Filter = "bmp files (*.bmp)|*.bmp";

            openFileDialog.FilterIndex = 2;
            openFileDialog.RestoreDirectory = true;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                //pictureBox1.Image
                
                this.image = new Bitmap(openFileDialog.FileName);
                AddressTextBox.Text = openFileDialog.FileName;
                this.Invalidate();
            }

        }

        private void LoadSavedButton_Click(object sender, EventArgs e)
        {
            Stream stream;
            OpenFileDialog openFileDialog = new OpenFileDialog();
            //looking for csv
            openFileDialog.Filter = "csv files (*.csv)|*.csv";
            openFileDialog.RestoreDirectory = true;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                if ((stream = openFileDialog.OpenFile()) != null)
                {
                    var reader = new StreamReader(stream);
                    {
                        Slicing.Read(reader);

                        reader.Close();
                        stream.Dispose();
                        stream.Close();
                    }
                    resetTextFields();
                }
            }
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            Stream myStream;
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "csv files (*.csv)|*.csv";
            saveFileDialog1.FilterIndex = 2;
            saveFileDialog1.RestoreDirectory = true;
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if ((myStream = saveFileDialog1.OpenFile()) != null)
                {
                    var writer = new StreamWriter(myStream);
                    {
                        Slicing.Write(writer);

                        writer.Close();
                        myStream.Dispose();
                        myStream.Close();
                    }
                }

            }
        }

        private void resetTextFields()
        {
            this.ActiveIndex = 0;
            this.SpriteNumberTextBox.Text = ActiveIndex.ToString();
            SpriteNameTextBox.Text = Slicing.Cuttings[ActiveIndex].Name;
            PosXbox.Text = Slicing.Cuttings[ActiveIndex].Pos.X.ToString();
            PosYbox.Text = Slicing.Cuttings[ActiveIndex].Pos.Y.ToString();
            SizeXbox.Text = Slicing.Cuttings[ActiveIndex].Size.X.ToString();
            SizeYbox.Text = Slicing.Cuttings[ActiveIndex].Size.Y.ToString();
            OffXbox.Text = Slicing.Cuttings[ActiveIndex].PivotOffset.X.ToString();
            OffYbox.Text = Slicing.Cuttings[ActiveIndex].PivotOffset.Y.ToString();
            this.Invalidate();
        }

        private void JsonTest_Click(object sender, EventArgs e)
        {
            this.Slicing.JsonSerialize();
        }

        private string getExtension(string file)
        {
            return Path.GetExtension(file);

        }

        private void Form1_DragDrop(object sender, DragEventArgs e)
        {
            //Take dropped items and store in array
            string[] droppedFiles = (string[])e.Data.GetData(DataFormats.FileDrop);

            //loop through all dropped iteams and display them
            foreach (var file in droppedFiles)
            {
                string fileType = getExtension(file);
                if (fileType == ".bmp")
                {
                    this.image = new Bitmap(file);
                    AddressTextBox.Text = file.ToString();
                    this.Invalidate();
                }
                if (fileType == ".csv")
                {
                    // open stream
                    Stream stream;
                    //using file dialog cause idk another way to do it plus it makes it compatible with the existing Read function for slices
                    OpenFileDialog openFileDialog = new OpenFileDialog();
                    //set to file
                    openFileDialog.FileName = file;
                    stream = openFileDialog.OpenFile();
                    var reader = new StreamReader(stream);
                    Slicing.Read(reader);
                    reader.Close();
                    resetTextFields();
                    this.Invalidate();
                }
            }
        }

        private void Form1_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop, false) == true)
            {
                e.Effect = DragDropEffects.All;
            }
        }
    }
}
