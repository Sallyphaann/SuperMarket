using BusinessLogic.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Interfaces
{
    public interface IItemDAL
    {
        public bool AddItem(Cart cart,Product product, int amount);
        public Item GetItembyId(int id);
        public bool IncreaseItem(Item item);
        public bool DecreaseItem(Item item);
    }
}
