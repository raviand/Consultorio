using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Consultorio.Models
{
    public class Planes
    {
        [Key]
        public string PlanesId { get; set; }
        public string NombrePlan { get; set; }
        
        public SegurosMedicos SegurosMedicosId { get; set; }
    }
}