using BusinessLogic.Entities;
using BusinessLogic.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class ItemManagement
    {
        IItemDAL Iitem;
        public ItemManagement(IItemDAL Iitem)
        {
            this.Iitem = Iitem;
        }
        public bool AddItem(Cart cart,Product product,int amount)
        {
            try
            { 
                return Iitem.AddItem(cart, product, amount);
            }
            catch (Exception ex) 
            { 
                return false;
            }
        }
        public Item GetItem(int id)
        {
            return Iitem.GetItembyId(id);
        }
        public bool IncreaseItem(Item item)
        {
            try
            {
                Iitem.IncreaseItem(item);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public bool DecreaseItem(Item item)
        {
            try
            {
                Iitem.DecreaseItem(item);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
