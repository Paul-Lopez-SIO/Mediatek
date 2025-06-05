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
        /// objet d'accès aux opérations possibles sur Personnel
        /// </summary>
        private readonly AccessPersonnel accessPersonnel;
        /// <summary>
        /// objet d'accès aux opérations possibles sur Absence
        /// </summary>
        private readonly AccessAbsence accessAbsence;
        /// <summary>
        /// Récupère les accès aux données
        /// </summary>
        public FrmGestionController()
        {
            accessPersonnel = new AccessPersonnel();
            accessAbsence = new AccessAbsence();
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
        /// retourne les motifs
        /// </summary>
        /// <returns>retourne les motifs</returns>
        public List<Motif> GetLesMotifs()
        {
            return accessPersonnel.GetLesMotifs();
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
        /// <summary>
        /// Récupère la liste des absences d’un personnel.
        /// </summary>
        /// <param name="idPersonnel">ID du personnel</param>
        /// <returns>Liste d'objets Absence</returns>
        public List<Absence> GetAbsences(int idPersonnel)
        {
            return accessAbsence.GetAbsences(idPersonnel);
        }
        /// <summary>
        /// Demande d'ajout une absence
        /// </summary>
        /// <param name="absence">objet absence à ajouter</param>
        public void AddAbsence(Absence absence)
        {
            accessAbsence.AddAbsence(absence);
        }
        /// <summary>
        /// met à jour la liste des absences
        /// </summary>
        /// <param name="absence"></param>
        public void UpdateAbsence(Absence nouvelleAbsence, Absence ancienneAbsence)
        {
            accessAbsence.UpdateAbsence( nouvelleAbsence,  ancienneAbsence);
        }
        /// <summary>
        /// Demande de suppression d'une absence
        /// </summary>
        /// <param name="absence">Objet absence à supprimer</param>
        public void DelAbsence(Absence absence)
        {
            accessAbsence.DelAbsence( absence);
        }
    }
}
