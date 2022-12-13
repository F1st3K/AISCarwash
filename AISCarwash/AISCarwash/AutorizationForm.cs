using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Security.Cryptography;

namespace AISCarwash
{

    public partial class AutorizationForm : Form
    {
        private int countTry = 3;

        public AutorizationForm()
        {
            InitializeComponent();
            this.CenterToScreen();
            textPassword.PasswordChar = '•';
        }

        private void AutorizationForm_Load(object sender, EventArgs e)
        {

        }

        private void buttonLogIn_Click(object sender, EventArgs e)
        {
            if (countTry > 0)
                LogIn();
        }

        private void LoginCaptcher()
        {
            this.Hide();
            CaptcherForm form = new CaptcherForm();
            form.Show();
        }


        private void buttonLogIn_MouseClick(object sender, MouseEventArgs e)
        {
            countTry--;
            counter.Text = "осталось попыток: " + countTry;
            if (countTry <= 0)
            {
                LoginCaptcher();
            }                
        }

        private void LogIn()
        {
            string column = "AccessRights";
            string tableName = "users";
            var hashPasswd = new HashPassword(textPassword.Text);
            string condition = "login = '" + textLogin.Text + "' AND password = '" + hashPasswd.Text + "'";
            DataTable resultTable = MySqlConnecter.QueryReturnTable(column, tableName, condition);
            if (resultTable.Rows.Count == 0)
                MessageBox.Show("*неверный логин и/или пароль*", "неудачный вход", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                string mode = resultTable.Rows[0][0].ToString();
                MessageBox.Show("*Успех вы вошли как " + mode + "*", "удачный вход", MessageBoxButtons.OK);
                ViewMenu(mode);
            }   
            
        }
        private void ViewMenu(string mode)
        {
            this.Hide();
            MainForm form = new MainForm(mode);
            form.Show();
        }

    }

}
