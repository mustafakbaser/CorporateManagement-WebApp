using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace RakamIKProjesi.Models.Siniflar
{
    public class Admin
    {
        [Key]
        public int AdminID { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(16)]
        public string KullaniciAd { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(16)]
        public string KullaniciSifre { get; set; }

        [Column(TypeName = "Char")] // Yetkiyi belirlemek için tek karakter kullanacağım
        [StringLength(1)]
        public string Yetki { get; set; }

    }
}