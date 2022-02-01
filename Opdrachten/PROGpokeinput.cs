using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROGopdacht
{
    class PROGpokeinput
    {
        public Pokedex StartPokemon { get; set; }
        public Pokedex currentPokemon { get; set; }

        public Input()
        {
            
        }
        
        public int AskForInput(int Number)
        {
            int input;
            if (int.TryParse(Console.ReadLine(), out input))
            {
                if (input < Number)
                {
                    return input;
                }
                Console.WriteLine("Invalid Input");
            }
            else
            {
                Console.WriteLine("Invalid Input");
            }
            return AskForInput(Number);
        }
    }
}
