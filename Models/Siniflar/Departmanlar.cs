using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace RakamIKProjesi.Models.Siniflar
{
    public class Departmanlar
    {
        [Key] //DepartmanID'yi Primary Key yapıyorum.
        public int DepartmanID { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(30)]
        public string DepartmanAd { get; set; }
        public bool Aktiflik { get; set; }
        public ICollection<Personel> Personels { get; set; } //Her bir departmanda birden fazla personel bulunabilir
    }
}