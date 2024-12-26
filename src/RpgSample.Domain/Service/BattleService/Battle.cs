using RpgSample.Domain.Weapons;

namespace RpgSample.Domain.Service.BattleService;

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
            Console.WriteLine("Press to [1] to equip sword in player ...");
            var args = Console.ReadKey();

            if(args.KeyChar.Equals('q'))
            {
                break;
            }

            if(args.KeyChar.Equals('1'))
            {
                var sword = new Sword(10, 5);
                
                var player = (Player)one;
                player.EquipWeapon(sword);

                Console.WriteLine("Sword equipada com sucesso!.");
            }
        }

        var loser = one.IsDead ? one : two;
        if(loser is not null)
        {
            Console.WriteLine($"{loser.GetType().Name} morreu ...");
            return;
        }

        Console.WriteLine("Empatado");
    }
}
