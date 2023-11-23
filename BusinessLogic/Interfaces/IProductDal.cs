using BusinessLogic.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Interfaces
{
    public interface IProductDal
    {
        public bool AddCategory(Category category);
        public bool AddSubCategory(Category category);
        public bool AddProduct(Product product , Category category);
        public List <Category> GetCategorieslist();
        public List<Category> GetSubCategory();
        public Category GetIdSubCategory( Category category);
        public Category GetIDParentCategory(Category category);
        public List<Product> GetListOfProduct();
        public bool DeleteProduct(Product product);
        public bool UpdateProduct(Product product,Category category);
        
    }
}
