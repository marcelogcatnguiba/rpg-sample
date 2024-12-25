namespace RpgSample.Domain.Service;

public class Battle
{
    public static void Start(Character one, Character two)
    {
        while(!one.IsDead && !two.IsDead)
        {
            Console.WriteLine("Start battle");
            Console.WriteLine("\n");

            ShowBattleStats.Show(one, two);
            Console.WriteLine("\n");

            Console.WriteLine("\tBATTLE STATS\n");
            Console.WriteLine($"Player cause {one.Attack(two)} damage.\n");
            Console.WriteLine($"Enemy cause {two.Attack(one)} damage.");
            Console.WriteLine("\n");
            
            ShowBattleStats.Show(one, two);
            Console.WriteLine("\n");
            
            Console.WriteLine("Press to continue ...");
            Console.WriteLine("Press to [q] to exit ...");
            var args = Console.ReadKey();

            if(args.KeyChar.Equals('q'))
            {
                break;
            }
        }

        var loser = one.IsDead ? one : two;
        if(loser is not null)
        {
            System.Console.WriteLine($"{loser.GetType().Name} morreu ...");
            return;
        }
        
        System.Console.WriteLine("Empatado");
    }
}
