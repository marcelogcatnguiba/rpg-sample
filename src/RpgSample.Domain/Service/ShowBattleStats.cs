namespace RpgSample.Domain.Service;

public class ShowBattleStats
{
    public static void Show(TargetObject objOne, TargetObject objTwo)
    {
        System.Console.WriteLine(new string('-', 40));
        System.Console.WriteLine(objOne);
        System.Console.WriteLine("\n");
        System.Console.WriteLine(objTwo);
        System.Console.WriteLine(new string('-', 40));
    }
}
