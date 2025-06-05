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
                controller.UpdatePersonnel(personnel);
                RemplirListePersonnel();
            }
            else
            {
                MessageBox.Show("Tous les champs doivent être remplis.", "Information");
            }
        }
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
    }
}
