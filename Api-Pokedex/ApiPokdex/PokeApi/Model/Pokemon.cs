using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PokeApi.Model
{
    public class Pokemon
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public List<string> Tipo { get; set; }
        public decimal Altura { get; set; }
        public decimal Peso { get; set; }
    }
}
