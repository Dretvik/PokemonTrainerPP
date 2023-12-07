
namespace PokemonTrainerPP
{
    public class Pokemon
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public int Health { get; set; }
        public int Level { get; set; }
        public int Attack { get; set; }

        public Pokemon(string name, string type, int health, int level, int attack)
        {
            Name = name;
            Type = type;
            Health = health;
            Level = level;
            Attack = attack;
        }

    }
}
