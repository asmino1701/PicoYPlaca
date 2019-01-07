﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PicoYPlaca
{
    public partial class Index : System.Web.UI.Page
    {
        public string placa;
        public string fecha;
        public string hora;
        public string minutos;
        
        
        protected void Page_Load(object sender, EventArgs e)
        {
            btnConsultar.Click += new EventHandler(this.onClick_btnConsultar);
            int cont=0;
            for (var i=0;i<24;i++)
            {                
                DDHora.Items.Add(new ListItem(cont.ToString(), cont.ToString()));
                cont++;               
            }
            cont = 0;
            for (var i = 0; i < 60; i++)
            {
                DDMinutos.Items.Add(new ListItem(cont.ToString(), cont.ToString()));
                cont++;
            }
            txtRespuesta.Text = "Respuesta: ";
        }

        void onClick_btnConsultar(object sender, EventArgs e)
        {
            Auto placaAuto = new Auto();
            Fecha fechaSeleccion = new Fecha();
            placa = txtplaca.Text;
            fecha = txtFecha.Text;
            hora = DDHora.SelectedValue;
            minutos = DDMinutos.SelectedValue;
            placaAuto.ObtenerPlaca(placa);
            string diaPlaca=placaAuto.DiaSemana;
            lblRespuesta.Text = fechaSeleccion.CompararDia(fecha, hora, minutos, diaPlaca);          
        }

    }
}