namespace RpgSample.Domain.Service.Battle;

public static class BattleService
{
    private static readonly AttackService atk = new();

    public static void Start(Character one, Character two)
    {
        while(!one.IsDead && !two.IsDead)
        {
            Console.WriteLine("Start battle");
            Console.WriteLine("\n");

            BattleUIService.ShowStats(one, two);
            Console.WriteLine("\n");

            Console.WriteLine("\tBATTLE LOGS\n");
            Console.WriteLine($"Player cause {atk.Attack(one, two)} damage.\n");
            Console.WriteLine($"Enemy cause {atk.Attack(two, one)} damage.");
            Console.WriteLine("\n");
            
            BattleUIService.ShowStats(one, two);
            Console.WriteLine("\n");
            
            Console.WriteLine("Press to continue ...");
            Console.WriteLine("Press to [q] to exit ...");
            Console.WriteLine("Press to [1] to equip sword in player ...");
            var args = Console.ReadKey();

            if(args.KeyChar.Equals('q'))
            {
                break;
            }

            if(args.KeyChar.Equals('1'))
            {
                var sword = new Sword(new(4, 8), 5);
                
                var player = (Player)one;
                player.EquipWeapon(sword);

                Console.WriteLine("Sword equipada com sucesso!.");
            }
        
        }

        var loser = one.IsDead ? one : two;
        if(loser is not null)
        {
            Console.WriteLine($"\n{loser.GetType().Name} morreu ...");
            return;
        }

        Console.WriteLine("\nEmpatado");
    }
}
