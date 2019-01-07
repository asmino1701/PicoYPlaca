using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PicoYPlaca
{
    public class Tiempo
    {
        
        public void CalculaHoras(bool DiaSeleccion, string horasSeleccion, string minutosSeleccion)
        {
            Index horaSeleccionada = new Index();
            int hora = Int32.Parse(horasSeleccion);
            int minutos = Int32.Parse(minutosSeleccion);
            if (DiaSeleccion)
            {
                if ((hora >= 7) && (hora <= 9))
                {
                    if((minutos > 30) && (hora==9))
                    {
                        horaSeleccionada.ActualizarResultado("El pico y placa ha finalizado a las 9:30.");
                    }
                    else horaSeleccionada.ActualizarResultado("El auto se encuentra en pico y placa de 7am a 9:30am.");
                }
                else if ((hora >= 16) && (hora <= 19))
                {
                    if ((minutos > 30) && (hora == 19))
                    {
                        horaSeleccionada.ActualizarResultado("El pico y placa ha finalizado a las 19:30.");
                    } else horaSeleccionada.ActualizarResultado("El auto se encuentra en pico y placa de 4pm a 7:30pm.");
                }
                else
                {
                    horaSeleccionada.ActualizarResultado("El auto no se encuentra en pico y placa.");
                }
            }
            else
            {
                horaSeleccionada.ActualizarResultado("El auto no se encuentra en pico y placa.");
            }
        }
    }
}