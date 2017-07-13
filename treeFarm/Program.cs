using System;
using System.Collections.Generic;

namespace treeFarm
{
    public class Tree
    {
        public double Height { get; set; } = 0;
        public string Location { get; set; } = "";
        public string Type { get; set; } = "";

        public string Move (string newLocation)
        {
            if (newLocation != this.Location)
            {
                this.Location = newLocation;
            }
            return this.Location;
        }

        public double Grow (double growth)
        {
            if (growth > 0.0)
            {
                this.Height += growth;
            }

            return this.Height;
        }
    }

    public class Farm
    {
        //property
        public string Name { get; set; }

        //property
        public List<Tree> treeInv = new List<Tree>();

        //method
        public void addTree (Tree value)
        {
            treeInv.Add(value);
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            
        }
    }
}
