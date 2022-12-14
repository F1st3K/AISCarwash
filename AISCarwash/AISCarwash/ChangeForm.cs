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
    public partial class ChangeForm : Form
    {
        private string _mode;
        private DataGridViewRow _currentRow;
        public ChangeForm(string mode)
        {
            _mode = mode;
            InitializeComponent();
            this.CenterToScreen();
        }

        private void BackToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            MainForm form = new MainForm(_mode);
            form.Show();
        }
        private string GetCurrentTable(int SelectedIndex)
        {
            string tableName = "";
            switch (SelectedIndex)
            {
                case 0: tableName = "ListWashers"; break;
                case 1: tableName = "ListClients"; break;
                case 2: tableName = "listServices"; break;
                default:
                    break;
            }
            return tableName;
        }
        private string[] GetCurrentNameColumns(int SelectedIndex)
        {
            string[] NameColumns = new string[] {};
            switch (SelectedIndex)
            {
                case 0: NameColumns = new string[] { "id", "Имя", "Фамилия", "Отчество", "Дата рождения" }; break;
                case 1: NameColumns = new string[] { "id", "Имя", "Фамилия", "Отчество", "Модель машины" }; break;
                case 2: NameColumns = new string[] { "id", "Наименование улуги", "Цена" }; break;
                default:
                    break;
            }
            return NameColumns;
        }
        private void UpdateGridView()
        {
            string tableName = GetCurrentTable(tabControl.SelectedIndex);
            string column = "*";
            string condition = "true";
            dataGridView.DataSource = MySqlConnecter.QueryReturnTable(column, tableName, condition);
            dataGridView = MySqlConnecter.ChangeColumnsName(dataGridView, GetCurrentNameColumns(tabControl.SelectedIndex));
            counterTable.Text = dataGridView.RowCount.ToString();
        }

        private void tabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateGridView();
        }
        private void SelectCurrentRow()
        {
            _currentRow = dataGridView.Rows[dataGridView.CurrentCell.RowIndex];
            _currentRow.Selected = true;
            buttonChangeClient.Enabled = true;
            buttonChangeService.Enabled = true;
            buttonChangeWasher.Enabled = true;
            buttonDelClient.Enabled = true;
            buttonDelService.Enabled = true;
            buttonDelWasher.Enabled = true;
        }
        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            SelectCurrentRow();
            switch (tabControl.SelectedIndex)
            {
                case 0: GetDataFromTableListWashers(); break;
                case 1: GetDataFromTableListClients(); break;
                case 2: GetDataFromTableListService(); break;
                default:
                    break;
            }
        }
        private void ResetAll()
        {
            textNameWasher.ResetText();
            textSurnameWasher.ResetText();
            textPatronymicWasher.ResetText();
            dateOBWasher.ResetText();
            textNameClient.ResetText();
            textSurnameClient.ResetText();
            textPatronymicClient.ResetText();
            textModelCarClient.ResetText();
            textNameService.ResetText();
            textPriceService.ResetText();

        }
        private void GetDataFromTableListWashers()
        {
            textNameWasher.Text = _currentRow.Cells[1].Value.ToString();
            textSurnameWasher.Text = _currentRow.Cells[2].Value.ToString();
            textPatronymicWasher.Text = _currentRow.Cells[3].Value.ToString();
            dateOBWasher.Text = _currentRow.Cells[4].Value.ToString();
        }
        private void GetDataFromTableListClients()
        {
            textNameClient.Text = _currentRow.Cells[1].Value.ToString();
            textSurnameClient.Text = _currentRow.Cells[2].Value.ToString();
            textPatronymicClient.Text = _currentRow.Cells[3].Value.ToString();
            textModelCarClient.Text = _currentRow.Cells[4].Value.ToString();
        }
        private void GetDataFromTableListService()
        {
            textNameService.Text = _currentRow.Cells[1].Value.ToString();
            textPriceService.Text = _currentRow.Cells[2].Value.ToString();
        }

        private void buttonChangeWasher_Click(object sender, EventArgs e)
        {
            if (MySqlConnecter.StringsIsEmpty(textNameWasher.Text, textSurnameWasher.Text))
                return;
            string table = GetCurrentTable(tabControl.SelectedIndex);
            string values = " "+_currentRow.Cells[1].OwningColumn.Name+" = '"+textNameWasher.Text+"', " +
                " "+_currentRow.Cells[2].OwningColumn.Name+" = '"+textSurnameWasher.Text+"', " +
                " "+_currentRow.Cells[3].OwningColumn.Name+" = '"+textPatronymicWasher.Text+"', " +
                " "+_currentRow.Cells[4].OwningColumn.Name+" = '"+dateOBWasher.Value.ToString("yyyy-MM-dd")+"'";
            string condition = ""+_currentRow.Cells[0].OwningColumn.Name+" = "+_currentRow.Cells[0].Value.ToString()+"";
            MySqlConnecter.QueryChangeInTable(table, values, condition);
            UpdateGridView();
            ResetAll();
        }

        private void buttonChangeClient_Click(object sender, EventArgs e)
        {
            if (MySqlConnecter.StringsIsEmpty(textNameClient.Text, textSurnameClient.Text, textModelCarClient.Text))
                return;
            string table = GetCurrentTable(tabControl.SelectedIndex);
            string values = " "+_currentRow.Cells[1].OwningColumn.Name+" = '"+textNameClient.Text+"', " +
                " "+_currentRow.Cells[2].OwningColumn.Name+" = '"+textSurnameClient.Text+"', " +
                " "+_currentRow.Cells[3].OwningColumn.Name+" = '"+textPatronymicClient.Text+"', " +
                " "+_currentRow.Cells[4].OwningColumn.Name+" = '"+textModelCarClient.Text+"'";
            string condition = ""+_currentRow.Cells[0].OwningColumn.Name+" = "+_currentRow.Cells[0].Value.ToString()+"";
            MySqlConnecter.QueryChangeInTable(table, values, condition);
            UpdateGridView();
            ResetAll();
        }

        private void buttonChangeService_Click(object sender, EventArgs e)
        {
            if (MySqlConnecter.StringsIsEmpty(textNameService.Text))
                return;
            string table = GetCurrentTable(tabControl.SelectedIndex);
            string values = " "+_currentRow.Cells[1].OwningColumn.Name+" = '"+textNameService.Text+"', " +
                " "+_currentRow.Cells[2].OwningColumn.Name+" = "+textPriceService.Text+"";
            string condition = ""+_currentRow.Cells[0].OwningColumn.Name+" = "+_currentRow.Cells[0].Value.ToString()+"";
            MySqlConnecter.QueryChangeInTable(table, values, condition);
            UpdateGridView();
            ResetAll();
        }
        private void DeleteCurrentRow()
        {
            string table = GetCurrentTable(tabControl.SelectedIndex);
            string condition = "" + _currentRow.Cells[0].OwningColumn.Name + " = " + _currentRow.Cells[0].Value.ToString() + "";
            MySqlConnecter.QueryDeleteInTable(table, condition);
            UpdateGridView();
            ResetAll();
        }
        private void WarningDeleteCurrentRow()
        {
            string row = "";
            for (int i = 0; i < dataGridView.Columns.Count; i++) row += "\t" + _currentRow.Cells[i].Value.ToString();
            DialogResult dialogResult = MessageBox.Show("Вы действительно хотите удалить следующую запись?: \n"+row+"", "Внимание! УДАЛЕНИЕ!", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
            if (dialogResult == DialogResult.Yes)
                DeleteCurrentRow();
        }

        private void buttonDelService_Click(object sender, EventArgs e)
        {
            WarningDeleteCurrentRow();
        }

        private void buttonDelClient_Click(object sender, EventArgs e)
        {
            WarningDeleteCurrentRow();
        }

        private void buttonDelWasher_Click(object sender, EventArgs e)
        {
            WarningDeleteCurrentRow();
        }

        private void dataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            SelectCurrentRow();
            WarningDeleteCurrentRow();
        }

        private void ChangeForm_Load(object sender, EventArgs e)
        {
            dateOBWasher.MaxDate = DateTime.Today;
            UpdateGridView();
        }
    }
}
