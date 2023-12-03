namespace Agro.Features.Authentication
{
    partial class AuthUC
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
            label5 = new Label();
            SignUpLink = new LinkLabel();
            BackLabel = new Label();
            groupBox1 = new GroupBox();
            ShowPasswordCB = new CheckBox();
            PasswordText = new TextBox();
            label4 = new Label();
            UsernameText = new TextBox();
            label3 = new Label();
            LoginBtn = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Location = new Point(81, 264);
            label5.Name = "label5";
            label5.Size = new Size(89, 15);
            label5.TabIndex = 15;
            label5.Text = "Not a member?";
            // 
            // SignUpLink
            // 
            SignUpLink.AutoSize = true;
            SignUpLink.BackColor = Color.Transparent;
            SignUpLink.Location = new Point(169, 264);
            SignUpLink.Name = "SignUpLink";
            SignUpLink.Size = new Size(75, 15);
            SignUpLink.TabIndex = 10;
            SignUpLink.TabStop = true;
            SignUpLink.Text = "sign up here.";
            SignUpLink.LinkClicked += SignUpLink_LinkClicked;
            // 
            // BackLabel
            // 
            BackLabel.AutoSize = true;
            BackLabel.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BackLabel.ForeColor = Color.SaddleBrown;
            BackLabel.Location = new Point(243, 318);
            BackLabel.Name = "BackLabel";
            BackLabel.Size = new Size(51, 25);
            BackLabel.TabIndex = 16;
            BackLabel.Text = "Back";
            BackLabel.TextAlign = ContentAlignment.MiddleCenter;
            BackLabel.Click += BackLabel_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(ShowPasswordCB);
            groupBox1.Controls.Add(PasswordText);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(UsernameText);
            groupBox1.Controls.Add(label3);
            groupBox1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(11, 28);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(292, 190);
            groupBox1.TabIndex = 17;
            groupBox1.TabStop = false;
            groupBox1.Text = "Welcome Back";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // ShowPasswordCB
            // 
            ShowPasswordCB.AutoSize = true;
            ShowPasswordCB.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ShowPasswordCB.Location = new Point(38, 160);
            ShowPasswordCB.Name = "ShowPasswordCB";
            ShowPasswordCB.Size = new Size(108, 19);
            ShowPasswordCB.TabIndex = 19;
            ShowPasswordCB.Text = "Show Password";
            ShowPasswordCB.UseVisualStyleBackColor = true;
            ShowPasswordCB.CheckedChanged += ShowPasswordCB_CheckedChanged;
            // 
            // PasswordText
            // 
            PasswordText.Font = new Font("Segoe UI", 12F);
            PasswordText.Location = new Point(36, 120);
            PasswordText.Name = "PasswordText";
            PasswordText.PlaceholderText = "Tamad";
            PasswordText.Size = new Size(221, 29);
            PasswordText.TabIndex = 18;
            PasswordText.UseSystemPasswordChar = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label4.Location = new Point(36, 102);
            label4.Name = "label4";
            label4.Size = new Size(57, 15);
            label4.TabIndex = 17;
            label4.Text = "Password";
            // 
            // UsernameText
            // 
            UsernameText.Font = new Font("Segoe UI", 12F);
            UsernameText.Location = new Point(36, 62);
            UsernameText.Multiline = true;
            UsernameText.Name = "UsernameText";
            UsernameText.PlaceholderText = "Juan";
            UsernameText.Size = new Size(221, 32);
            UsernameText.TabIndex = 16;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label3.Location = new Point(36, 44);
            label3.Name = "label3";
            label3.Size = new Size(60, 15);
            label3.TabIndex = 15;
            label3.Text = "Username";
            // 
            // LoginBtn
            // 
            LoginBtn.Location = new Point(95, 224);
            LoginBtn.Name = "LoginBtn";
            LoginBtn.Size = new Size(149, 37);
            LoginBtn.TabIndex = 9;
            LoginBtn.Text = "LOGIN";
            LoginBtn.UseVisualStyleBackColor = true;
            LoginBtn.Click += LoginBtn_Click;
            // 
            // AuthUC
            // 
            AccessibleRole = AccessibleRole.None;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            Controls.Add(groupBox1);
            Controls.Add(BackLabel);
            Controls.Add(SignUpLink);
            Controls.Add(label5);
            Controls.Add(LoginBtn);
            Name = "AuthUC";
            Size = new Size(320, 350);
            Load += AuthUC_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label5;
        private LinkLabel SignUpLink;
        
        private Label BackLabel;
        private GroupBox groupBox1;
        private TextBox PasswordText;
        private Label label4;
        private TextBox UsernameText;
        private Label label3;
        private Button LoginBtn;
        private CheckBox ShowPasswordCB;
    }
}
