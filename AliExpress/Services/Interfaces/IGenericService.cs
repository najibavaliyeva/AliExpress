using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AliExpress.Services.Interfaces
{
    public interface  IGenericService <T> where T : class
    {
        void Create(T dto);
        void Delete(int id);
        void GetById(int id);
        void GetAll();
    }
}
