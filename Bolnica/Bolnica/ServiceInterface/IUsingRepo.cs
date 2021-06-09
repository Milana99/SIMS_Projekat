using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bolnica.ServiceInterface
{
    interface IUsingRepo <T>
    {
        T GetOne(int Id);
        List<T> GetAll();
        void Create(T t);
        void Delete(int Id);
        void Update(T t);
    }
}
