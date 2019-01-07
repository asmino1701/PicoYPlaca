using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PicoYPlaca
{

    public class Auto
    {
        public string DiaSemana="";        
        public void ObtenerPlaca(string placaVehiculo)
        {
            //obtengo el último caracter del string
            string output = placaVehiculo.Substring(placaVehiculo.Length - 1, 1);

            switch (output)
            {

                case "1":
                    DiaSemana = "lunes";
                    break;
                case "2":
                    DiaSemana = "lunes";
                    break;
                case "3":
                    DiaSemana = "martes";
                    break;
                case "4":
                    DiaSemana = "martes";
                    break;
                case "5":
                    DiaSemana = "miércoles";
                    break;
                case "6":
                    DiaSemana = "miércoles";
                    break;
                case "7":
                    DiaSemana = "jueves";
                    break;
                case "8":
                    DiaSemana = "jueves";
                    break;
                case "9":
                    DiaSemana = "viernes";
                    break;
                case "0":
                    DiaSemana = "viernes";
                    break;
                default:
                    break;
            }

        }

    }

}