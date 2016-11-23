using Login.Entities;
using System;
using System.Windows.Forms;

namespace Login
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            labLoginMessage.Hide();

            if (PresentacionUsuario.login(tboUsuario.Text, tboPassword.Text))
            {
                MenuForm menuForm = new MenuForm();
                menuForm.FormClosed += new FormClosedEventHandler(menuFormClosed);
                menuForm.Show();
                this.Hide();
            }
            else
            {
                labLoginMessage.Text = "El usuario y/o contraseña no es válida.";
                labLoginMessage.Show();
            }
        }

        private void menuFormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }

        private void onEnterPressed(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                this.butLogin.PerformClick();
        }
    }
}
