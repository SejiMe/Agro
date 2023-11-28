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
        private readonly Guid? PK_farm;
        private readonly int? PK_personal;

        public AddressForm(IPersonalRepository personalRepository, IAddressRepository addressRepository, IFarmRepository farmRepository, string AddressTitle, int? Personal_ID, Guid? pk_farm)
        {
            _personalRepository = personalRepository;
            _addressRepository = addressRepository;
            _farmRepository = farmRepository;
            PK_farm  = pk_farm ?? Guid.Empty;
            
            InitializeComponent();
            TitleLabel.Text = AddressTitle;
        }

        private void AddressForm_Load(object sender, EventArgs e)
        {
            
        }
    }
}
