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

        public BindingList<Part> AssociatedParts;

        //Constructor
        public Product()
        {
            this.ProductID = 0;
            this.Name = "No Name";
            this.Price = 0;
            this.InStock = 0;
            this.Min = 0;
            this.Max = 0;
            this.AssociatedParts = new BindingList<Part>();
        }

        public Product(int id, string name, double price, int qty, int min, int max, BindingList<Part> associatedParts)
        {
            this.ProductID = id;
            this.Name = name;
            this.Price = price;
            this.InStock = qty;
            this.Min = min;
            this.Max = max;
            this.AssociatedParts = associatedParts;
        }

        //Methods
        public void addAssociatedPart(Part part)
        {
            this.AssociatedParts.Add(part);
        }

        public bool removeAssociatedPart(int index)
        {
            BindingList<Part> AssociatedParts = new BindingList<Part>();
            this.AssociatedParts.RemoveAt(index);
            return true;
        }

        public static Part lookupAssociatedPart(int index)
        {
            BindingList<Part> AssociatedParts = new BindingList<Part>();
            Part part = Inventory.AllParts.ElementAt(index);
            return part;
        }
    }
}
