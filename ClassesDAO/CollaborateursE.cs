//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré à partir d'un modèle.
//
//     Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//     Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ClassesDAO
{
    using System;
    using System.Collections.Generic;
    
    public partial class CollaborateursE
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CollaborateursE()
        {
            this.ContratTypeE = new HashSet<ContratTypeE>();
        }
    
        internal int matriculeE { get; set; }
        internal string civiliteE { get; set; }
        internal string nomE { get; set; }
        internal string prenomE { get; set; }
        internal string situationE { get; set; }
        internal string photoE { get; set; }
        internal bool actifE { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ContratTypeE> ContratTypeE { get; set; }
    }
}