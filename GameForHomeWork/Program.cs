using GameForHomeWork.heroes;
using GameForHomeWork.SuperPowers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameForHomeWork
{
    class Program
    {   
          public static character selectClass(string input)
        {
            if (int.TryParse(input, out int result))
            {
                return result switch
                {
                    1 => new warrior(),
                    2 => new spearman(),
                    3 => new barbarian(),
                    4 => new palladin(),
                    _ => null,
                };
            }
            return null;
        }

        public static character addPlayer()
        {
            character player;
            do
            {
                var ans = Console.ReadLine();
                player = selectClass(ans);
                if (player == null)
                {
                    Console.WriteLine("answer dont correct");
                }
            }
            while (player == null);
            return player;
        }
      
        static void Main()
        { 
            Console.WriteLine("select character class:");
            Console.WriteLine("1-warior");
            Console.WriteLine("2-spearman");
            Console.WriteLine("3-barbarian");
            Console.WriteLine("4-palladin");
            character player1 = addPlayer();

            Console.WriteLine("select another character class:");
            Console.WriteLine("1-warior");
            Console.WriteLine("2-spearman");
            Console.WriteLine("3-barbarian");
            Console.WriteLine("4-palladin");
            character player2 = addPlayer();

            Console.WriteLine("select player1 super power:");
            Console.WriteLine("1-HP");
            Console.WriteLine("2-Shield");
            Console.WriteLine("3-Attack");
            var ans = Console.ReadLine();

            switch (ans)
            {
               case "1" :
                player1.AddSuperPower(new HP(),SuperPowerGenerator.spg());
                    break;
               case "2" :
                player1.AddSuperPower(new Shield(),SuperPowerGenerator.spg());
                    break;
               case "3":
                    player1.AddSuperPower(new Attack(), SuperPowerGenerator.spg());
                    break;
               default :
                    Console.WriteLine("your character will not have superpowers ");
                    break;
            }

            Console.WriteLine("select player2 super power:");
            Console.WriteLine("1-HP");
            Console.WriteLine("2-Shield");
            Console.WriteLine("3-Attack");
             ans = Console.ReadLine();

            switch (ans)
            {
                case "1":
                    player2.AddSuperPower(new HP(), SuperPowerGenerator.spg());
                    break;
                case "2":
                    player2.AddSuperPower(new Shield(), SuperPowerGenerator.spg());
                    break;
                case "3":
                    player2.AddSuperPower(new Attack(), SuperPowerGenerator.spg());
                    break;
                default:
                    Console.WriteLine("your character will not have superpowers ");
                    break;
            }

            battlefield.battle(player1, player2);
        }

    }
}
