using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using Khronos_PMS.Util;
using Khronos_PMS.Model;

namespace Khronos_PMS {
    public partial class LoginForm : Form {
        public LoginForm() {
            InitializeComponent();
        }

        private void passwordTextBox_PreviewKeyDown(Object sender, PreviewKeyDownEventArgs e) {
            if (e.KeyCode == Keys.Enter)
                login();
        }

        private void loginButton_Click(Object sender, EventArgs e) {
            login();
        }

        private async void login() {
            if (errorTextLabel.Visible)
                errorTextLabel.Visible = false;

            String username = usernameTextBox.Text;
            String password = passwordTextBox.Text;

            if (String.IsNullOrEmpty(username) || String.IsNullOrEmpty(password)) {
                if (String.IsNullOrEmpty(username))
                    usernameTextBox.CreateGraphics().DrawRectangle(Pens.Red, 0, 0, usernameTextBox.Width - 1, usernameTextBox.Height - 1);
                if (String.IsNullOrEmpty(password))
                    passwordTextBox.CreateGraphics().DrawRectangle(Pens.Red, 0, 0, passwordTextBox.Width - 1, passwordTextBox.Height - 1);
            } else {
                Login login = null;
                progressBar.Visible = true;
                await Task.Run(() => { login = new Login(username, password); });
                if (login.IsValid)
                    startNewForm(login.Form);
                else {
                    errorTextLabel.Text = login.Message;
                    errorTextLabel.Visible = true;
                }
                progressBar.Visible = false;
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
            ((Control) sender).BackColor = Color.FromArgb(38, 38, 38);
            ((Control) sender).ForeColor = Color.FromArgb(233, 233, 233);
        }
    }
}