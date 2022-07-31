using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameForHomeWork.heroes
{
    internal class barbarian : character
    {
        public override int shield { get; set; } = 15;
        public override int attack { get; set; } = 5;
    }
}
