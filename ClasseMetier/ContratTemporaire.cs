/***********************************************************************
 * Module:  ContratTemporaire.cs
 * Author:  CDI14
 * Purpose: Definition of the Class ContratTemporaire
 ***********************************************************************/

using System;


namespace ABIEnCouches
{

    public abstract class ContratTemporaire : ContratType
    {
        protected DateTime datFinContrat;
        protected String motif;

        /// <summary>
        /// Constructeur
        /// </summary>
        /// <param name="idContrat"></param>
        /// <param name="dateDebutContrat"></param>
        /// <param name="qualification"></param>
        /// <param name="statut"></param>
        /// <param name="salaireContractuel"></param>
        /// <param name="datFinContrat"></param>
        /// <param name="motif"></param>
        public ContratTemporaire(DateTime dateDebutContrat, String qualification, String statut, Decimal salaireContractuel, DateTime datFinContrat, String motif) : base( dateDebutContrat,  qualification,  statut,  salaireContractuel)
        {
            this.dateDebutContrat = DateDebutContrat;
            this.qualification = Qualification;
            this.statut = Statut;
            this.salaireContractuel = SalaireContractuel;
            this.datFinContrat = DatFinContrat;
            this.motif = Motif;
        }



        public ContratTemporaire(int matricul,DateTime dateDebutContrat, String qualification, String statut, Decimal salaireContractuel, DateTime datFinContrat, String motif) : base(matricul,dateDebutContrat, qualification, statut, salaireContractuel)
        {
            this.dateDebutContrat = DateDebutContrat;
            this.qualification = Qualification;
            this.statut = Statut;
            this.salaireContractuel = SalaireContractuel;
            this.datFinContrat = DatFinContrat;
            this.motif = Motif;
        }



        /// <summary>
        /// GetSet DatFinContrat
        /// </summary>
        public DateTime DatFinContrat
        {
            get
            {
                return datFinContrat;
            }
           private set
            {
                if (this.datFinContrat != value)
                    this.datFinContrat = value;
            }
        }

        /// <summary>
        /// GetSet  Motif
        /// </summary>
        public String Motif
        {
            get
            {
                return motif;
            }
            private  set
            {
                if (this.motif != value)
                    this.motif = value;
            }
        }

        /// <summary>
        /// ToString()
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            // TODO: implement
            return "idContrat " + idContrat + " motif "+ motif;
        }



    }
}