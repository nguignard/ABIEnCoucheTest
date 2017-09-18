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
        public static void InstancieCollaborateursCollab(Collaborateur Collab)
        {
            if(DonneesDao.DbContextEntreprise == null)
            {
                DonneesDao.DbContextEntreprise = new EntrepriseContainer();
            }

            var query = from a in DonneesDao.DbContextEntreprise.ContratTypeESet
                        select a;

            ContratType LeContratType;

            foreach(ContratTypeE item in query)
            {
                if(item is CdiE)
                {
                    LeContratType = new Cdi(item.dateDebutE,item.qualificationE,item.statutE,item.salaireE);
                }

                if(item is CddE)
                {
                    LeContratType = new Cdd(item.dateDebutE, item.qualificationE, item.statutE, item.salaireE, ((CddE)item).dateFinE, ((CddE)item).motifE);
                }

                if(item is StageE)
                {
                    LeContratType = new Stagiaire(((StageE)item).ecoleE, ((StageE)item).missionE, ((StageE)item).motifE, item.dateDebutE, ((StageE)item).dateFinE , item.qualificationE, item.statutE, item.salaireE);
                }



            }


            


        }

        





    }
}
