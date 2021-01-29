using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace RakamIKProjesi.Models.Siniflar
{
    public class Projeler
    {
        [Key]
        public int ProjeID { get; set; }
        public string ProjeAd { get; set; }
        public string KullanilanTeknoloji { get; set; }
        public string BaslangicTarihi { get; set; }
        public bool ProjeAktifligi { get; set; }
    }
}