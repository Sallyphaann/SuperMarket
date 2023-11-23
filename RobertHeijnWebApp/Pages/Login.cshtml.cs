using BusinessLogic;
using DataAccessLayer;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Security.Claims;

namespace RobertHeijnWebApp.Pages
{
    public class LoginModel : PageModel
    {
        UserAdministration UserAdministration;

        UserDAL userDAL;

        [BindProperty]
        public LoginDTO LoginForm { get; set; }
        public LoginModel()
        {

            //this.UserAdministration = userAdministration;
            userDAL = new UserDAL();
            UserAdministration = new UserAdministration(userDAL);

        }
        public void OnGet()
        {

        }
        public async Task OnPost()
        {
            //if (ModelState.IsValid)
            //{
                string username = LoginForm.UserName.ToLower();
                if (UserAdministration.CanLogin(username, LoginForm.Password))
                {
                    int userid = UserAdministration.Getid(username);
                    List<Claim> claims = new List<Claim>();
                    claims.Add(new Claim(ClaimTypes.Name, LoginForm.UserName));
                    claims.Add(new Claim("id", userid.ToString()));
                    ClaimsIdentity claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
                    await HttpContext.SignInAsync(new ClaimsPrincipal(claimsIdentity));

                    Response.Redirect("/Index");
                }

                else
                {

                    await Response.WriteAsync("<script>alert('Login faied');window.location='/Login';</script>");
                }

            

        }
        public void showMessage(string message)
        {
            string strBuilder = "< script > alert('') </ script > ";
            Response.WriteAsync(strBuilder);
        }
    }
}
