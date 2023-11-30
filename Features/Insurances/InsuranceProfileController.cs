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
        private readonly int _profileId;
   
       
        Dictionary<string, Guid> addresses;
        
        public InsuranceProfileController(IPersonalRepository personalRepository, IFarmRepository farmRepository, IInsuranceRepository insuranceRepository, IServiceProvider serviceProvider, int PK_Personal)
        {
            _personalRepository = personalRepository;
            _farmRepository = farmRepository;
            _insuranceRepository = insuranceRepository;
            _serviceProvider = serviceProvider;
            _profileId = PK_Personal;
            InitializeComponent();



        }


        private async void InsuranceProfileController_Load(object sender, EventArgs e)
        {
            FarmSelectCB.Items.Clear();
            var farms = _farmRepository.GetAllFarm(_profileId);

            foreach (Farm farm in farms.Result)
            {
                if ((farm.CommodityName == null || farm.CommodityName == string.Empty) && farm.isHVCDP)
                {
                    addresses.Add("HVCDP", farm.PK_Farm.Value);
                    FarmSelectCB.Items.Add("HVCDP");
                    return;
                }
                else
                {
                    addresses.Add(farm.CommodityName, farm.PK_Farm.Value);
                    FarmSelectCB.Items.Add(farm.CommodityName);
                }
            }


            personData = _personalRepository.GetPerson(_profileId);
            FirstNameText.Text = personData.FirstName;
            LastNameText.Text = personData.LastName;
            if (personData.MiddleName is not null)
                MiddleNameText.Text = personData.MiddleName;
            SuffixText.Text = personData.Suffix;

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
            if(addresses.TryGetValue(FarmSelectCB.SelectedText, out var SelectedAddress))
            {
                var results = _farmRepository.GetFarm(_profileId, FarmSelectCB.SelectedText);
            }
            
        }
    }
}
