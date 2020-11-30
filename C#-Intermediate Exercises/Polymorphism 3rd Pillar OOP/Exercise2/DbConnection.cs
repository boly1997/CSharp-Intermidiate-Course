using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise2
{
    public abstract class DbConnection
    {
        public string _connectionString { get; set; }
        public TimeSpan timeSpan { get; set; }

        public DbConnection(string connection)
        {
            if (String.IsNullOrEmpty(connection))
            {
                throw new InvalidOperationException("String cant be null neither empty string");
            }
            else
                _connectionString = connection;
        }


        public abstract void Open();

        public abstract void Close();

    }
}
