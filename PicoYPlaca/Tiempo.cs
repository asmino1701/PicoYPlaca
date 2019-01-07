using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PicoYPlaca
{
    public class Tiempo
    {
        
        public String CalculaHoras(bool DiaSeleccion, string horasSeleccion, string minutosSeleccion)
        {
            
            string mensaje=string.Empty;
            int hora = Int32.Parse(horasSeleccion);
            int minutos = Int32.Parse(minutosSeleccion);
            if (DiaSeleccion)
            {
                if ((hora >= 7) && (hora <= 9))
                {
                    if((minutos > 30) && (hora==9))
                    {
                        mensaje ="El pico y placa ha finalizado a las 9:30." ;
                    }
                    else mensaje = "El auto se encuentra en pico y placa de 7am a 9:30am.";
                }
                else if ((hora >= 16) && (hora <= 19))
                {
                    if ((minutos > 30) && (hora == 19))
                    {
                        mensaje = "El pico y placa ha finalizado a las 19:30.";
                    } else mensaje = "El auto se encuentra en pico y placa de 4pm a 7:30pm.";
                }
                else
                {
                    mensaje = "El auto no se encuentra en pico y placa.";
                }
            }
            else
            {
                mensaje = "El auto no se encuentra en pico y placa.";
            }
            return mensaje;
        }
    }
}