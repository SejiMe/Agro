using BCrypt.Net;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Agro.Features.Authentication
{
    using Agro.Features.Farms;
    using Agro.Features.Layout;
    using Agro.Features.Person;
    using BCrypt.Net;
    public partial class AuthUC : UserControl
    {
        private readonly IAuthenticationRepository _repository;
        private readonly IFarmRepository _farmRepository;
        private readonly IServiceProvider _serviceProvider;
        private readonly AuthForm _form;
        private readonly MainForm _mainForm;

        public AuthUC(IServiceProvider serviceProvider,IFarmRepository farm, IAuthenticationRepository repository, AuthForm LoginForm, MainForm MainForm)
        {
            _repository = repository;
            _farmRepository = farm;
            _serviceProvider = serviceProvider;
            _form = LoginForm;
            InitializeComponent();
            _mainForm = MainForm;

        }

        private void SignUpLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            this.Parent.Controls["RegisterUC"].BringToFront();


        }

        private void AuthUC_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void BackLabel_Click(object sender, EventArgs e)
        {
            Parent.Controls["SelectRole"].BringToFront();
        }

        private void ShowPasswordCB_CheckedChanged(object sender, EventArgs e)
        {
            if (ShowPasswordCB.Checked)
                PasswordText.UseSystemPasswordChar = false;
            else
                PasswordText.UseSystemPasswordChar = true;
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {

            if (UsernameText.Text == string.Empty)
            { 
                MessageBox.Show("Please enter username", "No username", MessageBoxButtons.OK);
                return;
            }
            
            if(PasswordText.Text == string.Empty)
            {
                MessageBox.Show("Please enter a password", "No password", MessageBoxButtons.OK);
                return;
            }

            var res = _repository.FindExistingUser(UsernameText.Text);
            
            if (!res)
            {
                MessageBox.Show("The username doesn't exist", "Invalid Username", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            var user = _repository.GetUser(UsernameText.Text);
            if (user == null)
                MessageBox.Show("No user");

            var isVerified = BCrypt.Verify(PasswordText.Text, user.Password);

            if (isVerified)
            {
              var isLoggedIn =  _repository.Login(user);
              
                if(isLoggedIn)
                {
                    MessageBox.Show("Have a great day! We look forward to serving you :).");
                    _mainForm.RefreshPage();
                    _mainForm.Show();
                    ParentForm.Hide();
                }
            }
            else
            {
                MessageBox.Show("Wrong password", "Invalid Password", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

       
            
        }
    }
}
