using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace ABIEnCouches
{
    public class Collaborateurs
    {
        private  SortedDictionary<int, Collaborateur> listCollab;
        private  DataTable dtCollab ;

        /// <summary>
        /// Constructeurs Collaborateurs
        /// </summary>
        public Collaborateurs()
        {
            listCollab = new SortedDictionary<int, Collaborateur>();
            dtCollab = new DataTable();
                dtCollab.Columns.Add("MATRICULE", typeof(int));
                dtCollab.Columns.Add("NOM", typeof(String));
                dtCollab.Columns.Add("PRENOM", typeof(String));
        }


        //FONCTIONS-----------------------------------------------------------
        /// <summary>
        /// GetCollaborateurs()
        /// </summary>
        /// <returns></returns>
        public DataTable ListerCollaborateurs()
        {
            dtCollab.Clear();
            DataRow dr;
            foreach (Collaborateur collab in listCollab.Values)
            {
                dr = dtCollab.NewRow();
                dr[0] = collab.Matricule;
                dr[1] = collab.NomCollab;
                dr[2] = collab.PrenomCollab;
                dtCollab.Rows.Add(dr);
            }
            return this.dtCollab;
        }

        /// <summary>
        /// AddCollaborateur
        /// </summary>
        /// <param name="newCollab"></param>
        public void AddCollaborateur(Collaborateur newCollab)
        {
            if (controlAddCollab(newCollab))
            {
                this.listCollab.Add((int)newCollab.Matricule, newCollab);
            }
            else
            {
                throw new Exception("erreur générale pour entrer un contrat dans la collection");
            }

        }



        public void removeCollaborateur(int matricule, string leDemandeur)
        {
            if(leDemandeur == "ABIEnCouches.ctrlListerCollaborateur" )
            if (listCollab.ContainsKey(matricule))
            {
                this.listCollab.Remove(matricule);
            }

        }

        /// <summary>
        /// RestituerCollaborateur(int matricule)
        /// </summary>
        /// <param name="matricule"></param>
        /// <returns></returns>
        public Collaborateur RestituerCollaborateur(int matricule)
        {
            if (!this.listCollab.ContainsKey(matricule))
            {
                throw new Exception("ce contrat n'existe pas et ne peut donc pas être restitué");
            }
            else
            {
                return this.listCollab[matricule];
            }
        }

        /// <summary>
        /// controlAddContrats controle la validite du collaborateur ajouté
        /// </summary>
        /// <param name="newContrat"></param>
        /// <returns></returns>
        private  bool controlAddCollab(Collaborateur newCollaborateur)
        {
            bool b = true;
            String st = "le nouveau COLLABORATEUR ne peut être ajouté: ";

            if (newCollaborateur == null)
            {
                b = false;
                throw new Exception(st + "il est null ");
            }

            if (this.listCollab == null)
            {

                this.listCollab = new System.Collections.Generic.SortedDictionary<int, Collaborateur>();
            }

            if (newCollaborateur.Matricule <= 0)
            {
                b = false;
                throw new Exception(st + "le Matricule du collaborateur doit etre >0");
            }
            else if (this.listCollab.ContainsKey((int)newCollaborateur.Matricule))
            {
                b = false;
                throw new Exception(st + "le contrat existe deja dans la collection");
            }
            return b;
        }


        ///// <pdGenerated>default removeAll</pdGenerated>
        //public void RemoveAllContratType()
        //{
        //    if (contrats != null)
        //        contrats.Clear();
        //}
    }
}
