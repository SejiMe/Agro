using Agro.Features.Authentication;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Agro.Features.Layout
{
    public partial class GeneralNavigation : UserControl
    {
        private readonly IAuthenticationRepository _authenticationRepository;
        AuthenticationDTO _authenticationDTO;

        public GeneralNavigation(IAuthenticationRepository authenticationRepository)
        {
            _authenticationRepository = authenticationRepository;
            _authenticationDTO = _authenticationRepository.GetAuthenticationDetails();
            InitializeComponent();
        }

        private void GeneralNavigation_Load(object sender, EventArgs e)
        {
            if(_authenticationDTO.role == "TECHNICIAN")
            {
                ApplyMembershipBtn.Text = "Membership List";
                CropInsuranceBtn.Text = "Insurance List";
            }
        }


        private void ApplyMembershipBtn_Click(object sender, EventArgs e)
        {

            if(_authenticationDTO.role == "TECHNICIAN")
            {
                ParentForm.Controls["HeaderPanel"].Controls["TitleLabel"].Text = "Membership";
                ParentForm.Controls["ControllerPanel"].Controls["ListMembershipController"].BringToFront();
            }

            ParentForm.Controls["HeaderPanel"].Controls["TitleLabel"].Text = "Membership";
            ParentForm.Controls["ControllerPanel"].Controls["MemberProfileController"].BringToFront();
        }

        private void CropInsuranceBtn_Click(object sender, EventArgs e)
        {
            ParentForm.Controls["HeaderPanel"].Controls["TitleLabel"].Text = "Insurance";
            ParentForm.Controls["ControllerPanel"].Controls["InsuranceProfileController"].BringToFront();
        }

       
    }
}
