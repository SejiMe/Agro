﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Agro.Features.Layout
{
    public partial class GeneralNavigation : UserControl
    {
        public GeneralNavigation()
        {
            InitializeComponent();
        }

        private void ProfileBtn_Click(object sender, EventArgs e)
        {
            ParentForm.Controls["HeaderPanel"].Controls["TitleLabel"].Text = "My Profile";
        }
    }
}