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
    public partial class SelectAdmin : UserControl
    {
        public SelectAdmin()
        {
            InitializeComponent();
        }

        private void BackLabel_Click(object sender, EventArgs e)
        {
            Parent.Controls["SelectRole"].BringToFront();
        }

        private void AdminBtn_Click(object sender, EventArgs e)
        {
            Parent.Controls["RegisterUC"].Controls["RoleLabel"].Text = "ADMIN";
            Parent.Controls["AuthUC"].BringToFront();
        }

        private void TechnicianBtn_Click(object sender, EventArgs e)
        {
            Parent.Controls["RegisterUC"].Controls["RoleLabel"].Text = "TECHNICIAN";
            Parent.Controls["AuthUC"].BringToFront();
        }
    }
}
