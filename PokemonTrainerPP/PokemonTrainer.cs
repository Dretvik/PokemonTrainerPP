
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
        internal List<Pokemon> MyCombatTeam { get; set; }
        internal int NumberOfPokemonSeen { get; set; }
        internal int TimesFleedOrRunAway { get; set; }


        internal PokemonTrainer(int coins, int healthPotions, int pokeballs)
        {
            Coins = coins;
            HealthPotions = healthPotions;
            Pokeballs = pokeballs;
        }

        internal PokemonTrainer(int coins, int healthPotions, int pokeballs, List<Pokemon> myPokemons, List<Pokemon> myCombatTeam,int numberOfPokemonSeen)
        {
            Coins = coins;
            HealthPotions = healthPotions;
            Pokeballs = pokeballs;
            this.MyPokemons = myPokemons;
            this.MyCombatTeam = myCombatTeam;
            NumberOfPokemonSeen = numberOfPokemonSeen;
        }

        internal void PrintInfo()
        {
            Console.Clear();
            Console.WriteLine("Your stored pokemon: \n");

            for (int i = 1; i < MyPokemons.Count +1; i++)
            {
                Console.WriteLine($"Pokemon nr: {i}");
                Console.WriteLine($"Name           : {MyPokemons[i -1].Name}");
                Console.WriteLine($"Level          : {MyPokemons[i -1].Level}");
                Console.WriteLine($"Exp Points     : {MyPokemons[i -1].Experience}");
                Console.WriteLine($"Exp to next lvl: {MyPokemons[i -1].Level * 10 - MyPokemons[i -1].Experience}");
                Console.WriteLine($"HP             : {MyPokemons[i -1].Health}");
                Console.WriteLine($"Attack         : {MyPokemons[i -1].Attack}\n");
            }
        }

        internal void PrintCombatTeam()
        {
            Console.CursorTop = 0;
            Console.CursorLeft = 30;
            Console.WriteLine("Your pokemon in Combat Team: \n");

            for (int i = 1; i < MyCombatTeam.Count + 1; i++)
            {

                Console.CursorLeft = 30;
                Console.WriteLine($"Pokemon nr: {i}");
                Console.CursorLeft = 30;
                Console.WriteLine($"Name           : {MyCombatTeam[i - 1].Name}");
                Console.CursorLeft = 30;
                Console.WriteLine($"Level          : {MyCombatTeam[i - 1].Level}");
                Console.CursorLeft = 30;
                Console.WriteLine($"Exp Points     : {MyCombatTeam[i - 1].Experience}");
                Console.CursorLeft = 30;
                Console.WriteLine($"Exp to next lvl: {MyCombatTeam[i - 1].Level * 10 - MyCombatTeam[i - 1].Experience}");
                Console.CursorLeft = 30;
                Console.WriteLine($"HP             : {MyCombatTeam[i - 1].Health}");
                Console.CursorLeft = 30;
                Console.WriteLine($"Attack         : {MyCombatTeam[i - 1].Attack}\n");
            }
            Console.SetCursorPosition(0, Console.WindowHeight - 5);

        }

        internal void ShowTrainerStats()
        {
            Console.Clear();
            Console.WriteLine($"Here is your Stats: \n\nTrainer overview:\n");
            Console.WriteLine($"Name of trainer         : {TrainerName}");
            Console.WriteLine($"Number of pokemon seen  : {NumberOfPokemonSeen}");
            Console.WriteLine($"Pokemon caught          : {MyPokemons.Count + MyCombatTeam.Count}");
            Console.WriteLine($"Pokemon in combat team  : {MyCombatTeam.Count}");
            Console.WriteLine($"Times you ran away      : {TimesFleedOrRunAway}");
            Console.WriteLine("\nInventory overview:\n");
            Console.WriteLine($"Coins          : {Coins}");
            Console.WriteLine($"Pokeballs      : {Pokeballs}");
            Console.WriteLine($"Health Potions : {HealthPotions}");
            Console.WriteLine("\nPress any key to continue to options...\n");

        }
        internal void MovePokemonToCombatTeam(int pokemonIndex)
        {
            if (pokemonIndex >= 0 && pokemonIndex < MyPokemons.Count)
            {
                Pokemon selectedPokemon = MyPokemons[pokemonIndex];
                MyPokemons.RemoveAt(pokemonIndex);
                MyCombatTeam.Add(selectedPokemon);
            }
        }

        internal void MovePokemonToMainTeam(int pokemonIndex)
        {
            if (pokemonIndex >= 0 && pokemonIndex < MyCombatTeam.Count)
            {
                Pokemon selectedPokemon = MyCombatTeam[pokemonIndex];
                MyCombatTeam.RemoveAt(pokemonIndex);
                MyPokemons.Add(selectedPokemon);
            }
        }
    }
}
