using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C968_PA_MPlatt.Models
{
    public abstract class Part
    {
        //Properties
        public int PartID { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int InStock { get; set; }
        public int Min { get; set; }
        public int Max { get; set; }

        //Constructor
        public Part()
        {
            this.PartID = 0;
            this.Name = "No Name";
            this.Price = 0;
            this.InStock = 0;
            this.Min = 0;
            this.Max = 0;
        }   
        public Part(int id, string name, decimal price, int qty, int min, int max)
        {   
            this.PartID = id;
            this.Name = name;
            this.Price = price;
            this.InStock = qty;
            this.Min = min;
            this.Max = max;
        }
    }
}
