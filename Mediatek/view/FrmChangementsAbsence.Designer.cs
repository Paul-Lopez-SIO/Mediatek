namespace Mediatek.view
{
    partial class FrmChangementsAbsence
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
            cmbServices = new ComboBox();
            lblService = new Label();
            lblPersonnel = new Label();
            txtboxPersonnel = new TextBox();
            lblDateFin = new Label();
            txtboxDateFin = new TextBox();
            lblDateDebut = new Label();
            txtboxDateDebut = new TextBox();
            SuspendLayout();
            // 
            // cmbServices
            // 
            cmbServices.FormattingEnabled = true;
            cmbServices.Location = new Point(155, 79);
            cmbServices.Name = "cmbServices";
            cmbServices.Size = new Size(142, 23);
            cmbServices.TabIndex = 20;
            // 
            // lblService
            // 
            lblService.AutoSize = true;
            lblService.Location = new Point(155, 61);
            lblService.Name = "lblService";
            lblService.Size = new Size(44, 15);
            lblService.TabIndex = 19;
            lblService.Text = "Service";
            // 
            // lblPersonnel
            // 
            lblPersonnel.AutoSize = true;
            lblPersonnel.Location = new Point(7, 61);
            lblPersonnel.Name = "lblPersonnel";
            lblPersonnel.Size = new Size(59, 15);
            lblPersonnel.TabIndex = 18;
            lblPersonnel.Text = "Personnel";
            // 
            // txtboxPersonnel
            // 
            txtboxPersonnel.Location = new Point(7, 79);
            txtboxPersonnel.Name = "txtboxPersonnel";
            txtboxPersonnel.Size = new Size(142, 23);
            txtboxPersonnel.TabIndex = 17;
            // 
            // lblDateFin
            // 
            lblDateFin.AutoSize = true;
            lblDateFin.Location = new Point(155, 8);
            lblDateFin.Name = "lblDateFin";
            lblDateFin.Size = new Size(48, 15);
            lblDateFin.TabIndex = 14;
            lblDateFin.Text = "Date fin";
            // 
            // txtboxDateFin
            // 
            txtboxDateFin.Location = new Point(155, 26);
            txtboxDateFin.Name = "txtboxDateFin";
            txtboxDateFin.Size = new Size(142, 23);
            txtboxDateFin.TabIndex = 13;
            // 
            // lblDateDebut
            // 
            lblDateDebut.AutoSize = true;
            lblDateDebut.Location = new Point(7, 8);
            lblDateDebut.Name = "lblDateDebut";
            lblDateDebut.Size = new Size(65, 15);
            lblDateDebut.TabIndex = 12;
            lblDateDebut.Text = "Date début";
            // 
            // txtboxDateDebut
            // 
            txtboxDateDebut.Location = new Point(7, 26);
            txtboxDateDebut.Name = "txtboxDateDebut";
            txtboxDateDebut.Size = new Size(142, 23);
            txtboxDateDebut.TabIndex = 11;
            // 
            // FrmChangementsAbsence
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(306, 124);
            Controls.Add(cmbServices);
            Controls.Add(lblService);
            Controls.Add(lblPersonnel);
            Controls.Add(txtboxPersonnel);
            Controls.Add(lblDateFin);
            Controls.Add(txtboxDateFin);
            Controls.Add(lblDateDebut);
            Controls.Add(txtboxDateDebut);
            Name = "FrmChangementsAbsence";
            Text = "Changements Absence";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbServices;
        private Label lblService;
        private Label lblPersonnel;
        private TextBox txtboxPersonnel;
        private Label lblDateFin;
        private TextBox txtboxDateFin;
        private Label lblDateDebut;
        private TextBox txtboxDateDebut;
    }
}