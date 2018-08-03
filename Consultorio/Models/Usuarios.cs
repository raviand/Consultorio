using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Consultorio.Models
{
    public class Usuarios
    {
        [Key]
        public string UsuariosId { get; set; }
        [Required]
        [StringLength(256)]
        [DataType(DataType.EmailAddress)]
        public string  Email { get; set; }
        public bool EmailConfirmed { get; set; }
        [Required]
        public string PasswordHash { get; set; }
        public string securityStamp { get; set; }
        [Required]
        [DataType(DataType.PhoneNumber)]
        public string PhoneNumber { get; set; }
        public bool PhoneNumberConfirm { get; set; }
        public bool TwoFactorEnabled { get; set; }
        public DateTime LockoutEndDateUtc { get; set; }
        public bool LockoutEnabled { get; set; }
        public int AccessFailCount { get; set; }
        public string UserName { get; set; }
        public AccesType AccessType { get; set; }
    }

    public enum AccesType
    {
        Public,
        Administrator,
        Profesional,
        Management
    }
}