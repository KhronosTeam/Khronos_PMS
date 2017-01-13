using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Khronos_PMS {
    public partial class LoginForm : Form {
        private KhronosPMSEntities entities;
        public LoginForm() {
            InitializeComponent();
            entities = new KhronosPMSEntities();
        }

        private void loginButton_Click(Object sender, EventArgs e) {
            String username = usernameTextBox.Text;
            String password = passwordTextBox.Text;
            
            checkUser(username, password);
        }

        private void checkUser(String username, String password) {
            
            User user = entities.Users.FirstOrDefault(u => u.Username == username && u.Password == password);
            if (user == null) {
                // prikazati grešku
                Console.Out.WriteLine("Nešto nije dobro");
            } else {
                Admin admin = entities.Admins.Find(user.ID);
                Form form = null;
                if (admin != null) {
                    form = new AdminForm(admin);
                } else {
                    form = new MainForm(user);
                }
                startNewForm(form);
            }
        }

        private void startNewForm(Form form) {
            form.Show();
            form.Closed += (o, args) => { Close(); };
            Hide();
        }

        private void cancelButton_Click(Object sender, EventArgs e) {
            Close();
        }

        private void textBox_Enter(Object sender, EventArgs e) {
            ((Control) sender).BackColor = Color.FromArgb(233, 233, 233);
            ((Control) sender).ForeColor = Color.FromArgb(38, 38, 38);

        }

        private void textBox_Leave(Object sender, EventArgs e) {
            ((Control)sender).BackColor = Color.FromArgb(38, 38, 38);
            ((Control)sender).ForeColor = Color.FromArgb(233, 233, 233);
        }

        private void passwordTextBox_PreviewKeyDown(Object sender, PreviewKeyDownEventArgs e) {

        }
    }
}
