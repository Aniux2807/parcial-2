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
    public partial class About : Page
    {
        static List<Equipo> equipo = new List<Equipo>();

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

        protected void Button1_Click(object sender, EventArgs e)
        {

        }

        protected void ButtonEditar_Click(object sender, EventArgs e)
        {
            Equipo equi = equipo.Find(p => p.Nombre == TextBoxNombreE.Text);

            if (equi != null)
            {
                TextBoxNombreEquipo.Text = equi.Nombre;
                TextBoxNombreEquipo.Text = equi.Nombre;
                TextBoxCiudad.Text = equi.Ciudad;
                TextBoxAño.Text = equi.AñoFund;
                GridViewJugadores.DataSource = equi.Jugadores;
                GridViewJugadores.DataBind();
                GuardarArchivoJson();
            }
            else
            {
                Response.Write("<script>alert('El equipo no existe')</script>");
            }
        }

        protected void GridViewActores_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = GridViewJugadores.SelectedIndex;
            Equipo pelicula = equipo.Find(p => p.Nombre == TextBoxNombreE.Text);

            TextBoxJugador.Text = pelicula.Jugadores[id].Nombre;
        }

        protected void ButtonEditarNombre_Click(object sender, EventArgs e)
        {
            int id = GridViewJugadores.SelectedIndex;
            Equipo equ = equipo.Find(p => p.Nombre == TextBoxNombreE.Text);

            equ.Jugadores[id].Nombre = TextBoxJugador.Text;
            GridViewJugadores.DataSource = equ.Jugadores;
            GridViewJugadores.DataBind();
        }

        protected void TextBoxNombreE_TextChanged(object sender, EventArgs e)
        {

        }
    }
}