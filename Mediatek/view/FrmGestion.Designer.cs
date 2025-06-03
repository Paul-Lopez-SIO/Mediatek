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
            grpPersonnel = new GroupBox();
            grpAbsences = new GroupBox();
            btnAjoutPersonnel = new Button();
            btnModifierPersonnel = new Button();
            btnSupprimerPersonnel = new Button();
            btnSupprimerAbsence = new Button();
            btnModifierAbsence = new Button();
            btnAjouterAbsence = new Button();
            btnAfficherAbsences = new Button();
            SuspendLayout();
            // 
            // grpPersonnel
            // 
            grpPersonnel.Location = new Point(12, 12);
            grpPersonnel.Name = "grpPersonnel";
            grpPersonnel.Size = new Size(516, 212);
            grpPersonnel.TabIndex = 0;
            grpPersonnel.TabStop = false;
            grpPersonnel.Text = "Personnel";
            // 
            // grpAbsences
            // 
            grpAbsences.Location = new Point(12, 230);
            grpAbsences.Name = "grpAbsences";
            grpAbsences.Size = new Size(240, 144);
            grpAbsences.TabIndex = 1;
            grpAbsences.TabStop = false;
            grpAbsences.Text = "Absences";
            // 
            // btnAjoutPersonnel
            // 
            btnAjoutPersonnel.Location = new Point(258, 237);
            btnAjoutPersonnel.Name = "btnAjoutPersonnel";
            btnAjoutPersonnel.Size = new Size(132, 23);
            btnAjoutPersonnel.TabIndex = 2;
            btnAjoutPersonnel.Text = "Ajouter personnel";
            btnAjoutPersonnel.UseVisualStyleBackColor = true;
            // 
            // btnModifierPersonnel
            // 
            btnModifierPersonnel.Location = new Point(258, 269);
            btnModifierPersonnel.Name = "btnModifierPersonnel";
            btnModifierPersonnel.Size = new Size(132, 23);
            btnModifierPersonnel.TabIndex = 3;
            btnModifierPersonnel.Text = "Modifier personnel";
            btnModifierPersonnel.UseVisualStyleBackColor = true;
            // 
            // btnSupprimerPersonnel
            // 
            btnSupprimerPersonnel.Location = new Point(258, 300);
            btnSupprimerPersonnel.Name = "btnSupprimerPersonnel";
            btnSupprimerPersonnel.Size = new Size(132, 23);
            btnSupprimerPersonnel.TabIndex = 4;
            btnSupprimerPersonnel.Text = "Supprimer personnel";
            btnSupprimerPersonnel.UseVisualStyleBackColor = true;
            // 
            // btnSupprimerAbsence
            // 
            btnSupprimerAbsence.Location = new Point(396, 300);
            btnSupprimerAbsence.Name = "btnSupprimerAbsence";
            btnSupprimerAbsence.Size = new Size(132, 23);
            btnSupprimerAbsence.TabIndex = 7;
            btnSupprimerAbsence.Text = "Supprimer absence";
            btnSupprimerAbsence.UseVisualStyleBackColor = true;
            // 
            // btnModifierAbsence
            // 
            btnModifierAbsence.Location = new Point(396, 269);
            btnModifierAbsence.Name = "btnModifierAbsence";
            btnModifierAbsence.Size = new Size(132, 23);
            btnModifierAbsence.TabIndex = 6;
            btnModifierAbsence.Text = "Modifier absence";
            btnModifierAbsence.UseVisualStyleBackColor = true;
            // 
            // btnAjouterAbsence
            // 
            btnAjouterAbsence.Location = new Point(396, 237);
            btnAjouterAbsence.Name = "btnAjouterAbsence";
            btnAjouterAbsence.Size = new Size(132, 23);
            btnAjouterAbsence.TabIndex = 5;
            btnAjouterAbsence.Text = "Ajouter absence";
            btnAjouterAbsence.UseVisualStyleBackColor = true;
            // 
            // btnAfficherAbsences
            // 
            btnAfficherAbsences.Location = new Point(258, 329);
            btnAfficherAbsences.Name = "btnAfficherAbsences";
            btnAfficherAbsences.Size = new Size(270, 45);
            btnAfficherAbsences.TabIndex = 8;
            btnAfficherAbsences.Text = "Afficher absences";
            btnAfficherAbsences.UseVisualStyleBackColor = true;
            // 
            // FrmGestion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(535, 386);
            Controls.Add(btnAfficherAbsences);
            Controls.Add(btnSupprimerAbsence);
            Controls.Add(btnModifierAbsence);
            Controls.Add(btnAjouterAbsence);
            Controls.Add(btnSupprimerPersonnel);
            Controls.Add(btnModifierPersonnel);
            Controls.Add(btnAjoutPersonnel);
            Controls.Add(grpAbsences);
            Controls.Add(grpPersonnel);
            Name = "FrmGestion";
            Text = "MediaTek86 - Gestion";
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpPersonnel;
        private GroupBox grpAbsences;
        private Button btnAjoutPersonnel;
        private Button btnModifierPersonnel;
        private Button btnSupprimerPersonnel;
        private Button btnSupprimerAbsence;
        private Button btnModifierAbsence;
        private Button btnAjouterAbsence;
        private Button btnAfficherAbsences;
    }
}