using Agro.Data.Models;
using Agro.Features.Farms;
using Agro.Features.Insurances;
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
    public partial class InsuranceProfileController : UserControl
    {
        private readonly IPersonalRepository _personalRepository;
        private readonly IFarmRepository _farmRepository;
        private readonly IInsuranceRepository _insuranceRepository;
        private readonly IServiceProvider _serviceProvider;
        
        private Personal personData;
        public InsuranceProfileController(IPersonalRepository personalRepository, IFarmRepository farmRepository, IInsuranceRepository insuranceRepository ,IServiceProvider serviceProvider)
        {
            _personalRepository = personalRepository;
            _farmRepository = farmRepository;
            _insuranceRepository = insuranceRepository;
            _serviceProvider = serviceProvider;
            InitializeComponent();
            
        }

        public void SetArgs()
        {

        }




        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }
    }
}
