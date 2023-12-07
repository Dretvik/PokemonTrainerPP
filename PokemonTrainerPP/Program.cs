namespace PokemonTrainerPP
{
    internal class Program
    {
        private PokemonTrainer trainer;

        private Program()
        {
            trainer = new PokemonTrainer(50, 2, 5, new List<Pokemon>());
        }
        static void Main(string[] args)
        {
            Program program = new Program();
            program.Run();
        }

        private void Run()
        {
            Console.WriteLine("Hello and welcome to our pokemon trainer app!");
            Console.WriteLine("Please enter your name:");
            trainer.TrainerName = Console.ReadLine();

            var charmander = new Pokemon("Charmander", "Fire", 10, 5, 10);
            var squirtle = new Pokemon("Squirtle", "Water", 10, 5, 10);
            var bulbasaur = new Pokemon("Bulbasaur", "Grass", 10, 5, 10);

            while (true)
            {
                Console.Clear();
                Console.WriteLine($"Hello there {trainer.TrainerName}! \nPlease choose a starter pokemon:");
                Console.WriteLine("\n1. Charmander \n2. Squirtle \n3. Bulbasaur \n\n0. Exit program");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        AddPokemon(charmander);
                        break;
                    case "2":
                        AddPokemon(squirtle);
                        break;
                    case "3":
                        AddPokemon(bulbasaur);
                        break;
                    case "0":
                        return;
                    default:
                        Console.WriteLine("Invalid choice, please try again");
                        break;
                }
            }
        }

        private void AddPokemon(Pokemon pokemon)
        {
            Console.Clear();
            trainer.MyPokemons.Add(pokemon);
            GameMenu();
        }

        private void GameMenu()
        {
            while (true)
            {
                Console.WriteLine("Please choose an option:");
                Console.WriteLine("\n1. Go explore \n2. Go to store \n3. Show my pokemon \n\n0. Go back");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Console.Clear();
                        ExploreOptions();
                        break;
                    case "2":
                        Console.Clear();
                        GoToShop();
                        break;
                    case "3":
                        Console.Clear();
                        trainer.PrintInfo();
                        break;
                    case "0":
                        Console.Clear();
                        return;
                    default:
                        Console.Clear();
                        Console.WriteLine("Invalid choice, please try again");
                        break;
                }
            }
        }

        private void ExploreOptions()
        {
            while (true)
            {
                Console.WriteLine("Where do you want to explore?:");
                Console.WriteLine("\n1. Grass area \n2. Water area  \n3. Mountain Area \n\n0. Go back to main menu");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Console.Clear();
                        ExploreGrassArea();
                        break;
                    case "2":
                        //ExploreWaterArea();
                        break;
                    case "3":
                        //ExploreMountainArea();
                        break;
                    case "0":
                        Console.Clear();
                        return;
                    default:
                        Console.Clear();
                        Console.WriteLine("Invalid choice, please try again");
                        break;
                }
            }
        }

        private void ExploreGrassArea()
        {
            List<Pokemon> grassTypePokemons = new List<Pokemon>
            {
                new Pokemon("Chikorita","Grass", 10, 5, 10),
                new Pokemon("Tangela","Grass", 10, 5, 10),
                new Pokemon("Treecko","Grass", 10, 5, 10),
                new Pokemon("Turtwig","Grass", 10, 5, 10),
                new Pokemon("Oddish","Grass", 10, 5, 10),
            };
            Random random = new Random();
            var encounteredPokemon = grassTypePokemons[random.Next(grassTypePokemons.Count)];

            EncounterPokemonChoice(encounteredPokemon);
            return;
        }

        private void EncounterPokemonChoice(Pokemon encounteredPokemon)
        {
            while (true)
            {
                Console.WriteLine($"You encountered a wild {encounteredPokemon.Name} Lvl {encounteredPokemon.Level}!\n");
                Console.WriteLine($"What do you want to do {trainer.TrainerName}?");
                Console.WriteLine($"\n1. Catch {encounteredPokemon.Name} \n2. Fight {encounteredPokemon.Name} \n\n0. Run away");

                string choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        //CatchPokemon();
                        break;
                    case "2":
                        //FightPokemon();
                        break;
                    case "0":
                        Console.Clear();
                        return;
                    default:
                        Console.Clear();
                        Console.WriteLine("Invalid choice, please try again");
                        break;
                }
            }
        }

        private void GoToShop()
        {
            while (true)
            {
                Console.WriteLine($"Hello {trainer.TrainerName}! Welcome to the pokestore");
                Console.WriteLine($"You have:\n {trainer.Coins} Coins \n {trainer.Pokeballs} Pokeballs \n {trainer.HealthPotions} Potions");
                Console.WriteLine("\nPlease choose an option:");
                Console.WriteLine("\n1.Buy 1 Pokeball for 5 Coins \n2 Buy 1 potion for 10 coins \n\n0. Go back \n");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        BuyPokeballs();
                        break;
                    case "2":
                        BuyHealthPotions();
                        break;
                    case "0":
                        Console.Clear();
                        return;
                    default:
                        Console.Clear();
                        Console.WriteLine("Invalid choice, please try again");
                        break;
                }
            }
        }

        private void BuyHealthPotions()
        {
            if (trainer.Coins >= 10)
            {
                trainer.HealthPotions++;
                trainer.Coins -= 10;
                Console.Clear();
            }
            else
            {
                NotEnoughCoins();
            }
        }

        private void BuyPokeballs()
        {
            if (trainer.Coins >= 5)
            {
                trainer.Pokeballs++;
                trainer.Coins -= 5;
                Console.Clear();
            }
            else
            {
                NotEnoughCoins();
            }
        }
        private void NotEnoughCoins()
        {
            Console.WriteLine("\nOoops!\nYou don't have enough coins to buy this item");
            Console.WriteLine("\nPress any button to go back to the store menu");
            Console.ReadLine();
            Console.Clear();
        }
    }
}
