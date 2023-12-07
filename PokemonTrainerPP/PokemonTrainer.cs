

using System.Xml.Linq;

namespace PokemonTrainerPP
{
    public class PokemonTrainer
    {
        public string TrainerName { get; set; }
        public int Coins { get; set; }
        public int HealthPotions { get; set; }
        public int Pokeballs { get; set; }
        public List<Pokemon> myPokemons { get; set; }

        public PokemonTrainer(int coins, int healthPotions, int pokeballs)
        {
            Coins = coins;
            HealthPotions = healthPotions;
            Pokeballs = pokeballs;
        }

        public PokemonTrainer(int coins, int healthPotions, int pokeballs, List<Pokemon> myPokemons)
        {
            Coins = coins;
            HealthPotions = healthPotions;
            Pokeballs = pokeballs;
            this.myPokemons = myPokemons;
        }

        public void PrintInfo()
        {
            Console.Clear();
            Console.WriteLine("Your pokemon: \n");
            foreach (var pokemon in myPokemons)
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
