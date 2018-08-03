using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Consultorio.Models
{
    public class Especialidades
    {
        [Key]
        public string EspecialidadesId { get; set; }
        public string Especialidad { get; set; }
        public string MatriculaProvincia { get; set; }
        public string MatriculaCABA { get; set; }
        public ICollection<Dias> DiasAtencion { get; set; }
    }

    public enum Dias
    {
        Lunes,
        Martes,
        Miercoles,
        Jueves,
        Viernes,
        Sabado,
        Domingo
    }
}