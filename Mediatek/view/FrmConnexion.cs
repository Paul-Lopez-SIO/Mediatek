using Mediatek.controller;
using Mediatek.model;

namespace Mediatek.view
{
    public partial class FrmConnexion : Form
    {
        /// <summary>
        /// Contrôleur de la fenêtre
        /// </summary>
        private FrmConnexionController controller;

        /// <summary>
        /// Initialisations
        /// </summary>
        public FrmConnexion()
        {
            InitializeComponent();
            Init();
        }
        /// <summary>
        /// Etape d'initialisation : création du controlleur.
        /// </summary>
        private void Init()
        {
            controller = new FrmConnexionController();
        }

        /// <summary>
        /// Demande au controlleur de contrôler la connexion.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConnecter_Click(object sender, EventArgs e)
        {
            String login = txtboxLogin.Text;
            String mdp = txtboxMdp.Text;
            if (String.IsNullOrEmpty(login) || String.IsNullOrEmpty(mdp))
            {
                MessageBox.Show("Tous les champs doivent être remplis.", "Information");
            }
            else
            {
                Admin admin = new Admin(login, mdp);
                if (controller.ControleAuthentification(admin))
                {
                    FrmGestion frm = new FrmGestion();
                    frm.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Authentification incorrecte ou vous n'êtes pas admin", "Alerte");
                }
            }
        }
    }
}
