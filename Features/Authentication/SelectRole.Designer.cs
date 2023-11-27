namespace Agro.Features.Authentication
{
    partial class SelectRole
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
            QuitLabel = new Label();
            groupBox1 = new GroupBox();
            UserBtn = new Button();
            AdminBtn = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // QuitLabel
            // 
            QuitLabel.AutoSize = true;
            QuitLabel.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            QuitLabel.ForeColor = Color.SaddleBrown;
            QuitLabel.Location = new Point(242, 307);
            QuitLabel.Name = "QuitLabel";
            QuitLabel.Size = new Size(48, 25);
            QuitLabel.TabIndex = 13;
            QuitLabel.Text = "Quit";
            QuitLabel.TextAlign = ContentAlignment.MiddleCenter;
            QuitLabel.Click += QuitLabel_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(AdminBtn);
            groupBox1.Controls.Add(UserBtn);
            groupBox1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(27, 64);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(263, 195);
            groupBox1.TabIndex = 14;
            groupBox1.TabStop = false;
            groupBox1.Text = "Welcome Back";
            // 
            // UserBtn
            // 
            UserBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            UserBtn.Location = new Point(69, 124);
            UserBtn.Name = "UserBtn";
            UserBtn.Size = new Size(150, 50);
            UserBtn.TabIndex = 0;
            UserBtn.Text = "USER";
            UserBtn.UseVisualStyleBackColor = true;
            UserBtn.Click += UserBtn_Click;
            // 
            // AdminBtn
            // 
            AdminBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AdminBtn.Location = new Point(69, 50);
            AdminBtn.Name = "AdminBtn";
            AdminBtn.Size = new Size(150, 50);
            AdminBtn.TabIndex = 2;
            AdminBtn.Text = "ADMIN";
            AdminBtn.UseVisualStyleBackColor = true;
            AdminBtn.Click += AdminBtn_Click;
            // 
            // SelectRole
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(groupBox1);
            Controls.Add(QuitLabel);
            Name = "SelectRole";
            Size = new Size(320, 350);
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label QuitLabel;
        private GroupBox groupBox1;
        private Button AdminBtn;
        private Button UserBtn;
    }
}
