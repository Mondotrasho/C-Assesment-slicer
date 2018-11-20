using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication2
{
    using System.Drawing;
    using System.IO;

    class SpriteSlice
    {
        //data
        public List<Cutting> Cuttings;

        //create empty with one entry
        public SpriteSlice()
        {
            this.Cuttings = new List<Cutting> { new Cutting() };
        }
        
        public void addToList()
        {
            this.Cuttings.Add(new Cutting());
        }

        public int getCount()
        {
            return this.Cuttings.Count;
        }
        //returns true if the requested index is past the last
        public bool checkIndex(int i)
        {
            return this.getCount() < i;
        }
        //if there are not enough indexes add till there are enough
        public void checkAndAdd(int i)
        {
            while (this.checkIndex(i))
            {
                this.addToList();
            }
        }

        //writes each cutting to stream
        public void Write(StreamWriter writer)
        {
            foreach (var cutting in this.Cuttings)
            {
                cutting.Write(writer);

            }
        }
        //draws each cutting to Grpahics
        public void Draw(Graphics g)
        {
            foreach (var cutting in Cuttings)
            {
                cutting.DrawPoint(g);
            }
        }

    }
}
