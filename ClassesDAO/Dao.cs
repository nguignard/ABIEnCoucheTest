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


                listeCollaborateurs.AddCollaborateur(leCollab);
            }
        }




        public static void InstancieContratsCollaborateur(Collaborateur leCollaborateur)
        {
            if(DonneesDao.DbContextEntreprise == null)
            {
                DonneesDao.DbContextEntreprise = new EntrepriseContainer();
            }

            var query = from a in DonneesDao.DbContextEntreprise.ContratTypeESet
                        //where a.
                        select a;



            ContratType LeContratType = null;

            foreach(ContratTypeE item in query)
            {
                if(item is CdiE)
                {
                    LeContratType = new Cdi(item.dateDebutE,item.qualificationE.Trim(),item.statutE.Trim(),item.salaireE);
                }

                if(item is CddE)
                {
                    LeContratType = new Cdd(item.dateDebutE, item.qualificationE.Trim(), item.statutE.Trim(), item.salaireE, ((CddE)item).dateFinE, ((CddE)item).motifE.Trim());
                }

                if(item is StageE)
                {
                    LeContratType = new Stagiaire(((StageE)item).ecoleE.Trim(), ((StageE)item).missionE.Trim(), ((StageE)item).motifE.Trim(), item.dateDebutE, ((StageE)item).dateFinE , item.qualificationE.Trim(), item.statutE.Trim(), item.salaireE);
                }

                Console.WriteLine(item.ToString());

            }

            leCollaborateur.AddContrat(LeContratType);
            


        }

        





    }
}
