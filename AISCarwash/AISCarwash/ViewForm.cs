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
    public partial class ViewForm : Form
    {
        private string _mode;
        private string table = "provisionService";
        private DataGridViewRow _currentRow;
        public ViewForm(string mode)
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
        private void UpdateGridView()
        {
            string column = 
                "ProvisionService.idProvisionService, " +
                "listClients.Surname, " +
                "listClients.Name, " +
                "listClients.ModelCar, " +
                "listServices.ServiceName, " +
                "listServices.ServicePrice, " +
                "listWashers.Surname, " +
                "listWashers.Name";
            string tableName = "ProvisionService, listClients, listServices, listWashers";
            string condition = 
                "ProvisionService.idClient = listClients.idClient AND " +
                "ProvisionService.idService = listServices.idService AND " +
                "ProvisionService.idWasher = listWashers.idWasher";

            dataGridView.DataSource = MySqlConnecter.QueryReturnTable(column, tableName, condition);
            counterTable.Text = dataGridView.RowCount.ToString();
            dataGridView = MySqlConnecter.ChangeColumnsName(dataGridView,
                                    "id", "Фамилия клиента", "Имя клиента",
                                    "Модель машины", "Наименование услуги",
                                    "Цена", "Фамилия мойщика", "Имя мойщика");
        }                                                  
                                                        
        private void DeleteCurrentRow()
        {
            string condition = ""+_currentRow.Cells[0].OwningColumn.Name+" = "+_currentRow.Cells[0].Value.ToString()+"";
            MySqlConnecter.QueryDeleteInTable(table, condition);
            UpdateGridView();
        }
        private void WarningDeleteCurrentRow()
        {
            string row = "";
            for (int i = 0; i < dataGridView.Columns.Count; i++) row += "\t" + _currentRow.Cells[i].Value.ToString();
            DialogResult dialogResult = MessageBox.Show("Вы действительно хотите удалить следующую запись?: \n" + row + "", "Внимание! УДАЛЕНИЕ!", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
            if (dialogResult == DialogResult.Yes)
                DeleteCurrentRow();
        }

        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            _currentRow = dataGridView.Rows[dataGridView.CurrentCell.RowIndex];
            _currentRow.Selected = true;
        }

        private void dataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            _currentRow = dataGridView.Rows[dataGridView.CurrentCell.RowIndex];
            _currentRow.Selected = true;
            WarningDeleteCurrentRow();
        }

        private void ViewForm_Load(object sender, EventArgs e)
        {
            UpdateGridView();
        }
    }
}
