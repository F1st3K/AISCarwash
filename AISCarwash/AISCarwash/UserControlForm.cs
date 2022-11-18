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
        private MySqlConnecter mySqlConnecter;
        public UserControlForm(string mode)
        {
            _mode = mode;
            mySqlConnecter = new MySqlConnecter();
            InitializeComponent();
        }

        private void UserControlForm_Load(object sender, EventArgs e)
        {

        }

        private void BackToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            MainForm form = new MainForm(_mode);
            form.Show();
        }
    }
}
