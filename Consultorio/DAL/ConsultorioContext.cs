using Consultorio.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace Consultorio.DAL
{
    public class ConsultorioContext : DbContext
    {
        
        public ConsultorioContext(): base("ConsultorioContext")
        {
            Database.SetInitializer(new ConsultorioInitializer());
           
        }

        public DbSet<Especialidades> Especialidades { get; set; }
        public DbSet<Historial> Historial { get; set; }
        public DbSet<Localidades> Localidades { get; set; }
        public DbSet<Pacientes> Pacientes { get; set; }
        public DbSet<Planes> Planes { get; set; }
        public DbSet<Profesionales> Profesionales { get; set; }
        public DbSet<Provincias> Provincias { get; set; }
        public DbSet<SegurosMedicos> SegurosMedicos { get; set; }
        public DbSet<Telefonos> Telefonos { get; set; }
        public DbSet<Turnos> Turnos { get; set; }
        public DbSet<Usuarios> Usuarios { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}