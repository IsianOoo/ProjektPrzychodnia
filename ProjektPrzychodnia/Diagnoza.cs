//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProjektPrzychodnia
{
    using System;
    using System.Collections.Generic;
    
    public partial class Diagnoza
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Diagnoza()
        {
            this.dawkowanie = new HashSet<dawkowanie>();
        }
    
        public int Id_diagnozy { get; set; }
        public string Jednostka_Chorobowa { get; set; }
        public int Id_lekarza { get; set; }
        public Nullable<int> Id_wizyty { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<dawkowanie> dawkowanie { get; set; }
        public virtual Lekarz Lekarz { get; set; }
        public virtual Wizyta Wizyta { get; set; }
    }
}