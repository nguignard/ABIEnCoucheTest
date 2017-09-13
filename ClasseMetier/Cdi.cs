/***********************************************************************
 * Module:  Cdi.cs
 * Author:  CDI14
 * Purpose: Definition of the Class Cdi
 ***********************************************************************/

using System;


namespace ABIEnCouches
{
    public class Cdi : ContratType
    {

        public Cdi( DateTime dateDebutContrat, String qualification, String statut, Decimal salaireContractuel):base(  dateDebutContrat,  qualification,  statut, salaireContractuel)
        {

        }

        public override String ToString()
        {
            return "CDI : idContrat " + idContrat + " dateDebutContrat " + dateDebutContrat + " salaireContractuel " + salaireContractuel;
        }

    }
}