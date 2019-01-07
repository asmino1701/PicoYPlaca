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
        DateTime dateValue;
        public void ObtenerDia(string fechaIngresada)
        {
            dateValue = DateTime.ParseExact(fechaIngresada, "dd/mm/yyyy", CultureInfo.InvariantCulture);
            FechaSeleccionada = dateValue.ToString("dddd", new CultureInfo("es-ES"));
        }
    }
}