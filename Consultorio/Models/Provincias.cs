using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace Consultorio.Models
{
    public class Provincias
    {
        [Key]
        public string ProvinciaId { get; set; }
        public string Provincia { get; set; }
    }
}