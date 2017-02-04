using System;
using System.Windows.Forms;
using Khronos_PMS.View;
using System.Linq;
using Khronos_PMS.Model;
using Khronos_PMS.Util;

namespace Khronos_PMS {
    public static class Program {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        public static void Main() {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            
            DialogResult loginRezultat;
            User user;
            using (var loginForma = new LoginForm()) {
                loginRezultat = loginForma.ShowDialog();
                user = loginForma.User;
            }

            if (loginRezultat == DialogResult.OK && user != null) {
                if (user is Admin)
                    Application.Run(new AdminForm(user.ID));
                else
                    Application.Run(new MainForm(user.GetName(), user.ID));
            }
            
            //Application.Run(new MainForm("Student", 2));
        }
    }
}