using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameForHomeWork.heroes;

namespace GameForHomeWork.SuperPowers
{
    public class HP : SuperPowerInterface
    {
        void AddSuperPower(character player, int power)
        {
            player.hp += power;
        }
    }
}

