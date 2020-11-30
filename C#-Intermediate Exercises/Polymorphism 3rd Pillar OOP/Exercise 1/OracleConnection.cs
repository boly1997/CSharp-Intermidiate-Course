using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise_1
{
    public class OracleConnection : DbConnection
    {
        //Constructor
        public OracleConnection(string connection) : base(connection)
        {

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
