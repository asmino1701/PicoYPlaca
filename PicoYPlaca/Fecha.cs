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
        Auto diaSeleccionado = new Auto();
        DateTime dateValue;
        public void CompararDia(string fechaIngresada)
        {
            dateValue = DateTime.ParseExact(fechaIngresada, "dd/mm/yyyy", CultureInfo.InvariantCulture);
            FechaSeleccionada = dateValue.ToString("dddd", new CultureInfo("es-ES"));

            if (diaSeleccionado.DiaSemana == FechaSeleccionada)
            {
                Dia = true;
            }
        }
    }
}