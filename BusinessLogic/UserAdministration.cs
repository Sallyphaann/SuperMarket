using BusinessLogic.Entities;
using BusinessLogic.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class UserAdministration
    {
        private IUserDal Iuser;
        private User user;
        private List<User> users = new List<User>();
        public UserAdministration(IUserDal Iusers)
        {
            this.Iuser = Iusers;
            user = new User();
            //UpdateDB();
            AddUsertoList();

        }
        public void AddUsertoList()
        {
            users.Clear();
            users.AddRange(Iuser.GetAllAdmin());
        }
        public List<User> Users()
        {
            return users;
        }
        public bool AddAdmin(Admin user) // add new user
        {
            try
            {
               
              return Iuser.AddAdmin(user);

            }
            catch (Exception ex)
            {
                return false;
            }
            
           
           
        }
        // using to add new member
        public bool AddMember(Member user) // add new user
        {

            try
            {

                return Iuser.AddMember(user);
                
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public bool CanLogin(string username, string password)
        {
            // how to check if user enter wrong word


            // var user = users.Find(x => x.Username == username);


            try
            {
                User user = GetUserName(username);
                if (user == null)
                {
                    return false;
                }
                else
                {
                    
                    var hashpassword = PasswordHasher.sha256_hash(password + user.Salt);
                    if (hashpassword != user.Hashpassword)
                    {
                        return false;
                    }
                    
                }
            }

            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return true;

        }
        // using to get ID of Admin when create a new event 
        public int Getid(string name)
        {

            return Iuser.GetUserId(name);
        }
        public User GetUserName(string username)
        {
            if (users.Exists(x => x.Username == username))
            {
                return users.Find(x => x.Username == username);
            }
            return null;
        }
        public bool CheckUserNameExistence(User user)
        {
            if (users.Exists(x => x.Username == user.Username))
            {
                return true;
            }
            return false;
        }
        public bool CheckEmailUser(User user)
        {
            if (users.Exists(x => x.Email == user.Email))
            {
                return true;
            }
            return false;
        }
        //public void EditUser(User user)
        //{
        //    Iusers.UpdateUsers(user);
        //    UpdateDB();
        //}
        //public void DeleteUser(User user)
        //{
        //    users.Remove(user);
        //    Iusers.DeleteUsers(user);
        //    UpdateDB();


        //}
    }
}
