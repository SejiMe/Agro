namespace Agro.Features.Authentication
{
    partial class RegisterUC
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            FirstNameText = new TextBox();
            LastNameText = new TextBox();
            EmailText = new TextBox();
            label1 = new Label();
            UsernameText = new TextBox();
            PasswordText = new TextBox();
            AgreeCB = new CheckBox();
            tocLink = new LinkLabel();
            SignUpBtn = new Button();
            label2 = new Label();
            LoginLink = new LinkLabel();
            RoleLabel = new Label();
            CancelLabel = new Label();
            ShowCB = new CheckBox();
            SuspendLayout();
            // 
            // FirstNameText
            // 
            FirstNameText.Location = new Point(25, 77);
            FirstNameText.Name = "FirstNameText";
            FirstNameText.PlaceholderText = "First Name";
            FirstNameText.Size = new Size(125, 23);
            FirstNameText.TabIndex = 0;
            // 
            // LastNameText
            // 
            LastNameText.Location = new Point(168, 77);
            LastNameText.Name = "LastNameText";
            LastNameText.PlaceholderText = "Last Name";
            LastNameText.Size = new Size(130, 23);
            LastNameText.TabIndex = 1;
            // 
            // EmailText
            // 
            EmailText.Location = new Point(25, 108);
            EmailText.Name = "EmailText";
            EmailText.PlaceholderText = "Email";
            EmailText.Size = new Size(273, 23);
            EmailText.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(123, 42);
            label1.Name = "label1";
            label1.Size = new Size(48, 15);
            label1.TabIndex = 3;
            label1.Text = "Sign Up";
            // 
            // UsernameText
            // 
            UsernameText.Location = new Point(25, 136);
            UsernameText.Name = "UsernameText";
            UsernameText.PlaceholderText = "Username";
            UsernameText.Size = new Size(273, 23);
            UsernameText.TabIndex = 4;
            // 
            // PasswordText
            // 
            PasswordText.Location = new Point(25, 165);
            PasswordText.Name = "PasswordText";
            PasswordText.PlaceholderText = "Password";
            PasswordText.Size = new Size(273, 23);
            PasswordText.TabIndex = 5;
            PasswordText.UseSystemPasswordChar = true;
            // 
            // AgreeCB
            // 
            AgreeCB.AutoSize = true;
            AgreeCB.Location = new Point(30, 219);
            AgreeCB.Name = "AgreeCB";
            AgreeCB.Size = new Size(87, 19);
            AgreeCB.TabIndex = 6;
            AgreeCB.Text = "I accept the";
            AgreeCB.UseVisualStyleBackColor = true;
            // 
            // tocLink
            // 
            tocLink.AutoSize = true;
            tocLink.Location = new Point(114, 219);
            tocLink.Name = "tocLink";
            tocLink.Size = new Size(122, 15);
            tocLink.TabIndex = 7;
            tocLink.TabStop = true;
            tocLink.Text = "terms and conditions.";
            tocLink.LinkClicked += tocLink_LinkClicked;
            // 
            // SignUpBtn
            // 
            SignUpBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SignUpBtn.Location = new Point(87, 250);
            SignUpBtn.Name = "SignUpBtn";
            SignUpBtn.Size = new Size(117, 38);
            SignUpBtn.TabIndex = 8;
            SignUpBtn.Text = "SIGN UP";
            SignUpBtn.UseVisualStyleBackColor = true;
            SignUpBtn.Click += SignUpBtn_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(29, 312);
            label2.Name = "label2";
            label2.Size = new Size(142, 15);
            label2.TabIndex = 9;
            label2.Text = "Already have an account?";
            // 
            // LoginLink
            // 
            LoginLink.AutoSize = true;
            LoginLink.Location = new Point(168, 312);
            LoginLink.Name = "LoginLink";
            LoginLink.Size = new Size(66, 15);
            LoginLink.TabIndex = 10;
            LoginLink.TabStop = true;
            LoginLink.Text = "Login here.";
            LoginLink.LinkClicked += LoginLink_LinkClicked;
            // 
            // RoleLabel
            // 
            RoleLabel.AutoSize = true;
            RoleLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            RoleLabel.Location = new Point(117, 8);
            RoleLabel.Name = "RoleLabel";
            RoleLabel.Size = new Size(57, 21);
            RoleLabel.TabIndex = 11;
            RoleLabel.Text = "label3";
            RoleLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // CancelLabel
            // 
            CancelLabel.AutoSize = true;
            CancelLabel.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            CancelLabel.ForeColor = Color.SaddleBrown;
            CancelLabel.Location = new Point(248, 302);
            CancelLabel.Name = "CancelLabel";
            CancelLabel.Size = new Size(69, 25);
            CancelLabel.TabIndex = 12;
            CancelLabel.Text = "Cancel";
            CancelLabel.TextAlign = ContentAlignment.MiddleCenter;
            CancelLabel.Click += CancelLabel_Click;
            // 
            // ShowCB
            // 
            ShowCB.AutoSize = true;
            ShowCB.Location = new Point(30, 194);
            ShowCB.Name = "ShowCB";
            ShowCB.Size = new Size(108, 19);
            ShowCB.TabIndex = 13;
            ShowCB.Text = "Show Password";
            ShowCB.UseVisualStyleBackColor = true;
            ShowCB.CheckedChanged += ShowCB_CheckedChanged;
            // 
            // RegisterUC
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(ShowCB);
            Controls.Add(CancelLabel);
            Controls.Add(RoleLabel);
            Controls.Add(LoginLink);
            Controls.Add(label2);
            Controls.Add(SignUpBtn);
            Controls.Add(tocLink);
            Controls.Add(AgreeCB);
            Controls.Add(PasswordText);
            Controls.Add(UsernameText);
            Controls.Add(label1);
            Controls.Add(EmailText);
            Controls.Add(LastNameText);
            Controls.Add(FirstNameText);
            Name = "RegisterUC";
            Size = new Size(320, 350);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox FirstNameText;
        private TextBox LastNameText;
        private TextBox EmailText;
        private Label label1;
        private TextBox UsernameText;
        private TextBox PasswordText;
        private CheckBox AgreeCB;
        private LinkLabel tocLink;
        private Button SignUpBtn;
        private Label label2;
        private LinkLabel LoginLink;
        private Label RoleLabel;
        private Label CancelLabel;
        private CheckBox ShowCB;
    }
}
