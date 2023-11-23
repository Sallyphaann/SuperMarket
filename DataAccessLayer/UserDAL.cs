using BusinessLogic.Entities;
using BusinessLogic.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class UserDAL : BaseDAL, IUserDal
    {
        public bool AddAdmin(Admin admin)
        {
            try
            {
                //conn.Open();
                OpenDB();
                string addUsers = "insert into [dbi453444_synthesis].[dbo].[user] ([firstname],[lastname],[email],[address],[username],[hashingpassword],[salt],[position]) values(@firstname,@lastname,@email,@address,@username,@hashingpassword,@salt,@position)";
                SqlCommand cmd = new SqlCommand(addUsers, GetConnection());
                cmd.Parameters.AddWithValue("@firstname", admin.Firstname);
                cmd.Parameters.AddWithValue("@lastname", admin.Lastname);
                cmd.Parameters.AddWithValue("@email", admin.Email);
                cmd.Parameters.AddWithValue("@Address", admin.Address);
                cmd.Parameters.AddWithValue("@username", admin.Username);
                cmd.Parameters.AddWithValue("@hashingpassword", admin.Hashpassword);
                cmd.Parameters.AddWithValue("@salt", admin.Salt);
                cmd.Parameters.AddWithValue("@position", admin.Position);
                cmd.ExecuteNonQuery();
                //return true;

            }
            catch (Exception ex)
            {
                return false;
                throw new Exception(ex.Message);


            }
            finally
            {
                CloseDB();
            }
            return true;
        }

        public bool AddMember(Member member)
        {
            try
            {
                //conn.Open();
                OpenDB();
                string addUsers = "insert into [dbi453444_synthesis].[dbo].[user] ([firstname],[lastname],[email],[address],[username],[hashingpassword],[salt],[biography]) values(@firstname,@lastname,@email,@address,@username,@hashingpassword,@salt,@biography)";
                SqlCommand cmd = new SqlCommand(addUsers, GetConnection());
                cmd.Parameters.AddWithValue("@firstname", member.Firstname);
                cmd.Parameters.AddWithValue("@lastname", member.Lastname);
                cmd.Parameters.AddWithValue("@email", member.Email);
                cmd.Parameters.AddWithValue("@Address", member.Address);
                cmd.Parameters.AddWithValue("@username", member.Username);
                cmd.Parameters.AddWithValue("@hashingpassword", member.Hashpassword);
                cmd.Parameters.AddWithValue("@salt", member.Salt);
                cmd.Parameters.AddWithValue("@biography", member.Biography);
                cmd.ExecuteNonQuery();
                //return true;

            }
            catch (Exception ex)
            {
                return false;
                throw new Exception(ex.Message);


            }
            finally
            {
                CloseDB();
            }
            return true;
        }

        public void DeleteUser(User user)
        {
            throw new NotImplementedException();
        }

        public List<User> GetAllAdmin()
        {
            List<User> getAdmin = new List<User>();
            try
            {
                OpenDB();
                string search = "Select * from [dbi453444_synthesis].[dbo].[user] ";
                SqlCommand sqlCommand = new SqlCommand(search, GetConnection());
                SqlDataReader reader = sqlCommand.ExecuteReader();
                while (reader.Read())
                {
                    int id = int.Parse(reader[0].ToString());
                    string firstname = reader[1].ToString();
                    string lastname = reader[2].ToString();
                    string email = reader[3].ToString();
                    string address = reader[4].ToString();
                    string username = reader[5].ToString();
                    string hashedPassword = reader[6].ToString();
                    string salt = reader[7].ToString();
                    string position = reader[8].ToString();
                    getAdmin.Add(new Admin(id, firstname, lastname, email, address, username, hashedPassword, salt, position));
                   
                   
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                CloseDB();
            }
            return getAdmin;
        }

        public int GetUserId(string username)
        {
            try
            {

                OpenDB();

                string checkUsers = $"SELECT u.ID FROM [dbi453444_synthesis].[dbo].[user] as u WHERE u.username = '{username}'";
                SqlCommand cmd = new SqlCommand(checkUsers, GetConnection());
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {

                    int id = int.Parse(reader[0].ToString());
                    reader.Close();
                    return id;
                }
                return -1;




            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }


            finally
            {
                CloseDB();
            }
        }

        public void UpdateUser(User user)
        {
            throw new NotImplementedException();
        }
    }
}
