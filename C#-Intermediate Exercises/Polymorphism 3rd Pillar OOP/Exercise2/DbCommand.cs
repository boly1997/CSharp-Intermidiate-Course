using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise2
{
    public class DbCommand
    {
        public DbConnection _dbConnection { get; set; }

        public string _instruction { get; set; }

        public DbCommand(DbConnection dbConnection, string instruction)
        {
            if (dbConnection == null)
            {
                throw new InvalidOperationException("String cant be null");
            }

            _dbConnection = dbConnection;

            if (string.IsNullOrEmpty(instruction))
            {
                throw new InvalidOperationException("String cant be null neither empty string");
            }

            _instruction = instruction;
        }

        public void Execute()
        {
            _dbConnection.Open();
            Console.WriteLine($"Running: {_instruction}");
            _dbConnection.Close();


        }
    }
}
