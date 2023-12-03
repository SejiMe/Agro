using Agro.Data.Models;
using Agro.Features.Addresses;
using Agro.Features.Farms;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Agro.Features.Person
{
    public partial class MemberProfileController : UserControl
    {
        private readonly IPersonalRepository _personalRepository;
        private readonly IFarmRepository _farmRepository;
        private readonly int _profileId;
        private readonly IServiceProvider _serviceProvider;

        private Personal personData;
        Farm rice = new();
        Farm corn = new();
        Farm hvcdp = new();

        Snapshot snapshot = new();

        public MemberProfileController(IPersonalRepository personalRepository, IFarmRepository farmRepository, IServiceProvider serviceProvider, int id)
        {
            _serviceProvider = serviceProvider;
            _personalRepository = personalRepository;
            _farmRepository = farmRepository;
            _profileId = id;
            InitializeComponent();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }


        private void ProfileController_Load(object sender, EventArgs e)
        {
            personData = _personalRepository.GetPerson(_profileId);

            if (personData.IsApproved)
                SubmitBtn.Visible = false;

            FirstNameText.Text = personData.FirstName;
            LastNameText.Text = personData.LastName;

            if (personData.MiddleName is not null)
                MiddleNameText.Text = personData.MiddleName;
            SuffixText.Text = personData.Suffix;

            if (personData.ContactNumber is not null)
                ContactNumberText.Text = personData.ContactNumber.Substring(3);

            if (personData.Gender is not null)
            {
                if (personData.Gender == 'M')
                    GenderCB.Text = "Male";
                else
                    GenderCB.Text = "Female";
            }


            if (personData.SpouseName is not null)
                SpouseText.Text = personData.SpouseName;

           
                DateTime dt = (DateTime)personData.DateOfBirth;
                DateOfBirth.Value = new DateTime(dt.Year, dt.Month, dt.Day);

            


            var hasFarm = _farmRepository.HasFarm(_profileId);
            Task<IEnumerable<Farm>> farms;

            if (hasFarm.Result)
            {
                // Load all the farm that this profile Uses
                farms = _farmRepository.GetAllFarm(_profileId);
                rice = farms.Result
                    .Where(farm => farm.CommodityName == "Rice")
                    .First();

                corn = farms.Result
                   .Where(farm => farm.CommodityName == "Corn")
                   .First();
                hvcdp = farms.Result.Where(farm => farm.isHVCDP == true)
                    .First();

            }
            else
            {
                // IF this person doesnt have any farm create initialized a farm with address for default
                // use for Rice and Corn and HVDCP
                _farmRepository.CreateInitialFarms(personData);
                farms = _farmRepository.GetAllFarm(_profileId);

                rice = farms.Result
                    .Where(farm => farm.CommodityName == "Rice")
                    .First();

                corn = farms.Result

                   .Where(farm => farm.CommodityName == "Corn")
                   .First();
                hvcdp = farms.Result.Where(farm => farm.isHVCDP == true)
                    .First();
            }


            var personalAddress = _personalRepository.GetPersonalAddress(_profileId);
            #region address initial data

            if (personalAddress.HouseNumber != null)
                CurrentAddressText.Text += personalAddress.HouseNumber + ", ";

            if (personalAddress.Street != null)
                CurrentAddressText.Text += personalAddress.Street + ", ";

            if (personalAddress.Barangay != null)
                CurrentAddressText.Text += personalAddress.Barangay + ", ";

            CurrentAddressText.Text += personalAddress.Municipality + ", ";
            CurrentAddressText.Text += personalAddress.Province;

            #endregion
            #region rice initial data
            if (rice.FK_Address.LotNumber != null && rice.FK_Address.LotNumber != "")
                RiceAddressText.Text = rice.FK_Address.LotNumber + ", ";

            if (rice.FK_Address.Street != null)
                RiceAddressText.Text += rice.FK_Address.Street + ", ";

            if (rice.FK_Address.Barangay != null)
                RiceAddressText.Text += rice.FK_Address.Barangay + ", ";

            RiceAddressText.Text += rice.FK_Address.Municipality + ", ";
            RiceAddressText.Text += rice.FK_Address.Province;

            if (rice.AreaSQM > 0)
                RiceAreaText.Text = rice.AreaSQM.ToString();
            #endregion

            #region corn initial data
            if (corn.FK_Address.LotNumber != null)
                CornAddressText.Text += corn.FK_Address.LotNumber + ", ";

            if (corn.FK_Address.Street != null)
                CornAddressText.Text += corn.FK_Address.Street + ", ";

            if (corn.FK_Address.Barangay != null)
                CornAddressText.Text += corn.FK_Address.Barangay + ", ";

            CornAddressText.Text += corn.FK_Address.Municipality + ", ";
            CornAddressText.Text += corn.FK_Address.Province;

            if (corn.AreaSQM > 0)
                CornAreaText.Text = corn.AreaSQM.ToString();
            #endregion

            #region HVCDP Initial Data

            if (hvcdp.AreaSQM > 0)
                HVCDPAreaText.Text = hvcdp.AreaSQM.ToString();

            if (hvcdp.CommodityName != null)
                CommodityText.Text = hvcdp.CommodityName;

            if (hvcdp.FK_Address.LotNumber != null)
                HVCDPAddressText.Text = hvcdp.FK_Address.LotNumber.ToString() + ", ";

            if (hvcdp.FK_Address.Street != null)
                HVCDPAddressText.Text += hvcdp.FK_Address.Street.ToString() + ", ";

            if (hvcdp.FK_Address.Barangay != null)
                HVCDPAddressText.Text += hvcdp.FK_Address.Barangay.ToString() + ", ";

            HVCDPAddressText.Text += hvcdp.FK_Address.Municipality + ", ";
            HVCDPAddressText.Text += rice.FK_Address.Province;
            #endregion
        }

        public void RefreshPage()
        {
            CurrentAddressText.Text = string.Empty;
            CornAddressText.Text = string.Empty;
            RiceAddressText.Text = string.Empty;
            HVCDPAddressText.Text = string.Empty;
            this.OnLoad(EventArgs.Empty);
        }
        private void MiddleNameText_TextChanged(object sender, EventArgs e)
        {

        }

        private void CurrentAddressEditBtn_Click(object sender, EventArgs e)
        {
            var form = _serviceProvider.GetRequiredService<AddressForm>();
            form.SetArguments("Personal", personData.PK_Personal, Guid.Empty, null, this);
            form.ShowDialog();
        }


        private void RiceFarmAddressBtn_Click(object sender, EventArgs e)
        {
            var form = _serviceProvider.GetRequiredService<AddressForm>();
            form.SetArguments("Farm", null, rice.PK_Farm, null, this);
            form.ShowDialog();
        }

        private void CornFarmAddressBtn_Click(object sender, EventArgs e)
        {
            var form = _serviceProvider.GetRequiredService<AddressForm>();
            form.SetArguments("Farm", null, corn.PK_Farm, null, this);
            form.ShowDialog();
        }

        private void HVCDPAddressBtn_Click(object sender, EventArgs e)
        {
            var form = _serviceProvider.GetRequiredService<AddressForm>();
            form.SetArguments("Farm", null, hvcdp.PK_Farm, null, this);
            form.ShowDialog();
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            switch (UpdateBtn.Text)
            {
                case "Update":
                    
                    UpdateBtn.Text = "Save";
                    AbleControls();
                    // Save a snapshot of save
                    snapshot = new(FirstNameText.Text, LastNameText.Text, 
                        MiddleNameText.Text, SuffixText.Text, 
                        GenderCB.SelectedIndex, DateOfBirth.Value, 
                        AssociationText.Text, SpouseText.Text, 
                        RiceAreaText.Text, CornAreaText.Text,
               CommodityText.Text, HVCDPAreaText.Text, ContactNumberText.Text);

                    // Show cancel edit
                    SubmitBtn.Text = "Cancel Edit";
                    SubmitBtn.Visible = true;
                    
                    break;
                case "Save":
                    // Implement Guard clauses
                    

                    var res = MessageBox.Show("Do you wish to save the changes?", "Save Membership Profile", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (res == DialogResult.Yes)
                    {
                        Regex ValidContactNumber = new Regex(@"^(817|905|906|915|916|917|926|927|935|936|937|955|956|965|966|967|975|976|977|978|979|994|995|996|997|918|919|920|921|928|929|930|938|939|946|947|948|949|950|951|981|989|998|999)[0-9]\d{6}$");
                        if(ContactNumberText.Text.Length > 0)
                        {
                            if (!ValidContactNumber.IsMatch(ContactNumberText.Text))
                            {
                                MessageBox.Show("Please input a valid contact number", "Valid Contact Number", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }
                        }

                        if (RiceAreaText.Text.Length > 0 && new Regex(@"^[0-9]+$").IsMatch(RiceAreaText.Text))
                        {
                            rice.AreaSQM = int.Parse(RiceAreaText.Text);
                        }else if(RiceAreaText.Text.Length == 0)
                        {
                            rice.AreaSQM = 0;
                        }
                        else
                        {
                            MessageBox.Show("Enter a valid number in Square Meters", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }

                        if (CornAreaText.Text.Length > 0 && new Regex(@"^[0-9]+$").IsMatch(CornAreaText.Text))
                        {
                            corn.AreaSQM = int.Parse(CornAreaText.Text);
                        }
                        else if (CornAreaText.Text.Length == 0)
                        {
                            corn.AreaSQM = 0;
                        }
                        else
                        {
                            MessageBox.Show("Enter a valid number in Square Meters", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }

                        if (HVCDPAreaText.Text.Length > 0 && new Regex(@"^[0-9]+$").IsMatch(HVCDPAreaText.Text))
                        {
                            hvcdp.AreaSQM = int.Parse(HVCDPAreaText.Text);
                        }
                        else if (HVCDPAreaText.Text.Length == 0)
                        {
                            hvcdp.AreaSQM = 0;
                        }
                        else
                        {
                            MessageBox.Show("Enter a valid number in Square Meters", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }

                        personData.PK_Personal = _profileId;
                        personData.FirstName = FirstNameText.Text;
                        personData.MiddleName = MiddleNameText.Text;
                        personData.LastName = LastNameText.Text;
                        personData.Suffix = SuffixText.Text;
                        personData.civil_status = SpouseText.Text != string.Empty ? "Married" : "Single";
                        personData.SpouseName = SpouseText.Text;
                        personData.DateOfBirth = DateOfBirth.Value;
                        personData.Association = AssociationText.Text;
                        personData.ContactNumber = AreaCodeText.Text + ContactNumberText.Text;

                        if (GenderCB.Text == "Male")
                            personData.Gender = 'M';
                        else
                            personData.Gender = 'F';
                        // hvdcp
                        hvcdp.CommodityName = CommodityText.Text;
                       

                        
                       
                        _personalRepository.Save();
                        DisableControls();

                        UpdateBtn.Text = "Update";

                        SubmitBtn.Text = "Submit Application";
                        if (_personalRepository.HasActiveApplication(personData.PK_Personal))
                        {
                            SubmitBtn.Visible = false;
                        }

                        if (personData.IsApproved)
                            SubmitBtn.Visible = false;
                    }
                    break;
            }
        }

        private void SubmitBtn_Click(object sender, EventArgs e)
        {
            switch (SubmitBtn.Text)
            {
                case "Cancel Edit":

                    var res = MessageBox.Show("Are you sure you want to Cancel?", "Cancel Update", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if(res == DialogResult.Yes)
                    {
                        ReturnSnapshot();
                        // Free the snapshot
                        snapshot = new();
                        DisableControls();
                        UpdateBtn.Text = "Update";
                        SubmitBtn.Visible = false;
                    }
                break;

                case "Submit Application":
                    snapshot = new();
                    DisableControls();
                    _personalRepository.SubmitApplication(new MembershipApplication() { FK_Personal = personData});
                    _personalRepository.Save();
                    MessageBox.Show("Thank you for submmiting an application, We will contact you after we confirmed your application", "Thank you");
                    SubmitBtn.Visible = false;
                break;
            }
        }

        public void AbleControls()
        {

            FirstNameText.ReadOnly = false;
            LastNameText.ReadOnly = false;
            MiddleNameText.ReadOnly = false;
            SuffixText.ReadOnly = false;
            GenderCB.Enabled = true;
            DateOfBirth.Enabled = true;
            AssociationText.ReadOnly = false;
            SpouseText.ReadOnly = false;
            RiceAreaText.ReadOnly = false;
            CornAreaText.ReadOnly = false;
            CommodityText.ReadOnly = false;
            HVCDPAreaText.ReadOnly = false;
            ContactNumberText.ReadOnly = false;
        }

        public void ReturnSnapshot()
        {
            FirstNameText.Text = snapshot.firstname;
            LastNameText.Text = snapshot.lastname;
            MiddleNameText.Text = snapshot.middlename;
            SuffixText.Text = snapshot.suffix;
            GenderCB.SelectedIndex = snapshot.gender;
            DateOfBirth.Value = snapshot.datetimepicker;
            AssociationText.Text = snapshot.association;
            SpouseText.Text = snapshot.spouse;
            RiceAreaText.Text = snapshot.ricearea;
            CornAreaText.Text = snapshot.corn;
            CommodityText.Text = snapshot.commodity;
            HVCDPAreaText.Text = snapshot.hvcdparea;
            ContactNumberText.Text = snapshot.ContactNumber;
        }

        public void DisableControls()
        {
            FirstNameText.ReadOnly = true;
            LastNameText.ReadOnly = true;
            MiddleNameText.ReadOnly = true;
            SuffixText.ReadOnly = true;
            GenderCB.Enabled = false;
            DateOfBirth.Enabled = false;
            AssociationText.ReadOnly = true;
            SpouseText.ReadOnly = true;
            RiceAreaText.ReadOnly = true;
            CornAreaText.ReadOnly = true;
            CommodityText.ReadOnly = true;
            HVCDPAreaText.ReadOnly = true;
            ContactNumberText.ReadOnly = true;

        }

        

        private record struct Snapshot(string firstname, string lastname, string middlename, string suffix,
            int gender, DateTime datetimepicker, string association, string spouse,
            string ricearea, string corn, string commodity, string hvcdparea, string ContactNumber);

    }
}
