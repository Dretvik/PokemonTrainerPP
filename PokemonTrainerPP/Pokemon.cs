
namespace PokemonTrainerPP
{
    internal class Pokemon
    {
        internal string Name { get; set; }
        internal string Type { get; set; }
        internal int Health { get; set; }
        internal int Level { get; set; }
        internal int Attack { get; set; }

        internal Pokemon(string name, string type, int health, int level, int attack)
        {
            Name = name;
            Type = type;
            Health = health;
            Level = level;
            Attack = attack;
        }

    }
}
