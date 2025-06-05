using Mediatek.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediatek.dal
{
    public class AccessAbsence
    {
        private readonly Access access = null;

        public AccessAbsence()
        {
            access = Access.GetInstance();
        }

        /// <summary>
        /// Récupère la liste des absences d’un personnel.
        /// </summary>
        /// <param name="idPersonnel">ID du personnel</param>
        /// <returns>Liste d'objets Absence</returns>
        public List<Absence> GetAbsences(int idPersonnel)
        {
            List<Absence> lesAbsences = new List<Absence>();

            if (access.Manager != null)
            {
                string req = @"
                SELECT absence.idpersonnel, absence.datedebut, absence.datefin, absence.idmotif, motif.libelle 
                FROM absence
                JOIN motif ON absence.idmotif = motif.idmotif
                WHERE absence.idpersonnel = @idpersonnel;";
                Dictionary<string, object> parameters = new Dictionary<string, object>
                {
                    { "@idpersonnel", idPersonnel }
                };

                List<Object[]> records = access.Manager.ReqSelect(req, parameters);

                if (records != null)
                {
                    foreach (Object[] record in records)
                    {
                        Absence absence = new Absence(
                            (int)record[0],
                            Convert.ToDateTime(record[1]),
                            Convert.ToDateTime(record[2]),
                            (int)record[3],
                            (string)record[4]
                        );
                        lesAbsences.Add(absence);
                    }
                }
            }

            return lesAbsences;
        }
        /// <summary>
        /// Demande d'ajout une absence
        /// </summary>
        /// <param name="absence">objet absence à ajouter</param>
        public void AddAbsence(Absence absence)
        {
            if (access.Manager != null)
            {
                string req = "insert into absence(idpersonnel, datedebut, datefin, idmotif) ";
                req += "values (@idpersonnel, @datedebut, @datefin, @idmotif);";
                Dictionary<string, object> parameters = new Dictionary<string, object> {
                    { "@idpersonnel", absence.IdPersonnel },
                    { "@datedebut", absence.DateDebut },
                    { "@datefin", absence.DateFin },
                    { "@idmotif", absence.IdMotif },
                };
                access.Manager.ReqUpdate(req, parameters);
            }
        }
        /// <summary>
        /// met à jour la liste des absences
        /// </summary>
        /// <param name="absence"></param>
        public void UpdateAbsence(Absence nouvelleAbsence, Absence ancienneAbsence)
        {
            if (access.Manager != null)
            {
                string req = "UPDATE absence SET idpersonnel = @newId, datedebut = @newDebut, datefin = @newFin, idmotif = @newMotif " +
                             "WHERE idpersonnel = @oldId AND datedebut = @oldDebut;";

                Dictionary<string, object> parameters = new Dictionary<string, object>
        {
            { "@newId", nouvelleAbsence.IdPersonnel },
            { "@newDebut", nouvelleAbsence.DateDebut },
            { "@newFin", nouvelleAbsence.DateFin },
            { "@newMotif", nouvelleAbsence.IdMotif },
            { "@oldId", ancienneAbsence.IdPersonnel },
            { "@oldDebut", ancienneAbsence.DateDebut }
        };

                access.Manager.ReqUpdate(req, parameters);
            }
        }
        /// <summary>
        /// Demande de suppression d'une absence
        /// </summary>
        /// <param name="absence">Objet absence à supprimer</param>
        public void DelAbsence(Absence absence)
        {
            if (access.Manager != null)
            {
                string req = "DELETE FROM absence WHERE idpersonnel = @idpersonnel AND datedebut = @datedebut;";
                Dictionary<string, object> parameters = new Dictionary<string, object> {
            { "@idpersonnel", absence.IdPersonnel },
            { "@datedebut", absence.DateDebut }
        };
                access.Manager.ReqUpdate(req, parameters);
            }
        }

    }
}

