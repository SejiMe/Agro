namespace Agro.Features.Person
{
    partial class MemberProfileController
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
            CurrentAddressEditBtn = new Button();
            label8 = new Label();
            CurrentAddressText = new TextBox();
            groupBox2 = new GroupBox();
            RiceAreaText = new TextBox();
            RiceFarmAddressBtn = new Button();
            RiceAddressText = new TextBox();
            label7 = new Label();
            GenderCB = new ComboBox();
            DateTimePicker = new DateTimePicker();
            label6 = new Label();
            textBox6 = new TextBox();
            ContactNumberText = new TextBox();
            label5 = new Label();
            groupBox1 = new GroupBox();
            label4 = new Label();
            SuffixText = new TextBox();
            label3 = new Label();
            LastNameText = new TextBox();
            label2 = new Label();
            MiddleNameText = new TextBox();
            label1 = new Label();
            FirstNameText = new TextBox();
            groupBox3 = new GroupBox();
            HVCDPAddressBtn = new Button();
            HVCDPAddressText = new TextBox();
            HVCDPAreaText = new TextBox();
            CommodityText = new TextBox();
            groupBox4 = new GroupBox();
            CornAreaText = new TextBox();
            CornFarmAddressBtn = new Button();
            CornAddressText = new TextBox();
            SpouseText = new TextBox();
            label9 = new Label();
            label10 = new Label();
            AssociationText = new TextBox();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            SuspendLayout();
            // 
            // CurrentAddressEditBtn
            // 
            CurrentAddressEditBtn.Anchor = AnchorStyles.Top;
            CurrentAddressEditBtn.BackgroundImage = Properties.Resources.icons8_edit_32;
            CurrentAddressEditBtn.BackgroundImageLayout = ImageLayout.Zoom;
            CurrentAddressEditBtn.Location = new Point(72, 250);
            CurrentAddressEditBtn.Name = "CurrentAddressEditBtn";
            CurrentAddressEditBtn.Size = new Size(30, 23);
            CurrentAddressEditBtn.TabIndex = 24;
            CurrentAddressEditBtn.UseVisualStyleBackColor = true;
            CurrentAddressEditBtn.Click += CurrentAddressEditBtn_Click;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Top;
            label8.AutoSize = true;
            label8.Location = new Point(72, 231);
            label8.Name = "label8";
            label8.Size = new Size(49, 15);
            label8.TabIndex = 23;
            label8.Text = "Address";
            // 
            // CurrentAddressText
            // 
            CurrentAddressText.Anchor = AnchorStyles.Top;
            CurrentAddressText.Location = new Point(105, 250);
            CurrentAddressText.Name = "CurrentAddressText";
            CurrentAddressText.PlaceholderText = "Current Address";
            CurrentAddressText.ReadOnly = true;
            CurrentAddressText.Size = new Size(810, 23);
            CurrentAddressText.TabIndex = 13;
            // 
            // groupBox2
            // 
            groupBox2.Anchor = AnchorStyles.Top;
            groupBox2.Controls.Add(RiceAreaText);
            groupBox2.Controls.Add(RiceFarmAddressBtn);
            groupBox2.Controls.Add(RiceAddressText);
            groupBox2.Location = new Point(66, 397);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(849, 60);
            groupBox2.TabIndex = 22;
            groupBox2.TabStop = false;
            groupBox2.Text = "RICE";
            groupBox2.Enter += groupBox2_Enter;
            // 
            // RiceAreaText
            // 
            RiceAreaText.Location = new Point(51, 22);
            RiceAreaText.Name = "RiceAreaText";
            RiceAreaText.PlaceholderText = "Area in sqm";
            RiceAreaText.Size = new Size(361, 23);
            RiceAreaText.TabIndex = 13;
            // 
            // RiceFarmAddressBtn
            // 
            RiceFarmAddressBtn.BackgroundImage = Properties.Resources.icons8_edit_32;
            RiceFarmAddressBtn.BackgroundImageLayout = ImageLayout.Zoom;
            RiceFarmAddressBtn.Location = new Point(432, 22);
            RiceFarmAddressBtn.Name = "RiceFarmAddressBtn";
            RiceFarmAddressBtn.Size = new Size(30, 23);
            RiceFarmAddressBtn.TabIndex = 12;
            RiceFarmAddressBtn.UseVisualStyleBackColor = true;
            RiceFarmAddressBtn.Click += RiceFarmAddressBtn_Click;
            // 
            // RiceAddressText
            // 
            RiceAddressText.Location = new Point(466, 22);
            RiceAddressText.Name = "RiceAddressText";
            RiceAddressText.PlaceholderText = "Farm Location";
            RiceAddressText.Size = new Size(324, 23);
            RiceAddressText.TabIndex = 0;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top;
            label7.AutoSize = true;
            label7.Location = new Point(689, 180);
            label7.Name = "label7";
            label7.Size = new Size(45, 15);
            label7.TabIndex = 21;
            label7.Text = "Gender";
            // 
            // GenderCB
            // 
            GenderCB.Anchor = AnchorStyles.Top;
            GenderCB.DropDownWidth = 120;
            GenderCB.FormattingEnabled = true;
            GenderCB.Items.AddRange(new object[] { "Male", "Female" });
            GenderCB.Location = new Point(689, 198);
            GenderCB.Name = "GenderCB";
            GenderCB.Size = new Size(226, 23);
            GenderCB.TabIndex = 20;
            // 
            // DateTimePicker
            // 
            DateTimePicker.Anchor = AnchorStyles.Top;
            DateTimePicker.Format = DateTimePickerFormat.Short;
            DateTimePicker.Location = new Point(373, 198);
            DateTimePicker.Name = "DateTimePicker";
            DateTimePicker.Size = new Size(310, 23);
            DateTimePicker.TabIndex = 19;
            DateTimePicker.Value = new DateTime(2023, 11, 27, 0, 0, 0, 0);
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top;
            label6.AutoSize = true;
            label6.Location = new Point(420, 180);
            label6.Name = "label6";
            label6.Size = new Size(73, 15);
            label6.TabIndex = 18;
            label6.Text = "Date of Birth";
            // 
            // textBox6
            // 
            textBox6.Anchor = AnchorStyles.Top;
            textBox6.Location = new Point(72, 198);
            textBox6.Name = "textBox6";
            textBox6.ReadOnly = true;
            textBox6.Size = new Size(39, 23);
            textBox6.TabIndex = 17;
            textBox6.Text = "+63";
            // 
            // ContactNumberText
            // 
            ContactNumberText.Anchor = AnchorStyles.Top;
            ContactNumberText.Location = new Point(117, 198);
            ContactNumberText.Name = "ContactNumberText";
            ContactNumberText.PlaceholderText = "09123456789";
            ContactNumberText.Size = new Size(250, 23);
            ContactNumberText.TabIndex = 16;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top;
            label5.AutoSize = true;
            label5.Location = new Point(72, 180);
            label5.Name = "label5";
            label5.Size = new Size(96, 15);
            label5.TabIndex = 15;
            label5.Text = "Contact Number";
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top;
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(SuffixText);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(LastNameText);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(MiddleNameText);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(FirstNameText);
            groupBox1.FlatStyle = FlatStyle.Flat;
            groupBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(72, 61);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(843, 100);
            groupBox1.TabIndex = 14;
            groupBox1.TabStop = false;
            groupBox1.Text = "Member's Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(767, 25);
            label4.Name = "label4";
            label4.Size = new Size(49, 21);
            label4.TabIndex = 9;
            label4.Text = "Suffix";
            // 
            // SuffixText
            // 
            SuffixText.Location = new Point(769, 53);
            SuffixText.MinimumSize = new Size(0, 30);
            SuffixText.Name = "SuffixText";
            SuffixText.Size = new Size(47, 30);
            SuffixText.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(505, 29);
            label3.Name = "label3";
            label3.Size = new Size(84, 21);
            label3.TabIndex = 7;
            label3.Text = "Last Name";
            // 
            // LastNameText
            // 
            LastNameText.Location = new Point(505, 53);
            LastNameText.MaximumSize = new Size(250, 0);
            LastNameText.MinimumSize = new Size(0, 30);
            LastNameText.Name = "LastNameText";
            LastNameText.Size = new Size(250, 30);
            LastNameText.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(274, 29);
            label2.Name = "label2";
            label2.Size = new Size(104, 21);
            label2.TabIndex = 5;
            label2.Text = "Middle Name";
            // 
            // MiddleNameText
            // 
            MiddleNameText.Location = new Point(274, 53);
            MiddleNameText.MaximumSize = new Size(250, 0);
            MiddleNameText.MinimumSize = new Size(0, 30);
            MiddleNameText.Name = "MiddleNameText";
            MiddleNameText.Size = new Size(212, 30);
            MiddleNameText.TabIndex = 4;
            MiddleNameText.TextChanged += MiddleNameText_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 29);
            label1.Name = "label1";
            label1.Size = new Size(86, 21);
            label1.TabIndex = 3;
            label1.Text = "First Name";
            // 
            // FirstNameText
            // 
            FirstNameText.Location = new Point(6, 53);
            FirstNameText.MaximumSize = new Size(250, 0);
            FirstNameText.MinimumSize = new Size(0, 30);
            FirstNameText.Name = "FirstNameText";
            FirstNameText.Size = new Size(245, 30);
            FirstNameText.TabIndex = 2;
            // 
            // groupBox3
            // 
            groupBox3.Anchor = AnchorStyles.Top;
            groupBox3.Controls.Add(HVCDPAddressBtn);
            groupBox3.Controls.Add(HVCDPAddressText);
            groupBox3.Controls.Add(HVCDPAreaText);
            groupBox3.Controls.Add(CommodityText);
            groupBox3.Location = new Point(66, 547);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(849, 60);
            groupBox3.TabIndex = 25;
            groupBox3.TabStop = false;
            groupBox3.Text = "HVCDP";
            // 
            // HVCDPAddressBtn
            // 
            HVCDPAddressBtn.BackgroundImage = Properties.Resources.icons8_edit_32;
            HVCDPAddressBtn.BackgroundImageLayout = ImageLayout.Zoom;
            HVCDPAddressBtn.Location = new Point(432, 22);
            HVCDPAddressBtn.Name = "HVCDPAddressBtn";
            HVCDPAddressBtn.Size = new Size(30, 23);
            HVCDPAddressBtn.TabIndex = 17;
            HVCDPAddressBtn.UseVisualStyleBackColor = true;
            HVCDPAddressBtn.Click += HVCDPAddressBtn_Click;
            // 
            // HVCDPAddressText
            // 
            HVCDPAddressText.Location = new Point(466, 22);
            HVCDPAddressText.Name = "HVCDPAddressText";
            HVCDPAddressText.PlaceholderText = "Farm Location";
            HVCDPAddressText.Size = new Size(324, 23);
            HVCDPAddressText.TabIndex = 16;
            // 
            // HVCDPAreaText
            // 
            HVCDPAreaText.Location = new Point(263, 22);
            HVCDPAreaText.Name = "HVCDPAreaText";
            HVCDPAreaText.PlaceholderText = "Area in sqm";
            HVCDPAreaText.Size = new Size(149, 23);
            HVCDPAreaText.TabIndex = 15;
            // 
            // CommodityText
            // 
            CommodityText.Location = new Point(51, 22);
            CommodityText.Name = "CommodityText";
            CommodityText.PlaceholderText = "Commodity";
            CommodityText.Size = new Size(206, 23);
            CommodityText.TabIndex = 14;
            // 
            // groupBox4
            // 
            groupBox4.Anchor = AnchorStyles.Top;
            groupBox4.Controls.Add(CornAreaText);
            groupBox4.Controls.Add(CornFarmAddressBtn);
            groupBox4.Controls.Add(CornAddressText);
            groupBox4.Location = new Point(65, 474);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(849, 60);
            groupBox4.TabIndex = 26;
            groupBox4.TabStop = false;
            groupBox4.Text = "CORN";
            // 
            // CornAreaText
            // 
            CornAreaText.Location = new Point(51, 22);
            CornAreaText.Name = "CornAreaText";
            CornAreaText.PlaceholderText = "Area in sqm";
            CornAreaText.Size = new Size(361, 23);
            CornAreaText.TabIndex = 13;
            // 
            // CornFarmAddressBtn
            // 
            CornFarmAddressBtn.BackgroundImage = Properties.Resources.icons8_edit_32;
            CornFarmAddressBtn.BackgroundImageLayout = ImageLayout.Zoom;
            CornFarmAddressBtn.Location = new Point(432, 22);
            CornFarmAddressBtn.Name = "CornFarmAddressBtn";
            CornFarmAddressBtn.Size = new Size(30, 23);
            CornFarmAddressBtn.TabIndex = 12;
            CornFarmAddressBtn.UseVisualStyleBackColor = true;
            CornFarmAddressBtn.Click += CornFarmAddressBtn_Click;
            // 
            // CornAddressText
            // 
            CornAddressText.Location = new Point(466, 22);
            CornAddressText.Name = "CornAddressText";
            CornAddressText.PlaceholderText = "Farm Location";
            CornAddressText.Size = new Size(324, 23);
            CornAddressText.TabIndex = 0;
            // 
            // SpouseText
            // 
            SpouseText.Anchor = AnchorStyles.Top;
            SpouseText.Location = new Point(73, 302);
            SpouseText.Name = "SpouseText";
            SpouseText.PlaceholderText = "Spouse's Name";
            SpouseText.Size = new Size(842, 23);
            SpouseText.TabIndex = 27;
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.Top;
            label9.AutoSize = true;
            label9.Location = new Point(72, 284);
            label9.Name = "label9";
            label9.Size = new Size(45, 15);
            label9.TabIndex = 28;
            label9.Text = "Spouse";
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.Top;
            label10.AutoSize = true;
            label10.Location = new Point(71, 335);
            label10.Name = "label10";
            label10.Size = new Size(68, 15);
            label10.TabIndex = 30;
            label10.Text = "Association";
            // 
            // AssociationText
            // 
            AssociationText.Anchor = AnchorStyles.Top;
            AssociationText.Location = new Point(72, 353);
            AssociationText.Name = "AssociationText";
            AssociationText.PlaceholderText = "Association";
            AssociationText.Size = new Size(842, 23);
            AssociationText.TabIndex = 29;
            // 
            // MemberProfileController
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label10);
            Controls.Add(AssociationText);
            Controls.Add(label9);
            Controls.Add(SpouseText);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(CurrentAddressEditBtn);
            Controls.Add(label8);
            Controls.Add(CurrentAddressText);
            Controls.Add(groupBox2);
            Controls.Add(label7);
            Controls.Add(GenderCB);
            Controls.Add(DateTimePicker);
            Controls.Add(label6);
            Controls.Add(textBox6);
            Controls.Add(ContactNumberText);
            Controls.Add(label5);
            Controls.Add(groupBox1);
            Name = "MemberProfileController";
            Size = new Size(980, 608);
            Load += ProfileController_Load;
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button CurrentAddressEditBtn;
        private Label label8;
        private TextBox CurrentAddressText;
        private GroupBox groupBox2;
        private TextBox RiceAreaText;
        private Button RiceFarmAddressBtn;
        private TextBox RiceAddressText;
        private Label label7;
        private ComboBox GenderCB;
        private DateTimePicker DateTimePicker;
        private Label label6;
        private TextBox textBox6;
        private TextBox ContactNumberText;
        private Label label5;
        private GroupBox groupBox1;
        private Label label4;
        private TextBox SuffixText;
        private Label label3;
        private TextBox LastNameText;
        private Label label2;
        private TextBox MiddleNameText;
        private Label label1;
        private TextBox FirstNameText;
        private GroupBox groupBox3;
        private GroupBox groupBox4;
        private TextBox CornAreaText;
        private Button CornFarmAddressBtn;
        private TextBox CornAddressText;
        private TextBox HVCDPAreaText;
        private TextBox CommodityText;
        private Button HVCDPAddressBtn;
        private TextBox HVCDPAddressText;
        private TextBox SpouseText;
        private Label label9;
        private Label label10;
        private TextBox AssociationText;
    }
}
