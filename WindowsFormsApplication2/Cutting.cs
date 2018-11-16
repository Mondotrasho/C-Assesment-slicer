using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication2
{
    using System.Drawing;
    using System.IO;
    using System.Windows.Forms;

    public class Cutting
    {
        public struct Vector2
        {
            public int X;
            public int Y;
            public Vector2(int x, int y)
            {
                this.X = x;
                this.Y = y;
            }

            public void Write(StreamWriter writer)
            {
                writer.Write(X + "," + Y + ",");
            }
            
        }

        public int Number = 0;
        public string Name = String.Empty;
        public Vector2 Pos = new Vector2(0, 0);
        public Vector2 Size = new Vector2(10, 10);
        public Vector2 PivotOffset = new Vector2(0, 0);



        public void Write(StreamWriter writer)
        {
            writer.Write(Number);
            writer.Write(this.Name + ",");
            Pos.Write(writer);
            Size.Write(writer);
            PivotOffset.Write(writer);
            writer.WriteLine();
        }

        public void DrawPoint(PictureBox picture)
        {
            
                Color color = Color.DarkRed;
                Graphics g = picture.CreateGraphics();

                Pen pen = new Pen(color);
                SolidBrush fill = new SolidBrush(color);
                // g.DrawRectangle(pen,new Rectangle(bit[0], bit[1],5,5));//DrawLine(pen, new Point(bit[0], bit[0]), new Point(x, y));
                g.DrawRectangle(pen, new Rectangle(this.Pos.X, this.Pos.Y - 6, 1, 13));
                g.DrawRectangle(pen, new Rectangle(this.Pos.X - 6, this.Pos.Y, 13, 1));
                g.FillEllipse(fill, new Rectangle(this.Pos.X - 2, this.Pos.Y - 2, 5, 5));
            
        }
    }
}
