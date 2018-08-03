using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Consultorio.Models
{
    public class Telefonos
    {
        [Key]
        public string TelefonosId { get; set; }
        [Required]
        [DataType(DataType.PhoneNumber)]
        public string Telefono { get; set; }

        public Tipo TipoTelefono { get; set; }
    }

    public enum Tipo
    {
        Casa,
        Celular,
        Trabajo
    }
}