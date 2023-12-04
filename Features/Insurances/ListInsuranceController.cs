using Agro.Data.Models;
using Agro.Features.Authentication;
using Agro.Features.Farms;
using Agro.Features.Person;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace Agro.Features.Insurances
{
    public partial class ListInsuranceController : UserControl
    {

        private readonly IAuthenticationRepository _authenticationRepository;
        private readonly IPersonalRepository _personalRepository;
        private readonly IFarmRepository _farmRepository;
        private readonly IInsuranceRepository _insuranceRepository;

        private readonly AuthenticationDTO _authenticationDTO;
        private Personal _personData;
        private Farm _farm;
        private Insurance _insurance;


        IQueryable<Insurance> _queryingInsurances;

        private Insurance[] _activeInsurances;
        private Insurance[] _inactiveInsurances;
        private Insurance[] _applyingInsurances;

        public ListInsuranceController(IAuthenticationRepository authenticationRepository,
            IPersonalRepository personalRepository,
            IFarmRepository farmRepository,
            IInsuranceRepository insuranceRepository)
        {
            _authenticationRepository = authenticationRepository;
            _personalRepository = personalRepository;
            _farmRepository = farmRepository;
            _insuranceRepository = insuranceRepository;
            InitializeComponent();

            _queryingInsurances = _insuranceRepository.GetInsurances();


        }

        private void ListInsuranceController_Load(object sender, EventArgs e)
        {
            FilterSelectorCB.SelectedIndex = 1;
            FetchData();
            FillDataGridView();
        }

        private void ApproveInsuranceBtn_Click(object sender, EventArgs e)
        {
            UpdateApplication(true);
            FetchData();
            FillDataGridView();
        }



        private void FetchData()
        {
            _activeInsurances = _queryingInsurances
                    .Where(insurance => insurance.Remarks && insurance.Status == "ACTIVE")
                    .OrderBy(insurance => insurance.FK_Farm.FK_Personal.LastName)
                    .ToArray();

            _inactiveInsurances = _queryingInsurances
                    .Where(insurance => insurance.Remarks && insurance.Status == "INACTIVE")
                    .OrderBy(insurance => insurance.FK_Farm.FK_Personal.LastName)
                    .ToArray();

            _applyingInsurances = _queryingInsurances
                     .Where(insurance => !insurance.Remarks && insurance.Status == "WAITING")
                     .OrderBy(insurance => insurance.FK_Farm.FK_Personal.LastName)
                     .ToArray();

        }

        private void FillDataGridView()
        {
            MembersDataGrid.Rows.Clear();
            switch (FilterSelectorCB.SelectedIndex)
            {

                // 0 for applicants
                case 0:
                    if (SearchText.Text != string.Empty && SearchText.Text != null)
                    {
                        string[] splitter = new string[2];
                        if (SearchText.Text.Contains(","))
                        {
                            splitter = SearchText.Text.Split(",");
                        }
                        else
                        {
                            splitter[0] = SearchText.Text;
                        }
                        _applyingInsurances = _queryingInsurances
                                        .Where(applicant => applicant.Status == "WAITING" && EF.Functions.Like(applicant.FK_Farm.FK_Personal.LastName, $"%{splitter[0]}%"))
                                        .OrderBy(applicant => applicant.FK_Farm.FK_Personal.LastName)
                                        .ToArray();
                    }

                    MembersDataGrid.Columns["RemarksCol"].ReadOnly = false;

                    ApproveInsuranceBtn.Visible = true;
                    DeclineInsuranceBtn.Visible = true;
                    InactiveInsuranceBtn.Visible = false;

                    foreach (var application in _applyingInsurances)
                    {

                        // Name formatter
                        string fullname;

                        fullname = $"{application.FK_Farm.FK_Personal.LastName}";

                        if (application.FK_Farm.FK_Personal.Suffix != null && application.FK_Farm.FK_Personal.Suffix != string.Empty)
                            fullname += $" {application.FK_Farm.FK_Personal.Suffix}";

                        fullname += $", {application.FK_Farm.FK_Personal.FirstName}";

                        if (application.FK_Farm.FK_Personal.MiddleName != null && application.FK_Farm.FK_Personal.MiddleName != string.Empty)
                            fullname += $" {application.FK_Farm.FK_Personal.MiddleName[0]}.";

                        MembersDataGrid.Columns["DateAppliedCol"].Visible = true;

                        string FarmAddress = string.Empty;
                        // Farm Address
                        if (application.FK_Farm.FK_Address.HouseNumber != null && application.FK_Farm.FK_Address.HouseNumber != string.Empty)
                            FarmAddress += application.FK_Farm.FK_Address.HouseNumber + ", ";

                        if (application.FK_Farm.FK_Address.Street != null && application.FK_Farm.FK_Address.Street != string.Empty)
                            FarmAddress += application.FK_Farm.FK_Address.Street + ", ";

                        if (application.FK_Farm.FK_Address.Barangay != null && application.FK_Farm.FK_Address.Barangay != string.Empty)
                            FarmAddress += application.FK_Farm.FK_Address.Barangay + ", ";

                        FarmAddress += application.FK_Farm.FK_Address.Municipality + ", ";
                        FarmAddress += application.FK_Farm.FK_Address.Province;


                        MembersDataGrid.Columns["DateAppliedCol"].Visible = false;

                        // 
                        MembersDataGrid.Rows.Add(
                            application.PK_Insurance,
                            application.FK_Farm.PK_Farm, // FarmID
                            application.Remarks, // Remarks
                            application.Status, // Status
                            fullname, // owner name
                            application.FK_Farm.FK_Personal.FK_User.Role, // Role
                            application.FK_Farm.CommodityName, // Commodity
                            application.FK_Farm.AreaSQM, // Square Meters
                            FarmAddress, // Location
                            application.FK_Farm.isHVCDP, // isHVCDP
                            application.FK_Farm.TenurialStatus, // Tenurial Status
                            application.FK_Farm.LandCategorySoilType,  // LandCategory / soild
                            application.FK_Farm.FK_Personal.ContactNumber, // owner Contact nmber
                            application.DateApplied, // Date of Application
                            application.FK_Farm.NorthAdjacentOwner, // Adjacent Owners
                            application.FK_Farm.SouthAdjacentOwner,
                            application.FK_Farm.EastAdjacentOwner,
                            application.FK_Farm.WastAdjacentOwner);
                    }
                    break;


                // 1 for Active Insurances 
                case 1:

                    if (SearchText.Text != string.Empty)
                    {
                        string[] splitter = new string[2];
                        if (SearchText.Text.Contains(","))
                        {
                            splitter = SearchText.Text.Split(",");
                        }
                        else
                        {
                            splitter[0] = SearchText.Text;
                        }
                        // Getting the searched query
                        _activeInsurances = _queryingInsurances
                            .Where(insurance => insurance.Remarks && insurance.Status == "ACTIVE" && EF.Functions.Like(insurance.FK_Farm.FK_Personal.LastName, $"%{splitter[0]}%"))
                            .OrderBy(insurance => insurance.FK_Farm.FK_Personal.FirstName)
                            .ToArray();
                    }

                    MembersDataGrid.Columns["RemarksCol"].ReadOnly = true;
                    InactiveInsuranceBtn.Visible = true;
                    DeclineInsuranceBtn.Visible = false;
                    ApproveInsuranceBtn.Visible = false;

                    foreach (var insurance in _activeInsurances)
                    {

                        // Name formatter
                        string fullname;

                        fullname = $"{insurance.FK_Farm.FK_Personal.LastName}";

                        if (insurance.FK_Farm.FK_Personal.Suffix != null && insurance.FK_Farm.FK_Personal.Suffix != string.Empty)
                            fullname += $" {insurance.FK_Farm.FK_Personal.Suffix}";

                        fullname += $", {insurance.FK_Farm.FK_Personal.FirstName}";

                        if (insurance.FK_Farm.FK_Personal.MiddleName != null && insurance.FK_Farm.FK_Personal.MiddleName != string.Empty)
                            fullname += $" {insurance.FK_Farm.FK_Personal.MiddleName[0]}.";

                        string FarmAddress = string.Empty;
                        // Farm Address
                        if (insurance.FK_Farm.FK_Address.HouseNumber != null && insurance.FK_Farm.FK_Address.HouseNumber != string.Empty)
                            FarmAddress += insurance.FK_Farm.FK_Address.HouseNumber + ", ";

                        if (insurance.FK_Farm.FK_Address.Street != null && insurance.FK_Farm.FK_Address.Street != string.Empty)
                            FarmAddress += insurance.FK_Farm.FK_Address.Street + ", ";

                        if (insurance.FK_Farm.FK_Address.Barangay != null && insurance.FK_Farm.FK_Address.Barangay != string.Empty)
                            FarmAddress += insurance.FK_Farm.FK_Address.Barangay + ", ";

                        FarmAddress += insurance.FK_Farm.FK_Address.Municipality + ", ";
                        FarmAddress += insurance.FK_Farm.FK_Address.Province;


                        MembersDataGrid.Columns["DateAppliedCol"].Visible = false;

                        // 
                        MembersDataGrid.Rows.Add(
                            insurance.PK_Insurance,
                            insurance.FK_Farm.PK_Farm, // FarmID
                            insurance.Remarks, // Remarks
                            insurance.Status, // Status
                            fullname, // owner name
                            insurance.FK_Farm.FK_Personal.FK_User.Role, // Role
                            insurance.FK_Farm.CommodityName, // Commodity
                            insurance.FK_Farm.AreaSQM, // Square Meters
                            FarmAddress, // Location
                            insurance.FK_Farm.isHVCDP, // isHVCDP
                            insurance.FK_Farm.TenurialStatus, // Tenurial Status
                            insurance.FK_Farm.LandCategorySoilType,  // LandCategory / soild
                            insurance.FK_Farm.FK_Personal.ContactNumber, // owner Contact nmber
                            null, // Date of Application
                            insurance.FK_Farm.NorthAdjacentOwner, // Adjacent Owners
                            insurance.FK_Farm.SouthAdjacentOwner,
                            insurance.FK_Farm.EastAdjacentOwner,
                            insurance.FK_Farm.WastAdjacentOwner);
                    }
                    break;

                case 2:
                    if (SearchText.Text != string.Empty)
                    {
                        string[] splitter = new string[2];
                        if (SearchText.Text.Contains(","))
                        {
                            splitter = SearchText.Text.Split(",");
                        }
                        else
                        {
                            splitter[0] = SearchText.Text;
                        }
                        // Getting the searched query
                        _inactiveInsurances = _queryingInsurances
                            .Where(insurance => insurance.Remarks && insurance.Status == "INACTIVE" && EF.Functions.Like(insurance.FK_Farm.FK_Personal.LastName, $"%{splitter[0]}%"))
                            .OrderBy(insurance => insurance.FK_Farm.FK_Personal.FirstName)
                            .ToArray();
                    }

                    MembersDataGrid.Columns["RemarksCol"].ReadOnly = true;
                    InactiveInsuranceBtn.Visible = true;
                    DeclineInsuranceBtn.Visible = false;
                    ApproveInsuranceBtn.Visible = false;

                    foreach (var insurance in _inactiveInsurances)
                    {

                        // Name formatter
                        string fullname;

                        fullname = $"{insurance.FK_Farm.FK_Personal.LastName}";

                        if (insurance.FK_Farm.FK_Personal.Suffix != null && insurance.FK_Farm.FK_Personal.Suffix != string.Empty)
                            fullname += $" {insurance.FK_Farm.FK_Personal.Suffix}";

                        fullname += $", {insurance.FK_Farm.FK_Personal.FirstName}";

                        if (insurance.FK_Farm.FK_Personal.MiddleName != null && insurance.FK_Farm.FK_Personal.MiddleName != string.Empty)
                            fullname += $" {insurance.FK_Farm.FK_Personal.MiddleName[0]}.";

                        string FarmAddress = string.Empty;
                        // Farm Address
                        if (insurance.FK_Farm.FK_Address.HouseNumber != null && insurance.FK_Farm.FK_Address.HouseNumber != string.Empty)
                            FarmAddress += insurance.FK_Farm.FK_Address.HouseNumber + ", ";

                        if (insurance.FK_Farm.FK_Address.Street != null && insurance.FK_Farm.FK_Address.Street != string.Empty)
                            FarmAddress += insurance.FK_Farm.FK_Address.Street + ", ";

                        if (insurance.FK_Farm.FK_Address.Barangay != null && insurance.FK_Farm.FK_Address.Barangay != string.Empty)
                            FarmAddress += insurance.FK_Farm.FK_Address.Barangay + ", ";

                        FarmAddress += insurance.FK_Farm.FK_Address.Municipality + ", ";
                        FarmAddress += insurance.FK_Farm.FK_Address.Province;


                        MembersDataGrid.Columns["DateAppliedCol"].Visible = false;

                        // 
                        MembersDataGrid.Rows.Add(
                            insurance.PK_Insurance,
                            insurance.FK_Farm.PK_Farm, // FarmID
                            insurance.Remarks, // Remarks
                            insurance.Status, // Status
                            fullname, // owner name
                            insurance.FK_Farm.FK_Personal.FK_User.Role, // Role
                            insurance.FK_Farm.CommodityName, // Commodity
                            insurance.FK_Farm.AreaSQM, // Square Meters
                            FarmAddress, // Location
                            insurance.FK_Farm.isHVCDP, // isHVCDP
                            insurance.FK_Farm.TenurialStatus, // Tenurial Status
                            insurance.FK_Farm.LandCategorySoilType,  // LandCategory / soild
                            insurance.FK_Farm.FK_Personal.ContactNumber, // owner Contact nmber
                            null, // Date of Application
                            insurance.FK_Farm.NorthAdjacentOwner, // Adjacent Owners
                            insurance.FK_Farm.SouthAdjacentOwner,
                            insurance.FK_Farm.EastAdjacentOwner,
                            insurance.FK_Farm.WastAdjacentOwner);
                    }
                    break;
            }
        }

        private void UpdateApplication(bool isApprove)
        {
            var userDTO = _authenticationRepository.GetAuthenticationDetails();

            var user = _authenticationRepository.GetUserByID(userDTO.PK_User);

            var index = MembersDataGrid.CurrentRow.Index;
            var approvingThis = MembersDataGrid.Rows[index].Cells["FullNameCol"].Value.ToString();
            var id = Guid.Parse(MembersDataGrid.Rows[index].Cells["InsuranceID"].Value.ToString());

            string wishToWord = isApprove ? "approve" : "deny";
            var dialogres = MessageBox.Show($"Do you wish to {wishToWord} the application of {approvingThis}?", "Updating Applicant", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialogres == DialogResult.Yes)
                _insuranceRepository.UpdateInsurance(id, isApprove, user);
        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            FillDataGridView();
        }

        private void ApplyFilterBtn_Click(object sender, EventArgs e)
        {
            FetchData();
            FillDataGridView();
            if(FilterSelectorCB.SelectedIndex == 1)
            {
                InactiveInsuranceBtn.Text = "Inactive Insurance";
            }
            else if(FilterSelectorCB.SelectedIndex == 2)
            {
                InactiveInsuranceBtn.Text = "Remove Insurance";
            }
        }

        private void DeclineInsuranceBtn_Click(object sender, EventArgs e)
        {
            UpdateApplication(false);
            FetchData();
            FillDataGridView();
        }

        private void InactiveInsuranceBtn_Click(object sender, EventArgs e)
        {
            var userDTO = _authenticationRepository.GetAuthenticationDetails();

            var user = _authenticationRepository.GetUserByID(userDTO.PK_User);

            var index = MembersDataGrid.CurrentRow.Index;
            var approvingThis = MembersDataGrid.Rows[index].Cells["FullNameCol"].Value.ToString();
            var id = Guid.Parse(MembersDataGrid.Rows[index].Cells["InsuranceID"].Value.ToString());

            string wishToWord = string.Empty;
            switch (InactiveInsuranceBtn.Text)
            {
                case "Remove Insurance":
                    wishToWord = "remove";
                    var dialogres = MessageBox.Show($"Do you want to {wishToWord} the insurance for {approvingThis}?", "Tag Inactive Insurance", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dialogres == DialogResult.Yes)
                    {
                        var res = _insuranceRepository.RemoveInsurance(id);
                        if (res)
                        {
                            MessageBox.Show("The record of this insurance has been Removed from the database", "Removing of Data successfully executed");
                        }
                        else
                        {
                            MessageBox.Show("Try again something went wrong in removing the data", "Error in removing Data");
                        }
                    }
                    break;
                
                case "Inactive Insurance":
                    wishToWord = "inactive";

                    var dialog = MessageBox.Show($"Do you want  {wishToWord} the insurance for {approvingThis}?", "Tag Inactive Insurance", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if(dialog == DialogResult.Yes)
                    {
                        var res = _insuranceRepository.InactiveInsurance(id);
                        if (res)
                        {
                            MessageBox.Show("The insurance has been tagged as inactive", "Tagging Successfully executed");
                        }
                        else
                        {
                            MessageBox.Show("Try again something went wrong in sending the data", "Error in tagging");
                        }
                    }
                    break;
            }

            FetchData();
            FillDataGridView();
        }
    }
}
