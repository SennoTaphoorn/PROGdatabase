using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROGopdracht
{
    internal class PROGpoketype
    {
        public string name { get; private set; }
        public PokemonTypes pokemonType { get; private set; }
        

        public Pokemon(string Name, PokemonTypes Type)
        {
            name = Name;
            pokemonType = Type;
        }

        public string GetName()
        {
            return name;
        }
    }
}
