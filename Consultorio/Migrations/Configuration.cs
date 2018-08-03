namespace Consultorio.Migrations
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.IO;
    using System.Linq;
    using Consultorio.Models;
    using Consultorio.DAL;

    internal sealed class Configuration : DbMigrationsConfiguration<Consultorio.DAL.ConsultorioContext>
    {
        
        Logger log = new Logger { FileName = @"Log.txt" };
        public Configuration()
        {
            log.PrintLog("Entro en configuracion");
            try
            {
                AutomaticMigrationsEnabled = true;
                Database.SetInitializer(new ConsultorioInitializer());
            }
            catch (Exception e)
            {
                log.PrintLog("Error " + e.ToString());
            }
        }
        
    }
}
