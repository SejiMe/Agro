namespace Agro.Features.Person
{
    partial class ListMembershipController
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
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            dataGrid = new DataGridView();
            RemarksCol = new DataGridViewCheckBoxColumn();
            FullNameCol = new DataGridViewTextBoxColumn();
            ContactNumberCol = new DataGridViewTextBoxColumn();
            DOBCol = new DataGridViewTextBoxColumn();
            SearchText = new TextBox();
            SearchBtn = new Button();
            ToolTipSearchButton = new ToolTip(components);
            ((System.ComponentModel.ISupportInitialize)dataGrid).BeginInit();
            SuspendLayout();
            // 
            // dataGrid
            // 
            dataGrid.BackgroundColor = Color.MediumSeaGreen;
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = SystemColors.Control;
            dataGridViewCellStyle7.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle7.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.True;
            dataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            dataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGrid.Columns.AddRange(new DataGridViewColumn[] { RemarksCol, FullNameCol, ContactNumberCol, DOBCol });
            dataGrid.GridColor = Color.Green;
            dataGrid.Location = new Point(61, 65);
            dataGrid.Name = "dataGrid";
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = SystemColors.Control;
            dataGridViewCellStyle8.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle8.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.True;
            dataGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            dataGridViewCellStyle9.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle9.ForeColor = Color.Black;
            dataGridViewCellStyle9.SelectionBackColor = Color.FromArgb(192, 255, 192);
            dataGridViewCellStyle9.SelectionForeColor = Color.Black;
            dataGrid.RowsDefaultCellStyle = dataGridViewCellStyle9;
            dataGrid.RowTemplate.DividerHeight = 2;
            dataGrid.RowTemplate.Resizable = DataGridViewTriState.False;
            dataGrid.ScrollBars = ScrollBars.Vertical;
            dataGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGrid.Size = new Size(691, 399);
            dataGrid.TabIndex = 0;
            // 
            // RemarksCol
            // 
            RemarksCol.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            RemarksCol.HeaderText = "Remarks";
            RemarksCol.Name = "RemarksCol";
            RemarksCol.Width = 58;
            // 
            // FullNameCol
            // 
            FullNameCol.HeaderText = "Full Name";
            FullNameCol.Name = "FullNameCol";
            FullNameCol.ReadOnly = true;
            FullNameCol.Resizable = DataGridViewTriState.False;
            FullNameCol.Width = 250;
            // 
            // ContactNumberCol
            // 
            ContactNumberCol.HeaderText = "Contact No.";
            ContactNumberCol.Name = "ContactNumberCol";
            ContactNumberCol.ReadOnly = true;
            ContactNumberCol.Resizable = DataGridViewTriState.False;
            ContactNumberCol.SortMode = DataGridViewColumnSortMode.NotSortable;
            ContactNumberCol.Width = 140;
            // 
            // DOBCol
            // 
            DOBCol.HeaderText = "Date of Birth";
            DOBCol.Name = "DOBCol";
            DOBCol.ReadOnly = true;
            DOBCol.Resizable = DataGridViewTriState.True;
            DOBCol.SortMode = DataGridViewColumnSortMode.NotSortable;
            DOBCol.Width = 200;
            // 
            // SearchText
            // 
            SearchText.Location = new Point(61, 29);
            SearchText.Name = "SearchText";
            SearchText.PlaceholderText = "DELA CRUZ, JUAN";
            SearchText.Size = new Size(569, 23);
            SearchText.TabIndex = 1;
            // 
            // SearchBtn
            // 
            SearchBtn.Location = new Point(648, 26);
            SearchBtn.Name = "SearchBtn";
            SearchBtn.Size = new Size(104, 32);
            SearchBtn.TabIndex = 2;
            SearchBtn.Text = "Search";
            SearchBtn.UseVisualStyleBackColor = true;
            // 
            // ListMembershipController
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(SearchBtn);
            Controls.Add(SearchText);
            Controls.Add(dataGrid);
            Name = "ListMembershipController";
            Size = new Size(818, 487);
            ((System.ComponentModel.ISupportInitialize)dataGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGrid;
        private DataGridViewCheckBoxColumn RemarksCol;
        private DataGridViewTextBoxColumn FullNameCol;
        private DataGridViewTextBoxColumn ContactNumberCol;
        private DataGridViewTextBoxColumn DOBCol;
        private TextBox SearchText;
        private Button SearchBtn;
        private ToolTip ToolTipSearchButton;
    }
}
