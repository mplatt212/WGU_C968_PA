using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace C968_PA_MPlatt.Models
{
    class Inhouse : Part
    {
        public int MachineID { get; set; }

        public Inhouse()
        {
            PartID = 0;
            Name = "No Name";
            Price = 0;
            InStock = 0;
            Min = 0;
            Max = 0;
            MachineID = 0;
        }

        public Inhouse(int id, string name, decimal price, int qty, int min, int max, int machineID)
        {
            PartID = id;
            Name = name;
            Price = price;
            InStock = qty;
            Min = min;
            Max = max;
            MachineID = machineID;
        }
    }
}
