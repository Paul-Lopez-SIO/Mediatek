using Mediatek.dal;
using Mediatek.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Mediatek.controller
{
    /// <summary>
    /// controlleur de la page principale, "gestion".
    /// </summary>
    public class FrmGestionController
    {
        /// <summary>
        /// objet d'accès aux opérations possibles sur Developpeur
        /// </summary>
        private readonly AccessPersonnel accessPersonnel;
        /// <summary>
        /// Récupère les accès aux données
        /// </summary>
        public FrmGestionController()
        {
            accessPersonnel = new AccessPersonnel();
        }
        /// <summary>
        /// Récupère le personnel.
        /// </summary>
        /// <returns>Récupère la liste du personnel.</returns>
        public List<Personnel> GetLePersonnel()
        {
            return accessPersonnel.GetLePersonnel();
        }
        /// <summary>
        /// Demande d'ajout d'un personnel
        /// </summary>
        /// <param name="personnel">objet personnel à ajouter</param>
        public void AddPersonnel(Personnel personnel)
        {
            accessPersonnel.AddPersonnel(personnel);
        }

        /// <summary>
        /// retourne les services
        /// </summary>
        /// <returns>retourne les services</returns>
        public List<Service> GetLesServices()
        {
            return accessPersonnel.GetLesServices();
        }
        /// <summary>
        /// Demande de suppression d'un personnel
        /// </summary>
        /// <param name="personnel">objet personnel à supprimer</param>
        public void DelPersonnel(Personnel personnel)
        {
            accessPersonnel.DelPersonnel(personnel);
        }
        /// <summary>
        /// Demande de modification d'un personnel
        /// </summary>
        /// <param name="personnel">objet personnel à modifier</param>
        public void UpdatePersonnel(Personnel personnel)
        {
            accessPersonnel.UpdatePersonnel(personnel);
        }
    }
}
