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
    public class CartDAL : BaseDAL, ICartDAL
    {
        public bool CreateCart(Member member)
        {
            try
            {
                OpenDB();


                string createCart = "insert into [dbi453444_synthesis].[dbo].[sCart]([idCustomer]) values (@idCustomer)";
                SqlCommand cmd = new SqlCommand(createCart, GetConnection());
                cmd.Parameters.AddWithValue("@idCustomer", member.Id);
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


        public bool ClearCart(Cart cart)
        {

            try
            {
                OpenDB();
                SqlCommand cmd = new SqlCommand($"Delete [dbi453444_synthesis].[dbo].[ScLine] where cartID={cart.CartId}", GetConnection());
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

        public bool DeleteCart(int item)
        {

            try
            {
                OpenDB();
                SqlCommand cmd = new SqlCommand("Delete [dbi453444_synthesis].[dbo].[ScLine] where id=@id", GetConnection());
                cmd.Parameters.AddWithValue("@id", item);
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

        public List<Cart> GetAllCarts()
        {
            List<Cart> getCart = new List<Cart>();

            try
            {
                OpenDB();
                string cart = "Select * from [dbi453444_synthesis].[dbo].[sCart] ";
                SqlCommand sqlCommand = new SqlCommand(cart, GetConnection());
                SqlDataReader reader = sqlCommand.ExecuteReader();
                while (reader.Read())
                {
                    int cartId = int.Parse(reader[0].ToString());
                    Member customerID = (new Member(int.Parse(reader[1].ToString())));

                    getCart.Add(new Cart(cartId, customerID));

                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                CloseDB();
            }
            return getCart;
        }

        public Cart CheckCustomerHasCart(int id)
        {
            try
            {
                OpenDB();


                string checkCustomer = $"Select id from [dbi453444_synthesis].[dbo].[sCart] where idCustomer = '{id}'";
                SqlCommand cmd = new SqlCommand(checkCustomer, GetConnection());
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {

                    int cartId = int.Parse(reader[0].ToString());
                    reader.Close();
                    Cart cart = new Cart(cartId);
                    return cart;
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

        public List<Item> GetAllItems(Cart cart)
        {
            List<Item> getListOfItem = new List<Item>();

            try
            {
                OpenDB();
                string itemlist = $"select I.id,I.cartID,p.name , p.Price,p.Unit, I.amout from Product as p inner join ScLine as I on p.ID = I.productID inner join sCart as c on c.id = I.cartID where c.id ={cart.CartId}";
                SqlCommand sqlCommand = new SqlCommand(itemlist, GetConnection());
                SqlDataReader reader = sqlCommand.ExecuteReader();
                while (reader.Read())
                {
                    int id = int.Parse(reader[0].ToString());
                    int cartID = int.Parse(reader[1].ToString());
                    string name = reader[2].ToString();
                    decimal price = decimal.Parse(reader[3].ToString());
                    string unit = reader[4].ToString();
                    int amount = int.Parse(reader[5].ToString());
                    Product product = new Product(name, price, unit);
                    Cart cartId = new Cart(cartID);
                    getListOfItem.Add(new Item(id, cartId, product, amount));


                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                CloseDB();
            }
            return getListOfItem;
        }

        

        public Item CheckItemExist(Cart cart, Product product)
        {
            try
            {
                OpenDB();


                string checkItem = $"Select * from [dbi453444_synthesis].[dbo].[ScLine] where productID = '{product.ID}' And cartID = '{cart.CartId}'";
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
    }
}
