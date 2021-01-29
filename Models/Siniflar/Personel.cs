using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace RakamIKProjesi.Models.Siniflar
{
    public class Personel
    {
        [Key]
        public int PersonelID { get; set; }

        [Column(TypeName = "Varchar")] // PersonelAd'ın varchar değerinde ve 30 karakter uzunluğunda olacağını belirttim.
        [StringLength(30)]
        public string PersonelAd { get; set; }

        public string Birim { get; set; }
        public Projeler Proje { get; set; } //Bir personel sadece bir projede çalışabilir.
        public Departmanlar Departman { get; set; } //Bir personel sadece bir departmanda bulunabilir.

    }
}