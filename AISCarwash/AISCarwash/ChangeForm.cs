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
        private string GetCurrentTable()
        {
            string tableName = "";
            switch (tabControl.SelectedIndex)
            {
                case 0: tableName = "ListWashers"; break;
                case 1: tableName = "ListClients"; break;
                case 2: tableName = "listServices"; break;
                default:
                    break;
            }
            return tableName;
        }
        private void UpdateGridView()
        {
            string tableName = GetCurrentTable();
            string column = "*";
            string condition = $"EXISTS (SELECT {column} FROM {tableName})";
            dataGridView.DataSource = MySqlConnecter.QueryReturnTable(column, tableName, condition);
        }

        private void tabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateGridView();
        }
        private void SelectCurrentRow()
        {
            _currentRow = dataGridView.Rows[dataGridView.CurrentCell.RowIndex];
            _currentRow.Selected = true;
        }
        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            SelectCurrentRow();
            switch (GetCurrentTable())
            {
                case "ListWashers": GetDataFromTableListWashers(); break;
                case "ListClients": GetDataFromTableListClients(); break;
                case "listServices": GetDataFromTableListService(); break;
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
            string table = GetCurrentTable();
            string values = $" {_currentRow.Cells[1].OwningColumn.Name} = '{textNameWasher.Text}', " +
                $" {_currentRow.Cells[2].OwningColumn.Name} = '{textSurnameWasher.Text}', " +
                $" {_currentRow.Cells[3].OwningColumn.Name} = '{textPatronymicWasher.Text}', " +
                $" {_currentRow.Cells[4].OwningColumn.Name} = '{dateOBWasher.Value.ToString("yyyy-MM-dd")}'";
            string condition = $"{_currentRow.Cells[0].OwningColumn.Name} = {_currentRow.Cells[0].Value.ToString()}";
            MySqlConnecter.QueryChangeInTable(table, values, condition);
            UpdateGridView();
            ResetAll();
        }

        private void buttonChangeClient_Click(object sender, EventArgs e)
        {
            string table = GetCurrentTable();
            string values = $" {_currentRow.Cells[1].OwningColumn.Name} = '{textNameClient.Text}', " +
                $" {_currentRow.Cells[2].OwningColumn.Name} = '{textSurnameClient.Text}', " +
                $" {_currentRow.Cells[3].OwningColumn.Name} = '{textPatronymicClient.Text}', " +
                $" {_currentRow.Cells[4].OwningColumn.Name} = '{textModelCarClient.Text}'";
            string condition = $"{_currentRow.Cells[0].OwningColumn.Name} = {_currentRow.Cells[0].Value.ToString()}";
            MySqlConnecter.QueryChangeInTable(table, values, condition);
            UpdateGridView();
            ResetAll();
        }

        private void buttonChangeService_Click(object sender, EventArgs e)
        {
            string table = GetCurrentTable();
            string values = $" {_currentRow.Cells[1].OwningColumn.Name} = '{textNameService.Text}', " +
                $" {_currentRow.Cells[2].OwningColumn.Name} = {textPriceService.Text}";
            string condition = $"{_currentRow.Cells[0].OwningColumn.Name} = {_currentRow.Cells[0].Value.ToString()}";
            MySqlConnecter.QueryChangeInTable(table, values, condition);
            UpdateGridView();
            ResetAll();
        }
        private void DeleteCurrentRow()
        {
            string table = GetCurrentTable();
            string condition = $"{_currentRow.Cells[0].OwningColumn.Name} = {_currentRow.Cells[0].Value.ToString()}";
            MySqlConnecter.QueryDeleteInTable(table, condition);
            UpdateGridView();
            ResetAll();
        }
        private void WarningDeleteCurrentRow()
        {
            string row = "";
            for (int i = 0; i < dataGridView.Columns.Count; i++) row += "\t" + _currentRow.Cells[i].Value.ToString();
            DialogResult dialogResult = MessageBox.Show($"Вы действительно хотите удалить следующую запись?: \n{row}", "Внимание! УДАЛЕНИЕ!", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
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
            UpdateGridView();
        }
    }
}
