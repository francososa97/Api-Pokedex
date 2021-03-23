using PokeApi.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PokeApi.Helper
{
    public class OperacionPokemon
    {
        public List<Pokemon> Pokedex = new List<Pokemon>()
        {
             new Pokemon() { Id = 1, Nombre = "Bulbasaur" ,Tipo = new List<string>{"planta","veneno" },Altura=Convert.ToDecimal("1.2"),Peso=Convert.ToDecimal("6,9")},

        };
        public IEnumerable<Pokemon> GetPokedex()
        {
            return Pokedex;
        }

        public Pokemon GetPokedex(int id)
        {
            var cliente = Pokedex.Where(cli => cli.Id == id);

            return cliente.FirstOrDefault();
        }

        public void AddPokedex(Pokemon nuevoCliente)
        {
            Pokedex.Add(nuevoCliente);
            //validar por id
        }
        public bool DeletePokemon(int id)
        {
            var pokemon = Pokedex.Where(pokemon => pokemon.Id == id).FirstOrDefault();
            Pokedex.Remove(pokemon);

            var verificacion = Pokedex.Where(pokemon => pokemon.Id == id).FirstOrDefault();

            if (verificacion == null)
                return true;
            else
                return false;
        }
    }
}
