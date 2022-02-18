using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C968_PA_MPlatt.Models
{
    public class Product
    {
        //Properties
        public int ProductID { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public int InStock { get; set; }
        public int Min { get; set; }
        public int Max { get; set; }

        public static BindingList<Part> AssociatedParts = new BindingList<Part>();

        //Constructor
        public Product()
        {
            this.ProductID = 0;
            this.Name = "No Name";
            this.Price = 0;
            this.InStock = 0;
            this.Min = 0;
            this.Max = 0;
        }

        public Product(int id, string name, double price, int qty, int min, int max)
        {
            this.ProductID = id;
            this.Name = name;
            this.Price = price;
            this.InStock = qty;
            this.Min = min;
            this.Max = max;
        }

        //Methods
/*        public static void addAssociatedPart(Part)
        {

        }*/

        public static bool removeAssociatedPart(int ProductID)
        {
            return true;
        }

/*        public static Part lookupAssociatedPart(int ProductID)
        {
            return Part;
        }*/
    }
}
