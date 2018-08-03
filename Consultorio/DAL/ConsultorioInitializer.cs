using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.IO;
using System.Collections;
using Consultorio.Models;

namespace Consultorio.DAL
{
    public class ConsultorioInitializer : DropCreateDatabaseAlways<ConsultorioContext>
    {
        Logger log = new Logger { FileName = @"Log.txt" };
        protected override void Seed(ConsultorioContext context)
        {

            log.PrintLog("Entro en Seed - Initializer");
            //Cargo todas las provincias
            IList<Provincias> provincias = new List<Provincias>();
            int provId = 1;
            string vi = "Buenos Aires,Buenos Aires-GBA,Capital Federal,Catamarca,Chaco,Chubut,Córdoba,Corrientes,Entre Ríos," +
                "Formosa,Jujuy,La Pampa,La Rioja,Mendoza,Misiones,Neuquén,Río Negro,Salta,San Juan,San Luis,Santa Cruz,Santa Fe," +
                "Santiago del Estero,Tierra del Fuego,Tucumán";
            string[] vs = vi.Split(',');
            foreach (string pair in vs)
            {
                provincias.Add(new Provincias { ProvinciaId = provId++.ToString(), Provincia = pair });
            }
            log.PrintLog("Cargue las provincias " + provincias.Count);
            //Cargo todas las localidades
            IList<Localidades> localidades = new List<Localidades>();
            int locId = 1;
            try
            {
                StreamReader reader = new StreamReader(@"C:\\WorkspaceCSharp\\Consultorio\\CargaProvincia.txt");
                vi = "";
                ArrayList arrayList = new ArrayList();
                while((vi = reader.ReadLine()) != null)
                {
                    if(vi != null)
                    {
                        vs = vi.Split(':');
                        localidades.Add(new Localidades { LocalidadesId = locId++.ToString(), ProvinciaId = vs[0], Localidad = vs[1] });
                    }
                }
                reader.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Error en apertura de archivo: " + e.ToString());
                log.PrintLog("Error en apertura de archivo ");
            }
            log.PrintLog("Cargue las localidades " + localidades.Count);
            int sm = 1;
            IList<SegurosMedicos> segurosMedicos = new List<SegurosMedicos>();
            segurosMedicos.Add(new SegurosMedicos { SegurosMedicosId = sm++.ToString(), NombreSeguroMedico = "Galeno" } );
            segurosMedicos.Add(new SegurosMedicos { SegurosMedicosId = sm++.ToString(), NombreSeguroMedico = "Swiss Medical" });
            segurosMedicos.Add(new SegurosMedicos { SegurosMedicosId = sm++.ToString(), NombreSeguroMedico = "Medicus" });
            segurosMedicos.Add(new SegurosMedicos { SegurosMedicosId = sm++.ToString(), NombreSeguroMedico = "Osde" });
            segurosMedicos.Add(new SegurosMedicos { SegurosMedicosId = sm++.ToString(), NombreSeguroMedico = "Sancor" });
            segurosMedicos.Add(new SegurosMedicos { SegurosMedicosId = sm++.ToString(), NombreSeguroMedico = "Accord" });
            segurosMedicos.Add(new SegurosMedicos { SegurosMedicosId = sm++.ToString(), NombreSeguroMedico = "Bristol" });

            int pl = 1;
            IList<Planes> planes = new List<Planes>();
            planes.Add(new Planes { PlanesId = pl++.ToString(), SegurosMedicosId = segurosMedicos[0], NombrePlan = "220" });
            planes.Add(new Planes { PlanesId = pl++.ToString(), SegurosMedicosId = segurosMedicos[0], NombrePlan = "330" });
            planes.Add(new Planes { PlanesId = pl++.ToString(), SegurosMedicosId = segurosMedicos[0], NombrePlan = "440" });
            planes.Add(new Planes { PlanesId = pl++.ToString(), SegurosMedicosId = segurosMedicos[0], NombrePlan = "550" });
            planes.Add(new Planes { PlanesId = pl++.ToString(), SegurosMedicosId = segurosMedicos[1], NombrePlan = "SMG01" });
            planes.Add(new Planes { PlanesId = pl++.ToString(), SegurosMedicosId = segurosMedicos[1], NombrePlan = "SMG02" });
            planes.Add(new Planes { PlanesId = pl++.ToString(), SegurosMedicosId = segurosMedicos[1], NombrePlan = "SMG10" });
            planes.Add(new Planes { PlanesId = pl++.ToString(), SegurosMedicosId = segurosMedicos[1], NombrePlan = "SMG20" });
            planes.Add(new Planes { PlanesId = pl++.ToString(), SegurosMedicosId = segurosMedicos[1], NombrePlan = "SMG30" });
            planes.Add(new Planes { PlanesId = pl++.ToString(), SegurosMedicosId = segurosMedicos[1], NombrePlan = "SMG40" });
            planes.Add(new Planes { PlanesId = pl++.ToString(), SegurosMedicosId = segurosMedicos[1], NombrePlan = "SMG50" });
            planes.Add(new Planes { PlanesId = pl++.ToString(), SegurosMedicosId = segurosMedicos[1], NombrePlan = "SMG60" });
            planes.Add(new Planes { PlanesId = pl++.ToString(), SegurosMedicosId = segurosMedicos[1], NombrePlan = "SMG70" });
            planes.Add(new Planes { PlanesId = pl++.ToString(), SegurosMedicosId = segurosMedicos[2], NombrePlan = "Azul" });
            planes.Add(new Planes { PlanesId = pl++.ToString(), SegurosMedicosId = segurosMedicos[2], NombrePlan = "Celeste" });
            planes.Add(new Planes { PlanesId = pl++.ToString(), SegurosMedicosId = segurosMedicos[2], NombrePlan = "One" });
            planes.Add(new Planes { PlanesId = pl++.ToString(), SegurosMedicosId = segurosMedicos[2], NombrePlan = "Integra" });
            planes.Add(new Planes { PlanesId = pl++.ToString(), SegurosMedicosId = segurosMedicos[2], NombrePlan = "Centro Medicus" });
            planes.Add(new Planes { PlanesId = pl++.ToString(), SegurosMedicosId = segurosMedicos[3], NombrePlan = "210" });
            planes.Add(new Planes { PlanesId = pl++.ToString(), SegurosMedicosId = segurosMedicos[3], NombrePlan = "310" });
            planes.Add(new Planes { PlanesId = pl++.ToString(), SegurosMedicosId = segurosMedicos[3], NombrePlan = "410" });
            planes.Add(new Planes { PlanesId = pl++.ToString(), SegurosMedicosId = segurosMedicos[3], NombrePlan = "510" });
            planes.Add(new Planes { PlanesId = pl++.ToString(), SegurosMedicosId = segurosMedicos[3], NombrePlan = "Neo" });
            planes.Add(new Planes { PlanesId = pl++.ToString(), SegurosMedicosId = segurosMedicos[3], NombrePlan = "Plan Joven" });
            planes.Add(new Planes { PlanesId = pl++.ToString(), SegurosMedicosId = segurosMedicos[4], NombrePlan = "S400" });
            planes.Add(new Planes { PlanesId = pl++.ToString(), SegurosMedicosId = segurosMedicos[4], NombrePlan = "S350J" });
            planes.Add(new Planes { PlanesId = pl++.ToString(), SegurosMedicosId = segurosMedicos[4], NombrePlan = "S350" });
            planes.Add(new Planes { PlanesId = pl++.ToString(), SegurosMedicosId = segurosMedicos[4], NombrePlan = "S300" });
            planes.Add(new Planes { PlanesId = pl++.ToString(), SegurosMedicosId = segurosMedicos[4], NombrePlan = "S250J" });
            planes.Add(new Planes { PlanesId = pl++.ToString(), SegurosMedicosId = segurosMedicos[4], NombrePlan = "S250" });
            planes.Add(new Planes { PlanesId = pl++.ToString(), SegurosMedicosId = segurosMedicos[4], NombrePlan = "S200" });
            planes.Add(new Planes { PlanesId = pl++.ToString(), SegurosMedicosId = segurosMedicos[4], NombrePlan = "S100" });
            planes.Add(new Planes { PlanesId = pl++.ToString(), SegurosMedicosId = segurosMedicos[5], NombrePlan = "Accord110" });
            planes.Add(new Planes { PlanesId = pl++.ToString(), SegurosMedicosId = segurosMedicos[5], NombrePlan = "Accord210" });
            planes.Add(new Planes { PlanesId = pl++.ToString(), SegurosMedicosId = segurosMedicos[5], NombrePlan = "Accord310" });
            planes.Add(new Planes { PlanesId = pl++.ToString(), SegurosMedicosId = segurosMedicos[6], NombrePlan = "BM 500" });
            planes.Add(new Planes { PlanesId = pl++.ToString(), SegurosMedicosId = segurosMedicos[6], NombrePlan = "BM 400" });
            planes.Add(new Planes { PlanesId = pl++.ToString(), SegurosMedicosId = segurosMedicos[6], NombrePlan = "BM 200" });
            planes.Add(new Planes { PlanesId = pl++.ToString(), SegurosMedicosId = segurosMedicos[6], NombrePlan = "BM 180" });

            log.PrintLog("Cargue las cargue planes y Servicio Medico ");

            context.SegurosMedicos.AddRange(segurosMedicos);
            context.Provincias.AddRange(provincias);
            context.Localidades.AddRange(localidades);
            log.PrintLog("Grabe todo en el Context");

            //Cargo toda la clase en el Seed
            base.Seed(context);
        }
    }
}

