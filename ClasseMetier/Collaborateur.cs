/***********************************************************************
 * Module:  Collaborateur.cs
 * Author:  CDI14
 * Purpose: Definition of the Class Collaborateur
 ***********************************************************************/

using System;
using System.Data;
using System.Collections.Generic;

namespace ABIEnCouches
{
    /// <summary>
    /// Classe Collaborateur, gere les collections de collabotrateurs, les collaborateurs et leurs contrats
    /// </summary>
    public class Collaborateur
    {
        private int matricule;
        private String civilite;
        private string nomCollab;
        private string prenomCollab;
        private string situationFamiliale;
        private string photo;
        private bool actif;

        private SortedDictionary<int, ContratType> contrats;
        private DataTable dtContrats;
        private SortedDictionary<DateTime, HistoriqueAugmentation> augmentations;

        //CONSTRUCTEURS-------------------------------------------------------------------------------
        
        /// <summary>
        /// Constructeur Complet
        /// </summary>
        /// <param name="matricule"></param>
        /// <param name="civilite"></param>
        /// <param name="nomCollab"></param>
        /// <param name="prenomCollab"></param>
        /// <param name="situationFamillial"></param>
        /// <param name="actif"></param>
        public Collaborateur( String civilite, String nomCollab, String prenomCollab, String situationFamillial, bool actif)
        {
            this.Matricule = GetNewMatricule();
            this.Civilite = civilite;
            this.NomCollab = nomCollab;
            this.PrenomCollab = prenomCollab;
            this.SituationFamiliale = situationFamiliale;
            this.Actif = actif;

            this.contrats = new SortedDictionary<int, ContratType>();
            this.dtContrats = new DataTable();
            dtContrats.Columns.Add("IDCONTRAT", typeof(int));
            dtContrats.Columns.Add("TYPECONTRAT", typeof(String));
            dtContrats.Columns.Add("DATEDEBUT", typeof(String));

        }



        //GETTER-SETTERS----------------------------------------------------------------------

        /// <summary>
        /// Accesseur Matricule, Matricule ne peut être null
        /// </summary>
        public int Matricule
        {
            get
            {
                return matricule;
            }
            private set
            {
                if (value <=0)
                {
                    throw new Exception("Matricule obligatoire et >0 ");
                }
                else
                {
                    this.matricule = value;
                }
            }
        }

        /// <summary>
        /// Accesseur Civilité, ne peut être que M ou Mme
        /// </summary>
        public String Civilite
        {
            get
            {
                return civilite;
            }
            set
            {
               if (value.ToUpper() != "M" && value.ToUpper() != "F")
                    {
                        throw new Exception(" le champs cvilité doit être M ou F");
                    }
                    else
                    {
                        this.civilite = value.Trim().ToUpper();
                    }
            }
        }

        /// <summary>
        /// Accesseur NomCollab
        /// </summary>
        public string NomCollab
        {
            get
            {
                return nomCollab;
            }
            set
            {
                if (value.Trim().ToUpper() == "")
                {
                    throw new Exception("vous n'avez pas rentrer de nom pour ce collaborateur");
                }
                else
                {
                    this.nomCollab = value.Trim().ToUpper();
                }
            }
        }

        /// <summary>
        /// Accesseur PrénomCollab, ne peut être vide
        /// </summary>
        public string PrenomCollab
        {
            get
            {
                return prenomCollab;
            }
            set
            {
                if (value.Trim() == "")
                {
                    throw new Exception("vous n'avez pas rentrer de prénom pour ce collaborateur");
                }
                else
                {
                    this.prenomCollab = value.Trim();
                }
            }
        }

        /// <summary>
        /// Accesseur SituationFamiliale
        /// </summary>
        public string SituationFamiliale
        {
            get
            {
                return situationFamiliale;
            }
            set
            {
                this.situationFamiliale = value;
            }
        }

        /// <summary>
        /// Accesseur Photo
        /// </summary>
        public string Photo
        {
            get
            {
                return photo;
            }
            set
            {
                if (this.photo != value)
                    this.photo = value;
            }
        }

        /// <summary>
        /// Accesseur Actif
        /// </summary>
        public bool Actif
        {
            get
            {
                return actif;
            }
            set
            {
                if (this.actif != value)
                    this.actif = value;
            }
        }


        //FONCTIONS---------------------------------------------------------------------------

        //public ContratType ContratInitial()
        //{
        //    DateTime t = DateTime.MaxValue;
        //    ContratType x;

        //    Rechercher Date contrat initial
        //    foreach (DateTime c in dtContrats.Rows.Find(1))
        //    {
        //        if (t < c.DateDebutContrat)
        //        {
        //            t = c.DateDebutContrat;
        //        }
        //    }
        //    if (t != null)
        //    {

        //        return t;
        //    }
        //    else
        //    {
        //        throw new Exception("pas de contat initial");
        //    }


        //    //Retourner contrat Initial
        //    foreach (ContratType c in contrats.Values)
        //    {
        //        if (c.DateDebutContrat == t)
        //        {
        //            x = RestituerContrat(c.IdContrat);
        //        }
        //    }

        //    return x;


        //}



        public int GetNewMatricule()
        {
           return Donnees.CompteurCollaborateur++;
        }

        //public Object Equals(bool collaborateur)
        //{
        //    // TODO: implement
        //    return null;
        //}

        //public override Int32 GetHashCode()
        //{
        //    // TODO: implement
        //    return null;
        //}


