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
    public class ItemDAL : BaseDAL, IItemDAL
    {
        public bool AddItem(Cart cart ,Product product, int amount)
        {
            try 
            {
                OpenDB();
                string addItem = "insert into [dbi453444_synthesis].[dbo].[ScLine] ([cartID],[productID],[amout]) values (@cartID,@productID,@amout)";
                SqlCommand cmd = new SqlCommand(addItem, GetConnection());
                cmd.Parameters.AddWithValue("@cartID", cart.CartId);
                cmd.Parameters.AddWithValue("@productID", product.ID);
                cmd.Parameters.AddWithValue("@amout", amount);
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

        public Item GetItembyId(int id)
        {
            try
            {
                OpenDB();


                string checkItem = $"Select * from [dbi453444_synthesis].[dbo].[ScLine] where id ='{id}'";
                SqlCommand cmd = new SqlCommand(checkItem, GetConnection());
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {

                    int itemId = int.Parse(reader[0].ToString());
                    int cartId = int.Parse(reader[1].ToString());
                    int productId = int.Parse(reader[2].ToString());
                    int amount = int.Parse(reader[3].ToString());
                    reader.Close();

                    Item item = new Item(itemId, new Cart(cartId), new Product(productId), amount);
                    return item;
                }
                return null;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                CloseDB();
            }
        }
        public bool IncreaseItem(Item item)
        {
            try
            {
                OpenDB();
                //UPDATE ScLine SET amout = amout + 1 WHERE productID = 1;
                SqlCommand cmd = new SqlCommand($"UPDATE [dbi453444_synthesis].[dbo].[ScLine] SET amout=@amout + 1 where productID='{item.Product.ID}'", GetConnection());
                cmd.Parameters.AddWithValue("@amout", item.Amount);
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
        public bool DecreaseItem(Item item)
        {
            try
            {
                OpenDB();
                //UPDATE ScLine SET amout = amout + 1 WHERE productID = 1;
                SqlCommand cmd = new SqlCommand($"UPDATE [dbi453444_synthesis].[dbo].[ScLine] SET amout=@amout - 1 where productID='{item.Product.ID}'", GetConnection());
                cmd.Parameters.AddWithValue("@amout", item.Amount);
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
