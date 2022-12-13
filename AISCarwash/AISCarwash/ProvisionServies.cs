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
    public partial class ProvisionServies : Form
    {
        private string _mode;
        string[] idClients;
        string[] idServices;
        string[] idWashers;
        public ProvisionServies(string mode)
        {
            InitializeComponent();
            _mode = mode;
            this.CenterToScreen();
        }

        private void selectAddClient_CheckedChanged(object sender, EventArgs e)
        {
            groupAddClient.Enabled = selectAddClient.Checked;
        }

        private void BackToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            MainForm form = new MainForm(_mode);
            form.Show();
        }

        private void buttonAddClient_Click(object sender, EventArgs e)
        {
            if (MySqlConnecter.StringsIsEmpty(textNameClient.Text, textSurnameClient.Text, textModelCarClient.Text))
                return;
            string table = "listclients";
            string values = "DEFAULT, '"+textNameClient.Text+"', '"+textSurnameClient.Text+"', '"+textPatronymicClient.Text+"', '"+textModelCarClient.Text+"'";
            MySqlConnecter.QueryAddInTable(table, values);
            selectAddClient.Checked = false;
            UpdateBoxes();
            ResetAddClient();
        }
        private void ResetAddClient()
        {
            textNameClient.ResetText();
            textSurnameClient.ResetText();
            textPatronymicClient.ResetText();
            textModelCarClient.ResetText();
        }

        private void ProvisionServies_Load(object sender, EventArgs e)
        {
            UpdateBoxes();
        }
        private void UpdateBoxes()
        {
            selectClient.DropDownStyle = ComboBoxStyle.DropDownList;
            selectClient.DataSource = ParseData("*", "listClients");
            idClients = ParseData("idClient", "listClients");
            selectClient.SelectedIndex = selectClient.Items.Count - 1;

            selectService.DropDownStyle = ComboBoxStyle.DropDownList;
            selectService.DataSource = ParseData("*", "listServices");
            idServices = ParseData("idService", "listServices");
            selectService.SelectedIndex = selectService.Items.Count - 1;

            selectWasher.DropDownStyle = ComboBoxStyle.DropDownList;
            selectWasher.DataSource = ParseData("*", "listWashers");
            idWashers = ParseData("idWasher", "listWashers");
            selectWasher.SelectedIndex = selectWasher.Items.Count - 1;
        }
        private string[] ParseData(string column, string tableName)
        {
            string condition = "true";
            DataTable dt = MySqlConnecter.QueryReturnTable(column, tableName, condition);
            string[] data = new string[dt.Rows.Count];
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                for (int j = 0; j < dt.Columns.Count; j++)
                    data[i] += dt.Rows[i][j].ToString() + " \t ";
            }
            return data;
        }

        private void buttonProvisionService_Click(object sender, EventArgs e)
        {
            if (MySqlConnecter.StringsIsEmpty(selectClient.Text, selectService.Text, selectWasher.Text))
                return;
            string tableName = "provisionService";
            string values = "DEFAULT, " + idClients[selectClient.SelectedIndex] + ", " + idServices[selectService.SelectedIndex] + ", " + idWashers[selectWasher.SelectedIndex] + "";
            MySqlConnecter.QueryAddInTable(tableName, values);
            MessageBox.Show("проводка завершена успешно");
            BackToolStripMenuItem_Click(sender, e);
        }
    }
}
