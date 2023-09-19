using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace решение_задач_по_программированию_для_2023
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Cikl cikl = new Cikl();
            //file file = new file();        
            //file.Output_Inf();
            ////cikl.perevorot();
            ////cikl.calculator();

            Geymurchik geymurchik = new Geymurchik();
            //geymurchik.kvadrat();
            //geymurchik.kub();
            //geymurchik.xuy1();
            //geymurchik.cisli1();
            raspred raspred = new raspred();
            //raspred.Severozapad();
            //raspred.MinElements();
            Djonson djonson = new Djonson();
            djonson.ReadFile();
        }
    }
}
