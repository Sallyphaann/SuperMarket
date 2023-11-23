using BusinessLogic;
using BusinessLogic.Entities;
using DataAccessLayer;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RobertHeijnWebApp.Pages
{
    public class RegisterModel : PageModel
    {
        UserAdministration userAdministration;
        UserDAL userDal;
        [BindProperty]
        public MemberRegister RegisterForm { get; set; }
        public string messageLine { get; private set; }
        public RegisterModel()
        {
            userDal = new UserDAL();
            userAdministration = new UserAdministration(userDal);
        }
        public void OnGet()
        {

        }
        public IActionResult OnPostAsync()
        {

            //if (ModelState.IsValid == false)
            //{
            //    Response.Redirect("/Register");
            //}
            //else
            //{
                Member member = DTO.MemberDTO(RegisterForm);
                if (userAdministration.CheckUserNameExistence(member))
                {
                    messageLine = " Sorry this username was exit";
                    return Page();

                }
                if (userAdministration.CheckEmailUser(member))
                {
                    messageLine = " Sorry this Email was exit";
                    return Page();
                }
                else
                {

                    userAdministration.AddMember(member);
                    messageLine = "You are success";
                    Response.WriteAsync("<script>alert('Your account was created');window.location='/Index';</script>");
                    
                }



            return Page();
        }
        
    }
}
