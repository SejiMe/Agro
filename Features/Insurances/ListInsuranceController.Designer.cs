namespace Agro.Features.Insurances
{
    partial class ListInsuranceController
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            RemoveMemberBtn = new Button();
            DeclineMembershipBtn = new Button();
            ApproveMemberBtn = new Button();
            ApplyFilterBtn = new Button();
            SearchBtn = new Button();
            FilterSelectorCB = new ComboBox();
            SearchText = new TextBox();
            MembersDataGrid = new DataGridView();
            PersonalIDCol = new DataGridViewTextBoxColumn();
            RemarksCol = new DataGridViewCheckBoxColumn();
            Status = new DataGridViewTextBoxColumn();
            FullNameCol = new DataGridViewTextBoxColumn();
            RoleCol = new DataGridViewTextBoxColumn();
            ContactNumberCol = new DataGridViewTextBoxColumn();
            DOBCol = new DataGridViewTextBoxColumn();
            DateAppliedCol = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)MembersDataGrid).BeginInit();
            SuspendLayout();
            // 
            // RemoveMemberBtn
            // 
            RemoveMemberBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            RemoveMemberBtn.BackColor = Color.LimeGreen;
            RemoveMemberBtn.Font = new Font("Segoe UI", 12F);
            RemoveMemberBtn.ForeColor = Color.Black;
            RemoveMemberBtn.Location = new Point(31, 478);
            RemoveMemberBtn.Name = "RemoveMemberBtn";
            RemoveMemberBtn.Size = new Size(184, 42);
            RemoveMemberBtn.TabIndex = 44;
            RemoveMemberBtn.Text = "Remove Member";
            RemoveMemberBtn.UseVisualStyleBackColor = false;
            // 
            // DeclineMembershipBtn
            // 
            DeclineMembershipBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            DeclineMembershipBtn.BackColor = Color.LimeGreen;
            DeclineMembershipBtn.Font = new Font("Segoe UI", 12F);
            DeclineMembershipBtn.ForeColor = Color.Black;
            DeclineMembershipBtn.Location = new Point(548, 478);
            DeclineMembershipBtn.Name = "DeclineMembershipBtn";
            DeclineMembershipBtn.Size = new Size(184, 42);
            DeclineMembershipBtn.TabIndex = 43;
            DeclineMembershipBtn.Text = "Decline Membership";
            DeclineMembershipBtn.UseVisualStyleBackColor = false;
            DeclineMembershipBtn.Visible = false;
            // 
            // ApproveMemberBtn
            // 
            ApproveMemberBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            ApproveMemberBtn.BackColor = Color.LimeGreen;
            ApproveMemberBtn.Font = new Font("Segoe UI", 12F);
            ApproveMemberBtn.ForeColor = Color.Black;
            ApproveMemberBtn.Location = new Point(738, 478);
            ApproveMemberBtn.Name = "ApproveMemberBtn";
            ApproveMemberBtn.Size = new Size(184, 42);
            ApproveMemberBtn.TabIndex = 42;
            ApproveMemberBtn.Text = "Approve Membership";
            ApproveMemberBtn.UseVisualStyleBackColor = false;
            ApproveMemberBtn.Visible = false;
            // 
            // ApplyFilterBtn
            // 
            ApplyFilterBtn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            ApplyFilterBtn.BackColor = Color.LimeGreen;
            ApplyFilterBtn.Font = new Font("Segoe UI", 12F);
            ApplyFilterBtn.ForeColor = Color.Black;
            ApplyFilterBtn.Location = new Point(801, 57);
            ApplyFilterBtn.Name = "ApplyFilterBtn";
            ApplyFilterBtn.Size = new Size(121, 40);
            ApplyFilterBtn.TabIndex = 41;
            ApplyFilterBtn.Text = "Apply Filter";
            ApplyFilterBtn.UseVisualStyleBackColor = false;
            // 
            // SearchBtn
            // 
            SearchBtn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            SearchBtn.BackColor = Color.LimeGreen;
            SearchBtn.Font = new Font("Segoe UI", 12F);
            SearchBtn.ForeColor = Color.Black;
            SearchBtn.Location = new Point(526, 57);
            SearchBtn.Name = "SearchBtn";
            SearchBtn.Size = new Size(125, 40);
            SearchBtn.TabIndex = 40;
            SearchBtn.Text = "Search";
            SearchBtn.UseVisualStyleBackColor = false;
            // 
            // FilterSelectorCB
            // 
            FilterSelectorCB.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            FilterSelectorCB.FormattingEnabled = true;
            FilterSelectorCB.Items.AddRange(new object[] { "APPLICANTS", "MEMBERS" });
            FilterSelectorCB.Location = new Point(657, 66);
            FilterSelectorCB.Name = "FilterSelectorCB";
            FilterSelectorCB.Size = new Size(138, 23);
            FilterSelectorCB.TabIndex = 39;
            // 
            // SearchText
            // 
            SearchText.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            SearchText.Location = new Point(31, 66);
            SearchText.Name = "SearchText";
            SearchText.PlaceholderText = "DELA CRUZ, JUAN";
            SearchText.Size = new Size(489, 23);
            SearchText.TabIndex = 38;
            // 
            // MembersDataGrid
            // 
            MembersDataGrid.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            MembersDataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            MembersDataGrid.BackgroundColor = Color.MediumSeaGreen;
            MembersDataGrid.CellBorderStyle = DataGridViewCellBorderStyle.SunkenVertical;
            MembersDataGrid.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            MembersDataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            MembersDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            MembersDataGrid.Columns.AddRange(new DataGridViewColumn[] { PersonalIDCol, RemarksCol, Status, FullNameCol, RoleCol, ContactNumberCol, DOBCol, DateAppliedCol });
            MembersDataGrid.GridColor = Color.Green;
            MembersDataGrid.Location = new Point(31, 103);
            MembersDataGrid.MultiSelect = false;
            MembersDataGrid.Name = "MembersDataGrid";
            MembersDataGrid.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            MembersDataGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            MembersDataGrid.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            dataGridViewCellStyle3.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(192, 255, 192);
            dataGridViewCellStyle3.SelectionForeColor = Color.Black;
            MembersDataGrid.RowsDefaultCellStyle = dataGridViewCellStyle3;
            MembersDataGrid.RowTemplate.DividerHeight = 2;
            MembersDataGrid.RowTemplate.Resizable = DataGridViewTriState.False;
            MembersDataGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            MembersDataGrid.Size = new Size(891, 359);
            MembersDataGrid.TabIndex = 37;
            // 
            // PersonalIDCol
            // 
            PersonalIDCol.Frozen = true;
            PersonalIDCol.HeaderText = "PersonalID";
            PersonalIDCol.Name = "PersonalIDCol";
            PersonalIDCol.ReadOnly = true;
            PersonalIDCol.Visible = false;
            // 
            // RemarksCol
            // 
            RemarksCol.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            RemarksCol.Frozen = true;
            RemarksCol.HeaderText = "Remarks";
            RemarksCol.Name = "RemarksCol";
            RemarksCol.Width = 58;
            // 
            // Status
            // 
            Status.HeaderText = "Status";
            Status.Name = "Status";
            Status.ReadOnly = true;
            // 
            // FullNameCol
            // 
            FullNameCol.HeaderText = "Full Name";
            FullNameCol.Name = "FullNameCol";
            FullNameCol.ReadOnly = true;
            FullNameCol.Resizable = DataGridViewTriState.False;
            // 
            // RoleCol
            // 
            RoleCol.HeaderText = "Role";
            RoleCol.Name = "RoleCol";
            RoleCol.ReadOnly = true;
            // 
            // ContactNumberCol
            // 
            ContactNumberCol.HeaderText = "Contact No.";
            ContactNumberCol.Name = "ContactNumberCol";
            ContactNumberCol.ReadOnly = true;
            ContactNumberCol.Resizable = DataGridViewTriState.False;
            ContactNumberCol.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // DOBCol
            // 
            DOBCol.HeaderText = "Date of Birth";
            DOBCol.Name = "DOBCol";
            DOBCol.ReadOnly = true;
            DOBCol.Resizable = DataGridViewTriState.True;
            DOBCol.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // DateAppliedCol
            // 
            DateAppliedCol.HeaderText = "Date of Application Request";
            DateAppliedCol.Name = "DateAppliedCol";
            DateAppliedCol.ReadOnly = true;
            // 
            // ListInsuranceController
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(RemoveMemberBtn);
            Controls.Add(DeclineMembershipBtn);
            Controls.Add(ApproveMemberBtn);
            Controls.Add(ApplyFilterBtn);
            Controls.Add(SearchBtn);
            Controls.Add(FilterSelectorCB);
            Controls.Add(SearchText);
            Controls.Add(MembersDataGrid);
            Name = "ListInsuranceController";
            Size = new Size(953, 577);
            ((System.ComponentModel.ISupportInitialize)MembersDataGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button RemoveMemberBtn;
        private Button DeclineMembershipBtn;
        private Button ApproveMemberBtn;
        private Button ApplyFilterBtn;
        private Button SearchBtn;
        private ComboBox FilterSelectorCB;
        private TextBox SearchText;
        private DataGridView MembersDataGrid;
        private DataGridViewTextBoxColumn PersonalIDCol;
        private DataGridViewCheckBoxColumn RemarksCol;
        private DataGridViewTextBoxColumn Status;
        private DataGridViewTextBoxColumn FullNameCol;
        private DataGridViewTextBoxColumn RoleCol;
        private DataGridViewTextBoxColumn ContactNumberCol;
        private DataGridViewTextBoxColumn DOBCol;
        private DataGridViewTextBoxColumn DateAppliedCol;
    }
}
