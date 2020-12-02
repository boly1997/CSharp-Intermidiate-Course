using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise1
{
    public class ChangeStatusActivity : IActivity
    {
        public void Execute()
        {
            Console.WriteLine("Changing the status of the video record in the database to “Processing”.");
        }
    }
}
