

using System.Xml.Linq;

namespace PokemonTrainerPP
{
    internal class PokemonTrainer
    {
        internal string TrainerName { get; set; }
        internal int Coins { get; set; }
        internal int HealthPotions { get; set; }
        internal int Pokeballs { get; set; }
        internal List<Pokemon> MyPokemons { get; set; }

        internal PokemonTrainer(int coins, int healthPotions, int pokeballs)
        {
            Coins = coins;
            HealthPotions = healthPotions;
            Pokeballs = pokeballs;
        }

        internal PokemonTrainer(int coins, int healthPotions, int pokeballs, List<Pokemon> myPokemons)
        {
            Coins = coins;
            HealthPotions = healthPotions;
            Pokeballs = pokeballs;
            this.MyPokemons = myPokemons;
        }

        internal void PrintInfo()
        {
            Console.Clear();
            Console.WriteLine("Your pokemon: \n");
            foreach (var pokemon in MyPokemons)
            {
                Console.WriteLine($"Name : {pokemon.Name}");
                Console.WriteLine($"Level: {pokemon.Level}");
                Console.WriteLine($"HP   : {pokemon.Health}\n");

            }
            Console.WriteLine("Press any button to continue");
            Console.ReadLine();
            Console.Clear();
        }
    }
}
