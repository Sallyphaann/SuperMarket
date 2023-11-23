using BusinessLogic.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Interfaces
{
    public interface ICartDAL
    {
        public bool CreateCart(Member member);
        public bool DeleteCart(int cart);
        public bool ClearCart(Cart cart);
        public Cart CheckCustomerHasCart(int id);
        public Item CheckItemExist(Cart cart , Product product);
        public List<Cart> GetAllCarts();
        public List<Item> GetAllItems(Cart cart);
        
        
    }
}
