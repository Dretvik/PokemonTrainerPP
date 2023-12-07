namespace PokemonTrainerPP
{
    internal class Program
    {
        private PokemonTrainer trainer;

        public Program()
        {
            trainer = new PokemonTrainer(50, 2, 5, new List<Pokemon>());
        }
        static void Main(string[] args)
        {
            Program program = new Program();
            program.Run();
        }

        public void Run()
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
                Console.WriteLine("1. Charmander \n2. Squirtle \n3. Bulbasaur \n0. Exit program");

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

        public void AddPokemon(Pokemon pokemon)
        {
            Console.Clear();
            trainer.myPokemons.Add(pokemon);
            GameMenu(pokemon);
        }

        public void GameMenu(Pokemon pokemon)
        {
            while (true)
            {
                Console.WriteLine("Please choose an option:");
                Console.WriteLine("1. Go explore \n2. Go to store \n3. Show my pokemon \n0. Go back");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Console.WriteLine("");
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
                        return;
                    default:
                        Console.WriteLine("Invalid choice, please try again");
                        break;
                }
            }
        }


        public void GoToShop()
        {
            while (true)
            {
                Console.WriteLine($"Hello {trainer.TrainerName}! Welcome to the pokestore");
                Console.WriteLine($"You have:\n {trainer.Coins} Coins \n {trainer.Pokeballs} Pokeballs \n {trainer.HealthPotions} Potions");
                Console.WriteLine("\nPlease choose an option:");
                Console.WriteLine("1.Buy 1 Pokeball for 5 Coins \n2 Buy 1 potion for 10 coins \n0. Go back \n");

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
                Console.WriteLine("\nOoops!\nYou don't have enough coins to buy this item");
                Console.WriteLine("\nPress any button to go back to the store menu");
                Console.ReadLine();
                Console.Clear();
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
                Console.WriteLine("\nOoops!\nYou don't have enough coins to buy this item");
                Console.WriteLine("\nPress any button to go back to the store menu");
                Console.ReadLine();
                Console.Clear();
            }
        }
    }
}
