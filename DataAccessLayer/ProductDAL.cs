using BusinessLogic.Entities;
using BusinessLogic.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class ProductDAL : BaseDAL, IProductDal
    {
        public bool AddCategory(Category category)
        {
            try
            {
                OpenDB();
                string addCategory = "insert into [dbi453444_synthesis].[dbo].[Category] ([Name]) values (@Name)";
                SqlCommand cmd = new SqlCommand(addCategory, GetConnection());
                cmd.Parameters.AddWithValue("@Name", category.Name);
                cmd.ExecuteNonQuery();
                return true;
            }
            catch(Exception ex)
            {
                return false;
            }
            finally
            {
                CloseDB();
            }
        }
        public bool AddSubCategory(Category category)
        {
            try
            {
                OpenDB();
                string addSubategory = "insert into [dbi453444_synthesis].[dbo].[Category] ([Name],[ParentID]) values (@Name,@ParentID)";
                SqlCommand cmd = new SqlCommand(addSubategory, GetConnection());
                cmd.Parameters.AddWithValue("@Name", category.Name);
                cmd.Parameters.AddWithValue("@ParentID", category.ParentCategory.ID);
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
            finally
            {
                CloseDB();
            }
        }


        public bool AddProduct(Product product, Category category)
        {
            try
            {
                OpenDB();
                string addProduct = "insert into [dbi453444_synthesis].[dbo].[Product] ([name],[Price],[Unit],[Quantity],[ID Subcategory]) values (@name,@Price,@Unit,@Quantity,@IDSubcategory)";
                SqlCommand cmd = new SqlCommand(addProduct, GetConnection());
                cmd.Parameters.AddWithValue("@name", product.Name);
                cmd.Parameters.AddWithValue("@Price", product.Price);
                cmd.Parameters.AddWithValue("@Unit", product.Unit);
                cmd.Parameters.AddWithValue("@Quantity", product.Quantity);
                cmd.Parameters.AddWithValue("@IDSubcategory", category.ID);

                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
            finally
            {
                CloseDB();
            }

        }

        
        public bool DeleteProduct(Product product)
        {
            try 
            {
                OpenDB();
                SqlCommand cmd = new SqlCommand("Delete [dbi453444_synthesis].[dbo].[Product] where ID=@ID", GetConnection());
                cmd.Parameters.AddWithValue("@ID",product.ID);
                cmd.ExecuteNonQuery();
                return true;

            }
            catch (Exception ex)
            {
                return false;
            }
            finally
            {
                CloseDB();
            }
        }

        public List<Category> GetCategorieslist()
        {
            List<Category> getCategory = new List<Category>();

            try
            {
                OpenDB();
                //string category = "Select DISTINCT c2.Name as Category from [dbi453444_synthesis].[dbo].[Category] as c1 inner join [dbi453444_synthesis].[dbo].[Category] as c2 on c1.ParentID = c2.ID";
                string category = "select DISTINCT Name as Category from [dbi453444_synthesis].[dbo].[Category] where ParentID is Null";
                SqlCommand sqlCommand = new SqlCommand(category, GetConnection());
                SqlDataReader reader = sqlCommand.ExecuteReader();
                while (reader.Read())
                {

                    string name = (string)reader["Category"];
                    getCategory.Add(new Category(name));
                }
                reader.Close();
            }

            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                CloseDB();
            }
            return getCategory;
        }

        public Category GetIDParentCategory(Category category)
        {
            Category parentCategoryID = null;
            try
            {
                OpenDB();

                string search = "select id from Category where Name=@Name ";

                SqlCommand cmd = new SqlCommand(search, GetConnection());
                SqlCommand sqlCommand = new SqlCommand(search, GetConnection());
                sqlCommand.Parameters.AddWithValue("@Name", category.Name);
                SqlDataReader reader = sqlCommand.ExecuteReader();
                while (reader.Read())
                {
                    int id = int.Parse(reader[0].ToString());
                    parentCategoryID = new Category(id);

                }
                reader.Close();
            }

            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                CloseDB();
            }
            return parentCategoryID;
        }

        public Category GetIdSubCategory( Category category)
        {
            Category subCategoryID = null;
            try
            {
                OpenDB();

                string search = "select id from Category where Name=@Name ";

                SqlCommand cmd = new SqlCommand(search, GetConnection());
                SqlCommand sqlCommand = new SqlCommand(search, GetConnection());
                sqlCommand.Parameters.AddWithValue("@Name",category.Name);
                 SqlDataReader reader = sqlCommand.ExecuteReader();
                while (reader.Read())
                {
                    int id = int.Parse(reader[0].ToString());
                    subCategoryID = new Category(id);
                    
                }
                //reader.Close();
            }

            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                CloseDB();
            }
            return subCategoryID ;

        }

        public List<Product> GetListOfProduct()
        {
            
            List<Product> productList = new List<Product>();
            try
            {
                OpenDB();
                string sql = "select Product.ID,Category.Name as subCategory , Product.name,Product.Price,Product.Unit,Product.Quantity from [dbi453444_synthesis].[dbo].[Product] as Product join [dbi453444_synthesis].[dbo].[Category] as Category on Product.[ID Subcategory] = Category.ID";
                SqlCommand sqlCommand = new SqlCommand(sql, GetConnection());
                SqlDataReader reader = sqlCommand.ExecuteReader();
                while (reader.Read())
                {

                    //string name = (string)reader["subCategory"];
                    int id = int.Parse(reader[0].ToString()); ;
                    Category category = new Category(reader[1].ToString()); ;
                    string name = reader[2].ToString(); ;
                    decimal price = decimal.Parse(reader[3].ToString());
                    string unit = reader[4].ToString();
                    int quantity = int.Parse(reader[5].ToString());
                    productList.Add(new Product(id, category,name, price,unit,quantity));
                    
                }
                reader.Close();

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                CloseDB();
            }
            return productList;

        }

        public List<Category> GetSubCategory()
        {
            List<Category> getsubCategory = new List<Category>();
            try
            {
                OpenDB();

                string category = "Select s2.Name as [subCategory] from [dbi453444_synthesis].[dbo].[Category] as s1 inner join [dbi453444_synthesis].[dbo].[Category] as s2 " +
                    "on s1.ID = s2.ParentID ";
                SqlCommand sqlCommand = new SqlCommand(category, GetConnection());
                SqlDataReader reader = sqlCommand.ExecuteReader();
                while (reader.Read())
                {

                    string name = (string)reader["subCategory"];
                    getsubCategory.Add(new Category(name));
                }
                reader.Close();

            }

            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                CloseDB();
            }
            return getsubCategory;
        }

        public bool UpdateProduct(Product product,Category category)
        {
            try {

                OpenDB();

                string updateProduct = "Update [dbi453444_synthesis].[dbo].[Product] Set name=@name,Price=@Price,Unit=@Unit,Quantity=@Quantity,[ID Subcategory]= @IDSubcategory where ID=@ID";
                SqlCommand cmd = new SqlCommand(updateProduct, GetConnection());
                cmd.Parameters.AddWithValue("@ID", product.ID);
                cmd.Parameters.AddWithValue("@name", product.Name);
                cmd.Parameters.AddWithValue("@Price", product.Price);
                cmd.Parameters.AddWithValue("@Unit", product.Unit);
                cmd.Parameters.AddWithValue("@Quantity", product.Quantity);
                cmd.Parameters.AddWithValue("@IDSubcategory", category.ID);
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
            finally
            {
                CloseDB();
            }
        }
    }
}

