using Agro.Data.Models;
using Agro.Features.Authentication;
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

namespace Agro.Features.Person
{
    public partial class ListMembershipController : UserControl
    {
        private readonly IPersonalRepository _personalRepository;
        private readonly IAuthenticationRepository _authenticationRepository;
        MembershipApplication[] _applicants;
        Personal[] _members;
        IQueryable<MembershipApplication> queryingApplicants;
        IQueryable<Personal> queryingMembers;

        public ListMembershipController(IPersonalRepository personalRepository, IAuthenticationRepository authenticationRepository)
        {
            _authenticationRepository = authenticationRepository;
            _personalRepository = personalRepository;
            InitializeComponent();
        }

        private void ListMembershipController_Load(object sender, EventArgs e)
        {
            queryingMembers = _personalRepository.GetAllMembers();
            queryingApplicants = _personalRepository.GetAllApplicants();


            // 1 for members
            // 0 for applicants
            FilterSelectorCB.SelectedIndex = 1;

            // Fetch all default members that is approved
            FetchData();

            FillDataGridView();



        }

        private void FetchData()
        {
            _members = queryingMembers
                    .Where(person => person.IsApproved && person.FK_User.Role != "ADMIN")
                    .OrderBy(person => person.FirstName)
                    .ToArray();

            _applicants = queryingApplicants
                .Where(applicant => applicant.Remarks == "WAITING")
                .OrderBy(applicant => applicant.FK_Personal.LastName)
                .ToArray();
        }

        private void FillDataGridView()
        {
            MembersDataGrid.Rows.Clear();
            switch (FilterSelectorCB.SelectedIndex)
            {

                // 0 for applicants
                case 0:
                    if(SearchText.Text != string.Empty)
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
                        _applicants = queryingApplicants
                                        .Where(applicant => applicant.Remarks == "WAITING" && EF.Functions.Like(applicant.FK_Personal.LastName, $"%{splitter[0]}%") )
                                        .OrderBy(applicant => applicant.FK_Personal.LastName)
                                        .ToArray();
                    }
                    
                    MembersDataGrid.Columns["RemarksCol"].ReadOnly = false;

                    ApproveMemberBtn.Visible = true;
                    DeclineMembershipBtn.Visible = true;
                    RemoveMemberBtn.Visible = false;

                    foreach (var application in _applicants)
                    {

                        // Name formatter
                        string fullname;

                        fullname = $"{application.FK_Personal.LastName}";

                        if (application.FK_Personal.Suffix != null && application.FK_Personal.Suffix != string.Empty)
                            fullname += $" {application.FK_Personal.Suffix}";

                        fullname += $", {application.FK_Personal.FirstName}";

                        if (application.FK_Personal.MiddleName != null && application.FK_Personal.MiddleName != string.Empty)
                            fullname += $" {application.FK_Personal.MiddleName[0]}.";

                        MembersDataGrid.Columns["DateAppliedCol"].Visible = true;
                        MembersDataGrid.Rows.Add(application.FK_Personal.PK_Personal, application.FK_Personal.IsApproved, application.Remarks, fullname, application.FK_Personal.FK_User.Role, application.FK_Personal.ContactNumber, application.FK_Personal.DateOfBirth, application.DateApplied);
                    }

                    break;


                // 1 for approved members
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
                    _members = queryingMembers
                        .Where(person => person.IsApproved && person.FK_User.Role != "ADMIN" && EF.Functions.Like(person.LastName, $"%{splitter[0]}%"))
                        .OrderBy(person => person.FirstName)
                        .ToArray();
                    }

                    MembersDataGrid.Columns["RemarksCol"].ReadOnly = true;
                    RemoveMemberBtn.Visible = true;
                    DeclineMembershipBtn.Visible = false;
                    ApproveMemberBtn.Visible = false;

                    foreach (var member in _members)
                    {

                        // Name formatter
                        string fullname;

                        fullname = $"{member.LastName}";

                        if (member.Suffix != null && member.Suffix != string.Empty)
                            fullname += $" {member.Suffix}";

                        fullname += $", {member.FirstName}";

                        if (member.MiddleName != null && member.MiddleName != string.Empty)
                            fullname += $" {member.MiddleName[0]}.";
                        MembersDataGrid.Columns["DateAppliedCol"].Visible = false;
                        MembersDataGrid.Rows.Add(member.PK_Personal, member.IsApproved, member.IsApproved ? "MEMBER" : "", fullname, member.FK_User.Role, member.ContactNumber, member.DateOfBirth, null);
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
            var id = int.Parse(MembersDataGrid.Rows[index].Cells["PersonalIDCol"].Value.ToString());

            string wishToWord = isApprove ? "approve" : "deny";
            var dialogres = MessageBox.Show($"Do you wish to {wishToWord} the application of {approvingThis}?", "Updating Applicant", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialogres == DialogResult.Yes)
                _personalRepository.UpdatePersonMembership(id, user, isApprove);
        }

        private void ApplyFilterBtn_Click(object sender, EventArgs e)
        {
            FillDataGridView();
        }



        private void ApproveMemberBtn_Click(object sender, EventArgs e)
        {

            UpdateApplication(true);
            FetchData();
            FillDataGridView();
        }

        private void DeclineMembershipBtn_Click(object sender, EventArgs e)
        {
            UpdateApplication(false);
            FetchData();
            FillDataGridView();
        }

        private void RemoveMemberBtn_Click(object sender, EventArgs e)
        {
            var userDTO = _authenticationRepository.GetAuthenticationDetails();

            var user = _authenticationRepository.GetUserByID(userDTO.PK_User);

            var index = MembersDataGrid.CurrentRow.Index;
            var approvingThis = MembersDataGrid.Rows[index].Cells["FullNameCol"].Value.ToString();
            var id = int.Parse(MembersDataGrid.Rows[index].Cells["PersonalIDCol"].Value.ToString());

            if(userDTO.role == "TECHNICIAN" && MembersDataGrid.Rows[index].Cells["RoleCol"].Value.ToString() == "TECHNICIAN")
            {
                MessageBox.Show("You cant remove a membership of an Technician", "Invalid Removal", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var dialogres = MessageBox.Show($"Do you wish to remove the Membership of {approvingThis}?", "Updating Member", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialogres == DialogResult.Yes)
            {
                _personalRepository.RemoveMembership(id);
                FetchData();
                FillDataGridView();
            }
        }

        private void MembersDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
