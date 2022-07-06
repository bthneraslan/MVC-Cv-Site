using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
namespace CvSitem.Models.Siniflar
{
    public class Context : DbContext
    {
        public DbSet<Admin> Admins { get; set; }
        public DbSet<Deneyimler> Deneyimlers { get; set; }
        public DbSet<Egitim> Egitims { get; set; }
        public DbSet<Hakkinda> Hakkindas { get; set; }
        public DbSet<Hobiler> Hobilers { get; set; }
        public DbSet<İletisim> İletisims { get; set; }
        public DbSet<Yetenekler> Yeteneklers { get; set; }
        public DbSet<Sertifikalar> Sertifikalars { get; set; }
    }
}