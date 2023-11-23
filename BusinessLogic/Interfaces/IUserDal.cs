using BusinessLogic.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Interfaces
{
    public interface IUserDal
    {
        public bool AddAdmin(Admin admin);
        public bool AddMember(Member member);
        
        List<User> GetAllAdmin();
        public int GetUserId(string username);
    }
}
