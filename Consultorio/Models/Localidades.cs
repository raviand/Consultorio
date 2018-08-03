using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Consultorio.Models
{
    public class Localidades
    {
        [Key]
        public string LocalidadesId { get; set; }
        public string Localidad { get; set; }
        public string ProvinciaId { get; set; }
    }
}