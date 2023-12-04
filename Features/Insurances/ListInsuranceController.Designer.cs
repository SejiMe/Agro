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
            DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle11 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle12 = new DataGridViewCellStyle();
            InactiveInsuranceBtn = new Button();
            DeclineInsuranceBtn = new Button();
            ApproveInsuranceBtn = new Button();
            ApplyFilterBtn = new Button();
            SearchBtn = new Button();
            FilterSelectorCB = new ComboBox();
            SearchText = new TextBox();
            MembersDataGrid = new DataGridView();
            InsuranceID = new DataGridViewTextBoxColumn();
            FarmID = new DataGridViewTextBoxColumn();
            RemarksCol = new DataGridViewCheckBoxColumn();
            StatusCol = new DataGridViewTextBoxColumn();
            FullNameCol = new DataGridViewTextBoxColumn();
            RoleCol = new DataGridViewTextBoxColumn();
            CommodityCol = new DataGridViewTextBoxColumn();
            SqmCol = new DataGridViewTextBoxColumn();
            LocationCol = new DataGridViewTextBoxColumn();
            isHVCDP = new DataGridViewCheckBoxColumn();
            TenurialCol = new DataGridViewTextBoxColumn();
            LandCategorySoilTypeCol = new DataGridViewTextBoxColumn();
            ContactNumberCol = new DataGridViewTextBoxColumn();
            DateAppliedCol = new DataGridViewTextBoxColumn();
            NorthAdjacentCol = new DataGridViewTextBoxColumn();
            SouthAdjacentCol = new DataGridViewTextBoxColumn();
            EastAdjacentCol = new DataGridViewTextBoxColumn();
            WestAdjacentCol = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)MembersDataGrid).BeginInit();
            SuspendLayout();
            // 
            // InactiveInsuranceBtn
            // 
            InactiveInsuranceBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            InactiveInsuranceBtn.BackColor = Color.LimeGreen;
            InactiveInsuranceBtn.Font = new Font("Segoe UI", 12F);
            InactiveInsuranceBtn.ForeColor = Color.Black;
            InactiveInsuranceBtn.Location = new Point(31, 478);
            InactiveInsuranceBtn.Name = "InactiveInsuranceBtn";
            InactiveInsuranceBtn.Size = new Size(184, 42);
            InactiveInsuranceBtn.TabIndex = 44;
            InactiveInsuranceBtn.Text = "Inactive Insurance";
            InactiveInsuranceBtn.UseVisualStyleBackColor = false;
            InactiveInsuranceBtn.Click += InactiveInsuranceBtn_Click;
            // 
            // DeclineInsuranceBtn
            // 
            DeclineInsuranceBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            DeclineInsuranceBtn.BackColor = Color.LimeGreen;
            DeclineInsuranceBtn.Font = new Font("Segoe UI", 12F);
            DeclineInsuranceBtn.ForeColor = Color.Black;
            DeclineInsuranceBtn.Location = new Point(548, 478);
            DeclineInsuranceBtn.Name = "DeclineInsuranceBtn";
            DeclineInsuranceBtn.Size = new Size(184, 42);
            DeclineInsuranceBtn.TabIndex = 43;
            DeclineInsuranceBtn.Text = "Decline Insurance";
            DeclineInsuranceBtn.UseVisualStyleBackColor = false;
            DeclineInsuranceBtn.Visible = false;
            DeclineInsuranceBtn.Click += DeclineInsuranceBtn_Click;
            // 
            // ApproveInsuranceBtn
            // 
            ApproveInsuranceBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            ApproveInsuranceBtn.BackColor = Color.LimeGreen;
            ApproveInsuranceBtn.Font = new Font("Segoe UI", 12F);
            ApproveInsuranceBtn.ForeColor = Color.Black;
            ApproveInsuranceBtn.Location = new Point(738, 478);
            ApproveInsuranceBtn.Name = "ApproveInsuranceBtn";
            ApproveInsuranceBtn.Size = new Size(184, 42);
            ApproveInsuranceBtn.TabIndex = 42;
            ApproveInsuranceBtn.Text = "Approve Insurance";
            ApproveInsuranceBtn.UseVisualStyleBackColor = false;
            ApproveInsuranceBtn.Visible = false;
            ApproveInsuranceBtn.Click += ApproveInsuranceBtn_Click;
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
            ApplyFilterBtn.Click += ApplyFilterBtn_Click;
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
            SearchBtn.Click += SearchBtn_Click;
            // 
            // FilterSelectorCB
            // 
            FilterSelectorCB.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            FilterSelectorCB.FormattingEnabled = true;
            FilterSelectorCB.Items.AddRange(new object[] { "APPLICANTS", "ACTIVE", "INACTIVE" });
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
            dataGridViewCellStyle10.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = SystemColors.Control;
            dataGridViewCellStyle10.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle10.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle10.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = DataGridViewTriState.True;
            MembersDataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            MembersDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            MembersDataGrid.Columns.AddRange(new DataGridViewColumn[] { InsuranceID, FarmID, RemarksCol, StatusCol, FullNameCol, RoleCol, CommodityCol, SqmCol, LocationCol, isHVCDP, TenurialCol, LandCategorySoilTypeCol, ContactNumberCol, DateAppliedCol, NorthAdjacentCol, SouthAdjacentCol, EastAdjacentCol, WestAdjacentCol });
            MembersDataGrid.GridColor = Color.Green;
            MembersDataGrid.Location = new Point(31, 103);
            MembersDataGrid.MultiSelect = false;
            MembersDataGrid.Name = "MembersDataGrid";
            MembersDataGrid.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle11.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.BackColor = SystemColors.Control;
            dataGridViewCellStyle11.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle11.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle11.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = DataGridViewTriState.True;
            MembersDataGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle11;
            MembersDataGrid.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            dataGridViewCellStyle12.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle12.ForeColor = Color.Black;
            dataGridViewCellStyle12.SelectionBackColor = Color.FromArgb(192, 255, 192);
            dataGridViewCellStyle12.SelectionForeColor = Color.Black;
            MembersDataGrid.RowsDefaultCellStyle = dataGridViewCellStyle12;
            MembersDataGrid.RowTemplate.DividerHeight = 2;
            MembersDataGrid.RowTemplate.Resizable = DataGridViewTriState.False;
            MembersDataGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            MembersDataGrid.Size = new Size(891, 359);
            MembersDataGrid.TabIndex = 37;
            // 
            // InsuranceID
            // 
            InsuranceID.HeaderText = "InsuranceID";
            InsuranceID.Name = "InsuranceID";
            InsuranceID.ReadOnly = true;
            InsuranceID.Visible = false;
            // 
            // FarmID
            // 
            FarmID.HeaderText = "FarmID";
            FarmID.Name = "FarmID";
            FarmID.ReadOnly = true;
            FarmID.Visible = false;
            // 
            // RemarksCol
            // 
            RemarksCol.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            RemarksCol.HeaderText = "Remarks";
            RemarksCol.Name = "RemarksCol";
            RemarksCol.Width = 58;
            // 
            // StatusCol
            // 
            StatusCol.HeaderText = "Status";
            StatusCol.Name = "StatusCol";
            StatusCol.ReadOnly = true;
            // 
            // FullNameCol
            // 
            FullNameCol.HeaderText = "Owner";
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
            // CommodityCol
            // 
            CommodityCol.HeaderText = "Commodity";
            CommodityCol.Name = "CommodityCol";
            CommodityCol.ReadOnly = true;
            // 
            // SqmCol
            // 
            SqmCol.HeaderText = "Square Meters";
            SqmCol.Name = "SqmCol";
            SqmCol.ReadOnly = true;
            // 
            // LocationCol
            // 
            LocationCol.HeaderText = "Location";
            LocationCol.Name = "LocationCol";
            LocationCol.ReadOnly = true;
            // 
            // isHVCDP
            // 
            isHVCDP.HeaderText = "HVCDP";
            isHVCDP.Name = "isHVCDP";
            isHVCDP.ReadOnly = true;
            // 
            // TenurialCol
            // 
            TenurialCol.HeaderText = "Tenurial Status";
            TenurialCol.Name = "TenurialCol";
            TenurialCol.ReadOnly = true;
            // 
            // LandCategorySoilTypeCol
            // 
            LandCategorySoilTypeCol.HeaderText = "Land Category / Soil Type";
            LandCategorySoilTypeCol.Name = "LandCategorySoilTypeCol";
            LandCategorySoilTypeCol.ReadOnly = true;
            // 
            // ContactNumberCol
            // 
            ContactNumberCol.HeaderText = "Contact No.";
            ContactNumberCol.Name = "ContactNumberCol";
            ContactNumberCol.ReadOnly = true;
            ContactNumberCol.Resizable = DataGridViewTriState.False;
            ContactNumberCol.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // DateAppliedCol
            // 
            DateAppliedCol.HeaderText = "Date of Application Request";
            DateAppliedCol.Name = "DateAppliedCol";
            DateAppliedCol.ReadOnly = true;
            // 
            // NorthAdjacentCol
            // 
            NorthAdjacentCol.HeaderText = "North Adjacent Owner";
            NorthAdjacentCol.Name = "NorthAdjacentCol";
            NorthAdjacentCol.ReadOnly = true;
            // 
            // SouthAdjacentCol
            // 
            SouthAdjacentCol.HeaderText = "South Adjacent Owner";
            SouthAdjacentCol.Name = "SouthAdjacentCol";
            SouthAdjacentCol.ReadOnly = true;
            // 
            // EastAdjacentCol
            // 
            EastAdjacentCol.HeaderText = "East Adjacent Owner";
            EastAdjacentCol.Name = "EastAdjacentCol";
            EastAdjacentCol.ReadOnly = true;
            // 
            // WestAdjacentCol
            // 
            WestAdjacentCol.HeaderText = "West Adjacent Owner";
            WestAdjacentCol.Name = "WestAdjacentCol";
            WestAdjacentCol.ReadOnly = true;
            // 
            // ListInsuranceController
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(InactiveInsuranceBtn);
            Controls.Add(DeclineInsuranceBtn);
            Controls.Add(ApproveInsuranceBtn);
            Controls.Add(ApplyFilterBtn);
            Controls.Add(SearchBtn);
            Controls.Add(FilterSelectorCB);
            Controls.Add(SearchText);
            Controls.Add(MembersDataGrid);
            Name = "ListInsuranceController";
            Size = new Size(953, 577);
            Load += ListInsuranceController_Load;
            ((System.ComponentModel.ISupportInitialize)MembersDataGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button InactiveInsuranceBtn;
        private Button DeclineInsuranceBtn;
        private Button ApproveInsuranceBtn;
        private Button ApplyFilterBtn;
        private Button SearchBtn;
        private ComboBox FilterSelectorCB;
        private TextBox SearchText;
        private DataGridView MembersDataGrid;
        private DataGridViewTextBoxColumn InsuranceID;
        private DataGridViewTextBoxColumn FarmID;
        private DataGridViewCheckBoxColumn RemarksCol;
        private DataGridViewTextBoxColumn StatusCol;
        private DataGridViewTextBoxColumn FullNameCol;
        private DataGridViewTextBoxColumn RoleCol;
        private DataGridViewTextBoxColumn CommodityCol;
        private DataGridViewTextBoxColumn SqmCol;
        private DataGridViewTextBoxColumn LocationCol;
        private DataGridViewCheckBoxColumn isHVCDP;
        private DataGridViewTextBoxColumn TenurialCol;
        private DataGridViewTextBoxColumn LandCategorySoilTypeCol;
        private DataGridViewTextBoxColumn ContactNumberCol;
        private DataGridViewTextBoxColumn DateAppliedCol;
        private DataGridViewTextBoxColumn NorthAdjacentCol;
        private DataGridViewTextBoxColumn SouthAdjacentCol;
        private DataGridViewTextBoxColumn EastAdjacentCol;
        private DataGridViewTextBoxColumn WestAdjacentCol;
    }
}
