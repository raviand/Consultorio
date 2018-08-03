using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Consultorio.Models;
using System.IO;
using System.Collections;

namespace Consultorio.Controllers
{
    public class HomeController : Controller
    {
        Logger log = new Logger { FileName = @"Log.txt" };
        public ActionResult Index()
        {

            //int locId = 1;
            //try
            //{
            //    StreamReader reader = new StreamReader(@"C:\\WorkspaceCSharp\\Consultorio\\CargaProvincia.txt");
            //    string[] vs = new string[2];
            //    string vi = "";
            //    int pos = 0;
            //    ArrayList arrayList = new ArrayList();
            //    log.PrintLog("Ingresando al Wile");
            //    while ((vi = reader.ReadLine()) != null)
            //    {
                    
                
            //        vs = vi.Split(':');

            //        log.PrintLog($"linea: {pos++}  = {vs[0]} - {vs[1]}");
                    
            //    }
            //    reader.Close();

            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine("Error en apertura de archivo: " + e.ToString());
            //    log.PrintLog("Error en apertura de archivo ");
            //}



            log.PrintLog("Ingreso a Index");
            ViewBag.Message = "Bienvenido a la web de Natalia Gonzalez";
            log.PrintLog("Ingreso a Ejecuto el View");
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";
            log.PrintLog("Estoy en About");
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";
            log.PrintLog("Estoy en Contact");
            return View();
        }
    }
}