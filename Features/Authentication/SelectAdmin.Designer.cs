namespace Agro.Features.Authentication
{
    partial class SelectAdmin
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
            BackLabel = new Label();
            AdminBtn = new Button();
            TechnicianBtn = new Button();
            groupBox1 = new GroupBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // BackLabel
            // 
            BackLabel.AutoSize = true;
            BackLabel.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BackLabel.ForeColor = Color.SaddleBrown;
            BackLabel.Location = new Point(239, 303);
            BackLabel.Name = "BackLabel";
            BackLabel.Size = new Size(51, 25);
            BackLabel.TabIndex = 16;
            BackLabel.Text = "Back";
            BackLabel.TextAlign = ContentAlignment.MiddleCenter;
            BackLabel.Click += BackLabel_Click;
            // 
            // AdminBtn
            // 
            AdminBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AdminBtn.Location = new Point(69, 50);
            AdminBtn.Name = "AdminBtn";
            AdminBtn.Size = new Size(150, 50);
            AdminBtn.TabIndex = 15;
            AdminBtn.Text = "ADMIN";
            AdminBtn.UseVisualStyleBackColor = true;
            AdminBtn.Click += AdminBtn_Click;
            // 
            // TechnicianBtn
            // 
            TechnicianBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TechnicianBtn.Location = new Point(69, 124);
            TechnicianBtn.Name = "TechnicianBtn";
            TechnicianBtn.Size = new Size(150, 50);
            TechnicianBtn.TabIndex = 14;
            TechnicianBtn.Text = "TECHNICIAN";
            TechnicianBtn.UseVisualStyleBackColor = true;
            TechnicianBtn.Click += TechnicianBtn_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(AdminBtn);
            groupBox1.Controls.Add(TechnicianBtn);
            groupBox1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(27, 64);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(263, 195);
            groupBox1.TabIndex = 17;
            groupBox1.TabStop = false;
            groupBox1.Text = "Welcome Back";
            // 
            // SelectAdmin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(groupBox1);
            Controls.Add(BackLabel);
            Name = "SelectAdmin";
            Size = new Size(320, 350);
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label BackLabel;
        private Button AdminBtn;
        private Button TechnicianBtn;
        private GroupBox groupBox1;
    }
}
