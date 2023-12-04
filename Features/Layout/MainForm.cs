using Agro.Data.Models;
using Agro.Features.Authentication;
using Agro.Features.Insurances;
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
        private readonly IPersonalRepository _person;
        private readonly IServiceProvider _serviceProvider;
        private readonly AuthForm _authform;
        private readonly GeneralNavigation _generalNavigation;
        private AuthenticationDTO authenticationDTO;
        private Personal? _personData;

        enum Roles
        {
            FARMER,
            TECHNICIAN,
            ADMIN
        }

        public MainForm(AuthForm authform, GeneralNavigation generalNavigation ,IAuthenticationRepository authentication, IPersonalRepository people, IServiceProvider serviceProvider, AuthForm authForm)
        {
            _authform = authform;
            _authentication = authentication;
            _person = people;
            _serviceProvider = serviceProvider;
            _generalNavigation = generalNavigation; 
            InitializeComponent();

            _generalNavigation.Dock = DockStyle.Fill;
            NavigationalButtonsPanel.Controls.Add(_generalNavigation);
            Controls["HeaderPanel"].Controls["TitleLabel"].Text = "My Profile";


            if (authenticationDTO == null)
            {
                authform.Show();
                this.Hide();
                return;
            }
        }
       

        private void MainForm_Load(object sender, EventArgs e)
        {
            var user = _authentication.GetAuthenticationDetails();
            _personData = _person.GetPerson(user.PK_Personal);

            ControllerPanel.Controls.Clear();
            _generalNavigation.RefreshController();

            FullNameLabel.Text = $"{_personData.LastName}, {_personData.FirstName}";

            if (user.role == Roles.FARMER.ToString() || user.role == Roles.ADMIN.ToString())
            {
               
                NavigationPanel.Controls[index: 0].BringToFront();
            }

            authenticationDTO = _authentication.GetAuthenticationDetails();


            #region Controller Panel MAIN
            if (user.role == Roles.FARMER.ToString())
            {

                var insuranceProfileController = ActivatorUtilities.CreateInstance<InsuranceProfileController>(_serviceProvider, authenticationDTO.PK_Personal);
                var personalProfileController = ActivatorUtilities.CreateInstance<MemberProfileController>(_serviceProvider, authenticationDTO.PK_Personal);

                insuranceProfileController.Dock = DockStyle.Fill;
               
                personalProfileController.Dock = DockStyle.Fill;
                

                ControllerPanel.Controls.Add(personalProfileController);

                if (_personData.IsApproved)
                    ControllerPanel.Controls.Add(insuranceProfileController);
            }
            else
            {
                // TODO add list controllers
                var listmembershipController = _serviceProvider.GetRequiredService<ListMembershipController>();
                var listInsuranceController = _serviceProvider.GetRequiredService<ListInsuranceController>();
                listmembershipController.Dock = DockStyle.Fill;
                listInsuranceController.Dock = DockStyle.Fill;
                

                // if the technnician is not yet approved by admin
                if (_personData.IsApproved)
                {
                    ControllerPanel.Controls.Add(listmembershipController);
                    ControllerPanel.Controls.Add(listInsuranceController);
                    // Add controller for insurance list
                }
            }




            #endregion
        }

        private void NavigationPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ControllerPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        public void RefreshPage()
        {
            
            
            this.OnLoad(EventArgs.Empty);
        }

        
        private void LogOutBtn_Click(object sender, EventArgs e)
        {
            var res = MessageBox.Show("Are you sure you want to sign out?", "Exit Application", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
           if(res == DialogResult.Yes)
            {
                _authform.Controls["tableLayoutPanel1"]
                    .Controls["panel1"]
                    .Controls["ControllerPanel"]
                    .Controls["AuthUC"]
                    .Controls["groupBox1"]
                    .Controls["PasswordText"].Text = string.Empty;
                _authform.Show();
                this.Hide();
                _authentication.Logout();
            }

        }
    }
}
