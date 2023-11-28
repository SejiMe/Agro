namespace Agro.Features.Addresses
{
    partial class AddressForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            LotNumberText = new TextBox();
            HouseNumber = new TextBox();
            StreetText = new TextBox();
            BarangayCB = new ComboBox();
            MunicipalityText = new TextBox();
            textBox1 = new TextBox();
            button1 = new Button();
            TitleLabel = new Label();
            SuspendLayout();
            // 
            // LotNumberText
            // 
            LotNumberText.Location = new Point(34, 59);
            LotNumberText.Name = "LotNumberText";
            LotNumberText.PlaceholderText = "Lot Number";
            LotNumberText.Size = new Size(160, 23);
            LotNumberText.TabIndex = 0;
            // 
            // HouseNumber
            // 
            HouseNumber.Location = new Point(200, 59);
            HouseNumber.Name = "HouseNumber";
            HouseNumber.PlaceholderText = "House Number";
            HouseNumber.Size = new Size(216, 23);
            HouseNumber.TabIndex = 1;
            // 
            // StreetText
            // 
            StreetText.Location = new Point(34, 88);
            StreetText.Name = "StreetText";
            StreetText.PlaceholderText = "Street";
            StreetText.Size = new Size(160, 23);
            StreetText.TabIndex = 2;
            // 
            // BarangayCB
            // 
            BarangayCB.DisplayMember = "(none) ";
            BarangayCB.FormattingEnabled = true;
            BarangayCB.Items.AddRange(new object[] { "Agusan Pequeño", "Bayugan 3", "Bunawan Brook", "Caimpugan", "Consuelo", "Imelda", "Libertad", "Mambalili", "Nueva Era", "Poblacion", "San Andres", "San Marcos", "San Teodoro" });
            BarangayCB.Location = new Point(200, 88);
            BarangayCB.Name = "BarangayCB";
            BarangayCB.Size = new Size(216, 23);
            BarangayCB.TabIndex = 3;
            BarangayCB.Text = "Barangay";
            // 
            // MunicipalityText
            // 
            MunicipalityText.Location = new Point(34, 117);
            MunicipalityText.Name = "MunicipalityText";
            MunicipalityText.PlaceholderText = "Street";
            MunicipalityText.ReadOnly = true;
            MunicipalityText.Size = new Size(160, 23);
            MunicipalityText.TabIndex = 4;
            MunicipalityText.Text = "BUNAWAN";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(200, 117);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Street";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(216, 23);
            textBox1.TabIndex = 5;
            textBox1.Text = "AGUSAN DEL SUR";
            // 
            // button1
            // 
            button1.Location = new Point(320, 156);
            button1.Name = "button1";
            button1.Size = new Size(96, 31);
            button1.TabIndex = 6;
            button1.Text = "Submit";
            button1.UseVisualStyleBackColor = true;
            // 
            // TitleLabel
            // 
            TitleLabel.AutoSize = true;
            TitleLabel.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TitleLabel.Location = new Point(34, 21);
            TitleLabel.Name = "TitleLabel";
            TitleLabel.Size = new Size(164, 25);
            TitleLabel.TabIndex = 7;
            TitleLabel.Text = "ASDASDASDASD";
            TitleLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // AddressForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(469, 213);
            Controls.Add(TitleLabel);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(MunicipalityText);
            Controls.Add(BarangayCB);
            Controls.Add(StreetText);
            Controls.Add(HouseNumber);
            Controls.Add(LotNumberText);
            Name = "AddressForm";
            Text = "Address";
            Load += AddressForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox LotNumberText;
        private TextBox HouseNumber;
        private TextBox StreetText;
        private ComboBox BarangayCB;
        private TextBox MunicipalityText;
        private TextBox textBox1;
        private Button button1;
        private Label TitleLabel;
    }
}