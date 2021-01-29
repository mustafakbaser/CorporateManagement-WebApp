using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace RakamIKProjesi.Models.Siniflar
{
    public class Departmanlar
    {
        [Key] //DepartmanID'yi Primary Key yapıyorum.
        public int DepartmanID { get; set; }
        public string DepartmanAd { get; set; }
    }
}