namespace Agro.Features.Layout
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            NavigationPanel = new Panel();
            label1 = new Label();
            NavigationalButtonsPanel = new Panel();
            LogOutBtn = new Button();
            FullNameLabel = new Label();
            roundedPictureBox1 = new Components.RoundedPictureBox();
            HeaderPanel = new Panel();
            label3 = new Label();
            label2 = new Label();
            TitleLabel = new Label();
            ControllerPanel = new Panel();
            NavigationPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)roundedPictureBox1).BeginInit();
            HeaderPanel.SuspendLayout();
            SuspendLayout();
            // 
            // NavigationPanel
            // 
            NavigationPanel.BackColor = Color.DarkGreen;
            NavigationPanel.Controls.Add(label1);
            NavigationPanel.Controls.Add(NavigationalButtonsPanel);
            NavigationPanel.Controls.Add(LogOutBtn);
            NavigationPanel.Controls.Add(FullNameLabel);
            NavigationPanel.Controls.Add(roundedPictureBox1);
            NavigationPanel.Dock = DockStyle.Left;
            NavigationPanel.Location = new Point(0, 0);
            NavigationPanel.Name = "NavigationPanel";
            NavigationPanel.Size = new Size(203, 450);
            NavigationPanel.TabIndex = 0;
            NavigationPanel.Paint += NavigationPanel_Paint;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.DarkTurquoise;
            label1.Location = new Point(0, 220);
            label1.Name = "label1";
            label1.Size = new Size(125, 21);
            label1.TabIndex = 4;
            label1.Text = "Main Navigation";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // NavigationalButtonsPanel
            // 
            NavigationalButtonsPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            NavigationalButtonsPanel.AutoSize = true;
            NavigationalButtonsPanel.Location = new Point(0, 257);
            NavigationalButtonsPanel.Name = "NavigationalButtonsPanel";
            NavigationalButtonsPanel.Size = new Size(203, 193);
            NavigationalButtonsPanel.TabIndex = 3;
            // 
            // LogOutBtn
            // 
            LogOutBtn.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            LogOutBtn.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LogOutBtn.Location = new Point(0, 9);
            LogOutBtn.Name = "LogOutBtn";
            LogOutBtn.Size = new Size(203, 30);
            LogOutBtn.TabIndex = 2;
            LogOutBtn.Text = "Log Out";
            LogOutBtn.UseVisualStyleBackColor = true;
            LogOutBtn.Click += LogOutBtn_Click;
            // 
            // FullNameLabel
            // 
            FullNameLabel.AutoSize = true;
            FullNameLabel.FlatStyle = FlatStyle.Flat;
            FullNameLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FullNameLabel.ForeColor = Color.LawnGreen;
            FullNameLabel.Location = new Point(8, 180);
            FullNameLabel.MinimumSize = new Size(180, 0);
            FullNameLabel.Name = "FullNameLabel";
            FullNameLabel.Size = new Size(180, 21);
            FullNameLabel.TabIndex = 1;
            FullNameLabel.Text = "Sej Tech";
            FullNameLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // roundedPictureBox1
            // 
            roundedPictureBox1.BackColor = Color.Transparent;
            roundedPictureBox1.BackgroundImage = Properties.Resources.user;
            roundedPictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            roundedPictureBox1.InitialImage = (Image)resources.GetObject("roundedPictureBox1.InitialImage");
            roundedPictureBox1.Location = new Point(31, 74);
            roundedPictureBox1.Name = "roundedPictureBox1";
            roundedPictureBox1.Size = new Size(121, 96);
            roundedPictureBox1.TabIndex = 0;
            roundedPictureBox1.TabStop = false;
            // 
            // HeaderPanel
            // 
            HeaderPanel.BackColor = Color.MediumSeaGreen;
            HeaderPanel.Controls.Add(label3);
            HeaderPanel.Controls.Add(label2);
            HeaderPanel.Controls.Add(TitleLabel);
            HeaderPanel.Dock = DockStyle.Top;
            HeaderPanel.Location = new Point(203, 0);
            HeaderPanel.Name = "HeaderPanel";
            HeaderPanel.Size = new Size(597, 100);
            HeaderPanel.TabIndex = 1;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Location = new Point(422, 74);
            label3.Name = "label3";
            label3.Size = new Size(163, 15);
            label3.TabIndex = 2;
            label3.Text = "BUNAWAN AGUSAN DEL SUR";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(422, 9);
            label2.Name = "label2";
            label2.Size = new Size(163, 65);
            label2.TabIndex = 1;
            label2.Text = "AGRO";
            // 
            // TitleLabel
            // 
            TitleLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            TitleLabel.AutoSize = true;
            TitleLabel.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TitleLabel.Location = new Point(19, 35);
            TitleLabel.Name = "TitleLabel";
            TitleLabel.Size = new Size(83, 32);
            TitleLabel.TabIndex = 0;
            TitleLabel.Text = "label1";
            // 
            // ControllerPanel
            // 
            ControllerPanel.BackColor = Color.SeaGreen;
            ControllerPanel.BorderStyle = BorderStyle.FixedSingle;
            ControllerPanel.Dock = DockStyle.Fill;
            ControllerPanel.Location = new Point(203, 100);
            ControllerPanel.Name = "ControllerPanel";
            ControllerPanel.Size = new Size(597, 350);
            ControllerPanel.TabIndex = 2;
            ControllerPanel.Paint += ControllerPanel_Paint;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(800, 450);
            ControlBox = false;
            Controls.Add(ControllerPanel);
            Controls.Add(HeaderPanel);
            Controls.Add(NavigationPanel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "MainForm";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "                                ";
            WindowState = FormWindowState.Maximized;
            Load += MainForm_Load;
            NavigationPanel.ResumeLayout(false);
            NavigationPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)roundedPictureBox1).EndInit();
            HeaderPanel.ResumeLayout(false);
            HeaderPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel NavigationPanel;
        private Panel HeaderPanel;
        private Panel ControllerPanel;
        private Label TitleLabel;
        private Label label2;
        private Label label3;
        private Components.RoundedPictureBox roundedPictureBox1;
        private Label FullNameLabel;
        private Button LogOutBtn;
        private Panel NavigationalButtonsPanel;
        private Label label1;
    }
}