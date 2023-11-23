using BusinessLogic;
using BusinessLogic.Entities;
using DataAccessLayer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RobertHeijnWebApp.DTO;

namespace RobertHeijnWebApp.Pages
{
    [Authorize]
    public class ShopppingCartModel : PageModel
    {
        public int userId;
        CartDAL cartDal;
        CartManagement cartManagement;
        
        
        public ShopppingCartModel()
        {
            cartDal = new CartDAL();
            cartManagement = new CartManagement(cartDal);
            
        }
        [BindProperty]
        public CartDTO ID { get; set; }
        [BindProperty]
        public List<Item> cart { get; set; }
   
        public void OnGet()
        {
            userId = Convert.ToInt32(User.FindFirst("ID").Value);
            Cart cartId = cartManagement.GetCartid(userId);
            cart = cartManagement.GetListofItem(cartId);

        }
        //public void OnPostDelete(Cart cart)
        //{

        //    cartManagement.DeleteCartid(new Cart(cart.CartId));
        //}

    }
}
