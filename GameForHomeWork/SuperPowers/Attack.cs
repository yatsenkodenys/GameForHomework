﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameForHomeWork.SuperPowers
{
    public class Attack
    {
        void AddSuperPower(character player, int power)
        {
            player.attack += power;
        }
    }
}
