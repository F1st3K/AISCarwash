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
    public partial class AddForm : Form
    {
        private string _mode;

        public AddForm(string mode)
        {
            InitializeComponent();
            _mode = mode;
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
            string[] NameColumns = new string[] { };
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
            string condition = $"EXISTS (SELECT {column} FROM {tableName})";
            dataGridView.DataSource = MySqlConnecter.QueryReturnTable(column, tableName, condition);
            dataGridView = MySqlConnecter.ChangeColumnsName(dataGridView, GetCurrentNameColumns(tabControl.SelectedIndex));
            counterTable.Text = dataGridView.RowCount.ToString();
        }

        private void tabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateGridView();
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

        private void buttonAddWasher_Click(object sender, EventArgs e)
        {
            if (MySqlConnecter.StringsIsEmpty(textNameWasher.Text, textSurnameWasher.Text))
                return;
            string table = GetCurrentTable(tabControl.SelectedIndex);
            string values = $"DEFAULT, '{textNameWasher.Text}', '{textSurnameWasher.Text}', '{textPatronymicWasher.Text}', '{dateOBWasher.Value.ToString("yyyy-MM-dd")}'"; 
            MySqlConnecter.QueryAddInTable(table, values);
            UpdateGridView();
            ResetAll();
        }

        private void buttonAddClient_Click(object sender, EventArgs e)
        {
            if (MySqlConnecter.StringsIsEmpty(textNameClient.Text, textSurnameClient.Text, textModelCarClient.Text))
                return;
            string table = GetCurrentTable(tabControl.SelectedIndex);
            string values = $"DEFAULT, '{textNameClient.Text}', '{textSurnameClient.Text}', '{textPatronymicClient.Text}', '{textModelCarClient.Text}'";
            MySqlConnecter.QueryAddInTable(table, values);
            UpdateGridView();
            ResetAll();
        }

        private void buttonAddService_Click(object sender, EventArgs e)
        {
            if (MySqlConnecter.StringsIsEmpty(textNameService.Text))
                return;
            string table = GetCurrentTable(tabControl.SelectedIndex);
            string values = $"DEFAULT, '{textNameService.Text}', {textPriceService.Text}";
            MySqlConnecter.QueryAddInTable(table, values);
            UpdateGridView();
            ResetAll();
        }

        private void AddForm_Load(object sender, EventArgs e)
        {
            DateTime Now = DateTime.Today;
            dateOBWasher.MaxDate = new DateTime(Now.Year - 14, Now.Month, Now.Day);
            UpdateGridView();
        }

    }
}
