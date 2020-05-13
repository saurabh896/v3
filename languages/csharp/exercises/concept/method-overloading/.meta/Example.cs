class GameMaster
{
    public static string Describe(Character character)
    {
        return $"You're a level {character.Level} {character.Class} with {character.HitPoints} hit points.";
    }

    public static string Describe(Destination destination)
    {
        return $"You've arrived at {destination.Name}, a small town with {destination.Inhabitants}.";
    }

    public static string Describe(TravelMethod travelMethod)
    {
        if (travelMethod == TravelMethod.Walking)
        {
            return "You're travelling to your destination by foot.";
        }

        return "You're travelling to your destination on horse.";
    }

    public static string Describe(Character character, Destination destination, TravelMethod travelMethod = TravelMethod.Walking)
    {
        return $"{Describe(character)}\n{Describe(travelMethod)}\n{Describe(destination)}";
    }
}

class Character
{
    public string Class { get; set; }
    public int Level { get; set; }
    public int HitPoints { get; set; }
}

class Destination
{
    public string Name { get; set; }
    public int Inhabitants { get; set; }
}

enum TravelMethod
{
    Walking,
    Horse
}
