using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dominio.Entities
{
    public class Equipo : BaseEntity
    {
        public string NombreEquipo { get; set; }
        public int IdPaisFk { get; set; }
        public Pais Pais {get; set;}
        public ICollection<Persona> Personas {get; set;}
    }
}