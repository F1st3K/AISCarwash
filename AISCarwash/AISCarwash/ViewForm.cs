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
            string tableName = "provisionService";
            string column = "*";
            string condition = $"EXISTS (SELECT {column} FROM {tableName})";
            dataGridView.DataSource = MySqlConnecter.QueryReturnTable(column, tableName, condition);
            counterTable.Text = dataGridView.RowCount.ToString();
        }
    }
}
