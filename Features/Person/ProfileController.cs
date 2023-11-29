using Agro.Data.Models;
using Agro.Features.Farms;
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
    public partial class ProfileController : UserControl
    {
        private readonly IPersonalRepository _personalRepository;
        private readonly IFarmRepository _farmRepository;
        private readonly int _profileId;
        private Personal personData;
        Farm rice = new();
        Farm corn = new();
        Farm hvcdp = new();

        public ProfileController(IPersonalRepository personalRepository, IFarmRepository farmRepository, int id)
        {
            _personalRepository = personalRepository;
            _farmRepository = farmRepository;
            _profileId = id;
            InitializeComponent();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void CurrentAddressEditBtn_Click(object sender, EventArgs e)
        {

        }

        private async void ProfileController_Load(object sender, EventArgs e)
        {
            personData = _personalRepository.GetPerson(_profileId);

            FirstNameText.Text = personData.FirstName;
            LastNameText.Text = personData.LastName;
            if(personData.MiddleName is not null)
                MiddleNameText.Text = personData.MiddleName;
            SuffixText.Text = personData.Suffix;

            if (personData.Gender.HasValue)
                GenderCB.Text = personData.Gender.ToString();


            if (personData.SpouseName is not null)
                SpouseText.Text = personData.SpouseName;

            var hasFarm = await _farmRepository.HasFarm(_profileId);
            Task<IEnumerable<Farm>> farms;

            if (hasFarm)
            {
                farms = _farmRepository.GetAllFarm(_profileId);
                rice = farms.Result
                    .Where(farm => farm.CommodityName == "Rice")
                    .First();

                corn = farms.Result
                   .Where(farm => farm.CommodityName == "Corn")
                   .First();
                hvcdp = farms.Result.Where(farm => farm.isHVCDP == true)
                    .First();

            }else
            {
                await _farmRepository.CreateInitialFarms(personData);
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

            #region rice initial data
            if (rice.FK_Address.LotNumber != null)
                RiceAddressText.Text = rice.FK_Address.LotNumber.ToString() + ", ";

            if(rice.FK_Address.Street != null)
                RiceAddressText.Text += rice.FK_Address.Street.ToString() + ", ";

            if (rice.FK_Address.Barangay != null)
                RiceAddressText.Text += rice.FK_Address.Barangay.ToString() + ", ";

            RiceAddressText.Text += rice.FK_Address.Municipality + ", ";
            RiceAddressText.Text += rice.FK_Address.Province;
            
            if(rice.AreaSQM > 0)
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

            if(hvcdp.AreaSQM > 0)
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

        }

        private void MiddleNameText_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
