using BusinessLogic;
using BusinessLogic.Entities;
using DataAccessLayer;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RobertHeijnWebApp.DTO;

namespace RobertHeijnWebApp.Pages
{
    public class ProductModel : PageModel
    {
        ProductManagement productManagement;
        ProductDAL productDal;
        CartManagement cartManagement;
        CartDAL cartDal;
        public int userId;
        private int productID = 0;
        public ProductModel()
        {
            productDal = new ProductDAL();
            productManagement = new ProductManagement(productDal);
            cartDal = new CartDAL();
            cartManagement = new CartManagement(cartDal);
        }
        [BindProperty]
        public List<Product> ListProduct { get; set; }
        //[BindProperty]
        //public CartDTO Amount { get; set; }
        [BindProperty]
        public ProductDTO ProductForm { get; set; }
        public Product? GetProduct()
        {
            return productManagement.GetAllProduct().FirstOrDefault(p => p.ID == productID); ;
        }
        public void OnGet(int id )
        {
            ListProduct = productManagement.GetAllProduct();
            productID = id;
            //ProductForm = DTO.GetProductDTO(GetProduct());
            //userId = Convert.ToInt32(User.FindFirst("id").Value);
            //Member userid = new Member(userId);
            //cartManagement.CreateCart(userid);
        }
        public void OnPost()
        {
            
            Response.Redirect("/Product");

        }
    }
}
