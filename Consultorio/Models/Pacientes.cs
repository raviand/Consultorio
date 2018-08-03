using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Consultorio.Models
{
    public class Pacientes
    {
        [Key]
        public string PacientesId { get; set; }
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
        public string Calle { get; set; }
        //[ForeignKey("Localidades")]
        public Localidades LocalidadesId { get; set; } //del tipo Localidades
        [Required]
        [DataType(DataType.DateTime)]
        public DateTime FechaNacimiento { get; set; }
        public string Piso { get; set; }
        public string Departamento { get; set; }
        public string CodigoPostal { get; set; }
        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        public DateTime FechaIngreso { get; set; }
        public bool Eliminado { get; set; }
        [Required]
        [DataType(DataType.PhoneNumber)]
        public ICollection<Telefonos> Telefono { get; set; }
        //[ForeignKey("Usuarios")]
        public Usuarios UsuariosId { get; set; }  //Del tipo Usuarios
        public string NumeroCredencial { get; set; }
        //[ForeignKey("Planes")]
        public Planes PlanesId { get; set; } //Del tipo Planes
    }
}
