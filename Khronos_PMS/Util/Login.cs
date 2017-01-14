using System;
using System.Linq;
using System.Windows.Forms;
using Khronos_PMS.Model;

namespace Khronos_PMS.Util {
    class Login {
        private KhronosPMSEntities entities;
        private String username;
        private String password;
        private Form form;
        private bool isValid;
        private String message;

        public Login(String username, String password) {
            try {
                entities = new KhronosPMSEntities();
                this.username = username;
                this.password = password;
                this.isValid = false;
                queryUser();
            } catch (Exception e) {
                message = "Error establishing a database connection.";
            }
        }

        private void queryUser() {
            User user = entities.Users.FirstOrDefault(u => u.Username == username);
            if (user != null && PasswordUtil.CheckPassword(this.password, user.Password)) {
                isValid = true;
                if (user.Admin != null)
                    form = new AdminForm(user.Admin);
                else if (user.Worker != null)
                    form = new MainForm(user.Worker);
                else if (user.Customer != null) {
                    //form = new MainForm(user.Customer);
                } else
                    throw new Exception("Something is wrong!");
            } else
                message = "Wrong username or password!";
        }

        public Form Form {
            get { return form; }
        }

        public bool IsValid {
            get { return isValid; }
        }

        public string Message {
            get { return message; }
        }
    }
}