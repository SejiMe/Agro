using Agro.Data.Models;
using Agro.Features.Authentication;
using Agro.Features.Person;
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
        private readonly IPersonalRepository _personalRepository;

        Personal _personData;
        AuthenticationDTO _authenticationDTO;

        public GeneralNavigation(IAuthenticationRepository authenticationRepository, IPersonalRepository personalRepository)
        {
            _personalRepository = personalRepository;
            _authenticationRepository = authenticationRepository;

            InitializeComponent();

        }

        private void GeneralNavigation_Load(object sender, EventArgs e)
        {
            _authenticationDTO = _authenticationRepository.GetAuthenticationDetails();
            _personData = _personalRepository.GetPerson(_authenticationDTO.PK_Personal);



            if (_authenticationDTO.role != "TECHNICIAN" && _authenticationDTO.role != "ADMIN")
            {
                ApplyMembershipBtn.Text = "Apply Membership";
                CropInsuranceBtn.Text = "Apply Insurance";
                if (!_personData.IsApproved)
                    CropInsuranceBtn.Visible = false;
                else
                    CropInsuranceBtn.Visible = true;
            }else
            {
                ApplyMembershipBtn.Text = "View Members";
                CropInsuranceBtn.Text = "View Insurances";
                ApplyMembershipBtn.Visible = false;
                CropInsuranceBtn.Visible = false;
                
                if (_personData.IsApproved)
                {
                    ApplyMembershipBtn.Visible = true;
                    CropInsuranceBtn.Visible = true;
                }
                
            }
        }

       public void RefreshController() 
        {
            this.OnLoad(EventArgs.Empty);
        }

        private void ApplyMembershipBtn_Click(object sender, EventArgs e)
        {
            if (_authenticationDTO == null)
                return;


            if (_authenticationDTO.role == "TECHNICIAN" || _authenticationDTO.role == "ADMIN")
            {
                ParentForm.Controls["HeaderPanel"].Controls["TitleLabel"].Text = "Members";
                ParentForm.Controls["ControllerPanel"].Controls["ListMembershipController"].BringToFront();
            }
            else
            {
                ParentForm.Controls["HeaderPanel"].Controls["TitleLabel"].Text = "Membership";
                ParentForm.Controls["ControllerPanel"].Controls["MemberProfileController"].BringToFront();
            }
        }
        

        private void CropInsuranceBtn_Click(object sender, EventArgs e)
        {
            if (_authenticationDTO == null)
                return;

            if (_authenticationDTO.role == "TECHNICIAN" || _authenticationDTO.role == "ADMIN")
            {
                // TODO Change it for insurance 

                ParentForm.Controls["headerpanel"].Controls["titlelabel"].Text = "Insurances";
                ParentForm.Controls["controllerpanel"].Controls["ListInsuranceController"].BringToFront();
            }
            else
            {

                ParentForm.Controls["HeaderPanel"].Controls["TitleLabel"].Text = "Insurance";
                ParentForm.Controls["ControllerPanel"].Controls["InsuranceProfileController"].BringToFront();
            }

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
