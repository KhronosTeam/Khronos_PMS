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

        public static void writeToLog(string TableID, string OperationID, string Params)
        {
            Log newLog = new Log();
            newLog.Date = DateTime.Now;
            newLog.OperationID = OperationID;
            newLog.Params = Params;
            newLog.UserID = LoginManager.LoggedUser.ID;
            newLog.TableID = TableID;

            entities.Logs.Add(newLog);
            entities.SaveChangesAsync();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="enteties">enteties objekat koji je korišten za čuvanje u bazu</param>
        /// <param name="TableID">ime tabele koja je mijenjana</param>
        /// <param name="OperationID">"insert" OR "update"</param>
        /// <param name="Params">if "insert" then new ID else old values</param>
        /// <param name="userID">Id trenutno prijavljenog korisnika</param>
        public static void writeToLog(KhronosPMSEntities enteties, string TableID, string OperationID, string Params, int userID)
        {
            try
            {
                Log newLog = new Log();
                newLog.Date = DateTime.Now;
                newLog.OperationID = OperationID;
                newLog.Params = Params;
                newLog.UserID = LoginManager.LoggedUser.ID;
                newLog.TableID = TableID;
                newLog.UserID = userID;

                entities.Logs.Add(newLog);
                entities.SaveChangesAsync();
            }
            catch (Exception e) {
                Console.WriteLine(e.Message);
            }

        }
    }
}
