﻿using System;
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
            Cuttings = new List<Cutting> {};
            Cuttings.Add(new Cutting());
            Cuttings[0].Number = 0;
        }
        
        public void addToList()
        {
            Cuttings.Add(new Cutting());
        }

        public int getCount()
        {
            return Cuttings.Count;
        }
        //returns true if the requested index is past the last
        public bool checkIndex(int i)
        {
            return getCount() < i;
        }
        //if there are not enough indexes add till there are enough
        public void checkAndAdd(int i)
        {
            while (checkIndex(i + 1))
            {
                addToList();
            }
        }

        //writes each cutting to stream
        public void Write(StreamWriter writer)
        {
            foreach (var cutting in Cuttings)
            {
                cutting.Write(writer);

            }
        }
        //draws each cutting to Grpahics
        public void Draw(Graphics g, int active)
        {
            foreach (var cutting in Cuttings)
            {
                if (cutting == this.Cuttings[active])
                {
                    cutting.DrawPointSelected(g);
                }
                else
                {
                    cutting.DrawPoint(g);
                }
               
            }
        }

        public void Read(StreamReader reader)
        {
            this.Cuttings = new List<Cutting>();
            var allTheString =  new string[8];//reader.ReadLine().Split(',');
            int i = 0;
            while (!reader.EndOfStream)
            {
                allTheString = reader.ReadLine().Split(',');
                this.Cuttings.Add(new Cutting());
                this.Cuttings[i].Number = Convert.ToInt32(allTheString[0]);
                this.Cuttings[i].Name = allTheString[1];
                this.Cuttings[i].Pos = new Cutting.Vector2(Convert.ToInt32(allTheString[2]), Convert.ToInt32(allTheString[3]));
                this.Cuttings[i].Size = new Cutting.Vector2(Convert.ToInt32(allTheString[4]), Convert.ToInt32(allTheString[5]));
                this.Cuttings[i].PivotOffset = new Cutting.Vector2(Convert.ToInt32(allTheString[6]), Convert.ToInt32(allTheString[7]));
                i++;
            }
        }
    }
}
