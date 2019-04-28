//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré à partir d'un modèle.
//
//     Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//     Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SMAUG.Edmx
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;

    public partial class Item
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Item()
        {
            this.Publication = new HashSet<Publication>();
            this.Person = new HashSet<Person>();
            this.Arda = new HashSet<Arda>();
        }
    
        public int Ite_Id { get; set; }
        [DisplayName("Type")]
        public string Ite_Type { get; set; }
        [DisplayName("Name")]
        public string Ite_Name { get; set; }
        public string Ite_Collection { get; set; }
        public string Ite_Edition { get; set; }
        public string Ite_Editor { get; set; }
        public string Ite_ISBN { get; set; }
        public Nullable<short> Ite_ProdDate { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Publication> Publication { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Person> Person { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Arda> Arda { get; set; }
    }
}
