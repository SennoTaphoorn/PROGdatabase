using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROGopdracht
{
    internal class PROGaddpokemon
    {
        public List<Pokemon> pokemon { get; private set; }
        public List<PokemonType> pokeTypes { get; private set; }

        public Pokedex()
        {
            pokemon = new List<Pokemon>();
            pokeTypes = new List<PokemonType>();
        }

        public void AddPokemon(Pokemon addPokemon)
        {
            pokemon.Add(addPokemon);
        }

        public List<Pokemon> GetPokemons()
        {
            return pokemon;
        }
    }
}
