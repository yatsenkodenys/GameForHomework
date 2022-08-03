using GameForHomeWork.SuperPowers;
using GameForHomeWork.heroes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameForHomeWork
{
    public abstract class character
    {
        public int hp { get; set;} = 100;
        public virtual int shield { get; set; } = 0;
        public virtual int attack { get; set; } = 0;

        public virtual void AddSuperPower(SuperPowerInterface powerAdd, int power)
        {
            powerAdd.AddSuperPower(this, power);
        }

        public int Battack()
        {
            if (shield > 0)
                return attack;
            if (attack == 1)
                return 1;
            return --attack;
        }

        public void Defense(int power)
        {
            if (shield > 0)
            {
                var check = power / 2;
                if (check < shield)
                {
                    shield -= check;
                }
                else
                {
                    var ext = check - shield;
                    hp -= ext;
                    shield = 0;
                }

                hp -= (power - check);
            }
            else
            {
                hp -= power;
            }
        }

        public bool lose => hp > 0;

    }
}
