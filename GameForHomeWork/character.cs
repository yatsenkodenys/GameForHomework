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
    }
}
