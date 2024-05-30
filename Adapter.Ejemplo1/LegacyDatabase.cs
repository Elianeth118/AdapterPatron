using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter.Ejemplo1
{
    public class LegacyDatabase
    {
        public void InsertData(string data)
        {
            Console.WriteLine("Inserted data into legacy database :" + data);
        }
        public string GetData()
        {
            return "Data from legacy database";
        }
    }
}
