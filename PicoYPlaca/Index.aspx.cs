using System;
using System.Text.RegularExpressions;
using System.Web.UI.WebControls;

namespace PicoYPlaca
{
    public partial class Index : System.Web.UI.Page
    {
        public string placa;
        public string fecha;
        public string hora;
        public string minutos;
        static Regex ValidaPlaca = new Regex("^([abucxhoewgilrmvnspqktzyj|ABUCXHOEWGILRMVNSPQKTZYJ]\\w{0})+(-)+([0-9]\\d{3}\\z)");
        static Regex ValidaFecha = new Regex("^((((0[1-9])|([1-2][0-9])|(3[0-1]))|([1-9]))\x2F(((0[1-9])|(1[0-2]))|([1-9]))\x2F(([0-9]{2})|(((19)|([2]([0]{1})))([0-9]{2}))))$");

        protected void Page_Load(object sender, EventArgs e)
        {
            btnConsultar.Click += new EventHandler(this.onClick_btnConsultar);
            int cont = 0;
            for (var i = 0; i < 24; i++)
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
        }

        void onClick_btnConsultar(object sender, EventArgs e)
        {
            Auto placaAuto = new Auto();
            Fecha fechaSeleccion = new Fecha();
            placa = txtplaca.Text;
            fecha = txtFecha.Text;
            hora = DDHora.SelectedValue;
            minutos = DDMinutos.SelectedValue;
            string valPlaca = ValidacionesPlaca();
            string valFecha = ValidacionesFecha();
            if ((valPlaca == "OK") && valFecha == "OK")
            {
                
                placaAuto.ObtenerPlaca(placa);
                string diaPlaca = placaAuto.DiaSemana;
                lblRespuesta.Text = fechaSeleccion.CompararDia(fecha, hora, minutos, diaPlaca);
            }
        }

        public string ValidacionesPlaca()
        {
            string msj = string.Empty;
            if (!ValidaPlaca.IsMatch(placa))
            {
                lblvalidarPlaca.Text = "* Ingrese en el siguiente formato: ABC-0123 o abc-1234";
                lblvalidarPlaca.ForeColor = System.Drawing.Color.Red; ;
                return msj="";
            } else { lblvalidarPlaca.Text = ""; }
            
            return msj="OK";
        }

        public string ValidacionesFecha()
        {
            string msj = string.Empty;
            
            if (!ValidaFecha.IsMatch(fecha))
            {
                LlbValidarFecha.Text = "* Ingrese en el siguiente formato: dd/mm/aaaa";
                LlbValidarFecha.ForeColor = System.Drawing.Color.Red; ;
                return msj = "";
            }
            else { LlbValidarFecha.Text = ""; }
            return msj = "OK";
        }
    }
}