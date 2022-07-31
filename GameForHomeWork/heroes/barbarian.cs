using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameForHomeWork.heroes
{
    public class barbarian : character
    {
        public override int shield { get; set; } = 5;
        public override int attack { get; set; } = 15;
    }
}
