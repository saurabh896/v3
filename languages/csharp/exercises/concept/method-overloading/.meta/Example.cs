class Character
{
    public string Name { get; set; }
    public int Level { get; set; }
    public int HitPoints { get; set; }
}

class Destination
{
    public string Name { get; set; }
    public int Inhabitants { get; set; }
}

class Game
{
    public static string Describe(Character character)
    {
        return $"You're {character.Name}, a level {character.Level} character with {character.HitPoints} hit points.";
    }

    public static string Describe(Destination destination)
    {
        return $"You've arrived at {destination.Name}, which has {destination.Inhabitants} inhabitants.";
    }

    public static string Describe(Character character, Destination destination)
    {
        return $"{Describe(character)} Having rested a bit, you travel to your next destination. {Describe(destination)}";
    }
}