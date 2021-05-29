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
    public partial class Contact : Page
    {
        static List<Equipo> equipo = new List<Equipo>();
        static List<Jugador> jugado = new List<Jugador>();
       
        static List<Equipo> equipoCiudad = new List<Equipo>();

        protected void Page_Load(object sender, EventArgs e)
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

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int s = GridViewEquipo.SelectedIndex;
            GridViewEquipo.DataSource = equipo[s].Ciudad;
            GridViewEquipo.DataBind();
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string ciudad = TextBoxCiudad.Text;

            for(int x=0; x < equipo.Count; x++)
            {
                if (equipo[x].Ciudad == ciudad)
                {
                    equipoCiudad.Add(equipo[x]);
                }
                
            }

            GridViewEquipo.DataSource = equipoCiudad;
            GridViewEquipo.DataBind();



    }

        protected void TextBoxCiudad_TextChanged(object sender, EventArgs e)
        {

        }
    }
}