namespace Agro
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            ID = new Components.RoundedPictureBox();
            ((System.ComponentModel.ISupportInitialize)ID).BeginInit();
            SuspendLayout();
            // 
            // ID
            // 
            ID.Location = new Point(188, 95);
            ID.Name = "ID";
            ID.Size = new Size(203, 128);
            ID.TabIndex = 0;
            ID.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(ID);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)ID).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Components.RoundedPictureBox ID;
    }
}
