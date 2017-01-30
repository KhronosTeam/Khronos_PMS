using Khronos_PMS.Model;
using Khronos_PMS.View;
using System;

namespace Khronos_PMS.Util
{
    public class ActivityManager
    {
        private User user;
        private Unit unit;





        public ActivityManager(Unit u)
        {
            unit = u;
            user = LoginManager.loggedUser;
            if (unit == null)
            {
                new ActivityForm(this, false).Show();
            }else
            {
                new ActivityForm(this, true).Show();
            }

        }

        public bool addActivity(int manhour, String note)
        {
            Activity activity = new Activity();
            try
            {
                activity.Manhour = manhour;
                activity.Note = note;
                activity.WorkerID = user.ID;

                //activity.ProjectID = unit.ProjectID;
                //activity.UnitID = unit.ID;
                activity.ProjectID = 1;
                activity.UnitID = 16;

                ProjectManager.entities.Activities.Add(activity);
                ProjectManager.entities.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
