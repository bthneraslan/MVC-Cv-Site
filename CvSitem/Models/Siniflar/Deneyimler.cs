using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CvSitem.Models.Siniflar
{
    public class Deneyimler
    {
        [Key]
        public int ID { get; set; }
        [Column(TypeName = "Varchar")]
        [StringLength(100)]
        public string Baslik { get; set; }
        [Column(TypeName = "Varchar")]
        [StringLength(100)]
        public string AltBaslik { get; set; }
        [Column(TypeName = "Varchar")]
        [StringLength(1000)]
        public string Aciklama { get; set; }
        public DateTime Tarih { get; set; }
    }
}