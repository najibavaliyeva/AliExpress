using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AliExpress.Extensions
{
    public static class PriceExtension
    {
        public static bool IsGreaterThanZero(this double price)
        {
            return price > 0;
        }
    }
}
