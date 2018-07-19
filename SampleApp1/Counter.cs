using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleApp1
{
    public class Counter
    {
        private int counter;
        public int Value { get; set; } = 0;
        public static Counter operator ++(Counter c1)
        {
            return new Counter { Value = c1.Value + 1 };
        }
    }
}
