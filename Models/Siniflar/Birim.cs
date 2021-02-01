using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace RakamIKProjesi.Models.Siniflar
{
    public class Birim
    {
        [Key]
        public int BirimID { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(20)]
        public string BIRIM { get; set; }
    }
}