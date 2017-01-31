using Khronos_PMS.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Khronos_PMS.Util
{
    class LogManager
    {
        private static KhronosPMSEntities entities = new KhronosPMSEntities();

        public static void writeToLog(string TableID, string OperationID, string Params) {
            Log newLog = new Log();
            newLog.Date = DateTime.Now;
            newLog.OperationID = OperationID;
            newLog.Params = Params;
            newLog.UserID = LoginManager.LoggedUser.ID;
            newLog.TableID = TableID;

            entities.Logs.Add(newLog);
            entities.SaveChangesAsync();
        }
    }
}
