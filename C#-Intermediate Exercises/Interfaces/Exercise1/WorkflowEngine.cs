using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise1
{

    public class WorkflowEngine
    {
        public void Run(IWorkFlow workFlow)
        {
            var list = workFlow.GetListOfActivities();
            foreach(var activity in list)
            {
                activity.Execute();
            }

        }

    }

   
    
}
