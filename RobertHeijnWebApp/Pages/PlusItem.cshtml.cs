using BusinessLogic;
using BusinessLogic.Entities;
using DataAccessLayer;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RobertHeijnWebApp.Pages
{
    public class PlusItemModel : PageModel
    {
        ItemManagement itemManagement;
        ItemDAL ItemDAL;
        CartManagement cartManagement;
        CartDAL cartDal;
        public PlusItemModel()
        {
            ItemDAL = new ItemDAL();
            itemManagement = new ItemManagement(ItemDAL);
            cartDal = new CartDAL();
            cartManagement = new CartManagement(cartDal);

        }
        public void OnGet(int id)
        {
            Item item = itemManagement.GetItem(id);
            if (item != null)
            {
                itemManagement.IncreaseItem(item);
                Response.Redirect("/ShopppingCart");
            }
            
            
        }
    }
}
