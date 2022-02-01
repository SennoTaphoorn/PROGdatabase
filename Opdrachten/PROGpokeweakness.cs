using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROGopdracht
{
     public abstract class PROGpokeweakness
    {
        public List<PokemonTypes> weaknesses { get; private set; }
        public string pokemontypes { get; private set; }
        public PokemonTypes(string Type)
        {
            pokemontypes = Type;
            weaknesses = new List<PokemonTypes>();
        }
        public bool CheckWeakness(PokemonTypes typeToCheckAgainst)
        {
            bool WeakAgainst = weaknesses.Contains(typeToCheckAgainst);
            return WeakAgainst;
        }
        public void AddWeakness(PokemonTypes addPokemonType)
        {
            weaknesses.Add(addPokemonType);
        }

    }
}
