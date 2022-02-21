using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using C968_PA_MPlatt.Models;

namespace C968_PA_MPlatt.Models
{
    public class Inventory
    {
        public static BindingList<Product> Products = new BindingList<Product>();
        public static BindingList<Part> AllParts = new BindingList<Part>();

        public static BindingList<Product> DefaultProducts()
        {
            Products.Add(new Product(1, "Laptop", 599.99, 3, 0, 5));
            Products.Add(new Product(2, "Web Book", 299.99, 5, 0, 10));
            Products.Add(new Product(3, "Gaming PC", 1299.99, 2, 0, 5));
            return Products;
        }

        public static BindingList<Part> DefaultParts()
        {
            AllParts.Add(new Inhouse(1, "Motherboard", 399, 4, 0, 7, 22));
            AllParts.Add(new Outsourced(2, "CPU", 899, 3, 0, 12, "Intel"));
            AllParts.Add(new Inhouse(3, "PSU", 499, 7, 0, 10, 44));
            return AllParts;
        }

        public Inventory()
        {
            DefaultProducts();
            DefaultParts();
        }

        public static void addProduct(Product product)
        {
            Products.Add(new Product());
            Console.WriteLine("hello test");
        }

        public static bool removeProduct(int ProductID)
        {
            return true;
        }

        public static Product lookupProduct(int ProductID)
        {
            return new Product();
        }

        public static void updateProduct(int ProductID, Product product)
        {

        }

        public static void addPart(Part part)
        {
            
        }

        public static bool deletePart(Part part)
        {
            return true;
        }

/*        public static Part lookupPart(int ProductID)
        {
            return new Part();
        }*/

        public static void updatePart(int ProductID, Part part)
        {

        }
    }
}
