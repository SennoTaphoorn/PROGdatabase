using System;

namespace PROGopdacht
{
    class PROGdatabase
    {
        static void Main(string[] args)
        {
            Pokedex PokeDex = new Pokedex();
            Input Start = new Input();

            Pokemon Jolteon = new Pokemon("Jolteon", electric);
            Pokemon Pikachu = new Pokemon("Pikachu", electric);
            Pokemon Zapdos = new Pokemon("Zapdos", electric);
            Pokemon Flareon = new Pokemon("Flareon", fire);
            Pokemon Vulpix = new Pokemon("Vulpix", fire);
            Pokemon Charizard = new Pokemon("Charizard", fire);
            Pokemon Slowpoke = new Pokemon("Slowpoke", water);
            Pokemon Vaporeon = new Pokemon("Vaporeon", water);
            Pokemon Blastoise = new Pokemon("Blastoise", water);
            Pokemon Bulbasaur = new Pokemon("Bulbasaur", grass);
            Pokemon Leafeon = new Pokemon("Leafeon", grass);
            Pokemon Arceus = new Pokemon("Arceus", grass);

            PokeDex.AddPokemon(Jolteon);
            PokeDex.AddPokemon(Pikachu);
            PokeDex.AddPokemon(Zapdos);
            PokeDex.AddPokemon(Flareon);
            PokeDex.AddPokemon(Vulpix);
            PokeDex.AddPokemon(Charizard);
            PokeDex.AddPokemon(Slowpoke);
            PokeDex.AddPokemon(Vaporeon);
            PokeDex.AddPokemon(Blastoise);
            PokeDex.AddPokemon(Bulbasaur);
            PokeDex.AddPokemon(Leafeon);
            PokeDex.AddPokemon(Arceus);

            Water water = new Water("Water");
            Grass grass = new Grass("Grass");
            Electric electric = new Electric("Electric");
            Fire fire = new Fire("Fire");
            water.AddWeakness(grass);
            water.AddWeakness(electric);
            grass.AddWeakness(fire);
            fire.AddWeakness(water);

            while (true)
            {
                int choice = Start.AskForInput(6);

                if (choice == 1)
                {
                    foreach (Pokemon p in PokeDex.GetPokemons())
                    {
                        Console.WriteLine("\n" + p.GetName() + ", " + p.pokemonType.pokemontype + "\n");
                    }
                }

                if (choice == 2)
                {
                    foreach (Pokemon p in PokeDex.GetPokemons())
                    {
                        if (p.pokemonType.pokemontype == "Electric")
                        {
                            Console.WriteLine("\n" + p.GetName() + ", " + p.pokemonType.pokemontype + "\n");
                        }

                    }
                }

                if (choice == 3)
                {
                    foreach (Pokemon p in PokeDex.GetPokemons())
                    {
                        if (p.pokemonType.pokemontype == "Fire")
                        {
                            Console.WriteLine("\n" + p.GetName() + ", " + p.pokemonType.pokemontype + "\n");
                        }

                    }
                }

                if (choice == 4)
                {
                    foreach (Pokemon p in PokeDex.GetPokemons())
                    {
                        if (p.pokemonType.pokemontype == "Water")
                        {
                            Console.WriteLine("\n" + p.GetName() + ", " + p.pokemonType.pokemontype + "\n");
                        }

                    }
                }

                if (choice == 5)
                {
                    foreach (Pokemon p in PokeDex.GetPokemons())
                    {
                        if (p.pokemonType.pokemontype == "Grass")
                        {
                            Console.WriteLine("\n" + p.GetName() + ", " + p.pokemonType.pokemontype + "\n");
                        }

                    }
                }
            }
        }
    }
}
