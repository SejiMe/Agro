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
        private readonly int _profileId;
        public ProfileController(IPersonalRepository personalRepository, int id)
        {
            _personalRepository = personalRepository;
            _profileId = id;
            InitializeComponent();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void CurrentAddressEditBtn_Click(object sender, EventArgs e)
        {

        }

        private void ProfileController_Load(object sender, EventArgs e)
        {
            var personData = _personalRepository.GetPerson(_profileId);

            FirstNameText.Text = personData.FirstName;
            LastNameText.Text = personData.LastName;
            if(personData.MiddleName is not null)
                MiddleNameText.Text = personData.MiddleName;
            SuffixText.Text = personData.Suffix;

            if (personData.Gender.HasValue)
                GenderCB.Text = personData.Gender.ToString();


            if (personData.SpouseName is not null)
                SpouseText.Text = personData.SpouseName;
          


        }

        private void MiddleNameText_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
