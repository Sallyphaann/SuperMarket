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
    public class AddtoCartModel : PageModel
    {
        public int userId;
        ProductManagement productManagement;
        ProductDAL productDal;
        CartManagement cartManagement;
        CartDAL cartDal;
        ItemManagement itemManagement;
        ItemDAL ItemDAL;
        private int productID = 0;
        private int amount;
        
        public AddtoCartModel()
        {
            productDal = new ProductDAL();
            productManagement = new ProductManagement(productDal);
            cartDal = new CartDAL();
            cartManagement = new CartManagement(cartDal);
            ItemDAL = new ItemDAL();
            itemManagement = new ItemManagement(ItemDAL);
            amount = 1;
        }
        [BindProperty]
        public CartDTO Amount { get; set; }
        [BindProperty]
        public ProductDTO ProductForm { get; set; }

        public Product? GetProduct()
        {
            return productManagement.GetAllProduct().FirstOrDefault(p => p.ID == productID);
        }
        public void OnGet(int id)
        {
            productID = id;

            ProductForm = DTO.GetProductDTO(GetProduct());
        }
        //    //public IActionResult OnPostAsync()
        //    //{

        //    //    //if (ModelState.IsValid == false)
        //    //    //{
        //    //    //    Response.Redirect("/Product");
        //    //    //}
        //    //    //else
        //    //    //{
        //    //        Product product = DTO.AddProduct(ProductForm);
        //    //        Cart cart = DTO.AddAmount(Amount);
        //    //        cartManagement.AddToCart(product, cart);
        //    //    //}
        //    //    return Page();
        //    //}
        public void OnPost()
        {
            userId = Convert.ToInt32(User.FindFirst("ID").Value);
            
            Cart cartId = cartManagement.GetCartid(userId);
            if (cartId != null)
            {
                
                //Product product = DTO.productDTO(ProductForm);
                
                Product product = DTO.productDTO(ProductForm);
                Item item = cartManagement.GetItem(cartId, product);

                if (item !=null)
                {
                   
                    itemManagement.IncreaseItem(item);
                    Response.WriteAsync("<script>alert('Product was added');window.location='/Product';</script>");
                }
                else
                {
                    itemManagement.AddItem(cartId, product, amount);
                    Response.WriteAsync("<script>alert('Product was added');window.location='/Product';</script>");
                }
                
            }
            else
            {
                Member userid = new Member(userId);
                cartManagement.CreateCart(userid);
                Cart newCart = cartManagement.GetCartid(userId);
                Product product = DTO.productDTO(ProductForm);
                itemManagement.AddItem(newCart, product, amount);
                Response.WriteAsync("<script>alert('Product was added');window.location='/Product';</script>");
            }
            

        }
    }
}
