using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameForHomeWork
{
    public static class SuperPoverGenerator
    {
        public static int spg()
        {
            return new Random().Next(5,10);
        }
    }
}
