using Agro.Data.Models;
using Agro.Features.Farms;
using Agro.Features.Insurances;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Agro.Features.Person
{
    public partial class InsuranceProfileController : UserControl
    {
        private readonly IPersonalRepository _personalRepository;
        private readonly IFarmRepository _farmRepository;
        private readonly IInsuranceRepository _insuranceRepository;
        private readonly IServiceProvider _serviceProvider;

        private Personal personData;
        private Farm farm;
        Address address;
        private readonly int _profileId;
        Snapshot snapshot = new();

        Regex ValidInputNumber = new Regex(@"^[0-9]+$");
        

        Dictionary<string, int> addresses = new();

        public InsuranceProfileController(IPersonalRepository personalRepository, IFarmRepository farmRepository, IInsuranceRepository insuranceRepository, IServiceProvider serviceProvider, int PK_Personal)
        {

            InitializeComponent();


            _personalRepository = personalRepository;
            _farmRepository = farmRepository;
            _insuranceRepository = insuranceRepository;
            _serviceProvider = serviceProvider;
            _profileId = PK_Personal;
        }


        private void InsuranceProfileController_Load(object sender, EventArgs e)
        {



            FarmSelectCB.Items.Clear();


            var hasFarm = _farmRepository.HasFarm(_profileId);
            Task<IEnumerable<Farm>> farms = null;


            if (hasFarm.Result)
            {
                farms = _farmRepository.GetAllFarm(_profileId);
            }


            if (farms.Result != null)
            {
                foreach (Farm farm in farms.Result)
                {
                    if ((farm.CommodityName == null || farm.CommodityName == string.Empty) && farm.isHVCDP == true)
                    {
                        Console.WriteLine(farm.PK_Farm.Value);
                        MessageBox.Show(farm.PK_Farm.Value.ToString());
                        addresses.Add("HVCDP", farm.FK_Personal.PK_Personal);
                        FarmSelectCB.Items.Add("HVCDP");
                        continue;
                    }
                    else
                    {
                        addresses.Add(farm.CommodityName, farm.FK_Personal.PK_Personal);
                        FarmSelectCB.Items.Add(farm.CommodityName);
                    }
                }
            }



            personData = _personalRepository.GetPerson(_profileId);
            FirstNameText.Text = personData.FirstName;
            LastNameText.Text = personData.LastName;
            if (personData.MiddleName is not null)
                MiddleNameText.Text = personData.MiddleName;
            SuffixText.Text = personData.Suffix;

            if (personData.ContactNumber is not null)
                ContactNumberText.Text = personData.ContactNumber.Substring(3);

            var personalAddress = _personalRepository.GetPersonalAddress(_profileId);
            #region set address
            if (personalAddress.HouseNumber != null)
                CurrentAddressText.Text += personalAddress.HouseNumber + ", ";

            if (personalAddress.Street != null)
                CurrentAddressText.Text += personalAddress.Street + ", ";

            if (personalAddress.Barangay != null)
                CurrentAddressText.Text += personalAddress.Barangay + ", ";

            CurrentAddressText.Text += personalAddress.Municipality + ", ";
            CurrentAddressText.Text += personalAddress.Province;

            #endregion
            #region rice logic
            //if (rice.FK_Address.LotNumber != null && rice.FK_Address.LotNumber != "")
            //    RiceAddressText.Text = rice.FK_Address.LotNumber + ", ";

            //if (rice.FK_Address.Street != null)
            //    RiceAddressText.Text += rice.FK_Address.Street + ", ";

            //if (rice.FK_Address.Barangay != null)
            //    RiceAddressText.Text += rice.FK_Address.Barangay + ", ";

            //RiceAddressText.Text += rice.FK_Address.Municipality + ", ";
            //RiceAddressText.Text += rice.FK_Address.Province;

            //if (rice.AreaSQM > 0)
            //    RiceAreaText.Text = rice.AreaSQM.ToString();
            #endregion

        }


        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void FarmSelectCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            FarmAddressText.Text = string.Empty;
            if (addresses.TryGetValue(FarmSelectCB.SelectedText, out var SelectedAddress))
            {
                farm = _farmRepository.GetFarm(SelectedAddress, FarmSelectCB.Text);
                TenurialStatusText.Text = farm.TenurialStatus;
                LandSoilText.Text = farm.LandCategorySoilType;
                AreaSqmText.Text = farm.AreaSQM.ToString();
                NorthAdjacentText.Text = farm.NorthAdjacentOwner;
                SouthAdjacentText.Text = farm.SouthAdjacentOwner;
                EastAdjacentText.Text = farm.EastAdjacentOwner;
                WestAdjacentText.Text = farm.WastAdjacentOwner;

                if (farm.FK_Address.LotNumber != null && farm.FK_Address.LotNumber != "")
                    FarmAddressText.Text = farm.FK_Address.LotNumber + ", ";

                if (farm.FK_Address.Street != null)
                    FarmAddressText.Text += farm.FK_Address.Street + ", ";

                if (farm.FK_Address.Barangay != null)
                    FarmAddressText.Text += farm.FK_Address.Barangay + ", ";

                FarmAddressText.Text += farm.FK_Address.Municipality + ", ";
                FarmAddressText.Text += farm.FK_Address.Province;

            }

        }

        public void RefreshPage()
        {
            this.OnLoad(EventArgs.Empty);
        }

        private void InsuranceProfileController_Enter(object sender, EventArgs e)
        {   

        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            switch (UpdateBtn.Text)
            {
                case "Update":
                    SwitchReadOnlyControls(false);
                    // Create a snapshot
                    snapshot = new(AreaSqmText.Text, TenurialStatusText.Text, LandSoilText.Text, NorthAdjacentText.Text, SouthAdjacentText.Text, WestAdjacentText.Text, EastAdjacentText.Text);

                    // Update the butons names 
                    SubmitBtn.Enabled = true;
                    SubmitBtn.Text = "Cancel Edit";
                    UpdateBtn.Text = "Save";

                    break;

                case "Save":
                    SwitchReadOnlyControls(true);
                    // TODO if has active Insurance Application
                    
                    if(AreaSqmText.Text.Length > 0)
                    {
                        if (ValidInputNumber.IsMatch(AreaSqmText.Text))
                        {
                            farm.AreaSQM = int.Parse(AreaSqmText.Text);
                        }
                        else
                        {
                            MessageBox.Show("Invalid input in Area SQM please type the area of land in Square Meters", "Invalid Number Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }

                    farm.TenurialStatus = TenurialStatusText.Text;
                    farm.NorthAdjacentOwner = NorthAdjacentText.Text;
                    farm.SouthAdjacentOwner = SouthAdjacentText.Text;
                    farm.EastAdjacentOwner = EastAdjacentText.Text;
                    farm.WastAdjacentOwner = WestAdjacentText.Text;

                    

                    break;
            }
        }

        private void SubmitBtn_Click(object sender, EventArgs e)
        {
            switch (SubmitBtn.Text)
            {
                case "Cancel Edit":
                    SwitchReadOnlyControls(false);
                    AreaSqmText.Text = snapshot.AreaSqm;
                    TenurialStatusText.Text = snapshot.TenurialStatus;
                    LandSoilText.Text = snapshot.TenurialStatus;
                    NorthAdjacentText.Text = snapshot.NorthAdjacent;
                    SouthAdjacentText.Text = snapshot.SouthAdjacent;
                    EastAdjacentText.Text = snapshot.EastAdjacent;
                    WestAdjacentText.Text = snapshot.WestAdjacent;
                    break;

                case "Submit Application":
                    SwitchReadOnlyControls(true);
                    _insuranceRepository.AddInsurance(new Insurance() 
                    { 
                        FK_Farm = farm
                    });
                    _personalRepository.Save();
                    MessageBox.Show("Thank you for Applying an Insurance", "Insurance Application submitted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
            }
        }

        private void SwitchReadOnlyControls(bool isEnable)
        {
            switch (isEnable)
            {
                case false:
                    AreaSqmText.ReadOnly = false;
                    TenurialStatusText.ReadOnly = false;
                    LandSoilText.ReadOnly = false;
                    NorthAdjacentText.ReadOnly = false;
                    SouthAdjacentText.ReadOnly = false;
                    EastAdjacentText.ReadOnly = false;
                    WestAdjacentText.ReadOnly = false;
                    break;

                case true:
                    AreaSqmText.ReadOnly = true;
                    TenurialStatusText.ReadOnly = true;
                    LandSoilText.ReadOnly = true;
                    NorthAdjacentText.ReadOnly = true;
                    SouthAdjacentText.ReadOnly = true;
                    EastAdjacentText.ReadOnly = true;
                    WestAdjacentText.ReadOnly = true;
                    break;
            }
        }

        private record struct Snapshot(string AreaSqm, string TenurialStatus, string LandSoilType, string NorthAdjacent, string SouthAdjacent, string WestAdjacent, string EastAdjacent);
    }
}
