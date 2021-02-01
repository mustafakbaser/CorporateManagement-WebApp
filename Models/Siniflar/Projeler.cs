using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace RakamIKProjesi.Models.Siniflar
{
    public class Projeler
    {
        [Key]
        public int ProjeID { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(50)]
        public string ProjeAd { get; set; }

        [Column(TypeName = "char")] //Kullanılan teknolojiyi birim değerlerle ekleyeceğim. 
        [StringLength(1)]
        public string KullanilanTeknoloji { get; set; }
        public int BirimID { get; set; }
        public string BaslangicTarihi { get; set; }
        public bool ProjeAktifligi { get; set; }
        public ICollection<Personel> Personels { get; set; } //Her bir projede birden fazla personel bulunabilir

    }
}