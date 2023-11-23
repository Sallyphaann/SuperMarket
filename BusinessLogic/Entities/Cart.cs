using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Entities
{
    public class Cart
    {
        public Cart(List<Item> listOfItem)
        {
            ListOfItem = listOfItem;
            
        }

        public Cart(int cartId, List<Item> listOfItem)
        {
            CartId = cartId;
            ListOfItem = listOfItem;
            

        }
        public Cart(Item item)
        {
            ListOfItem.Add(item);
        }

        public Cart(int cartId, Member customer)
        {
            CartId = cartId;
            Customer = customer;
        }
        public Cart(int cartId)
        {
            CartId = cartId;
        }

        //public void AddItem(Item item)
        //{
        //    if (ListOfItem.Contains(item))
        //    {
        //        ListOfItem.First(i => i.Product.ID == item.Product.ID).IncreaseAmount();
        //    }
        //    else
        //    {
        //        ListOfItem.Add(item);
        //    }
        //}
        public int CartId { get; set; }
        public Member Customer { get; set; }
        public List<Item> ListOfItem { get; set; }






    }
}
