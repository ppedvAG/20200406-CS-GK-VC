using System;
using System.Collections.Generic;
using System.Text;

namespace Demo_Library
{
    public class MyRandom : Random
    {
        public int NextMaxInclusive(int min, int max)
        {
            return base.Next(min, max+1);

        }

    }
}
