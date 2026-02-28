using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AliExpress.Exceptions.NotFoundException
{
    public class CatalogNotFoundException : NotFoundException
    {
        public CatalogNotFoundException( ) : base("Catalog")
        {
        }
    }
}
