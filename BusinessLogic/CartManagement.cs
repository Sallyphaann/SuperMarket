using BusinessLogic.Entities;
using BusinessLogic.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class CartManagement
    {
        private List<Cart> cart = new List<Cart>();
        private List<Item> listofItem = new List<Item>();
        ICartDAL Icart;
        public CartManagement(ICartDAL Icart)
        {
            this.Icart = Icart;
        }
        public bool CreateCart(Member member)
        {
            try 
            { 
                return Icart.CreateCart(member);
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public bool CheckCustomerHasCart(Member member)
        {
            if (cart.Exists(x => x.Customer.Id == member.Id))
            {
                return true;
            }
            return false;
        }
        public List<Cart> GetCart()
        {
            cart.Clear();
            cart.AddRange(Icart.GetAllCarts());
            return cart;
        }
        public List<Item> GetListofItem(Cart cart)
        {
            listofItem.Clear();
            listofItem.AddRange(Icart.GetAllItems(cart));
            return listofItem;
        }
        //public bool CheckItemwasExist(Cart cart , Product Product)
        //{
        //    try
        //    {
        //        GetListofItem(cart).Exists(p=>p.Product.ID == Product.ID);
        //        return true;
        //    }
        //    catch (Exception ex)
        //    {
        //        return false;
        //    }
        //}
        public Cart GetCartid(int id)
        {

            return Icart.CheckCustomerHasCart(id);
        }
        public Item GetItem(Cart cart ,Product product)
        {
            return Icart.CheckItemExist(cart, product);
        }
        //public bool IncreaseItem(Item item) 
        //{
        //    try
        //    {
        //        Icart.IncreaseItem(item);
        //        return true;
        //    }
        //    catch (Exception ex) 
        //    {
        //        return false;
        //    }
        //}
        //public bool AddToCart(Product product, Cart cart)
        //{
        //    try
        //    {
        //        Icart.AddCart(product, cart);
        //        return true;
        //    }
        //    catch (Exception ex)
        //    {
        //        return false;
        //    }
        //}
        public bool DeleteCartid(int cart)
        {
            try
            {
                Icart.DeleteCart(cart);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public bool ClearCart(Cart cart)
        {
            try
            {
                Icart.ClearCart(cart);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
