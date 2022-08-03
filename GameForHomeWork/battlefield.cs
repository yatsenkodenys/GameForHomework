using GameForHomeWork.heroes;
using GameForHomeWork.SuperPowers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameForHomeWork
{
    public static class battlefield
    {
        public static void battle(character player1, character player2)
        {
            int round = 0;
            do
            {
                Console.WriteLine($"round {++round}");
                player2.Defense(player1.Battack());
                player1.Defense(player2.Battack());
            } while(player1.lose && player2.lose);

            var winner = player1.lose
               ? player1
               : player2.lose
                   ? player2
                   : null;

            var looser = winner != player1
                ? player1
                : player2;

            if (winner != null)
            {
                Console.WriteLine($"{winner.GetType().Name} won in {round} round.");
                Console.WriteLine($"HP left {winner.hp}.");
                Console.WriteLine($"Looser is {looser.GetType().Name}.");
            }
            else
            {
                Console.WriteLine("No winners");
            }
        }
        
    }
}
