using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dominio.Entities
{
    public class Persona : BaseEntity
    {
        public string NombrePersona { get; set; }
        public string ApellidpPersona { get; set; }
        public int Edad { get; set; }
        public int IdTipoNominaFk { get; set; }
        public TipoNomina TipoNomina {get; set;}
        public int IdEquipoFk { get; set; }
        public Equipo Equipo {get; set;}
        public Jugador Jugador {get; set;}
    }
}