using Mediatek.controller;
using Mediatek.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mediatek.view
{
    public partial class FrmGestion : Form
    {
        /// <summary>
        /// Controleur de la fenêtre
        /// </summary>
        private FrmGestionController controller;
        /// <summary>
        /// Objet pour gérer la liste du personnel
        /// </summary>
        private readonly BindingSource bdgPersonnel = new BindingSource();
        /// <summary>
        /// objet pour gérer la liste des absences
        /// </summary>
        private readonly BindingSource bdgAbsences = new BindingSource();
        /// <summary>
        /// construction des composants graphiques et appel des autres initialisations
        /// </summary>
        public FrmGestion()
        {
            InitializeComponent();
            Init();
            RemplirListePersonnel();

        }
        /// <summary>
        /// Initialisations :
        /// Création du controleur et remplissage des listes
        /// </summary>
        private void Init()
        {
            controller = new FrmGestionController();
            cmbService.DataSource = controller.GetLesServices();
            cmbService.DisplayMember = "Nom";
            cmbService.ValueMember = "Idservice";

            cmbMotif.DataSource = controller.GetLesMotifs();
            cmbMotif.DisplayMember = "libelle";
            cmbMotif.ValueMember = "Idmotif";
            btnAbsenceAjout.Enabled = false;
            btnAbsencesModifier.Enabled = false;
            btnAbsencesSupprimer.Enabled = false;

        }
        /// <summary>
        /// Affiche la liste du personnel.
        /// </summary>
        private void RemplirListePersonnel()
        {
            List<Personnel> lePersonnel = controller.GetLePersonnel();
            dgvPersonnel.DataSource = null;
            bdgPersonnel.DataSource = lePersonnel;
            dgvPersonnel.DataSource = bdgPersonnel;
            dgvPersonnel.Columns["idpersonnel"].Visible = false;
            dgvPersonnel.Columns["idservice"].Visible = false;
            dgvPersonnel.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }
        /// <summary>
        /// Affiche la liste des absences
        /// </summary>
        private void RemplirListeAbsence()
        {
            int idPersonnel = (int)dgvPersonnel.SelectedRows[0].Cells["idpersonnel"].Value;
            List<Absence> absences = controller.GetAbsences(idPersonnel);
            dgvAbsences.DataSource = null;
            bdgAbsences.DataSource = absences;
            dgvAbsences.DataSource = bdgAbsences;
            dgvAbsences.Columns["idpersonnel"].Visible = false;
            dgvAbsences.Columns["idmotif"].Visible = false;
            dgvAbsences.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }
        /// <summary>
        /// Ajouter un personnel.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button3_Click(object sender, EventArgs e)
        {
            Service service = (Service)cmbService.SelectedItem;
            if (!txtboxNom.Text.Equals("") && !txtboxPrenom.Text.Equals("") && !txtboxTel.Text.Equals("") && !txtboxMail.Text.Equals("") && cmbService.SelectedIndex != -1)
            {

                Personnel personnel = new Personnel(
                    0,
                    txtboxNom.Text,
                    txtboxPrenom.Text,
                    txtboxTel.Text,
                    txtboxMail.Text,
                    service.Nom,
                    service.Idservice
                );
                controller.AddPersonnel(personnel);
                RemplirListePersonnel();
            }
            else
            {
                MessageBox.Show("Tous les champs doivent être remplis.", "Information");
            }
        }
        /// <summary>
        /// Action de modifier un personnel
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPersonnelModifier_Click(object sender, EventArgs e)
        {
            if (dgvPersonnel.SelectedRows.Count > 0)
            {
                int idPersonnel = (int)dgvPersonnel.SelectedRows[0].Cells["idpersonnel"].Value;
                Service service = (Service)cmbService.SelectedItem;
                Personnel personnel = new Personnel(
                        idPersonnel,
                        txtboxNom.Text,
                        txtboxPrenom.Text,
                        txtboxTel.Text,
                        txtboxMail.Text,
                        service.Nom,
                        service.Idservice
                    );
                if (MessageBox.Show("Voulez-vous modifier " + personnel.Nom + " " + personnel.Prenom + " ?", "Confirmation de modification", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    controller.UpdatePersonnel(personnel);
                    RemplirListePersonnel();

                }
            }
            else
            {
                MessageBox.Show("Tous les champs doivent être remplis.", "Information");
            }
        }
        /// <summary>
        /// Action de supprimer un personnel
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPersonnelSupprimer_Click(object sender, EventArgs e)
        {
            if (dgvPersonnel.SelectedRows.Count > 0)
            {
                Personnel personnel = (Personnel)bdgPersonnel.List[bdgPersonnel.Position];
                if (MessageBox.Show("Voulez-vous vraiment supprimer " + personnel.Nom + " " + personnel.Prenom + " ?", "Confirmation de suppression", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    controller.DelPersonnel(personnel);
                    RemplirListePersonnel();
                }
            }
            else
            {
                MessageBox.Show("Une ligne doit être sélectionnée.", "Attention");
            }
        }
        /// <summary>
        /// Ajoute le personnel sélectionné aux champs "gestion personnel".
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvPersonnel_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvPersonnel.SelectedRows.Count == 1)
            {
                Personnel personnel = (Personnel)bdgPersonnel.List[bdgPersonnel.Position];
                txtboxNom.Text = personnel.Nom;
                txtboxPrenom.Text = personnel.Prenom;
                txtboxTel.Text = personnel.Tel;
                txtboxMail.Text = personnel.Mail;
                cmbService.Text = personnel.Nomservice;

                btnAbsenceAjout.Enabled = false;
                btnAbsencesModifier.Enabled = false;
                btnAbsencesSupprimer.Enabled = false;
                btnAfficherAbsences.Enabled = true;
            }
            else
            {
                txtboxNom.Text = "";
                txtboxPrenom.Text = "";
                txtboxTel.Text = "";
                txtboxMail.Text = "";
                cmbService.Text = "";
            }
        }
        /// <summary>
        /// Affiche les absences d'un personnel sélectionné
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAfficherAbsences_Click(object sender, EventArgs e)
        {
            if (dgvPersonnel.SelectedRows.Count == 1)
            {
                btnAbsenceAjout.Enabled = true;
                btnAbsencesModifier.Enabled = true;
                btnAbsencesSupprimer.Enabled = true;
                btnAfficherAbsences.Enabled = false;

                RemplirListeAbsence();
            }

            else
            {
                MessageBox.Show("Une seule ligne doit être sélectionnée.", "Attention");
            }
        }

        private void btnAbsenceAjout_Click(object sender, EventArgs e)
        {
            Motif motif = (Motif)cmbMotif.SelectedItem;
            if (!txtboxNom.Text.Equals("") && !txtboxPrenom.Text.Equals("") && !txtboxTel.Text.Equals("") && !txtboxMail.Text.Equals("") && cmbService.SelectedIndex != -1)
            {
                int idPersonnel = (int)dgvPersonnel.SelectedRows[0].Cells["idpersonnel"].Value;
                DateTime dateDebut = dtpDebut.Value.Date;
                DateTime dateFin = dtpFin.Value.Date;

                List<Absence> absencesExistantes = controller.GetAbsences(idPersonnel);
                bool existeDeja = absencesExistantes.Any(a => a.DateDebut == dateDebut && a.DateFin == dateFin);

                if (existeDeja)
                {
                    MessageBox.Show("Une absence existe déjà pour cette date et ce personnel.", "Erreur");
                }
                else if (dateFin < dateDebut)
                {
                    MessageBox.Show("La date de début doit être antérieure à la date de fin de l'absence.", "Erreur");
                }
                else
                {
                    Absence absence = new Absence(
                        idPersonnel,
                        dateDebut,
                        dateFin,
                        motif.Idmotif,
                        motif.Libelle
                    );
                    controller.AddAbsence(absence);
                    RemplirListeAbsence();
                }
            }
            else
            {
                MessageBox.Show("Tous les champs doivent être remplis.", "Information");
            }
        }
        /// <summary>
        /// Action de modifier une absence
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAbsencesModifier_Click(object sender, EventArgs e)
        {
            if (dgvAbsences.SelectedRows.Count == 0)
            {
                MessageBox.Show("Sélectionnez une absence à modifier.", "Attention");
                return;
            }

            Motif motif = (Motif)cmbMotif.SelectedItem;
            int idPersonnel = (int)dgvPersonnel.SelectedRows[0].Cells["idpersonnel"].Value;

            DateTime newDebut = dtpDebut.Value.Date;
            DateTime newFin = dtpFin.Value.Date;

            Absence ancienneAbsence = (Absence)bdgAbsences.List[bdgAbsences.Position];

            Absence nouvelleAbsence = new Absence(
                idPersonnel,
                newDebut,
                newFin,
                motif.Idmotif,
                motif.Libelle
            );

            List<Absence> absencesExistantes = controller.GetAbsences(idPersonnel);
            bool existeDeja = absencesExistantes.Any(a =>
                a.DateDebut == newDebut &&
                a.IdPersonnel == idPersonnel &&
                (a.DateDebut != ancienneAbsence.DateDebut || a.IdPersonnel != ancienneAbsence.IdPersonnel));

            if (existeDeja)
            {
                MessageBox.Show("Une absence existe déjà pour cette date et ce personnel.", "Erreur");
                return;
            }

            if (MessageBox.Show("Voulez-vous modifier cette absence ?", "Confirmation de modification", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                controller.UpdateAbsence(nouvelleAbsence, ancienneAbsence);
                RemplirListeAbsence();
            }
        }

        private void btnAbsencesSupprimer_Click(object sender, EventArgs e)
        {
            if (dgvAbsences.SelectedRows.Count > 0)
            {
                Absence absence = (Absence)bdgAbsences.List[bdgAbsences.Position];

                string message = $"Voulez-vous vraiment supprimer cette absence ?";
                if (MessageBox.Show(message, "Confirmation de suppression", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    controller.DelAbsence(absence);
                    RemplirListeAbsence();
                }
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner une absence à supprimer.", "Information");
            }
        }
    }
}
