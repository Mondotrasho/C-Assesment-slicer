using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication2
{
    using System.Drawing;
    using System.IO;
    using System.Runtime.Serialization;
    using System.Windows.Forms;
    [DataContract]
    public class Cutting
    {
        public struct Vector2
        {
            [DataMember(Name = "X", IsRequired = true)]
            public int X;
            [DataMember(Name = "Y", IsRequired = true)]
            public int Y;
            public Vector2(int x, int y)
            {
                X = x;
                Y = y;
            }
            public void Write(StreamWriter writer)
            {
                writer.Write(X + "," + Y + ",");
            }

        }
        [DataMember(Name = "Number", IsRequired = true)]
        public int Number = 0;
        [DataMember(Name = "Name", IsRequired = true)]
        public string Name = String.Empty;
        [DataMember(Name = "Pos", IsRequired = true)]
        public Vector2 Pos = new Vector2(0, 0);
        [DataMember(Name = "Size", IsRequired = true)]
        public Vector2 Size = new Vector2(10, 10);
        [DataMember(Name = "PivotOffset", IsRequired = true)]
        public Vector2 PivotOffset = new Vector2(0, 0);
        
        public void Write(StreamWriter writer)
        {
            writer.Write(Number + ",");
            writer.Write(Name + ",");
            Pos.Write(writer);
            Size.Write(writer);
            PivotOffset.Write(writer);
            writer.WriteLine();
        }

        public void DrawPoint(Graphics g)
        {

            Color red = Color.DarkRed;
            Color green = Color.Green;
            Color black = Color.Black;
            Color blue = Color.Blue;
            

            Pen penred = new Pen(red);
            SolidBrush fillred = new SolidBrush(red);
            Pen pengreen = new Pen(green);
            SolidBrush fillgreen = new SolidBrush(green);
            Pen penblack = new Pen(black);
            SolidBrush fillblack = new SolidBrush(black);
            Pen penblue = new Pen(blue);
            SolidBrush fillblue = new SolidBrush(blue);
            
            //draw Box
            g.DrawRectangle(penblack, new Rectangle(Pos.X - (Size.X / 2),Pos.Y - (Size.Y / 2),Size.X ,Size.Y));

            //find Pivot
            //positive because left to right is down to up
            var centerX = Pos.X + PivotOffset.X;
            //negative because bot to top is up to down
            var centerY = Pos.Y - PivotOffset.Y;

            //draw Middle/Pivot
            g.DrawRectangle(penred, new Rectangle(centerX, centerY - 6, 1, 13));
            g.DrawRectangle(penred, new Rectangle(centerX - 6, centerY, 13, 1));
            g.FillEllipse(fillred, new Rectangle(centerX - 2, centerY - 2, 5, 5));
            //draw bot left
            g.DrawRectangle(penblue, new Rectangle(Pos.X - (Size.X / 2), Pos.Y + (Size.Y / 2) - 6, 1, 13));
            g.DrawRectangle(penblue, new Rectangle(Pos.X - (Size.X / 2) - 6, Pos.Y + (Size.Y / 2), 13, 1));
            g.FillEllipse(fillblue, new Rectangle(Pos.X - (Size.X / 2) - 2, Pos.Y + (Size.Y / 2) - 2, 5, 5));
            //draw bot Right
            g.DrawRectangle(penblue, new Rectangle(Pos.X + (Size.X / 2), Pos.Y + (Size.Y / 2) - 6, 1, 13));
            g.DrawRectangle(penblue, new Rectangle(Pos.X + (Size.X / 2) - 6, Pos.Y + (Size.Y / 2), 13, 1));
            g.FillEllipse(fillblue, new Rectangle(Pos.X + (Size.X / 2) - 2, Pos.Y + (Size.Y / 2) - 2, 5, 5));
            //draw top left
            g.DrawRectangle(penblue, new Rectangle(Pos.X - (Size.X / 2), Pos.Y - (Size.Y / 2) - 6, 1, 13));
            g.DrawRectangle(penblue, new Rectangle(Pos.X - (Size.X / 2) - 6, Pos.Y - (Size.Y / 2), 13, 1));
            g.FillEllipse(fillblue, new Rectangle(Pos.X - (Size.X / 2) - 2, Pos.Y - (Size.Y / 2) - 2, 5, 5));
            //draw top right
            g.DrawRectangle(penblue, new Rectangle(Pos.X + (Size.X / 2), Pos.Y - (Size.Y / 2) - 6, 1, 13));
            g.DrawRectangle(penblue, new Rectangle(Pos.X + (Size.X / 2) - 6, Pos.Y - (Size.Y / 2), 13, 1));
            g.FillEllipse(fillblue, new Rectangle(Pos.X + (Size.X / 2) - 2, Pos.Y - (Size.Y / 2) - 2, 5, 5));


        }

        public void DrawPointSelected(Graphics g)
        {

            Color red = Color.Red;
            Color green = Color.Green;
            Color black = Color.Black;
            Color blue = Color.Blue;


            Pen penred = new Pen(red);
            SolidBrush fillred = new SolidBrush(red);
            Pen pengreen = new Pen(green);
            SolidBrush fillgreen = new SolidBrush(green);
            Pen penblack = new Pen(black);
            SolidBrush fillblack = new SolidBrush(black);
            Pen penblue = new Pen(blue);
            SolidBrush fillblue = new SolidBrush(blue);

            //draw Box
            g.DrawRectangle(penblack, new Rectangle(Pos.X - (Size.X / 2), Pos.Y - (Size.Y / 2), Size.X, Size.Y));

            //find Pivot
            //positive because left to right is down to up
            var centerX = Pos.X + PivotOffset.X;
            //negative because bot to top is up to down
            var centerY = Pos.Y - PivotOffset.Y;

            //draw Middle/Pivot
            g.DrawRectangle(pengreen, new Rectangle(centerX, centerY - 6, 1, 13));
            g.DrawRectangle(pengreen, new Rectangle(centerX - 6, centerY, 13, 1));
            g.FillEllipse(fillgreen, new Rectangle(centerX - 2, centerY - 2, 5, 5));
            //draw bot left
            g.DrawRectangle(pengreen, new Rectangle(Pos.X - (Size.X / 2), Pos.Y + (Size.Y / 2) - 6, 1, 13));
            g.DrawRectangle(pengreen, new Rectangle(Pos.X - (Size.X / 2) - 6, Pos.Y + (Size.Y / 2), 13, 1));
            g.FillEllipse(fillgreen, new Rectangle(Pos.X - (Size.X / 2) - 2, Pos.Y + (Size.Y / 2) - 2, 5, 5));
            //draw bot Right
            g.DrawRectangle(pengreen, new Rectangle(Pos.X + (Size.X / 2), Pos.Y + (Size.Y / 2) - 6, 1, 13));
            g.DrawRectangle(pengreen, new Rectangle(Pos.X + (Size.X / 2) - 6, Pos.Y + (Size.Y / 2), 13, 1));
            g.FillEllipse(fillgreen, new Rectangle(Pos.X + (Size.X / 2) - 2, Pos.Y + (Size.Y / 2) - 2, 5, 5));
            //draw top left
            g.DrawRectangle(pengreen, new Rectangle(Pos.X - (Size.X / 2), Pos.Y - (Size.Y / 2) - 6, 1, 13));
            g.DrawRectangle(pengreen, new Rectangle(Pos.X - (Size.X / 2) - 6, Pos.Y - (Size.Y / 2), 13, 1));
            g.FillEllipse(fillgreen, new Rectangle(Pos.X - (Size.X / 2) - 2, Pos.Y - (Size.Y / 2) - 2, 5, 5));
            //draw top right
            g.DrawRectangle(pengreen, new Rectangle(Pos.X + (Size.X / 2), Pos.Y - (Size.Y / 2) - 6, 1, 13));
            g.DrawRectangle(pengreen, new Rectangle(Pos.X + (Size.X / 2) - 6, Pos.Y - (Size.Y / 2), 13, 1));
            g.FillEllipse(fillgreen, new Rectangle(Pos.X + (Size.X / 2) - 2, Pos.Y - (Size.Y / 2) - 2, 5, 5));


        }
    }
}