        /// <summary>
        /// onGoingCDI permet de savoir si unCDI est en cours
        /// </summary>
        /// <returns></returns>
        private bool onGoingContrat(ContratType newContrat)
        {
            bool b = true;
            //foreach (ContratType contrat in contrats.Values)
            //{
            //    if ((contrat is Cdi && (contrat.FinReelContrat == null))
            //        || (contrat is ContratTemporaire && (((ContratTemporaire)(contrat)).FinReelContrat > newContrat.DateDebutContrat)))
            //    {
            //        b = false;
            //    }

            //}
            return b;
        }

        /// <summary>
        /// ToString
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return "Matricule " + this.Matricule + " Civilite " + this.Civilite + " Nom " + this.NomCollab + " Prénom " + this.PrenomCollab;
        }


        //GESTION COLLECTION D'AUGMENTATIONS--------------------------------------------------------------------------------------

        /// <pdGenerated>default getter</pdGenerated>
        public System.Collections.Generic.SortedDictionary<DateTime, HistoriqueAugmentation> GetAugmentations()
        {
            if (augmentations == null)
                augmentations = new System.Collections.Generic.SortedDictionary<DateTime, HistoriqueAugmentation>();
            return augmentations;
        }

        /// <pdGenerated>default Add</pdGenerated>
        public void AddAugmentation(HistoriqueAugmentation newAugmentation)
        {
            if (newAugmentation == null)
            {
                throw new Exception("la nouvelle augmentation doit être renseignée");
            }
            else if (this.augmentations == null)
            {
                this.augmentations = new System.Collections.Generic.SortedDictionary<DateTime, HistoriqueAugmentation>();
            }
            else if (newAugmentation.MontantAugmentation < 0)
            {
                throw new Exception("l'augmentation ne doit pas être < 0");
            }
            else
            {
                //il faudrai verifier si la duree est >3 ans
                this.augmentations.Add(newAugmentation.DateAugmentation,newAugmentation);
            }
        }

        public HistoriqueAugmentation RestituerAugmentation(DateTime date)
        {
            if (!augmentations.ContainsKey(date))
            {
                throw new Exception("cet AVENANT n'existe pas et ne peut donc pas être restitué");
            }
            else
            {
                return augmentations[date];
            }
        }




        //GESTION COLLECTION DE CONTRATS--------------------------------------------------------------------------------
        /// <pdGenerated>default getter</pdGenerated>
        public DataTable GetContrats()
        {
            dtContrats.Clear();
            DataRow dr;
            foreach (ContratType contrat in contrats.Values)
            {
                dr = dtContrats.NewRow();
                dr[0] = contrat.IdContrat;
                dr[1] = contrat.TypeContrat();
                dr[2] = contrat.DateDebutContrat.Date.ToString();
                dtContrats.Rows.Add(dr);
            }
            return this.dtContrats;
        }

        ///// <pdGenerated>default setter</pdGenerated>
        //public void SetContrat(ContratType newContrat)
        //{
        //    //RemoveAllContratType();
        //    foreach (ContratType oContrat in contrats.Values)
        //        AddContrat(oContrat);
        //}

        /// <pdGenerated>default Add</pdGenerated>
        public void AddContrat(ContratType newContrat)
        {
            if (controlAddContrats(newContrat))
            {
                this.contrats.Add(newContrat.IdContrat, newContrat);
            }
            else
            {
                throw new Exception("erreur générale pour entrer un contrat dans la collection");
            }

        }

        /// <summary>
        ///  RestituerContrat(int idContrat) 
        /// </summary>
        /// <param name="idContrat"></param>
        /// <returns></returns>
        public ContratType RestituerContrat(int idContrat)
        {
            if (!contrats.ContainsKey(idContrat))
            {
                throw new Exception("ce contrat n'existe pas et ne peut donc pas être restitué");
            }
            else
            {
                return contrats[idContrat];
            }
        }

        ///// <pdGenerated>default removeAll</pdGenerated>
        //public void RemoveAllContratType()
        //{
        //    if (contrats != null)
        //        contrats.Clear();
        //}

        /// <summary>
        /// controlAddContrats controle la validite du contrat vis a vis des autres contrat avant de l'ajouter
        /// </summary>
        /// <param name="newContrat"></param>
        /// <returns></returns>
        private bool controlAddContrats(ContratType newContrat)
        {
            bool b = true;
            String st = "le nouveau contrat ne peut être ajouté: ";

            if (newContrat == null)
            {
                b = false;
                throw new Exception(st + "le contrat est null ");
            }

            if (this.contrats == null)
            {
                this.contrats = new System.Collections.Generic.SortedDictionary<int, ContratType>();
            }

            if (this.contrats.ContainsKey(newContrat.IdContrat))
            {
                b = false;
                throw new Exception(st + "le contrat existe deja dans la collection");
            }

            if (onGoingContrat(newContrat))
            {
                //b = false;
                //throw new Exception(st + " un contrat est déja en cours");
            }
            return b;
        }

        public DataTable ListerContrats()
        {
            dtContrats.Clear();
            DataRow dr;
            foreach(ContratType contrat in contrats.Values)
            {
                Type leType = contrat.GetType();

                Console.WriteLine(leType.ToString());

                dr = dtContrats.NewRow();
                dr[0] = contrat.IdContrat;
                dr[1] = leType.ToString();
                dr[2] = contrat.DateDebutContrat.Date.ToString();
                dtContrats.Rows.Add(dr);
            }
            return this.dtContrats;
        }

    }
}