namespace Mediatek.view
{
    partial class FrmChangementsPersonnel
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
            txtboxNom = new TextBox();
            lblNom = new Label();
            lblPrenom = new Label();
            txtboxPrenom = new TextBox();
            lblTel = new Label();
            txtboxTel = new TextBox();
            lblService = new Label();
            lblMail = new Label();
            txtboxMail = new TextBox();
            cmbServices = new ComboBox();
            SuspendLayout();
            // 
            // txtboxNom
            // 
            txtboxNom.Location = new Point(12, 29);
            txtboxNom.Name = "txtboxNom";
            txtboxNom.Size = new Size(142, 23);
            txtboxNom.TabIndex = 0;
            // 
            // lblNom
            // 
            lblNom.AutoSize = true;
            lblNom.Location = new Point(12, 11);
            lblNom.Name = "lblNom";
            lblNom.Size = new Size(34, 15);
            lblNom.TabIndex = 1;
            lblNom.Text = "Nom";
            // 
            // lblPrenom
            // 
            lblPrenom.AutoSize = true;
            lblPrenom.Location = new Point(160, 11);
            lblPrenom.Name = "lblPrenom";
            lblPrenom.Size = new Size(49, 15);
            lblPrenom.TabIndex = 3;
            lblPrenom.Text = "Prénom";
            // 
            // txtboxPrenom
            // 
            txtboxPrenom.Location = new Point(160, 29);
            txtboxPrenom.Name = "txtboxPrenom";
            txtboxPrenom.Size = new Size(142, 23);
            txtboxPrenom.TabIndex = 2;
            // 
            // lblTel
            // 
            lblTel.AutoSize = true;
            lblTel.Location = new Point(308, 11);
            lblTel.Name = "lblTel";
            lblTel.Size = new Size(25, 15);
            lblTel.TabIndex = 5;
            lblTel.Text = "Tel.";
            // 
            // txtboxTel
            // 
            txtboxTel.Location = new Point(308, 29);
            txtboxTel.Name = "txtboxTel";
            txtboxTel.Size = new Size(142, 23);
            txtboxTel.TabIndex = 4;
            // 
            // lblService
            // 
            lblService.AutoSize = true;
            lblService.Location = new Point(232, 64);
            lblService.Name = "lblService";
            lblService.Size = new Size(44, 15);
            lblService.TabIndex = 9;
            lblService.Text = "Service";
            // 
            // lblMail
            // 
            lblMail.AutoSize = true;
            lblMail.Location = new Point(84, 64);
            lblMail.Name = "lblMail";
            lblMail.Size = new Size(30, 15);
            lblMail.TabIndex = 7;
            lblMail.Text = "Mail";
            // 
            // txtboxMail
            // 
            txtboxMail.Location = new Point(84, 82);
            txtboxMail.Name = "txtboxMail";
            txtboxMail.Size = new Size(142, 23);
            txtboxMail.TabIndex = 6;
            // 
            // cmbServices
            // 
            cmbServices.FormattingEnabled = true;
            cmbServices.Location = new Point(232, 82);
            cmbServices.Name = "cmbServices";
            cmbServices.Size = new Size(145, 23);
            cmbServices.TabIndex = 10;
            // 
            // FrmChangementsPersonnel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(457, 134);
            Controls.Add(cmbServices);
            Controls.Add(lblService);
            Controls.Add(lblMail);
            Controls.Add(txtboxMail);
            Controls.Add(lblTel);
            Controls.Add(txtboxTel);
            Controls.Add(lblPrenom);
            Controls.Add(txtboxPrenom);
            Controls.Add(lblNom);
            Controls.Add(txtboxNom);
            Name = "FrmChangementsPersonnel";
            Text = "Changements Personnel";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtboxNom;
        private Label lblNom;
        private Label lblPrenom;
        private TextBox txtboxPrenom;
        private Label lblTel;
        private TextBox txtboxTel;
        private Label lblService;
        private Label lblMail;
        private TextBox txtboxMail;
        private ComboBox cmbServices;
    }
}