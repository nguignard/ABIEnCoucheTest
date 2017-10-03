/***********************************************************************
 * Module:  Stagiaire.cs
 * Author:  CDI14
 * Purpose: Definition of the Class Stagiaire
 ***********************************************************************/

using System;


namespace ABIEnCouches
{
    public class Stagiaire : ContratTemporaire
    {
        private String ecole;
        private String mission;

        public Stagiaire(String ecole, String mission, 
            String motif, DateTime dateDebutContrat, DateTime datFinContrat, String qualification, String statut,  Decimal salaireContractuel) : 
            base(   dateDebutContrat,  qualification,  statut,  salaireContractuel,  datFinContrat,  motif)
        {
            this.ecole = Ecole;
            this.Mission = Mission;
        }


        public Stagiaire(int mat, String ecole, String mission,
           String motif, DateTime dateDebutContrat, DateTime datFinContrat, String qualification, String statut, Decimal salaireContractuel) :
           base(mat, dateDebutContrat, qualification, statut, salaireContractuel, datFinContrat, motif)
        {
            this.ecole = Ecole;
            this.Mission = Mission;
        }



        public override String ToString()
        {
           
            return "Stage : Ecole " + Ecole+ " Mission " + Mission;
        }


        public String Ecole
        {
            get
            {
                return ecole;
            }
            set
            {
                if (this.ecole != value)
                    this.ecole = value;
            }
        }

        public String Mission
        {
            get
            {
                return mission;
            }
            set
            {
                if (this.mission != value)
                    this.mission = value;
            }
        }

    }
}