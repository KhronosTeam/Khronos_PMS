using System;
using System.Linq;
using System.Windows.Forms;
using Khronos_PMS.Model;
using Khronos_PMS.View;

namespace Khronos_PMS.Util {
    class LoginManager {
        public static User LoggedUser;
        private User user;
        private KhronosPMSEntities entities;
        private String username;
        private String password;
        private bool isValid;
        private String message;

        public LoginManager(String username, String password) {
            try {
                entities = ProjectManager.entities;
                this.username = username;
                this.password = password;
                this.isValid = false;
                queryUser();
            } catch (Exception) {
                message = "Error establishing a database connection.";
            }
        }

        private void queryUser() {
            User user = entities.Users.FirstOrDefault(u => u.Username == username);
            LoggedUser = user;
            if (user != null && PasswordUtil.CheckPassword(this.password, user.Password)) {
                isValid = true;
                if (user.Admin != null)
                    this.user = user.Admin;    
                else if (user.Worker != null)
                    this.user = user.Worker;
                else if (user.Customer != null) {
                    this.user = user.Customer;
                } else
                    throw new Exception("Something is wrong!");
                this.user.ID = user.ID;
            } else
                message = "Wrong username or password!";
        }
        
        public bool IsValid {
            get { return isValid; }
        }

        public string Message {
            get { return message; }
        }

        public User User {
            get { return user; }
        }
    }
}