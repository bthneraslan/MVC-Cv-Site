using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CvSitem.Models.Siniflar
{
    public class İletisim
    {
        [Key]
        public int ID { get; set; }
        [Column(TypeName = "Varchar")]
        [StringLength(50)]
        public string AdSoyad { get; set; }
        [Column(TypeName = "Varchar")]
        [StringLength(100)]
        public string Mail { get; set; }
        [Column(TypeName = "Varchar")]
        [StringLength(40)]
        public string Konu { get; set; }
        [Column(TypeName = "Varchar")]
        [StringLength(1000)]
        public string Mesaj { get; set; }
    }
}