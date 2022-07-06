using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CvSitem.Models.Siniflar
{
    public class Yetenekler
    {
        [Key]
        public int ID { get; set; }
        [Column(TypeName ="Varchar")]
        [StringLength(100)]
        public string Yetenek { get; set; }
    }
}