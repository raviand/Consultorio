namespace Consultorio.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Especialidades",
                c => new
                    {
                        EspecialidadesId = c.String(nullable: false, maxLength: 128),
                        Especialidad = c.String(),
                        MatriculaProvincia = c.String(),
                        MatriculaCABA = c.String(),
                        Profesionales_ProfesionalesId = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.EspecialidadesId)
                .ForeignKey("dbo.Profesionales", t => t.Profesionales_ProfesionalesId)
                .Index(t => t.Profesionales_ProfesionalesId);
            
            CreateTable(
                "dbo.Historials",
                c => new
                    {
                        HistorialId = c.String(nullable: false, maxLength: 128),
                        Informe = c.String(nullable: false),
                        PacientesId_PacientesId = c.String(maxLength: 128),
                        ProfesionalesId_ProfesionalesId = c.String(maxLength: 128),
                        TurnosId_TurnosId = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.HistorialId)
                .ForeignKey("dbo.Pacientes", t => t.PacientesId_PacientesId)
                .ForeignKey("dbo.Profesionales", t => t.ProfesionalesId_ProfesionalesId)
                .ForeignKey("dbo.Turnos", t => t.TurnosId_TurnosId)
                .Index(t => t.PacientesId_PacientesId)
                .Index(t => t.ProfesionalesId_ProfesionalesId)
                .Index(t => t.TurnosId_TurnosId);
            
            CreateTable(
                "dbo.Pacientes",
                c => new
                    {
                        PacientesId = c.String(nullable: false, maxLength: 128),
                        Nombre = c.String(nullable: false, maxLength: 256),
                        Apellido = c.String(nullable: false, maxLength: 256),
                        Dni = c.String(nullable: false, maxLength: 128),
                        Calle = c.String(),
                        FechaNacimiento = c.DateTime(nullable: false),
                        Piso = c.String(),
                        Departamento = c.String(),
                        CodigoPostal = c.String(),
                        Email = c.String(nullable: false),
                        FechaIngreso = c.DateTime(nullable: false),
                        Eliminado = c.Boolean(nullable: false),
                        NumeroCredencial = c.String(),
                        LocalidadesId_LocalidadesId = c.String(maxLength: 128),
                        PlanesId_PlanesId = c.String(maxLength: 128),
                        UsuariosId_UsuariosId = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.PacientesId)
                .ForeignKey("dbo.Localidades", t => t.LocalidadesId_LocalidadesId)
                .ForeignKey("dbo.Planes", t => t.PlanesId_PlanesId)
                .ForeignKey("dbo.Usuarios", t => t.UsuariosId_UsuariosId)
                .Index(t => t.LocalidadesId_LocalidadesId)
                .Index(t => t.PlanesId_PlanesId)
                .Index(t => t.UsuariosId_UsuariosId);
            
            CreateTable(
                "dbo.Localidades",
                c => new
                    {
                        LocalidadesId = c.String(nullable: false, maxLength: 128),
                        Localidad = c.String(),
                        ProvinciaId = c.String(),
                    })
                .PrimaryKey(t => t.LocalidadesId);
            
            CreateTable(
                "dbo.Planes",
                c => new
                    {
                        PlanesId = c.String(nullable: false, maxLength: 128),
                        NombrePlan = c.String(),
                        SegurosMedicosId_SegurosMedicosId = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.PlanesId)
                .ForeignKey("dbo.SegurosMedicos", t => t.SegurosMedicosId_SegurosMedicosId)
                .Index(t => t.SegurosMedicosId_SegurosMedicosId);
            
            CreateTable(
                "dbo.SegurosMedicos",
                c => new
                    {
                        SegurosMedicosId = c.String(nullable: false, maxLength: 128),
                        NombreSeguroMedico = c.String(),
                    })
                .PrimaryKey(t => t.SegurosMedicosId);
            
            CreateTable(
                "dbo.Telefonos",
                c => new
                    {
                        TelefonosId = c.String(nullable: false, maxLength: 128),
                        Telefono = c.String(nullable: false),
                        TipoTelefono = c.Int(nullable: false),
                        Pacientes_PacientesId = c.String(maxLength: 128),
                        Profesionales_ProfesionalesId = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.TelefonosId)
                .ForeignKey("dbo.Pacientes", t => t.Pacientes_PacientesId)
                .ForeignKey("dbo.Profesionales", t => t.Profesionales_ProfesionalesId)
                .Index(t => t.Pacientes_PacientesId)
                .Index(t => t.Profesionales_ProfesionalesId);
            
            CreateTable(
                "dbo.Usuarios",
                c => new
                    {
                        UsuariosId = c.String(nullable: false, maxLength: 128),
                        Email = c.String(nullable: false, maxLength: 256),
                        EmailConfirmed = c.Boolean(nullable: false),
                        PasswordHash = c.String(nullable: false),
                        securityStamp = c.String(),
                        PhoneNumber = c.String(nullable: false),
                        PhoneNumberConfirm = c.Boolean(nullable: false),
                        TwoFactorEnabled = c.Boolean(nullable: false),
                        LockoutEndDateUtc = c.DateTime(nullable: false),
                        LockoutEnabled = c.Boolean(nullable: false),
                        AccessFailCount = c.Int(nullable: false),
                        UserName = c.String(),
                        AccessType = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.UsuariosId);
            
            CreateTable(
                "dbo.Profesionales",
                c => new
                    {
                        ProfesionalesId = c.String(nullable: false, maxLength: 128),
                        Nombre = c.String(nullable: false, maxLength: 256),
                        Apellido = c.String(nullable: false, maxLength: 256),
                        Dni = c.String(nullable: false, maxLength: 128),
                        FechaNacimiento = c.DateTime(nullable: false),
                        Calle = c.String(),
                        Piso = c.String(),
                        Departamento = c.String(),
                        CodigoPostal = c.String(),
                        Email = c.String(nullable: false),
                        FechaIngreso = c.DateTime(),
                        Eliminado = c.Boolean(nullable: false),
                        AtiendeDomicilio = c.Boolean(nullable: false),
                        LocalidadesId_LocalidadesId = c.String(nullable: false, maxLength: 128),
                        UsuariosId_UsuariosId = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.ProfesionalesId)
                .ForeignKey("dbo.Localidades", t => t.LocalidadesId_LocalidadesId, cascadeDelete: true)
                .ForeignKey("dbo.Usuarios", t => t.UsuariosId_UsuariosId)
                .Index(t => t.LocalidadesId_LocalidadesId)
                .Index(t => t.UsuariosId_UsuariosId);
            
            CreateTable(
                "dbo.Turnos",
                c => new
                    {
                        TurnosId = c.String(nullable: false, maxLength: 128),
                        FechaTurno = c.DateTime(nullable: false),
                        HoraTurno = c.Time(nullable: false, precision: 7),
                        FechaSolicitud = c.DateTime(nullable: false),
                        estadoTurno = c.Int(nullable: false),
                        EspecialidadesId_EspecialidadesId = c.String(nullable: false, maxLength: 128),
                        PacienteId_PacientesId = c.String(nullable: false, maxLength: 128),
                        ProfesionalesId_ProfesionalesId = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => t.TurnosId)
                .ForeignKey("dbo.Especialidades", t => t.EspecialidadesId_EspecialidadesId, cascadeDelete: true)
                .ForeignKey("dbo.Pacientes", t => t.PacienteId_PacientesId, cascadeDelete: true)
                .ForeignKey("dbo.Profesionales", t => t.ProfesionalesId_ProfesionalesId, cascadeDelete: true)
                .Index(t => t.EspecialidadesId_EspecialidadesId)
                .Index(t => t.PacienteId_PacientesId)
                .Index(t => t.ProfesionalesId_ProfesionalesId);
            
            CreateTable(
                "dbo.Provincias",
                c => new
                    {
                        ProvinciaId = c.String(nullable: false, maxLength: 128),
                        Provincia = c.String(),
                    })
                .PrimaryKey(t => t.ProvinciaId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Historials", "TurnosId_TurnosId", "dbo.Turnos");
            DropForeignKey("dbo.Turnos", "ProfesionalesId_ProfesionalesId", "dbo.Profesionales");
            DropForeignKey("dbo.Turnos", "PacienteId_PacientesId", "dbo.Pacientes");
            DropForeignKey("dbo.Turnos", "EspecialidadesId_EspecialidadesId", "dbo.Especialidades");
            DropForeignKey("dbo.Historials", "ProfesionalesId_ProfesionalesId", "dbo.Profesionales");
            DropForeignKey("dbo.Profesionales", "UsuariosId_UsuariosId", "dbo.Usuarios");
            DropForeignKey("dbo.Telefonos", "Profesionales_ProfesionalesId", "dbo.Profesionales");
            DropForeignKey("dbo.Profesionales", "LocalidadesId_LocalidadesId", "dbo.Localidades");
            DropForeignKey("dbo.Especialidades", "Profesionales_ProfesionalesId", "dbo.Profesionales");
            DropForeignKey("dbo.Historials", "PacientesId_PacientesId", "dbo.Pacientes");
            DropForeignKey("dbo.Pacientes", "UsuariosId_UsuariosId", "dbo.Usuarios");
            DropForeignKey("dbo.Telefonos", "Pacientes_PacientesId", "dbo.Pacientes");
            DropForeignKey("dbo.Pacientes", "PlanesId_PlanesId", "dbo.Planes");
            DropForeignKey("dbo.Planes", "SegurosMedicosId_SegurosMedicosId", "dbo.SegurosMedicos");
            DropForeignKey("dbo.Pacientes", "LocalidadesId_LocalidadesId", "dbo.Localidades");
            DropIndex("dbo.Turnos", new[] { "ProfesionalesId_ProfesionalesId" });
            DropIndex("dbo.Turnos", new[] { "PacienteId_PacientesId" });
            DropIndex("dbo.Turnos", new[] { "EspecialidadesId_EspecialidadesId" });
            DropIndex("dbo.Profesionales", new[] { "UsuariosId_UsuariosId" });
            DropIndex("dbo.Profesionales", new[] { "LocalidadesId_LocalidadesId" });
            DropIndex("dbo.Telefonos", new[] { "Profesionales_ProfesionalesId" });
            DropIndex("dbo.Telefonos", new[] { "Pacientes_PacientesId" });
            DropIndex("dbo.Planes", new[] { "SegurosMedicosId_SegurosMedicosId" });
            DropIndex("dbo.Pacientes", new[] { "UsuariosId_UsuariosId" });
            DropIndex("dbo.Pacientes", new[] { "PlanesId_PlanesId" });
            DropIndex("dbo.Pacientes", new[] { "LocalidadesId_LocalidadesId" });
            DropIndex("dbo.Historials", new[] { "TurnosId_TurnosId" });
            DropIndex("dbo.Historials", new[] { "ProfesionalesId_ProfesionalesId" });
            DropIndex("dbo.Historials", new[] { "PacientesId_PacientesId" });
            DropIndex("dbo.Especialidades", new[] { "Profesionales_ProfesionalesId" });
            DropTable("dbo.Provincias");
            DropTable("dbo.Turnos");
            DropTable("dbo.Profesionales");
            DropTable("dbo.Usuarios");
            DropTable("dbo.Telefonos");
            DropTable("dbo.SegurosMedicos");
            DropTable("dbo.Planes");
            DropTable("dbo.Localidades");
            DropTable("dbo.Pacientes");
            DropTable("dbo.Historials");
            DropTable("dbo.Especialidades");
        }
    }
}
