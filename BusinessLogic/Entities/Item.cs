using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Entities
{
    public class Item
    {
        public Item(int id, Cart cart, Product product, int amount)
        {
            Id = id;
            Product = product;
            Cart = cart;
            Amount = amount;
        }
        public Item(int id, Product product, int amount)
        {
            Id = id;
            Product = product;
            Amount = amount;
        }
        public Item(Product product,int amount)
        {

            Product = product;
            Amount = amount;
            
        }
        //public void IncreaseAmount()
        //{
        //    Amount++;
        //}
        public int Id { get; set; }
        public Product Product { get; set; }
        public Cart Cart { get; set; }
        public int Amount { get; set; }
    }
}
