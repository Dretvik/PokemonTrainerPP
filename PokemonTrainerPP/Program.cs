namespace PokemonTrainerPP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PokemonTrainer trainer = new PokemonTrainer(10, 2, 5, new List<Pokemon>());

            Console.WriteLine("Hello and welcome to our pokemon trainer app");
            Console.WriteLine("Please enter your name:");
            trainer.TrainerName = Console.ReadLine();

            Pokemon charmander = new Pokemon("Charmander", "Fire", 10, 5);
            Pokemon squirtle = new Pokemon("Squirtle", "Water", 10, 5);
            Pokemon bulbasaur = new Pokemon("Bulbasaur", "Grass", 10, 5);

            while (true)
            {
                Console.WriteLine("Please choose an option:");
                Console.WriteLine("1. Charmander \n2. Squirtle \n3. Bulbasaur \n0. Exit program");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        AddPokemon(trainer, charmander);
                        break;
                    case "2":
                        AddPokemon(trainer, squirtle);
                        break;
                    case "3":
                        AddPokemon(trainer, bulbasaur);
                        break;
                    case "0":
                        return;
                    default:
                        Console.WriteLine("Invalid choice, please try again");
                        break;
                }
            }
        }

        public static void AddPokemon(PokemonTrainer trainer, Pokemon pokemon)
        {
            Console.Clear();
            trainer.myPokemons.Add(pokemon);
            GameMenu(trainer, pokemon);
        }

        public static void GameMenu(PokemonTrainer trainer, Pokemon pokemon)
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
                        GoToShop(trainer);
                        break;
                    case "3":
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

        public static void GoToShop(PokemonTrainer trainer)
        {
            Console.Clear();
            Console.WriteLine($"Hello {trainer.TrainerName}! Welcome to the pokestore");
            Console.WriteLine(
                $"You have:\n {trainer.Coins} Coins \n {trainer.Pokeballs} Pokeballs \n {trainer.HealthPotions} Potions");
            while (true)
            {
                Console.WriteLine("Please choose an option:");
                Console.WriteLine("1.Buy Pokeball for 1 Coins \n2 Buy potion for 5 coins \n0. Go back");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        trainer.Pokeballs++;
                        trainer.Coins--;
                        break;
                    case "2":
                        
                        break;
                    case "0":
                        return;
                    default:
                        Console.WriteLine("Invalid choice, please try again");
                        break;
                }
            }
        }
    }
}
