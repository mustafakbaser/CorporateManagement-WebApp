using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace RakamIKProjesi.Models.Siniflar
{
    public class Context: DbContext
    {
        public DbSet<Admin> Admins { get; set; }
        public DbSet<Departmanlar> Departmans { get; set; }
        public DbSet<Personel> Personels { get; set; }
        public DbSet<Projeler> Projelers { get; set; }
        public DbSet<Birim> Birims { get; set; }

    }
}