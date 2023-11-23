using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Custom_Exception.DatalayerExceptions
{
    public class DatalayerException  : Exception
    {
        public DatalayerException(string message):base(message)
        {

        }
        public DatalayerException(string message, Exception innerException): base(message, innerException)
        {

        }
        public DatalayerException()
        {

        }

    }
}
