using System;
using System.Windows.Forms;
using Khronos_PMS.View;
using System.Linq;

namespace Khronos_PMS {
    public static class Program {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        public static void Main() {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //todo obrisati ovaj dio kad login proradi, samo da ima ulogovani user kad se pokrene aplikacija
            //Model.KhronosPMSEntities entities = new Model.KhronosPMSEntities();
            //Model.User user = entities.Users.FirstOrDefault(u => u.Username == "vladanstojnic");
            Application.Run(new LoginForm());
        }
    }
}
