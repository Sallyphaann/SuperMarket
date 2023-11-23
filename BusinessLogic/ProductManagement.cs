using BusinessLogic.Entities;
using BusinessLogic.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class ProductManagement
    {
        private IProductDal Iproduct;
        
        
        private List<Category> ListofCategory = new List<Category>();
        private List<Category> subCategory = new List<Category>();
        private List<Product> products = new List<Product>();
        public ProductManagement(IProductDal Iproduct)
        {
            this.Iproduct = Iproduct;

        }
        public bool AddProduct(Product product , Category category)
        {
            //bool result = true;
            //if (result)
            //{
            //    Iproduct.AddProduct(product, category);
            //    return result;
            //}
            //else
            //{
            //    return false;
            //}
            try {
                Iproduct.AddProduct(product, category);
                 return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public Category GetSubCategoryID(Category category)
        {
            return Iproduct.GetIdSubCategory(category);

        }
        public Category GetParentCategoryID(Category category)
        {
            return Iproduct.GetIDParentCategory(category);
        }
        
        public List<Category> AddSubCategorytoList()
        {
            subCategory.Clear();
            subCategory.AddRange(Iproduct.GetSubCategory());
            return subCategory;
        }
        public List<Category> AddCategoryToList()
        {
            ListofCategory.Clear();
            ListofCategory.AddRange(Iproduct.GetCategorieslist());
            return ListofCategory;
        }
        public List<Product> GetAllProduct()
        {
            products.Clear();
            products.AddRange(Iproduct.GetListOfProduct());
            return products;
        }
        public bool AddCategory(Category category)
        {
            //bool result = true;
            //if (result)
            //{
            //    Iproduct.AddCategory(category);
            //    return result;
            //}
            //else
            //{
            //    return false;
            //}
            try {
                Iproduct.AddCategory(category);
                return true; }
            catch (Exception ex) { return false; }
            }
        public bool AddSubCategory(Category category)
        {
            
            try
            {
                Iproduct.AddSubCategory(category);
                return true;

            }
            catch (Exception ex)
            {
                return false;
            }
        }
        
        public bool CheckCategoryexist(Category category)
        {
            if (ListofCategory.Exists(x => x.Name == category.Name ))
            {
                return true;
            }
            return false;
        }
        public bool CheckSubcategoryWasExist(Category category)
        {
            if(AddSubCategorytoList().Exists(x=>x.Name == category.Name))
            {
                return true;
            }
            return false;
        }
        public bool DeleteProduct(Product product)
        {
            
            try {

                Iproduct.DeleteProduct(product);
                return true;
            
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public bool UpdateProduct(Product product, Category category)
        {
            
            try 
            {
                Iproduct.UpdateProduct(product, category);
                   return true;

            }
            catch (Exception ex) 
            {
                return false;
            }
        }
        public bool CheckProductWasExist(Product product)
        {
            if (GetAllProduct().Exists(x => x.Name == product.Name))
            {
                return true;
            }
            return false;
        }
        public bool SearchProduct(Product product)
        {
            if(GetAllProduct().Exists(x => x.Name == product.Name))
            {
                return true;
            }
            return false ;
        }

    }
}
