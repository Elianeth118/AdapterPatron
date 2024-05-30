using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter.Ejemplo1
{
    public  interface IDatabase
    {
        void Add(string data);
        string Retrieve();
    }
}
