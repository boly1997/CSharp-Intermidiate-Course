using System;

namespace Exercise_1
{
    class Program
    {
        static void Main(string[] args)
        {
            var dataBase = new OracleConnection("1234");
            var dataBase2 = new SqlConnection("1234");

            dataBase.Open();
            dataBase2.Open();
            dataBase.Close();
            dataBase2.Close(); 

        }
    }
}
