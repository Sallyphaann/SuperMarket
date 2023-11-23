using BusinessLogic;
using BusinessLogic.Entities;
using DataAccessLayer;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RobertHeijnWebApp.Pages
{
    public class ClearModel : PageModel
    {
        CartDAL cartDal;
        CartManagement cartManagement;
        UserDAL userDal;
        UserAdministration userAdministration;
        public ClearModel()
        {
            cartDal = new CartDAL();
            cartManagement = new CartManagement(cartDal);
            userDal = new UserDAL();

            userAdministration = new UserAdministration(userDal);
        }
        public void OnGet()
        {

            int userId = userAdministration.Getid(User.Identity.Name);
            Cart cart = cartManagement.GetCartid(userId);
            cartManagement.ClearCart(cart);
            Response.WriteAsync("<script>alert('Your cart removed');window.location='/ShopppingCart';</script>");

        }
    }
}
