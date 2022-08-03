using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameForHomeWork.heroes;

namespace GameForHomeWork.SuperPowers
{
    internal class Shield : SuperPowerInterface
    {
        void AddSuperPower(character player, int power)
        {
            player.shield += power;
        }

    }
}
