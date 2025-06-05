using Mediatek.dal;
using Mediatek.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediatek.controller
{
    internal class FrmConnexionController
    {
        /// <summary>
        /// objet d'accès aux opérations possibles sur Developpeur
        /// </summary>
        private readonly AccessPersonnel accessPersonnel;

        /// <summary>
        /// Récupère l'acces aux données
        /// </summary>
        public FrmConnexionController()
        {
            accessPersonnel = new AccessPersonnel();
        }
        /// <summary>
        /// Vérifie l'authentification
        /// </summary>
        /// <param name="admin">objet contenant les informations de connexion</param>
        /// <returns> vrai si les informations de connexion sont correctes</returns>
        public Boolean ControleAuthentification(Admin admin)
        {
            return accessPersonnel.ControleConnexion(admin);
        }

    }
}
