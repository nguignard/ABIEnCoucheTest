using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using ABIEnCouches;
using ClassesDAO;

namespace MetierServicesApp
{
    // REMARQUE : vous pouvez utiliser la commande Renommer du menu Refactoriser pour changer le nom de classe "ServiceAbi" dans le code, le fichier svc et le fichier de configuration.
    // REMARQUE : pour lancer le client test WCF afin de tester ce service, sélectionnez ServiceAbi.svc ou ServiceAbi.svc.cs dans l'Explorateur de solutions et démarrez le débogage.
    public class ServiceAbi : IServiceAbi
    {
        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }



        public IList<Collaborateur> GetCollaborateurs()
        {
            Collaborateurs listeCollaborateurs = new Collaborateurs();
            Dao.instancieCollaborateurs(listeCollaborateurs);

            foreach (Collaborateur item in listeCollaborateurs.ListerCollaborateurs
            {

            }
        }



        public string AddCollaborateur(Collaborateur newCollaborateur)
        {

        }




    }
}
