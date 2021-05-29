using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Cartelera_de_Cine
{
    public partial class _Default : Page
    {
        static List<Equipo> equipo = new List<Equipo>();
        static List<Jugador> jugado = new List<Jugador>();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                string archivo = Server.MapPath("Peliculas.json");

                if (File.Exists(archivo))
                {
                    StreamReader jsonStream = File.OpenText(archivo);
                    string json = jsonStream.ReadToEnd();
                    jsonStream.Close();

                    equipo = JsonConvert.DeserializeObject<List<Equipo>>(json);
                }
            }
        }

        private void GuardarArchivoJson()
        {
            string json = JsonConvert.SerializeObject(equipo);
            string archivo = Server.MapPath("Peliculas.json");
            System.IO.File.WriteAllText(archivo, json);
        }

        private void ingresoEquipos()
        {
            Equipo equi = new Equipo();
            equi.Nombre = TextBoxNombreEquipo.Text;
            equi.Ciudad = TextBoxCiudad.Text;
            equi.AñoFund = TextBoxAño.Text;
            equi.Jugadores = jugado.ToList();

            equipo.Add(equi);
           

        }
        private void ingresarJugador()
        {
            Jugador jugadorrr = new Jugador(); 
            jugadorrr.Nombre = TextBoxNombreJugador.Text;

            jugado.Add(jugadorrr);
        }

        protected void ButtonGuardarPelicula_Click(object sender, EventArgs e)
        {
            if (equipo == null)
            {
                ingresoEquipos();
                Response.Write("<script>alert('El equipo ha sido ingresado')</script>");
            }
            else
            {
                Equipo equ = equipo.Find(p => p.Nombre == TextBoxNombreEquipo.Text);
                if (equipo == null)
                {
                    ingresoEquipos();
                    Response.Write("<script>alert('El equipo ha sido ingresado')</script>");
                }
                else
                {
                    Response.Write("<script>alert('El equipo ya ha sido ingresado')</script>");
                }
            }

            GuardarArchivoJson();
            TextBoxNombreEquipo.Text = "";
            TextBoxCiudad.Text = "";
            TextBoxAño.Text = "";

        }

        

        protected void ButtonIngresarActor_Click(object sender, EventArgs e)
        {
           
            if (jugado==null)
            {
                ingresarJugador();
            }
            else
            {
                Jugador actor = jugado.Find(a => a.Nombre == TextBoxNombreJugador.Text);
                if(actor!= null)
                {
                    Response.Write("<script>alert('El jugador ya ha sido ingresado')</script>");
                }
                else
                {
                    ingresarJugador();
                    Response.Write("<script>alert('El jugador ha sido ingresado ')</script>");
                }
            }

            
            TextBoxNombreJugador.Text = "";

        }

        protected void TextBoxNombreEquipo_TextChanged(object sender, EventArgs e)
        {

        }
    }
}