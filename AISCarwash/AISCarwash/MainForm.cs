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
    public partial class MainForm : Form
    {
        private string _mode;
        public MainForm(string mode)
        {
            InitializeComponent();
            this.CenterToScreen();
            if (mode == "user" || mode == "admin")
                _mode = mode;
            else Close();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            if (_mode == "user")
                ActivateUserMode();
        }
        private void ActivateUserMode()
        {
            buttonUserControl.Enabled = false;
            buttonUserControl.Visible = false;
            buttonAdd.Enabled = false;
            buttonAdd.Visible = false;
            buttonChange.Enabled = false;
            buttonChange.Visible = false;
        }
        private void exit_Click(object sender, EventArgs e)
        {
            Close();
            Application.Exit();
        }

        private void buttonUserControl_Click(object sender, EventArgs e)
        {
            this.Close();
            UserControlForm form = new UserControlForm(_mode);
            form.Show();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            this.Close();
            ChangeForm form = new ChangeForm(_mode);
            form.Show();
        }
    }
}
