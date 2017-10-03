using ABIEnCouches;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesDAO
{

    /// <summary>
    /// Classe DAO de fonctions statics permettant d'acceder aux entitées 
    /// </summary>
    public class Dao
    {

        /// <summary>
        /// instancieCollaborateurs: créer la liste des collaborateurs depuis la BD
        /// </summary>
        /// <param name="listeCollaborateurs"></param>
        public static void instancieCollaborateurs(Collaborateurs listeCollaborateurs)
        {
            //Collaborateurs Abi = null;

            //ServiceABI.Collaborateur unCollaborateur = DonneesDao.DbContextEntreprise.GetCollaborateurs();

            //foreach(CollaborateursE item in DonneesDao.DbContextEntreprise.CollaborateursESet)
            //{
            //    leCollab = new Collaborateur(item.civiliteE, item.nomE, item.prenomE, item.situationE, item.actifE);

            //    InstancieContratsCollaborateur(leCollab);
            //    listeCollaborateurs.AddCollaborateur(leCollab);
            //}
        }

        /// <summary>
        /// InstancieContratsCollaborateur: ajoute les contrats d'un collaborateur à partir de la base de donnee
        /// </summary>
        /// <param name="leCollaborateur"></param>
        public static void InstancieContratsCollaborateur(Collaborateur leCollaborateur)
        {
            ContratType LeContratType = null;

            foreach(ServiceABI.ContratType item in DonneesDao.DbContextEntreprise.GetContratsCollaborateur(leCollaborateur.Matricule.ToString()))
            {
                if(item is ServiceABI.Cdi)
                {
                    LeContratType = new Cdi(item.IdContrat, item.DateDebutContrat,item.Qualification.Trim(),item.Statut.Trim(),item.SalaireContractuel);
                }

                if(item is ServiceABI.Cdd)
                {
                    LeContratType = new Cdd(item.IdContrat, item.DateDebutContrat, item.Qualification.Trim(), item.Statut.Trim(), item.SalaireContractuel, ((ServiceABI.Cdd)item).DateFinContrat, ((ServiceABI.Cdd)item).Motif.Trim());
                }

                if(item is ServiceABI.Stagiaire)
                {
                    LeContratType = new Stagiaire(item.IdContrat, ((ServiceABI.Stagiaire)item).Ecole.Trim(), ((ServiceABI.Stagiaire)item).Mission.Trim(), ((ServiceABI.Stagiaire)item).Motif.Trim(), item.DateDebutContrat, ((ServiceABI.Stagiaire)item).DateFinContrat , item.Qualification.Trim(), item.Statut.Trim(), item.SalaireContractuel);
                }
                leCollaborateur.AddContrat(LeContratType);

            }
        }




        /// <summary>
        /// Ajoute un Collaborateur avec sa liste de contrats à la liste des collaborateurs Entity FrameWork
        /// </summary>
        /// <param name="leCollaborateur"></param>
        public static void AddNewCollaborateur(Collaborateur leCollaborateur)
        {
         
            ContratType ct = leCollaborateur.ContratInitial();
            CollaborateursE collaborateurE = new CollaborateursE(leCollaborateur.Matricule, leCollaborateur.Civilite, leCollaborateur.NomCollab, leCollaborateur.PrenomCollab, leCollaborateur.SituationFamiliale, leCollaborateur.Photo, leCollaborateur.Actif);
            ContratTypeE contratE = toContratE(ct);
            contratE.CollaborateurEntity = collaborateurE; //Ajoute le contrat initial au collaborateur

            collaborateurE.ContratTypeE.Add(contratE);
            try
            {
                DonneesDao.DbContextEntreprise.CollaborateursESet.Add(collaborateurE);
                DonneesDao.DbContextEntreprise.SaveChanges();
            }
            catch (Exception )
            {
                //DonneesDao.DbContextEntreprise.CollaborateursESet.Remove(collaborateurE);
                //DonneesDao.DbContextEntreprise.SaveChanges();

                throw new Exception("le nouveau collaborateur n'a pu etre mis en DB");
            }
        }


        /// <summary>
        /// toContratE transforme un contrat Metier en contrat entityFrameWork
        /// </summary>
        /// <param name="unContrat"></param>
        /// <returns></returns>
        public static ContratTypeE toContratE(ContratType unContrat)
        {
            ContratTypeE contratE = null;

            if(unContrat is Cdi)
            {
                contratE = new CdiE(unContrat.IdContrat, unContrat.DateDebutContrat, unContrat.Qualification, unContrat.Statut, unContrat.SalaireContractuel, unContrat.FinReelContrat);
                            }
            else if(unContrat is Cdd)
            {
                contratE = new CddE(unContrat.IdContrat, unContrat.DateDebutContrat, unContrat.Qualification, unContrat.Statut, unContrat.SalaireContractuel, unContrat.FinReelContrat,
                    ((Cdd)unContrat).DateFinContrat, ((Cdd)unContrat).Motif);
            }
            else if(unContrat is Stagiaire)
            {
                contratE = new StageE(unContrat.IdContrat, unContrat.DateDebutContrat, unContrat.Qualification, unContrat.Statut, unContrat.SalaireContractuel, unContrat.FinReelContrat,
                   ((Stagiaire)unContrat).DateFinContrat, ((Stagiaire)unContrat).Motif,
                   ((Stagiaire)unContrat).Ecole, ((Stagiaire)unContrat).Mission
                   );
            }
            return contratE;
        }




    }
}
