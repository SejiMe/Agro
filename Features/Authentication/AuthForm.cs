using Microsoft.Extensions.DependencyInjection;
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
    public partial class AuthForm : Form
    {
        private readonly IServiceProvider _serviceProvider;
        
        public AuthForm(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
         
            
            InitializeComponent();
            
        }
       
        private void AuthForm_Load(object sender, EventArgs e)
        {

            var controller1 = _serviceProvider.GetRequiredService<AuthUC>();
            var controller2 = _serviceProvider.GetRequiredService<RegisterUC>();
            
            ControllerPanel.Controls.Add(new SelectRole());
            ControllerPanel.Controls.Add(new SelectAdmin());
            ControllerPanel.Controls.Add(controller1);
            ControllerPanel.Controls.Add(controller2);
        }
    }
}
