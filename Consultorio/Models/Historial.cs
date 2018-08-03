using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Consultorio.Models
{
    public class Historial
    {
        [Key]
        public string HistorialId { get; set; }
        //[ForeignKey("Pacientes")]
        public Pacientes PacientesId { get; set; }
        //[ForeignKey("Profesionales")]
        public Profesionales ProfesionalesId { get; set; }
        //[ForeignKey("Turnos")]
        public Turnos TurnosId { get; set; }
        [Required]
        public string Informe { get; set; }
    }
}