using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Entities
{
    public class Product
    {
        public Product(int iD, Category subCategory, string name, decimal price, string unit, int quanntity)
        {
            ID = iD;
            Name = name;
            Price = price;
            Unit = unit;
            Quantity = quanntity;
           SubCategory = subCategory;
        }
        public Product()
        {

        }
        public Product(int iD, string name, decimal price, string unit, int quanntity)
        {
            ID = iD;
            Name = name;
            Price = price;
            Unit = unit;
            Quantity = quanntity;
           
        }
        public Product(string name, decimal price, string unit, int quanntity)
        {
            Name = name;
            Price = price;
            Unit = unit;
            Quantity = quanntity;
            //SubCategory = subCategory;
        }

        public Product(int iD)
        {
            ID = iD;
        }

        public Product(string name)
        {
            Name = name;
        }

        public Product(string name, decimal price,string unit)
        {
            Name = name;
            Price = price;
            Unit = unit;
        }
        public Product(int id ,string name, decimal price, string unit)
        {
            ID = id;    
            Name = name;
            Price = price;
            Unit = unit;
        }
        //public Product(int iD, string name, decimal price, string unit, int quanntity, Category subCategory,int subCategoryName)
        //{
        //    ID = iD;
        //    Name = name;
        //    Price = price;
        //    Unit = unit;
        //    Quantity = quanntity;
        //    SubCategory = subCategory;
        //    SubCategoryName = subCategoryName;
        //}

        public int ID { get; private set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Unit { get; set; }
        public int Quantity { get; set; }
        public Category SubCategory { get;set; }
        //public int SubCategoryName { get; private set; }
        public override string ToString()
        {
            return $"{Name}";
        }
    }
}

 