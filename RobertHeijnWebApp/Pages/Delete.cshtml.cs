using BusinessLogic;
using BusinessLogic.Entities;
using DataAccessLayer;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RobertHeijnWebApp.Pages
{
    public class DeleteModel : PageModel
    {
        CartDAL cartDal;
        CartManagement cartManagement;
        public DeleteModel()
        {
            cartDal = new CartDAL();
            cartManagement = new CartManagement(cartDal);
        }
        
        public void OnGet(int id)
        {

            cartManagement.DeleteCartid(id);
            Response.WriteAsync("<script>alert('Your product has removed from the shopping cart');window.location='/ShopppingCart';</script>");
        }
        
    }
}
