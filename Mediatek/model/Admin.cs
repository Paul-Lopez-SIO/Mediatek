using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediatek.model
{
    /// <summary>
    /// Classe métier interne qui mémorise les données de connexion (nom, prénom, mot de passe).
    /// </summary>
    public class Admin
    {
        public string Login { get; }
        public string Mdp { get; }

        /// <summary>
        /// Valorise les propriétés
        /// </summary>
        /// <param name="nom"></param>
        /// <param name="prenom"></param>
        /// <param name="mdp"></param>
        public Admin(string login, string mdp)
        {
            this.Login = login;
            this.Mdp = mdp;
        }
    }
}

