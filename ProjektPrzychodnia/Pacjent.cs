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
    
    public partial class Pacjent
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Pacjent()
        {
            this.Wizyta = new HashSet<Wizyta>();
        }
    
        public int Id_pacjenta { get; set; }
        public string Imie { get; set; }
        public string nazwisko { get; set; }
        public string Pesel { get; set; }
    
        public virtual Adres Adres { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Wizyta> Wizyta { get; set; }
    }
}
