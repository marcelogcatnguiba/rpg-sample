namespace RpgSample.Domain.Entities.CharacterAttributes;

public class Attributes(int str, int dex, int inteligence)
{
    public int Strength { get ; private set; } = str;
    public int Dexterity { get ; private set; } = dex;
    public int Inteligence { get ; private set; } = inteligence;

    public void Update(int? str, int? dex, int? inteligence)
    {
        Strength += str ?? 0;
        Dexterity += dex ?? 0;
        Inteligence += inteligence ?? 0;
    }
}
