using ABIEnCouches;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesDAO
{
    public class Dao
    {

        /// <summary>
        /// instancieCollaborateurs: créer la liste des collaborateurs depuis la BD
        /// </summary>
        /// <param name="listeCollaborateurs"></param>
        public static void instancieCollaborateurs(Collaborateurs listeCollaborateurs)
        {
            if (DonneesDao.DbContextEntreprise == null)
            {
                DonneesDao.DbContextEntreprise = new EntrepriseContainer();
            }

            //var query = from a in DonneesDao.DbContextEntreprise.CollaborateursESet
            //            select a;
                       
            Collaborateur leCollab = null;

            foreach(CollaborateursE item in DonneesDao.DbContextEntreprise.CollaborateursESet)
            {
                leCollab = new Collaborateur(item.civiliteE, item.nomE, item.prenomE, item.situationE, item.actifE);

                InstancieContratsCollaborateur(leCollab);
                listeCollaborateurs.AddCollaborateur(leCollab);
            }
        }

        /// <summary>
        /// InstancieContratsCollaborateur: ajoute les contrats d'un collaborateur à partir de la base de donnee
        /// </summary>
        /// <param name="leCollaborateur"></param>
        public static void InstancieContratsCollaborateur(Collaborateur leCollaborateur)
        {
            if(DonneesDao.DbContextEntreprise == null)
            {
                DonneesDao.DbContextEntreprise = new EntrepriseContainer();
            }

            var query = from b in DonneesDao.DbContextEntreprise.ContratTypeESet
                        where b.CollaborateurEntity.matriculeE == leCollaborateur.Matricule
                        select b;

            ContratType LeContratType = null;

            foreach(ContratTypeE item in query)
            {
                if(item is CdiE)
                {
                    LeContratType = new Cdi(item.idContratE, item.dateDebutE,item.qualificationE.Trim(),item.statutE.Trim(),item.salaireE);
                }

                if(item is CddE)
                {
                    LeContratType = new Cdd(item.idContratE, item.dateDebutE, item.qualificationE.Trim(), item.statutE.Trim(), item.salaireE, ((CddE)item).dateFinE, ((CddE)item).motifE.Trim());
                }

                if(item is StageE)
                {
                    LeContratType = new Stagiaire(item.idContratE, ((StageE)item).ecoleE.Trim(), ((StageE)item).missionE.Trim(), ((StageE)item).motifE.Trim(), item.dateDebutE, ((StageE)item).dateFinE , item.qualificationE.Trim(), item.statutE.Trim(), item.salaireE);
                }

                Console.WriteLine(item.ToString());
                leCollaborateur.AddContrat(LeContratType);

            }

         
            


        }





        public static void AddCollaborateur(Collaborateur leCollaborateur)
        {
            if(DonneesDao.DbContextEntreprise == null)
            {
                DonneesDao.DbContextEntreprise = new EntrepriseContainer();
            }
            CollaborateursE c = new CollaborateursE(leCollaborateur.Matricule, leCollaborateur.Civilite, leCollaborateur.NomCollab, leCollaborateur.PrenomCollab, leCollaborateur.SituationFamiliale, leCollaborateur.Photo, leCollaborateur.Actif);

            try
            {
                DonneesDao.DbContextEntreprise.CollaborateursESet.Add(c);
                DonneesDao.DbContextEntreprise.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }

            


        }






    }
}
