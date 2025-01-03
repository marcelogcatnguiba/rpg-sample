namespace RpgSample.Domain.Service.Battle.UI;

public static class BattleUIService
{
    public static void Show(TargetObject objOne, TargetObject objTwo)
    {
        Console.WriteLine(new string('-', 40));
        Console.WriteLine(objOne);
        Console.WriteLine("\n");
        Console.WriteLine(objTwo);
        Console.WriteLine(new string('-', 40));
    }
}
