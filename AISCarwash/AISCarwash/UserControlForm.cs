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
    public partial class UserControlForm : Form
    {
        private string _mode;
        private DataGridViewRow _currentRow;
        public UserControlForm(string mode)
        {
            _mode = mode;
            InitializeComponent();
            this.CenterToScreen();
        }

        private void UserControlForm_Load(object sender, EventArgs e)
        {
            UpdateGridView();
            string[] modes = new string[] { "user", "admin"};
            ChangeMode.DataSource = modes;
            CreateMode.DataSource = modes;
            ChangeMode.DropDownStyle = ComboBoxStyle.DropDownList;
            CreateMode.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void BackToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            MainForm form = new MainForm(_mode);
            form.Show();
        }
        private void ResetChange()
        {
            textChangeFullname.ResetText();
            textChangeLogin.ResetText();
            textChangePassword.ResetText();
            ChangeMode.ResetText();
        }
        private void ResetCreate()
        {
            textCreateFullname.ResetText();
            textCreateLogin.ResetText();
            textCreatePassword.ResetText();
            CreateMode.ResetText();
        }
        private void UpdateGridView()
        {
            string tableName = "users";
            string column = "*";
            string condition = "true";
            dataGridView.DataSource = MySqlConnecter.QueryReturnTable(column, tableName, condition);
            dataGridView = MySqlConnecter.ChangeColumnsName(dataGridView, "id", "Имя", "Логин", "Пароль", "Роль");
            counterTable.Text = dataGridView.RowCount.ToString();
        }

        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            _currentRow = dataGridView.Rows[dataGridView.CurrentCell.RowIndex];
            _currentRow.Selected = true;
            buttonChange.Enabled = true;
            buttonDelete.Enabled = true;
            GetDateChange();
        }
        private void GetDateChange()
        {
            textChangeFullname.Text = _currentRow.Cells[1].Value.ToString();
            textChangeLogin.Text = _currentRow.Cells[2].Value.ToString();
            textChangePassword.Text = _currentRow.Cells[3].Value.ToString();
            ChangeMode.Text = _currentRow.Cells[4].Value.ToString();
        }

        private void buttonChange_Click(object sender, EventArgs e)
        {
            if (MySqlConnecter.StringsIsEmpty(textChangeLogin.Text, textChangePassword.Text))
                return;
            if (ExistUserLogin(textChangeLogin.Text, 1))
                return;
            var passwd = new HashPassword(textChangePassword.Text);
            string table = "users";
            string values = " "+_currentRow.Cells[1].OwningColumn.Name+" = '"+textChangeFullname.Text+"', " +
                ""+_currentRow.Cells[2].OwningColumn.Name+" = '"+textChangeLogin.Text+"', " +
                ""+_currentRow.Cells[3].OwningColumn.Name+" = '"+passwd.Text+"', " +
                ""+_currentRow.Cells[4].OwningColumn.Name+" = '"+ChangeMode.Text+"'";
            string condition = ""+_currentRow.Cells[0].OwningColumn.Name+" = "+_currentRow.Cells[0].Value.ToString()+"";
            MySqlConnecter.QueryChangeInTable(table, values, condition);
            UpdateGridView();
            ResetChange();
        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            if(MySqlConnecter.StringsIsEmpty(textCreateLogin.Text, textCreatePassword.Text))
                return;
            if (ExistUserLogin(textCreateLogin.Text, 0))
                return;
            string table = "users";
            var passwd = new HashPassword(textChangePassword.Text);
            string values = "DEFAULT, '"+textCreateFullname.Text+"', '"+textCreateLogin.Text+"', '"+passwd.Text+"', '"+CreateMode.Text+"'";
            MySqlConnecter.QueryAddInTable(table, values);
            UpdateGridView();
            ResetCreate();
        }
        private bool ExistUserLogin(string login, int countLogin)
        {
            string column = "*";
            string tableName = "users";
            string condition = "login = '"+login+"'";
            DataTable table = MySqlConnecter.QueryReturnTable(column, tableName, condition);
            if (table.Rows.Count > countLogin)
            {
                MessageBox.Show("Пользователь с таким логином уже существует", "EROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;
            }
            return false;
        }
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            string row = "";
            for (int i = 0; i < dataGridView.Columns.Count; i++) row += "\t" + _currentRow.Cells[i].Value.ToString();
            DialogResult dialogResult = MessageBox.Show("Вы действительно хотите удалить следующую запись?: \n"+row+"", "Внимание! УДАЛЕНИЕ!", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
            if (dialogResult == DialogResult.Yes)
                DeleteUser();
        }
        private void DeleteUser()
        {
            string table = "users";
            string condition = "" + _currentRow.Cells[0].OwningColumn.Name + " = " + _currentRow.Cells[0].Value.ToString() + "";
            MySqlConnecter.QueryDeleteInTable(table, condition);
            UpdateGridView();
            ResetChange();
        }

        private void buttonRandPwdForChange_Click(object sender, EventArgs e)
        {
            textChangePassword.Text = new RandomPassword(8, 25).Password;
        }

        private void buttonRandPwdForCreate_Click(object sender, EventArgs e)
        {
            textCreatePassword.Text = new RandomPassword(8, 25).Password;
        }
    }
}
