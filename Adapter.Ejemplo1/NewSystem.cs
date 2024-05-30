using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter.Ejemplo1
{
    public class NewSystem
    {
        private readonly IDatabase _database;
        public  NewSystem(IDatabase database)
        {
            _database = database;
        }
        public void SaveData(string data)
        {
            _database.Add(data);
            Console.WriteLine("Datos guardados en el nuevo sistema");

        }
        public void LoadData()
        {
            string data = _database.Retrieve();
            Console.WriteLine("Data loaded in thenew system");
        }
    }
}
