using Agro.Data.Models;
using Agro.Features.Farms;
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

namespace Agro.Features.Addresses
{
    public partial class AddressForm : Form
    {
        private readonly IPersonalRepository _personalRepository;
        private readonly IAddressRepository _addressRepository;
        private readonly IFarmRepository _farmRepository;


        Guid? PK_farm;
        int? PK_personal;
        string AddressTitle = string.Empty;
        Address address;
        MemberProfileController? _memberController;
        InsuranceProfileController? _insuranceProfileController;

        public AddressForm(IPersonalRepository personalRepository, IAddressRepository addressRepository, IFarmRepository farmRepository)
        {
            _personalRepository = personalRepository;
            _addressRepository = addressRepository;
            _farmRepository = farmRepository;


            InitializeComponent();
            // Who this is for




        }
        //MemberProfileController? controller, InsuranceProfileController? controllerInsurance
        public void SetArguments(string addressTitle, int? Personal_ID, Guid? pk_farm, InsuranceProfileController? insuranceController, MemberProfileController? memberController)
        {
            PK_farm = pk_farm ?? Guid.Empty;
            PK_personal = Personal_ID ?? 0;
            AddressTitle = addressTitle;
            _memberController = memberController;
            
            _insuranceProfileController = insuranceController ?? null;
            
        }
        private void AddressForm_Load(object sender, EventArgs e)
        {
            TitleLabel.Text = AddressTitle;

            address = AddressTitle switch
            {
                "Personal" => _personalRepository.GetPersonalAddress((int)PK_personal),
                "Farm" => _farmRepository.GetFarmAddress((Guid)PK_farm),
                _ => throw new ArgumentException("Invalid Title must be Personal or Farm")
            };

            LotNumberText.Text = address.LotNumber ?? null;
            HouseNumber.Text = address.HouseNumber ?? null;

            if (address.Barangay != null)
                BarangayCB.Text = address.Barangay;
            else
                BarangayCB.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            address.Barangay = BarangayCB.Text;

            if (LotNumberText.Text != string.Empty)
                address.LotNumber = LotNumberText.Text;
           

            if (HouseNumber.Text != string.Empty)
                address.HouseNumber = HouseNumber.Text;

            if(StreetText.Text != string.Empty)
                address.Street = StreetText.Text;

            _addressRepository.UpdateAddress(address);

            _memberController?.RefreshPage();
            
            if(_insuranceProfileController != null)
            {
                 //_insuranceProfileController.RefreshPage();
            }
               
        }
    }
}
