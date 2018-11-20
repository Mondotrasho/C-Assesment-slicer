namespace WindowsFormstutorial
{
    using System.Collections.Generic;
    using System.Drawing;
    using System.IO;
    using System.Windows.Forms;

    public class DrawableCoordinate
    {
        public List<int[]> Box;
        
        //add XY coords
        public void Add(int a, int b)
        {
            Box.Add(new[] { a, b });
        }
        //write out xy cords using comma seperated
        public void Write(StreamWriter writer)
        {
            foreach (var thing in Box)
            {
                writer.Write(thing[0].ToString() +","+ thing[1].ToString() +",");
            }
            
        }
        public void DrawPoint(PictureBox picture)
        {
        
            foreach (var bit in Box)
            {
                Color color = Color.DarkRed;
                Graphics g = picture.CreateGraphics();
                
                Pen pen = new Pen(color);
                SolidBrush fill = new SolidBrush(color);
                // g.DrawRectangle(pen,new Rectangle(bit[0], bit[1],5,5));//DrawLine(pen, new Point(bit[0], bit[0]), new Point(x, y));
                g.DrawRectangle(pen, new Rectangle(bit[0], bit[1] - 6, 1, 13));
                g.DrawRectangle(pen, new Rectangle(bit[0] - 6, bit[1] , 13, 1));
                g.FillEllipse(fill ,new Rectangle(bit[0]-2, bit[1]-2, 5, 5));
            }
        }
    }
}