using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Entities
{
    public class Admin:User
    {
        string position;
        public Admin(string firstname, string lastname, string email, string address, string username, string hashedPassword, string salt, string position) : base(firstname, lastname, email, address, username, hashedPassword, salt)
        {
            this.position = position;
        }
        public Admin(int id, string firstname, string lastname, string email, string address, string username, string hashedPassword, string salt, string position) : base(id, firstname, lastname, email, address, username, hashedPassword, salt)
        {
            this.position = position;
        }

        public string Position { get => position; }
    }
}
