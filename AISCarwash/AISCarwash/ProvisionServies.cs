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
        public ProvisionServies(string mode)
        {
            InitializeComponent();
            _mode = mode;
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
    }
}
