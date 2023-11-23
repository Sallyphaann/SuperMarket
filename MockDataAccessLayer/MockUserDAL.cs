using BusinessLogic.Entities;
using BusinessLogic.Interfaces;
using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MockDataAccessLayer
{
    public class MockUserDAL : BaseDAL, IUserDal
    {
        //
        List<User> users = new List<User>();
        public MockUserDAL()
        {
            users.Add(new Admin(1, "Tom", "Handy", "Tom21@gmail.com", "Arnhem", "Tom", "123", "123", "Admin"));
            users.Add(new Admin(2, "angelia", "Jullie", "Aj@gmail.com", "USA", "angelie", "123", "123", "Admin"));
            users.Add(new Member(1, "Jenny", "Le", "Jenny@gmail.com", "USA", "jennyle", "456", "456", "love peace"));
            users.Add(new Member(2, "Luka", "France", "Luka@gmail.com", "USA", "Luka", "789", "789", "outgoing person"));

        }
        public bool AddAdmin(Admin admin)
        {
            foreach (User user in users)
            {
                if (user.Email == admin.Email)
                {
                    return false;
                }
            }
            return true;

        }

        public bool AddMember(Member member)
        {
            foreach (User user in users)
            {
                if (user.Email == member.Email)
                {
                    return false;
                }
            }
            return true;
        }
        //public bool Canlogin(string name, string password)
        //{
        //    foreach (User user in users)
        //    {
        //        if (user.Username == name && user.Hashpassword == password && user.Salt == password)
        //        {

        //        }

        //    }


            public List<User> GetAllAdmin()
            {

                return users;
            }

            public int GetUserId(string username)
            {
               foreach(User user in users)
               {
                if (user.Username == username)
                {
                    return user.UserID;
                }
               }
               return -1;
          
            }

            
        }
    } 
