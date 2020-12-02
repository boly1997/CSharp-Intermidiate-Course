using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise1
{
    public class CallWebActivity : IActivity
    {
        public void Execute()
        {
            Console.WriteLine("Calling a web service provided by a third-party video encoding service to tell them you have a video ready for encoding.");
        }
    }

   
}
