using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Entities
{
    public class Category
    {
        public Category(int iD, string name, List<Category> subCategories)
        {
            ID = iD;
            Name = name;
            SubCategories = subCategories;
        }

        public Category(string name)
        {

            Name = name;
        }
        public Category(int id)
        {

            ID = id;
        }

        public Category(int id , string name )
        {
            ID = id;
            Name = name;

        }

        public Category( string name, Category parentCategory)
        {
           
            Name = name;
            ParentCategory = parentCategory;
            
        }

        public Category(int iD, string name, Category parentCategory)
        {
            ID = iD;
            Name = name;
            ParentCategory = parentCategory;
            
        }

        public int ID { get; private set; }
        public string Name { get; private set; }
        public Category ParentCategory { get; private set; }
        public List<Category> SubCategories { get; private set; }
        public override string ToString()
        {
            return $"{Name}";
        }

    }
}
