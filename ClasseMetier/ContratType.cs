/***********************************************************************
 * Module:  ContratType.cs
 * Author:  CDI14
 * Purpose: Definition of the Class ContratType
 ***********************************************************************/

using System;


namespace ABIEnCouches
{

    /// <summary>
    /// Classe ContratType Abstraite
    /// </summary>
    public abstract class ContratType
    {
        //ATTRIBUTS------------------------------------------------------------
       
        protected int idContrat;
        protected DateTime dateDebutContrat;
        protected String qualification;
        protected String statut;
        protected Decimal salaireContractuel;
        protected DateTime? finReelContrat;

        protected System.Collections.Generic.SortedDictionary<int,Avenant> avenants;

        //CONSTRUCTEUR -------------------------------------------------------
        public ContratType(DateTime dateDebutContrat, String qualification, String statut, Decimal salaireContractuel)
        {
            this.IdContrat = GetNewIdContrat();
            this.DateDebutContrat = dateDebutContrat;
            this.Qualification = qualification;
            this.Statut = statut;
            this.SalaireContractuel = salaireContractuel;
        }


        public ContratType(int IdContrat, DateTime dateDebutContrat, String qualification, String statut, Decimal salaireContractuel)
        {
            this.IdContrat = IdContrat;
            this.DateDebutContrat = dateDebutContrat;
            this.Qualification = qualification;
            this.Statut = statut;
            this.SalaireContractuel = salaireContractuel;
        }

        //GET SET--------------------------------------------------------------

        /// <summary>
        /// PPT IdContrat
        /// </summary>
        public int IdContrat
        {
            get
            {
                return idContrat;
            }
             set
            {
                if (this.idContrat < 0)
                {
                    throw new Exception("l'idContrat est obligatoire > 0");
                }
                else
                {
                    this.idContrat = value;
                }

            }
        }

        /// <summary>
        /// getset DateDebutContrat
        /// </summary>
        public DateTime DateDebutContrat
        {
            get
            {
                return dateDebutContrat;
            }
            private set
            {
                if (this.dateDebutContrat != value)
                    this.dateDebutContrat = value;
            }
        }

        public String Qualification
        {
            get
            {
                return qualification;
            }
            private set
            {
                if (this.qualification != value)
                    this.qualification = value;
            }
        }

        public String Statut
        {
            get
            {
                return statut;
            }
            private set
            {
                if (this.statut != value)
                    this.statut = value;
            }
        }

        public decimal SalaireContractuel
        {
            get
            {
                return salaireContractuel;
            }

           private set
            {
                if (value<0 )
                { throw new Exception("le salaire doit être compris entre 0 et 3000"); }
                 else
                    { 
                this.salaireContractuel = value;
                }
            }
        }

        /// <summary>
        /// FinReelContrat
        /// </summary>
        public DateTime? FinReelContrat
        {
            get
            {
                return finReelContrat;
            }
            set
            {
                if (value > this.DateDebutContrat)
                    this.finReelContrat = value;
            }
        }

        /// <summary>
        /// GetIdContrat() nouvelId
        /// </summary>
        /// <returns></returns>
        public int GetNewIdContrat()
        {
            return Donnees.CompteurContrat++;
        }





        //GESTION DES AVENANTS----------------------------------------------
     
        /// <pdGenerated>default getter</pdGenerated>
        public System.Collections.Generic.SortedDictionary<int, Avenant> ListerAvenants()
        {
            if (avenants == null)
                avenants = new System.Collections.Generic.SortedDictionary<int, Avenant>();
            return avenants;
        }

        /// <pdGenerated>default Add</pdGenerated>
        public void AddAvenant(Avenant newAvenant)
        {

            if (this.avenants == null)
            {
                this.avenants = new System.Collections.Generic.SortedDictionary<int, Avenant>();
            }

            if (newAvenant == null)
            {
                throw new Exception("le nouvel Avenant doit être renseignée");
            }

            if (newAvenant.IdAvenant < 0)
            {
                throw new Exception("l'ID de l'Avenant ne doit pas être < 0");
            }
            else if (avenants.ContainsKey(newAvenant.IdAvenant))
            {
                throw new Exception("l'ID de l'Avenant Existe déjà");
            } 
            else
            {
                this.avenants.Add(newAvenant.IdAvenant,newAvenant);
            }
        }

        /// <summary>
        /// RestituerAvenant(int idAvenant)
        /// </summary>
        /// <param name="idAvenant"></param>
        /// <returns></returns>
        public Avenant RestituerAvenant(int idAvenant)
        {
            if (!avenants.ContainsKey(idAvenant))
            {
                throw new Exception("cet AVENANT n'existe pas et ne peut donc pas être restitué");
            }
            else
            {
                return avenants[idAvenant];
            }
        }



        //FONCTIONS-------------------------------------------------------------------------









        /// <summary>
        /// cloturerContrat
        /// </summary>
        public DateTime? CloturerContrat
        {
            get
            {
                return finReelContrat;
            }
            set
            {
                if (value > this.DateDebutContrat)
                {
                    this.finReelContrat = value;
                }
                else
                {
                    throw new Exception("la date de fin de contrat doit être > à la date de début de contrat");
                }
            }
        }

        /// <summary>
        /// ToString()
        /// </summary>
        /// <returns></returns>
        public override String ToString()
        {
            return "idContrat "+ idContrat+ " qualification " + " statut "+ statut ;
        }
    }
}