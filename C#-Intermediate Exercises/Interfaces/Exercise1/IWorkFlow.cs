using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise1
{
    public interface IWorkFlow
    {
        void RegisterActivity(IActivity activity);

        IList<IActivity> GetListOfActivities();

    }

    

}
