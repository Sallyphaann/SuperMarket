using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Entities
{
    public class Member:User
    {
        
        string biography;
        public Member(string firstname, string lastname, string email, string address, string username, string hashedPassword, string salt, string biography) : base(firstname, lastname, email, address, username, hashedPassword, salt)
        {
           
            this.biography = biography;
        }
        public Member(int id, string firstname, string lastname, string email, string address, string username, string hashedPassword, string salt, string biography) : base(id, firstname, lastname, email, address, username, hashedPassword, salt)
        {
            
            this.biography = biography;
        }
        public Member(int id):base(id)
        {
            
        }
        
        public string Biography { get => biography; }
    }
}

