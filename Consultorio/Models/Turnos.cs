using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Consultorio.Models
{
    public class Turnos
    {
        [Key]
        public string TurnosId { get; set; }
        [Required]
        [DataType(DataType.Date)]
        public DateTime FechaTurno { get; set; }
        [Required]
        public TimeSpan HoraTurno { get; set; }
        public DateTime FechaSolicitud { get; set; }
        [Required]
        //[ForeignKey("Pacientes")]
        public Pacientes PacienteId { get; set; }
        [Required]
        //[ForeignKey("Profesionales")]
        public Profesionales ProfesionalesId { get; set; }
        [Required]
        //[ForeignKey("Especialidades")]
        public Especialidades EspecialidadesId { get; set; }
        public EstadoTurno estadoTurno { get; set; }

    }

    public enum EstadoTurno
    {
        Atendido,
        Asignado,
        Cancelado,
        Sobreturno
    }
}