using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Cartelera_de_Cine
{
    public class Equipo
    {
        string nombre;
        string ciudad;
        string añoFund;
        List<Jugador> jugadoress = new List<Jugador>();

        public string Nombre { get => nombre; set => nombre = value; }
        public string Ciudad { get => ciudad; set => ciudad = value; }
        public string AñoFund { get => añoFund; set => añoFund = value; }
        public List<Jugador> Jugadores { get => jugadoress; set => jugadoress = value; }
       
    }
}