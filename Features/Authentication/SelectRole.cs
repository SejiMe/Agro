using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Agro.Features.Authentication
{
    public partial class SelectRole : UserControl
    {
        public SelectRole()
        {
            InitializeComponent();
        }

        private void AdminBtn_Click(object sender, EventArgs e)
        {
            Parent.Controls["SelectAdmin"].BringToFront();
        }

        private void UserBtn_Click(object sender, EventArgs e)
        {
            Parent.Controls["RegisterUC"].Controls["RoleLabel"].Text = "FARMER";
            Parent.Controls["AuthUC"].BringToFront();
        }

        private void QuitLabel_Click(object sender, EventArgs e)
        {
            var res = MessageBox.Show("Are you sure you want to Exit?", "Exit Application", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
                Application.Exit();
        }
    }
}
