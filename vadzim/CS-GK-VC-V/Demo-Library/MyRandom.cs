using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Library
{
    public class MyRandom : Random
    {
        public int NextMaxInclusive(int min, int max)
        {
            return base.Next(min, max+1); // mit max++ gibts keinen Unterschied
        }
    }
}
