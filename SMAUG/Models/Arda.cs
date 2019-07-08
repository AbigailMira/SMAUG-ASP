//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré à partir d'un modèle.
//
//     Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//     Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SMAUG.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Arda
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Arda()
        {
            this.Develops = new HashSet<Publication>();
            this.Interpretor = new HashSet<Person>();
            this.RefersTo = new HashSet<Item>();
            this.Inventor = new HashSet<Person>();
            this.Introduces = new HashSet<Publication>();
        }
    
        public int Ard_Id { get; set; }
        public string Ard_Name { get; set; }
        public string Ard_Type { get; set; }
        public string Ard_Race { get; set; }
        public string Ard_People { get; set; }
        public Nullable<int> Ard_FirstAppearance { get; set; }
        public string Ard_Gender { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Publication> Develops { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Person> Interpretor { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Item> RefersTo { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Person> Inventor { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Publication> Introduces { get; set; }
    }
}
