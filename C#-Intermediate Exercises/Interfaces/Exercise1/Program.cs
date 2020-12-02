using System;

namespace Exercise1
{
   
  
    class Program
    {
        static void Main(string[] args)
        {

            var workflowEngine = new WorkflowEngine();
            var workflow = new WorkFlow();
            workflow.RegisterActivity(new UploadVideoActivity());
            workflow.RegisterActivity(new CallWebActivity());


            workflowEngine.Run(workflow);
           

        }
    }
}
