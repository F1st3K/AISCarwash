using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AISCarwash
{
    public partial class AutorizationForm : Form
    {
        MySqlConnecter mySqlConnecter;
        public AutorizationForm()
        {
            InitializeComponent();
            const string connectionString = "host='localhost';database='carwah_shema';uid='root';pwd='';charset=utf8;";
            mySqlConnecter = new MySqlConnecter(connectionString);
            textPassword.PasswordChar = '•';
        }

        private void AutorizationForm_Load(object sender, EventArgs e)
        {

        }

        private void buttonLogIn_Click(object sender, EventArgs e)
        {
            string column = "AccessRights";
            string tableName = "users";
            string condition = $"login = '{textLogin.Text}' AND password = '{textPassword.Text}'";
            DataTable resultTable = mySqlConnecter.QueryReturnTable(column, tableName, condition);
            if (resultTable.Rows.Count == 0)
                MessageBox.Show("*неверный логин и/или пароль*", "неудачный вход", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                string mode = resultTable.Rows[0][0].ToString();
                MessageBox.Show($"*Успех вы вошли как {mode}*", "удачный вход", MessageBoxButtons.OK); 
                LogIn(mode);
            }   
        }
        private void LogIn(string mode)
        {
            this.Hide();
            MainForm form = new MainForm(mode);
            form.Show();
        }
    }

}
