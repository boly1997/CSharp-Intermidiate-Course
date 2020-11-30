using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise2
{
    public class SqlConnection : DbConnection
    {
        //Constructor
        public SqlConnection(string connection) : base(connection)
        {
            _connectionString = connection;
        }

        public override void Close()
        {
            Console.WriteLine("Closing App");
        }

        public override void Open()
        {
            Console.WriteLine("Openning App");
        }
    }
}
