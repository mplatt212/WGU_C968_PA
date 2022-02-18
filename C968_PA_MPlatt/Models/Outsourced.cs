using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C968_PA_MPlatt.Models
{
    class Outsourced : Part
    {
        public string CompanyName { get; set; }

        public Outsourced()
        {

        }

        public Outsourced(int id, string name, decimal price, int qty, int min, int max)
        {
            PartID = id;
            Name = name;
            Price = price;
            InStock = qty;
            Min = min;
            Max = max;
        }
    }
}
