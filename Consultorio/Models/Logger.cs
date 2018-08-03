using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.IO;

namespace Consultorio.Models
{
    public class Logger
    {
        public string path { get; set; }
        public string FileName { get; set; }

        public Logger()
        {
            path = "C:\\WorkspaceCSharp\\Consultorio\\log.txt";
        }
        public Logger( string  costumPath )
        {
            path = costumPath;
        }
        public Logger(string costumPath, string customFleName)
        {
            path = costumPath;
            FileName = customFleName;
        }

        
        public int PrintLog(string msg)
        {
            string[] log = new string[1];
            log[0] =  $"[{DateTime.Today.ToShortDateString()} - {DateTime.UtcNow.ToLongTimeString()}] {msg}" ;
            //path += $"\\{FileName}";
            int ret = 0;
            //log = "\n" + log;
            try
            {
             
                File.AppendAllLines(path, log);
                
                //using(StreamWriter streamwriter = new StreamWriter(path))
                //{
                //    streamwriter.WriteLine(msg);
                //    streamwriter.Close();
                //}
            }catch(Exception e)
            {
                Console.WriteLine("Error al Grabar Log :" + e.ToString());
                ret = -1;
            }


            return ret;
        }
    }
}