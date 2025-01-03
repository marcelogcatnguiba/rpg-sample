namespace RpgSample.Domain.Service.Battle.UI;

public static class BattleUIService
{
    public static void ShowStats(TargetObject objOne, TargetObject objTwo)
    {
        Console.WriteLine(new string('*', 30));
        Console.WriteLine(objOne);
        Console.WriteLine("\n");
        Console.WriteLine(objTwo);
        Console.WriteLine(new string('*', 30));
    }
}
