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
    
    public partial class Kullanici
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Kullanici()
        {
            this.Bilet = new HashSet<Bilet>();
            this.MesajKutusu = new HashSet<MesajKutusu>();
            this.Yorumlar = new HashSet<Yorumlar>();
        }
    
        public int KullaniciID { get; set; }
        public string Sifre { get; set; }
        public string SifreTekrari { get; set; }
        public string KullaniciSoyadi { get; set; }
        public string Telefon { get; set; }
        public string EPosta { get; set; }
        public string KullaniciAdi { get; set; }
        public Nullable<int> MesajID { get; set; }
        public string UyeKodu { get; set; }
        public string Onay { get; set; }
        public Nullable<int> RolID { get; set; }
        public string TC { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Bilet> Bilet { get; set; }
        public virtual Iletisim Iletisim { get; set; }
        public virtual Rol Rol { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MesajKutusu> MesajKutusu { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Yorumlar> Yorumlar { get; set; }
    }
}
