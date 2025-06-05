
using Mediatek.model;
using Microsoft.VisualBasic.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Threading.Tasks;

namespace Mediatek.dal
{
    public class AccessPersonnel
    {
        /// <summary>
        /// Instance unique de l'accès aux données
        /// </summary>
        private readonly Access access = null;

        /// <summary>
        /// Constructeur pour créer l'accès aux données
        /// </summary>
        public AccessPersonnel()
        {
            access = Access.GetInstance();
        }

        /// <summary>
        /// Controle si l'utillisateur a le droit de se connecter (login, password)
        /// </summary>
        /// <param name="login"></param>
        /// <param name="mdp"></param>
        /// <returns>vrai si l'utilisateur a le profil "admin"</returns>
        public Boolean ControleConnexion(Admin admin)
        {
            if (access.Manager != null)
            {
                Dictionary<string, object> parameters = new Dictionary<string, object> {
                    { "@login", admin.Login },
                    { "@pwd", admin.Mdp }
                };
                string req = "select * from responsable";
                req += " where login = @login and pwd = SHA2(@pwd, 256);";
                    List<Object[]> records = access.Manager.ReqSelect(req, parameters);
                    if (records != null)
                    {
                        return (records.Count > 0);
                    }

            }
            return false;
        }
        /// <summary>
        /// Récupère le personnel.
        /// </summary>
        /// <returns>la liste du personnel</returns>
        public List<Personnel> GetLePersonnel()
        {
            List<Personnel> lePersonnel = new List<Personnel>();
            if (access.Manager != null)
            {
                string req = "SELECT idpersonnel, personnel.nom as nom, personnel.prenom as prenom, personnel.tel as tel, personnel.mail as mail, service.nom as nomservice, personnel.idservice as idservice FROM personnel JOIN service ON personnel.idservice = service.idservice ORDER BY nom, prenom;";
                List<Object[]> records = access.Manager.ReqSelect(req);
                if (records != null)
                {
                    foreach (Object[] record in records)
                    {
                        Personnel personnel = new Personnel((int)record[0], (string)record[1], (string)record[2], (string)record[3], (string)record[4], (string)record[5], (int)record[6]);
                        lePersonnel.Add(personnel);
                    }
                }
            }
            return lePersonnel;
        }
        /// <summary>
        /// Demande d'ajout un personnel
        /// </summary>
        /// <param name="personnel">objet personnel à ajouter</param>
        public void AddPersonnel(Personnel personnel)
        {
            if (access.Manager != null)
            {
                string req = "insert into personnel(nom, prenom, tel, mail, idservice) ";
                req += "values (@nom, @prenom, @tel, @mail, @idservice);";
                Dictionary<string, object> parameters = new Dictionary<string, object> {
                    { "@nom", personnel.Nom },
                    { "@prenom", personnel.Prenom },
                    { "@tel", personnel.Tel },
                    { "@mail", personnel.Mail },
                    { "@idservice", personnel.Idservice },
                };
                access.Manager.ReqUpdate(req, parameters);
            }
        }
        /// <summary>
        /// récupère les services
        /// </summary>
        /// <returns>une liste des services</returns>
        public List<Service> GetLesServices()
        {
            List<Service> lesServices = new List<Service>();
            if (access.Manager != null)
            {
                string req = "SELECT idservice, nom FROM service;";
                List<Object[]> records = access.Manager.ReqSelect(req);
                if (records != null)
                {
                    foreach (Object[] record in records)
                    {
                        Service service = new Service((int)record[0], (string)record[1]);
                        lesServices.Add(service);
                    }
                }
            }
            return lesServices;
        }
        /// <summary>
        /// récupère les motifs
        /// </summary>
        /// <returns>une liste des motifs</returns>
        public List<Motif> GetLesMotifs()
        {
            List<Motif> lesMotifs = new List<Motif>();
            if (access.Manager != null)
            {
                string req = "SELECT idmotif, libelle FROM motif;";
                List<Object[]> records = access.Manager.ReqSelect(req);
                if (records != null)
                {
                    foreach (Object[] record in records)
                    {
                        Motif motif = new Motif((int)record[0], (string)record[1]);
                        lesMotifs.Add(motif);
                    }
                }
            }
            return lesMotifs;
        }
        /// <summary>
        /// Demande de suppression d'un personnel
        /// </summary>
        /// <param name="personnel">objet developpeur à supprimer</param>
        public void DelPersonnel(Personnel personnel)
        {
            if (access.Manager != null)
            {
                string req = "delete from personnel where idpersonnel = @idpersonnel;";
                Dictionary<string, object> parameters = new Dictionary<string, object> {
                    {"@idpersonnel", personnel.Idpersonnel }
                };
                access.Manager.ReqUpdate(req, parameters);

            }
        }
        /// <summary>
        /// Demande de modification d'un personnel
        /// </summary>
        /// <param name="personnel">objet personnel à modifier</param>
        public void UpdatePersonnel(Personnel personnel)
        {
            if (access.Manager != null)
            {
                string req = "update personnel set nom = @nom, prenom = @prenom, tel = @tel, mail = @mail, idservice = @idservice ";
                req += "where idpersonnel = @idpersonnel;";
                Dictionary<string, object> parameters = new Dictionary<string, object> {
                    { "@idpersonnel", personnel.Idpersonnel },
                    { "@nom", personnel.Nom },
                    { "@prenom", personnel.Prenom },
                    { "@tel", personnel.Tel },
                    { "@mail", personnel.Mail },
                    { "@idservice", personnel.Idservice }
                };
                access.Manager.ReqUpdate(req, parameters);
            }
        }
    }
}
