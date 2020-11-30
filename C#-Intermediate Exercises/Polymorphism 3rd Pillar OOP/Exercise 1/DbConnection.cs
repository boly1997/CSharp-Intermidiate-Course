using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise_1
{
    public abstract class DbConnection
    {
        protected string _connectionString { get; set; }
        private TimeSpan _timeOut { get; set; }

        public DbConnection(string connection)
        {
            if (string.IsNullOrEmpty(connection))
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
