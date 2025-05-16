namespace Oppgave_pokemon;

class Pokemon
{
    public string Name { get; }
    public int Health { get; }
    public int Level { get; }

    public Pokemon(string name ,int health, int level)
    {
        Name = name;
        Health = health;
        Level = level;
    }

    public void PokemonInfo()
    {
        Console.WriteLine($"{this.Name} har en hp på {this.Health} og er på level {this.Level}");
    }
    
    
}