using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameForHomeWork.heroes
{
    public class palladin : character
    {
        public override int shield { get; set; } = 13;
        public override int attack { get; set; } = 7;

        public virtual void AddSuperPower(SuperPowerInterface powerAdd, int power)
        {
            powerAdd.AddSuperPower(this, power);
        }
    }
}
