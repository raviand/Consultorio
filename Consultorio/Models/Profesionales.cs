using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Consultorio.Models
{
    public class Profesionales 
    {
        [Key]
        public string ProfesionalesId { get; set; }

        [Required]
        [DataType(DataType.Text)]
        [StringLength(256)]
        public string Nombre { get; set; }

        [Required]
        [DataType(DataType.Text)]
        [StringLength(256)]
        public string Apellido { get; set; }

        [Required]
        [StringLength(128)]
        public string Dni { get; set; }

        [Required]
        public Localidades LocalidadesId { get; set; } //del tipo Localidades

        [Required]
        [DataType(DataType.DateTime)]
        public DateTime FechaNacimiento { get; set; }

        public string Calle { get; set; }

        public string Piso { get; set; }

        public string Departamento { get; set; }

        public string CodigoPostal { get; set; }

        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email{ get; set; }

        public DateTime? FechaIngreso { get; set; }

        public bool Eliminado { get; set; }

        [Required]
        [DataType(DataType.PhoneNumber)]
        public ICollection<Telefonos> TelefonosId { get; set; }

        public Usuarios UsuariosId { get; set; }  //Del tipo Usuarios

        [Required]
        public bool AtiendeDomicilio { get; set; }

        [Required]
        public ICollection<Especialidades> EspecialidadId { get; set; }
    }
}