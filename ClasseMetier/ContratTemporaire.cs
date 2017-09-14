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
        protected DateTime dateFinContrat;
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
        public ContratTemporaire(DateTime dateDebutContrat, String qualification, String statut, Decimal salaireContractuel, 
            DateTime datFinContrat, String motif) : base(dateDebutContrat, qualification,  statut,  salaireContractuel)
        {
            this.DateFinContrat = datFinContrat;
            this.Motif = motif;
        }

        /// <summary>
        /// GetSet DatFinContrat
        /// </summary>
        public DateTime DateFinContrat
        {
            get
            {
                return dateFinContrat;
            }
           private set
            {
                if (this.dateFinContrat != value)
                    this.dateFinContrat = value;
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