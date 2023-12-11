namespace PokemonTrainerPP
{
    internal class Program
    {
        private PokemonTrainer trainer;

        private Program()
        {
            trainer = new PokemonTrainer(50, 2, 5, new List<Pokemon>(), new List<Pokemon>(), 1);
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

            if (trainer.MyPokemons.Count == 0)
            {
                ChooseStarterPokemon();
            }
            else
            {
                GameMenu();
            }


        }

        private void ChooseStarterPokemon()
        {
            bool starterChoice = true;

            var charmander = new Pokemon("Charmander", "Fire", 10, 5, 10);
            var squirtle = new Pokemon("Squirtle", "Water", 10, 5, 10);
            var bulbasaur = new Pokemon("Bulbasaur", "Grass", 10, 5, 10);



            while (starterChoice)
            {
                Console.Clear();
                Console.WriteLine($"Hello there {trainer.TrainerName}! \nPlease choose a starter pokemon:");
                Console.WriteLine("\n1. Charmander \n2. Squirtle \n3. Bulbasaur \n\n0. Exit program");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        AddPokemon(charmander);
                        starterChoice = !starterChoice;
                        break;
                    case "2":
                        AddPokemon(squirtle);
                        starterChoice = !starterChoice;
                        break;
                    case "3":
                        AddPokemon(bulbasaur);
                        starterChoice = !starterChoice;
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
                Console.WriteLine("\n1. Go explore \n2. Go to store \n3. Show Trainer stats \n4. Show my pokemon \n\n0. Exit Game");

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
                        ShowTrainerStats();
                        break;
                    case "4":
                        Console.Clear();
                        trainer.PrintInfo();
                        trainer.PrintCombatTeam();
                        Console.WriteLine("Press any button to continue");
                        Console.ReadLine();
                        Console.Clear();
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
                        Console.Clear();
                        ExploreWaterArea();
                        break;
                    case "3":
                        Console.Clear();
                        ExploreMountainArea();
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

        private void ExploreWaterArea()
        {
            Random randomLevel = new Random();
            Random randomStats = new Random();
            Random randomHP = new Random();
            int PokemonHP = randomHP.Next(10, 250);
            int PokemonStats = randomStats.Next(10, 200);
            int pokemonLevel = randomLevel.Next(5, 50);

            List<Pokemon> waterPokemons = new List<Pokemon>
            {
                new Pokemon("Krabby", "Water",PokemonHP , pokemonLevel, PokemonStats),
                new Pokemon("Magikarp", "Water", PokemonHP, pokemonLevel, PokemonStats),
                new Pokemon("Marill", "Water", PokemonHP, pokemonLevel, PokemonStats),
                new Pokemon("Staryu", "Water", PokemonHP, pokemonLevel, PokemonStats),
                new Pokemon("Horssea", "Water", PokemonHP, pokemonLevel, PokemonStats),
            };
            Random random = new Random();
            var encounteredPokemon = waterPokemons[random.Next(waterPokemons.Count)];

            EncounterPokemonChoice(encounteredPokemon);
        }

        private void ExploreMountainArea()
        {
            Random randomLevel = new Random();
            Random randomStats = new Random();
            Random randomHP = new Random();
            int PokemonHP = randomHP.Next(10, 250);
            int PokemonStats = randomStats.Next(10, 200);
            int pokemonLevel = randomLevel.Next(5, 50);

            List<Pokemon> mountainPokemons = new List<Pokemon>
            {
                new Pokemon("Geodude", "Rock", PokemonHP, pokemonLevel, PokemonStats),
                new Pokemon("Onyx", "Rock", PokemonHP, pokemonLevel, PokemonStats),
                new Pokemon("Rhyhorn", "Rock", PokemonHP, pokemonLevel, PokemonStats),
                new Pokemon("Kabuto", "Rock", PokemonHP, pokemonLevel, PokemonStats),
                new Pokemon("Larvitar", "Rock", PokemonHP, pokemonLevel, PokemonStats),
            };
            Random random = new Random();
            var encounteredPokemon = mountainPokemons[random.Next(mountainPokemons.Count)];

            EncounterPokemonChoice(encounteredPokemon);
        }

        private void ExploreGrassArea()
        {
            Random randomLevel = new Random();
            Random randomStats = new Random();
            Random randomHP = new Random();
            int PokemonHP = randomHP.Next(10, 250);
            int PokemonStats = randomStats.Next(10, 200);
            int pokemonLevel = randomLevel.Next(5, 50);

            List<Pokemon> grassTypePokemons = new List<Pokemon>
            {
                new Pokemon("Chikorita","Grass", PokemonHP, pokemonLevel, PokemonStats),
                new Pokemon("Tangela","Grass", PokemonHP, pokemonLevel, PokemonStats),
                new Pokemon("Treecko","Grass", PokemonHP, pokemonLevel, PokemonStats),
                new Pokemon("Turtwig","Grass", PokemonHP, pokemonLevel, PokemonStats),
                new Pokemon("Oddish","Grass", PokemonHP, pokemonLevel, PokemonStats),
            };
            Random random = new Random();
            var encounteredPokemon = grassTypePokemons[random.Next(grassTypePokemons.Count)];

            EncounterPokemonChoice(encounteredPokemon);
        }

        private void EncounterPokemonChoice(Pokemon encounteredPokemon)
        {
            trainer.NumberOfPokemonSeen++;
            bool encounterOptions = true;

            while (encounterOptions)
            {
                Console.WriteLine($"You encountered a wild {encounteredPokemon.Name}!\n");
                Console.WriteLine($"Stats: \n Lvl   {encounteredPokemon.Level} \n  HP  {encounteredPokemon.Health} \n Attatck {encounteredPokemon.Attack}");
                Console.WriteLine($"\nWhat do you want to do {trainer.TrainerName}?");
                Console.WriteLine($"\n1. Catch {encounteredPokemon.Name} \n2. Fight {encounteredPokemon.Name} \n\n0. Run away");

                string choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        Console.Clear();
                        CatchPokemon(encounteredPokemon);
                        encounterOptions = !encounterOptions;
                        break;
                    case "2":
                        //FightPokemon();
                        encounterOptions = !encounterOptions;
                        break;
                    case "0":
                        trainer.TimesFleedOrRunAway++;
                        Console.Clear();
                        return;
                    default:
                        Console.Clear();
                        Console.WriteLine("Invalid choice, please try again");
                        break;
                }
            }
        }

        private void CatchPokemon(Pokemon encounteredPokemon)
        {
            Console.Clear();
            if (trainer.Pokeballs >= 1)
            {
                Console.WriteLine($"\nYou caught {encounteredPokemon.Name}!\n");
                Console.WriteLine("Press any key to continue...");
                Console.ReadLine();
                trainer.Pokeballs--;
                trainer.MyPokemons.Add(encounteredPokemon);
            }
            else
            {
                Console.WriteLine("You don't have enough pokeballs, go to store to buy more..");
                Console.WriteLine("Press any key to continue...");
                Console.ReadLine();
            }
            Console.Clear();
        }

        internal void GoToShop()
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

        private void ShowTrainerStats()
        {
            while (true)
            {
                trainer.ShowTrainerStats();

                Console.WriteLine("\nNow what do you want to do?");
                Console.WriteLine("1. Manage fighting team \n2. Go to Store \n\n0. Go back");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Console.Clear();
                        ManagePokemon();
                        return;
                    case "2":
                        Console.Clear();
                        GoToShop();
                        return;
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

        private void ManagePokemon()
        {
            while (true)
            {
                Console.Clear();
                trainer.PrintInfo();
                trainer.PrintCombatTeam();
                Console.WriteLine("Select a Pokemon number to manage (0 to quit): ");

                string input = Console.ReadLine();

                if (input == "0")
                {
                    Console.Clear();
                    return;
                }

                if (int.TryParse(input, out int pokemonIndex))
                {
                    Console.WriteLine("1. Move to Combat Team\n2. Move to Storage");
                    string moveChoice = Console.ReadLine();

                    switch (moveChoice)
                    {
                        case "1":
                            trainer.MovePokemonToCombatTeam(pokemonIndex - 1);
                            break;
                        case "2":
                            trainer.MovePokemonToMainTeam(pokemonIndex - 1);
                            break;
                        default:
                            Console.WriteLine("Invalid choice.");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid Pokemon number or 'Q' to quit.");
                }
                Console.Clear();
            }
        }

    }
}
