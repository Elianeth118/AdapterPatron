// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using Adapter.Ejemplo1;

LegacyDatabase legacyDatabase = new LegacyDatabase();
DatabaseAdapter adapter = new DatabaseAdapter(legacyDatabase);
NewSystem newSystem=new NewSystem(adapter);
newSystem.SaveData("Impostant data");
newSystem.LoadData();
