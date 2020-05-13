using Xunit;

public class GameMasterTests
{
    [Fact]
    public void Describe_character()
    {
        var character = new Character();
        character.Class = "Warrior";
        character.Level = 16;
        character.HitPoints = 89;
        Assert.Equal("", GameMaster.Describe(character));
    }
}
