using System;

namespace Exercise2
{
 


    class Program
    {
        static void Main(string[] args)
        {
            var dataBase = new OracleConnection("1234");
            var dbCommand = new DbCommand(dataBase, "SELECT * FROM TABLE");
            dbCommand.Execute();

        }
    }
}
