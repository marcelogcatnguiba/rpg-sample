namespace RpgSample.Domain.Entities.Model;

public class MinMaxDamage
{
    public int Min { get; set; }
    public int Max { get; set; }

    public MinMaxDamage() { }
    public MinMaxDamage(int min, int max)
    {
        Min = min;
        Max = max;
    }
}
