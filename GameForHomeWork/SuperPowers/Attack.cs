using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameForHomeWork.heroes;

namespace GameForHomeWork.SuperPowers
{
    public class Attack : SuperPowerInterface
    {
        void AddSuperPower(character player, int power)
        {
            player.attack += power;
        }
    }
}
