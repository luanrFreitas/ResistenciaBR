using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Microsoft.AspNet.Identity;

namespace ResistenciaBR.Models
{
    public class Tip
    {
        [Key]
        public int Codigo { get; set; }
        [Required]
        public string Categoria { get; set; }
        [Required]
        public string Titulo { get; set; }
        [Required]
        [DataType(DataType.MultilineText)]
        public string Texto { get; set; }
        public string Autor { get; set; }

    }
}