using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Custom_Exception.DatalayerExceptions
{
    public class ConnectionUnavailableException :DatalayerException
    {
        public ConnectionUnavailableException(string message) : base(message)
        {

        }
        public ConnectionUnavailableException(string message, Exception innerException) : base(message, innerException)
        {

        }
        public ConnectionUnavailableException()
        {

        }
    }
}
