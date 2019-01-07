using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Globalization;

namespace PicoYPlaca
{
    public class Fecha
    {
       public string FechaSeleccionada;
        public bool Dia= false;
        
        DateTime dateValue;
        public void CompararDia(string fechaIngresada, string hora, string minutos, string diaPlaca)
        {
            Auto diaSeleccionado = new Auto();
            Tiempo horaSeleccionado = new Tiempo();
            //string diaSelecto = diaSeleccionado.DiaSemana;

            dateValue = DateTime.ParseExact(fechaIngresada, "dd/mm/yyyy", CultureInfo.InvariantCulture);
            FechaSeleccionada = dateValue.ToString("dddd", new CultureInfo("es-ES"));

            if (diaPlaca == FechaSeleccionada)
            {
                Dia = true;
            }
            horaSeleccionado.CalculaHoras(Dia, hora, minutos);
        }
    }
}