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
    }
}
