using Agro.Data.Models;
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

namespace Agro.Features.Authentication;

using Agro.Features.Farms;
using BCrypt.Net;



public partial class RegisterUC : UserControl
{
    private readonly IServiceProvider _serviceProvider;
    private readonly IFarmRepository _farmRepository;
    private readonly IPersonalRepository _personalRepository;
    private readonly IAuthenticationRepository _authenticationRepository;


    public RegisterUC(
        IServiceProvider serviceProvider,
        IAuthenticationRepository authenticationRepository,
        IPersonalRepository personalRepository,
        IFarmRepository farmRepository)
    {
        InitializeComponent();
        _farmRepository = farmRepository;
        _serviceProvider = serviceProvider;
        _personalRepository = personalRepository;
        _authenticationRepository = authenticationRepository;
    }

    private void CancelLabel_Click(object sender, EventArgs e)
    {
        var ans = MessageBox.Show("Are you sure you want to exit?", "Close Agro Application", MessageBoxButtons.OKCancel);

        if (ans == DialogResult.OK)
            Parent.Controls["SelectRole"].BringToFront();

    }

    private void LoginLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
    {
        this.Parent.Controls["AuthUC"].BringToFront();
    }

    private void tocLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
    {
        var toc = new TermsAndConditions();
        toc.ShowDialog();
    }

    private void SignUpBtn_Click(object sender, EventArgs e)
    {
        if (_authenticationRepository.FindExistingUser(UsernameText.Text))
        {
            var res = MessageBox.Show("Username has already been taken", "Already Exist", MessageBoxButtons.RetryCancel);
            if (res == DialogResult.Retry)
                _ = UsernameText.Text.Remove(UsernameText.Text.Length - 1);
            else
                UsernameText.Text = string.Empty;
            
            return;
        }

        if (string.IsNullOrEmpty(PasswordText.Text))
        {
            MessageBox.Show("Add Password", "Invalid Submission", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        if (string.IsNullOrEmpty(FirstNameText.Text))
        {
            MessageBox.Show("Please Add First Name", "Invalid Submission", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        if (string.IsNullOrEmpty(LastNameText.Text))
        { 
            MessageBox.Show("Please Add Last Name", "Invalid Submission", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        if(string.IsNullOrEmpty(EmailText.Text))
        { 
            MessageBox.Show("Add Email Address", "No Email", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        if (!AgreeCB.Checked)
        {
            MessageBox.Show("Please Agree to Terms and Conditions");
            return;
        }

        string salt = BCrypt.GenerateSalt(10);
        string password = BCrypt.HashPassword(PasswordText.Text, salt);
                
        var result = _personalRepository.RegisterPerson(new Personal() { FirstName = FirstNameText.Text, LastName = LastNameText.Text, 
            FK_User = new User() { Email = EmailText.Text, Password = password, Salt = salt, Role = RoleLabel.Text, UserName = UsernameText.Text } });


        if (result != null)
        {

            _farmRepository.CreateInitialFarms(result);
           var dialogRes =  MessageBox.Show("Successfully Created a new User", "Successful", MessageBoxButtons.OK);
           if(dialogRes == DialogResult.OK)
               Parent.Controls["AuthUC"].BringToFront();
        }
    }
}
