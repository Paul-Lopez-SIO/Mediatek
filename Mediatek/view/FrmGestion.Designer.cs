namespace Mediatek.view
{
    partial class FrmGestion
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
            components = new System.ComponentModel.Container();
            grpPersonnel = new GroupBox();
            dgvPersonnel = new DataGridView();
            bddManagerBindingSource = new BindingSource(components);
            grpAbsences = new GroupBox();
            dgvAbsences = new DataGridView();
            btnAfficherAbsences = new Button();
            bddManagerBindingSource1 = new BindingSource(components);
            groupBox1 = new GroupBox();
            btnPersonnelSupprimer = new Button();
            lblService = new Label();
            btnPersonnelModifier = new Button();
            btnPersonnelAjout = new Button();
            cmbService = new ComboBox();
            llbMail = new Label();
            lblTel = new Label();
            txtboxMail = new TextBox();
            txtboxTel = new TextBox();
            lblPrenom = new Label();
            lblNom = new Label();
            txtboxPrenom = new TextBox();
            txtboxNom = new TextBox();
            groupBox2 = new GroupBox();
            btnAbsencesSupprimer = new Button();
            btnAbsencesModifier = new Button();
            btnAbsenceAjout = new Button();
            lblMotif = new Label();
            txtboxFin = new TextBox();
            cmbMotif = new ComboBox();
            lblDateFin = new Label();
            txtboxDebut = new TextBox();
            lblDateDebut = new Label();
            grpPersonnel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPersonnel).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bddManagerBindingSource).BeginInit();
            grpAbsences.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAbsences).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bddManagerBindingSource1).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // grpPersonnel
            // 
            grpPersonnel.Controls.Add(dgvPersonnel);
            grpPersonnel.Location = new Point(12, 12);
            grpPersonnel.Name = "grpPersonnel";
            grpPersonnel.Size = new Size(567, 212);
            grpPersonnel.TabIndex = 0;
            grpPersonnel.TabStop = false;
            grpPersonnel.Text = "Personnel";
            // 
            // dgvPersonnel
            // 
            dgvPersonnel.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPersonnel.Location = new Point(6, 22);
            dgvPersonnel.Name = "dgvPersonnel";
            dgvPersonnel.Size = new Size(555, 184);
            dgvPersonnel.TabIndex = 0;
            dgvPersonnel.SelectionChanged += dgvPersonnel_SelectionChanged;
            // 
            // bddManagerBindingSource
            // 
            bddManagerBindingSource.DataSource = typeof(bddmanager.BddManager);
            // 
            // grpAbsences
            // 
            grpAbsences.Controls.Add(dgvAbsences);
            grpAbsences.Controls.Add(btnAfficherAbsences);
            grpAbsences.Location = new Point(12, 230);
            grpAbsences.Name = "grpAbsences";
            grpAbsences.Size = new Size(240, 313);
            grpAbsences.TabIndex = 1;
            grpAbsences.TabStop = false;
            grpAbsences.Text = "Absences";
            // 
            // dgvAbsences
            // 
            dgvAbsences.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAbsences.Location = new Point(6, 22);
            dgvAbsences.Name = "dgvAbsences";
            dgvAbsences.Size = new Size(228, 252);
            dgvAbsences.TabIndex = 0;
            // 
            // btnAfficherAbsences
            // 
            btnAfficherAbsences.Location = new Point(6, 280);
            btnAfficherAbsences.Name = "btnAfficherAbsences";
            btnAfficherAbsences.Size = new Size(228, 27);
            btnAfficherAbsences.TabIndex = 8;
            btnAfficherAbsences.Text = "Afficher absences";
            btnAfficherAbsences.UseVisualStyleBackColor = true;
            // 
            // bddManagerBindingSource1
            // 
            bddManagerBindingSource1.DataSource = typeof(bddmanager.BddManager);
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnPersonnelSupprimer);
            groupBox1.Controls.Add(lblService);
            groupBox1.Controls.Add(btnPersonnelModifier);
            groupBox1.Controls.Add(btnPersonnelAjout);
            groupBox1.Controls.Add(cmbService);
            groupBox1.Controls.Add(llbMail);
            groupBox1.Controls.Add(lblTel);
            groupBox1.Controls.Add(txtboxMail);
            groupBox1.Controls.Add(txtboxTel);
            groupBox1.Controls.Add(lblPrenom);
            groupBox1.Controls.Add(lblNom);
            groupBox1.Controls.Add(txtboxPrenom);
            groupBox1.Controls.Add(txtboxNom);
            groupBox1.Location = new Point(258, 230);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(321, 164);
            groupBox1.TabIndex = 9;
            groupBox1.TabStop = false;
            groupBox1.Text = "Gestion personnel";
            // 
            // btnPersonnelSupprimer
            // 
            btnPersonnelSupprimer.Location = new Point(220, 135);
            btnPersonnelSupprimer.Name = "btnPersonnelSupprimer";
            btnPersonnelSupprimer.Size = new Size(96, 23);
            btnPersonnelSupprimer.TabIndex = 20;
            btnPersonnelSupprimer.Text = "Supprimer";
            btnPersonnelSupprimer.UseVisualStyleBackColor = true;
            btnPersonnelSupprimer.Click += btnPersonnelSupprimer_Click;
            // 
            // lblService
            // 
            lblService.AutoSize = true;
            lblService.Location = new Point(163, 109);
            lblService.Name = "lblService";
            lblService.Size = new Size(44, 15);
            lblService.TabIndex = 9;
            lblService.Text = "Service";
            // 
            // btnPersonnelModifier
            // 
            btnPersonnelModifier.Location = new Point(113, 135);
            btnPersonnelModifier.Name = "btnPersonnelModifier";
            btnPersonnelModifier.Size = new Size(96, 23);
            btnPersonnelModifier.TabIndex = 19;
            btnPersonnelModifier.Text = "Modifier";
            btnPersonnelModifier.UseVisualStyleBackColor = true;
            btnPersonnelModifier.Click += btnPersonnelModifier_Click;
            // 
            // btnPersonnelAjout
            // 
            btnPersonnelAjout.Location = new Point(6, 135);
            btnPersonnelAjout.Name = "btnPersonnelAjout";
            btnPersonnelAjout.Size = new Size(96, 23);
            btnPersonnelAjout.TabIndex = 18;
            btnPersonnelAjout.Text = "Ajouter";
            btnPersonnelAjout.UseVisualStyleBackColor = true;
            btnPersonnelAjout.Click += button3_Click;
            // 
            // cmbService
            // 
            cmbService.FormattingEnabled = true;
            cmbService.Location = new Point(215, 106);
            cmbService.Name = "cmbService";
            cmbService.Size = new Size(100, 23);
            cmbService.TabIndex = 8;
            // 
            // llbMail
            // 
            llbMail.AutoSize = true;
            llbMail.Location = new Point(177, 68);
            llbMail.Name = "llbMail";
            llbMail.Size = new Size(30, 15);
            llbMail.TabIndex = 7;
            llbMail.Text = "Mail";
            // 
            // lblTel
            // 
            lblTel.AutoSize = true;
            lblTel.Location = new Point(15, 68);
            lblTel.Name = "lblTel";
            lblTel.Size = new Size(25, 15);
            lblTel.TabIndex = 6;
            lblTel.Text = "Tel.";
            // 
            // txtboxMail
            // 
            txtboxMail.Location = new Point(215, 63);
            txtboxMail.Name = "txtboxMail";
            txtboxMail.Size = new Size(100, 23);
            txtboxMail.TabIndex = 5;
            // 
            // txtboxTel
            // 
            txtboxTel.Location = new Point(49, 63);
            txtboxTel.Name = "txtboxTel";
            txtboxTel.Size = new Size(100, 23);
            txtboxTel.TabIndex = 4;
            // 
            // lblPrenom
            // 
            lblPrenom.AutoSize = true;
            lblPrenom.Location = new Point(158, 27);
            lblPrenom.Name = "lblPrenom";
            lblPrenom.Size = new Size(49, 15);
            lblPrenom.TabIndex = 3;
            lblPrenom.Text = "Prénom";
            // 
            // lblNom
            // 
            lblNom.AutoSize = true;
            lblNom.Location = new Point(6, 27);
            lblNom.Name = "lblNom";
            lblNom.Size = new Size(34, 15);
            lblNom.TabIndex = 2;
            lblNom.Text = "Nom";
            // 
            // txtboxPrenom
            // 
            txtboxPrenom.Location = new Point(215, 22);
            txtboxPrenom.Name = "txtboxPrenom";
            txtboxPrenom.Size = new Size(100, 23);
            txtboxPrenom.TabIndex = 1;
            // 
            // txtboxNom
            // 
            txtboxNom.Location = new Point(49, 22);
            txtboxNom.Name = "txtboxNom";
            txtboxNom.Size = new Size(100, 23);
            txtboxNom.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnAbsencesSupprimer);
            groupBox2.Controls.Add(btnAbsencesModifier);
            groupBox2.Controls.Add(btnAbsenceAjout);
            groupBox2.Controls.Add(lblMotif);
            groupBox2.Controls.Add(txtboxFin);
            groupBox2.Controls.Add(cmbMotif);
            groupBox2.Controls.Add(lblDateFin);
            groupBox2.Controls.Add(txtboxDebut);
            groupBox2.Controls.Add(lblDateDebut);
            groupBox2.Location = new Point(258, 400);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(321, 143);
            groupBox2.TabIndex = 10;
            groupBox2.TabStop = false;
            groupBox2.Text = "Gestion absences";
            // 
            // btnAbsencesSupprimer
            // 
            btnAbsencesSupprimer.Location = new Point(220, 110);
            btnAbsencesSupprimer.Name = "btnAbsencesSupprimer";
            btnAbsencesSupprimer.Size = new Size(96, 23);
            btnAbsencesSupprimer.TabIndex = 17;
            btnAbsencesSupprimer.Text = "Supprimer";
            btnAbsencesSupprimer.UseVisualStyleBackColor = true;
            // 
            // btnAbsencesModifier
            // 
            btnAbsencesModifier.Location = new Point(113, 110);
            btnAbsencesModifier.Name = "btnAbsencesModifier";
            btnAbsencesModifier.Size = new Size(96, 23);
            btnAbsencesModifier.TabIndex = 16;
            btnAbsencesModifier.Text = "Modifier";
            btnAbsencesModifier.UseVisualStyleBackColor = true;
            // 
            // btnAbsenceAjout
            // 
            btnAbsenceAjout.Location = new Point(6, 110);
            btnAbsenceAjout.Name = "btnAbsenceAjout";
            btnAbsenceAjout.Size = new Size(96, 23);
            btnAbsenceAjout.TabIndex = 15;
            btnAbsenceAjout.Text = "Ajouter";
            btnAbsenceAjout.UseVisualStyleBackColor = true;
            // 
            // lblMotif
            // 
            lblMotif.AutoSize = true;
            lblMotif.Location = new Point(163, 72);
            lblMotif.Name = "lblMotif";
            lblMotif.Size = new Size(36, 15);
            lblMotif.TabIndex = 11;
            lblMotif.Text = "Motif";
            // 
            // txtboxFin
            // 
            txtboxFin.Location = new Point(215, 30);
            txtboxFin.Name = "txtboxFin";
            txtboxFin.Size = new Size(100, 23);
            txtboxFin.TabIndex = 12;
            // 
            // cmbMotif
            // 
            cmbMotif.FormattingEnabled = true;
            cmbMotif.Location = new Point(215, 69);
            cmbMotif.Name = "cmbMotif";
            cmbMotif.Size = new Size(100, 23);
            cmbMotif.TabIndex = 10;
            // 
            // lblDateFin
            // 
            lblDateFin.AutoSize = true;
            lblDateFin.Location = new Point(181, 35);
            lblDateFin.Name = "lblDateFin";
            lblDateFin.Size = new Size(23, 15);
            lblDateFin.TabIndex = 14;
            lblDateFin.Text = "Fin";
            // 
            // txtboxDebut
            // 
            txtboxDebut.Location = new Point(49, 30);
            txtboxDebut.Name = "txtboxDebut";
            txtboxDebut.Size = new Size(100, 23);
            txtboxDebut.TabIndex = 10;
            // 
            // lblDateDebut
            // 
            lblDateDebut.AutoSize = true;
            lblDateDebut.Location = new Point(6, 35);
            lblDateDebut.Name = "lblDateDebut";
            lblDateDebut.Size = new Size(39, 15);
            lblDateDebut.TabIndex = 11;
            lblDateDebut.Text = "Début";
            // 
            // FrmGestion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(594, 555);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(grpAbsences);
            Controls.Add(grpPersonnel);
            Name = "FrmGestion";
            Text = "MediaTek86 - Gestion";
            grpPersonnel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvPersonnel).EndInit();
            ((System.ComponentModel.ISupportInitialize)bddManagerBindingSource).EndInit();
            grpAbsences.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvAbsences).EndInit();
            ((System.ComponentModel.ISupportInitialize)bddManagerBindingSource1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpPersonnel;
        private GroupBox grpAbsences;
        private Button btnAfficherAbsences;
        private BindingSource bddManagerBindingSource;
        private BindingSource bddManagerBindingSource1;
        private DataGridView dgvAbsences;
        private DataGridView dgvPersonnel;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private TextBox txtboxNom;
        private TextBox txtboxPrenom;
        private Label lblNom;
        private Label lblPrenom;
        private Label llbMail;
        private Label lblTel;
        private TextBox txtboxMail;
        private TextBox txtboxTel;
        private Label lblService;
        private ComboBox cmbService;
        private TextBox txtboxFin;
        private Label lblDateFin;
        private TextBox txtboxDebut;
        private Label lblDateDebut;
        private Label lblMotif;
        private ComboBox cmbMotif;
        private Button btnAbsenceAjout;
        private Button btnAbsencesModifier;
        private Button btnAbsencesSupprimer;
        private Button btnPersonnelSupprimer;
        private Button btnPersonnelModifier;
        private Button btnPersonnelAjout;
    }
}