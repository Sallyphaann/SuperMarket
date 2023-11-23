using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Entities
{
    public class User
    {
        private int id;
        private string username;
        private string hashpassword;
        private string salt;
        private string firstname;
        private string lastname;
        private string email;
        private string address;
        


        // constructor

        public User()
        {

        }
        
        // using this constructor to edit the user information
        public User(string firstname, string lastname, string email, string address, string username)
        {
            this.firstname = firstname;
            this.lastname = lastname;
            this.email = email;
            this.address = address;
            this.username = username;
        }

        public User(int id)
        {
            this.id = id;

        }
        public User(string username, int id)
        {
            this.username = username;
            this.id = id;
        }


        public User(string firstname, string lastname, string email, string address, string username, string hashpassword, string salt)
        {

            //this.account = account;
            this.firstname = firstname;
            this.lastname = lastname;
            this.email = email;
            this.address = address;
            this.username = username;
            this.hashpassword = hashpassword;
            this.salt = salt;
        }
        public User(int id, string firstname, string lastname, string email, string address, string username, string hashpassword, string salt)
        {
            this.id = id;
            this.firstname = firstname;
            this.lastname = lastname;
            this.email = email;
            this.address = address;
            this.username = username;
            this.hashpassword = hashpassword;
            this.salt = salt;
        }

        
        //public int UserID { get; private set; }
        public string Firstname { get => firstname; set => firstname = value; }
        public string Lastname { get => lastname; set => lastname = value; }
        
        public string Email { get => email; set => email = value; }
        public string Address { get => address; set => address = value; }
        public string Username { get => username; set => username = value; }
        public string Hashpassword { get => hashpassword; set => hashpassword = value; }
        public string Salt { get => salt; set => salt = value; }
        public int Id { get => id;  set => id = value; }

        //public int Id { get=> id; private set => id; }

        public override string ToString()
        {
            return $"{username}+{firstname}";
        }
    }
}

