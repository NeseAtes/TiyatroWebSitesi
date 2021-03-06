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
    
    public partial class Oyunlar
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Oyunlar()
        {
            this.Bilet = new HashSet<Bilet>();
            this.Fotograflar = new HashSet<Fotograflar>();
            this.Oyuncular = new HashSet<Oyuncular>();
            this.OyunTakvimi = new HashSet<OyunTakvimi>();
            this.Sahneler = new HashSet<Sahneler>();
            this.Yorumlar = new HashSet<Yorumlar>();
        }
    
        public int OyunId { get; set; }
        public string OyunAdi { get; set; }
        public string Imdb { get; set; }
        public Nullable<System.TimeSpan> OyunSuresi { get; set; }
        public Nullable<int> OyunFiyati { get; set; }
        public Nullable<System.DateTime> OyunTarih { get; set; }
        public string OyunDurumu { get; set; }
        public Nullable<int> VideoID { get; set; }
        public Nullable<int> SatisID { get; set; }
        public Nullable<int> OyunTuruID { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Bilet> Bilet { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Fotograflar> Fotograflar { get; set; }
        public virtual KullaniciTuru KullaniciTuru { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Oyuncular> Oyuncular { get; set; }
        public virtual OyunTuru OyunTuru { get; set; }
        public virtual Video Video { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OyunTakvimi> OyunTakvimi { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Sahneler> Sahneler { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Yorumlar> Yorumlar { get; set; }
    }
}
