using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter.Ejemplo1
{
    public class DatabaseAdapter : IDatabase
    {
        private readonly LegacyDatabase _legacyDatabase;

        public DatabaseAdapter(LegacyDatabase legacyDatabase)
        {
            _legacyDatabase = legacyDatabase;
        }
        public void Add(string data)
        {
            _legacyDatabase.InsertData(data);
        }
        public string Retrieve()
        {
            return _legacyDatabase.GetData();
        }
    }
}
