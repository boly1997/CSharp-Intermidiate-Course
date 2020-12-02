using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise1
{
    public class WorkFlow : IWorkFlow
    {
        private readonly IList<IActivity> _activities;

        public WorkFlow()
        {
            _activities = new List<IActivity>();

        }

        public IList<IActivity> GetListOfActivities()
        {
            return _activities;
        }

        public void RegisterActivity(IActivity activity)
        {
            _activities.Add(activity);
        }

    }

}

