using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AliExpress.Exceptions.InvalidException
{
    public class PriceInvalidException : Exception
    {
        public PriceInvalidException() : base("Price must be greater than zero!")
        {
        }
    }
}
