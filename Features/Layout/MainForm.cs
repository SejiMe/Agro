using Agro.Features.Authentication;
using Agro.Features.Person;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Agro.Features.Layout
{
    public partial class MainForm : Form
    {
        private readonly IAuthenticationRepository _authentication;
        private readonly IPersonalRepository _people;
        private readonly IServiceProvider _serviceProvider;
        private readonly AuthForm _authform;

        enum Roles
        {
            FARMER,
            TECHNICIAN,
            ADMIN
        }

        public MainForm(AuthForm authform, IAuthenticationRepository authentication, IPersonalRepository people, IServiceProvider serviceProvider)
        {
            _authentication = authentication;
            _people = people;
            _serviceProvider = serviceProvider;
            InitializeComponent();

            var GeneralNavController = _serviceProvider.GetRequiredService<GeneralNavigation>();

            NavigationalButtonsPanel.Controls.Add(GeneralNavController);

            var user = _authentication.GetAuthenticationDetails();

            if (user == null)
            {
                authform.Show();
                this.Hide();
                return;
            }
          

        }

        private void NavigationPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ControllerPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            var user = _authentication.GetAuthenticationDetails();

            MessageBox.Show(user.PK_User.ToString());
            var person = _people.GetPersonByUser((Guid)user.PK_User);
            FullNameLabel.Text = $"{person.LastName}, {person.FirstName}";

            if (user.role == Roles.FARMER.ToString() || user.role == Roles.ADMIN.ToString())
            {
                NavigationPanel.Controls[0].BringToFront();
            }

            var addressController = _serviceProvider.GetRequiredService<ProfileController>();
            addressController.Dock = DockStyle.Fill;
            #region Controller Panel MAIN
            ControllerPanel.Controls.Add(addressController);
            #endregion
        }
    }
}
