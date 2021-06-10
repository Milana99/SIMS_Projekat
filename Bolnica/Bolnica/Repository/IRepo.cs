using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bolnica.Repository
{
    public interface IRepo<T>
    {
        List<T> Load();
        void Save(List<T> l);

        int getNextId();

    }
}
