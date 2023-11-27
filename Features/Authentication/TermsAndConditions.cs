using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Agro.Features.Authentication
{
    public partial class TermsAndConditions : Form
    {
        public TermsAndConditions()
        {
            InitializeComponent();
        }

        private void TermsAndConditions_Load(object sender, EventArgs e)
        {
            richTextBox1.Text = $"Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed euismod, diam vel tincidunt bibendum, enim velit bibendum ex, vel aliquam sapien urna vel nunc. Donec euismod, quam vel lacinia lacinia, sapien nisl bibendum sapien, vel bibendum sapien sapien vel sapien. Nulla facilisi. Donec euismod, quam vel lacinia lacinia, sapien nisl bibendum sapien, vel bibendum sapien sapien vel sapien. Nulla facilisi.\r\n\r\n- Lorem ipsum dolor sit amet, consectetur adipiscing elit.\r\n- Sed euismod, diam vel tincidunt bibendum, enim velit bibendum ex, vel aliquam sapien urna vel nunc.\r\n- Donec euismod, quam vel lacinia lacinia, sapien nisl bibendum sapien, vel bibendum sapien sapien vel sapien.\r\n    1. Nulla facilisi.\r\n    2. Donec euismod, quam vel lacinia lacinia, sapien nisl bibendum sapien, vel bibendum sapien sapien vel sapien.";
        }
    }
}
