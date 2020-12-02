using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise1
{
    public class SendEmailActivity : IActivity
    {
        public void Execute()
        {
            Console.WriteLine("Sending an email to the owner of the video notifying them that the video started processing.");
        }
    }

   
}
