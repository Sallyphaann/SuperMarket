using BusinessLogic.Custom_Exception.DatalayerExceptions;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class BaseDAL
    {
        private SqlConnection connection;
        // connect with Database
        protected BaseDAL()
        {
            connection = new SqlConnection("Data Source=mssqlstud.fhict.local;Initial Catalog=dbi453444_synthesis;Persist Security Info=True;User ID=dbi453444_synthesis;Password=Halan2021!");
        }
        protected SqlConnection GetConnection()
        {
            return connection;
        }
        protected void OpenDB()
        {
            try
            {
                 connection.Open();
            }
            catch (SqlException)
            {
                throw new ConnectionUnavailableException("\tDatabase connection unavailable!\n" +
                                                     "Check your internet connection or connect to VPN!");
            }

        }
        protected void CloseDB()
        {
            // check the system if it is open so close it 
            connection.Close();
        }
    }
}
