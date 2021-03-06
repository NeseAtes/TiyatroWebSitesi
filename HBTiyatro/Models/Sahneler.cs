//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HBTiyatro.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Sahneler
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Sahneler()
        {
            this.Bilet = new HashSet<Bilet>();
            this.Koltuk = new HashSet<Koltuk>();
            this.OyunTakvimi = new HashSet<OyunTakvimi>();
        }
    
        public int SahneId { get; set; }
        public string SahneAdi { get; set; }
        public Nullable<int> OyunlarNo { get; set; }
        public string SahneAdresi { get; set; }
        public string SahneTelefon { get; set; }
        public Nullable<int> TiyatroNo { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Bilet> Bilet { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Koltuk> Koltuk { get; set; }
        public virtual Oyunlar Oyunlar { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OyunTakvimi> OyunTakvimi { get; set; }
        public virtual Tiyatrolar Tiyatrolar { get; set; }
    }
}
