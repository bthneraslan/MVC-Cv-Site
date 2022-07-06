using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CvSitem.Models.Siniflar
{
    public class Hakkinda
    {
        [Key]
        public int ID { get; set; }
        [Column(TypeName = "Varchar")]
        [StringLength(30)]
        public string Ad { get; set; }
        [Column(TypeName = "Varchar")]
        [StringLength(30)]
        public string Soyad { get; set; }
        [Column(TypeName = "Varchar")]
        [StringLength(100)]
        public string Adres { get; set; }
        [Column(TypeName = "Varchar")]
        [StringLength(40)]
        public string Mail { get; set; }
        [Column(TypeName = "Varchar")]
        [StringLength(20)]
        public string Telefon { get; set; }
        [Column(TypeName = "Varchar")]
        [StringLength(1000)]
        public string KisaNot { get; set; }
        [Column(TypeName = "Varchar")]
        [StringLength(100)]
        public string Fotograf { get; set; }
    }
}