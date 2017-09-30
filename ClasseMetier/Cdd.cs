/***********************************************************************
 * Module:  Cdd.cs
 * Author:  CDI14
 * Purpose: Definition of the Class Cdd
 ***********************************************************************/

using System;


namespace ABIEnCouches
{
    public class Cdd : ContratTemporaire
    {
        public Cdd(DateTime dateDebutContrat, String qualification, String statut, Decimal salaireContractuel, DateTime datFinContrat, String motif):base(   dateDebutContrat,  qualification,  statut,  salaireContractuel,  datFinContrat,  motif)
        {

        }


        public override String ToString()
        {
            return "CDD : dateDebutContrat "+ dateDebutContrat+ " idContrat " + idContrat;
        }

    }
}