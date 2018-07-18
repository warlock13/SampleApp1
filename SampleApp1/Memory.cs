using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleApp1
{
    public class Memory
    {
        public Memory() { }
        private List<object> memory = new List<object>();
        public void AddToMemory(object o)
        {
            memory.Add(o);
        }
        public void PrintMemory()
        {
            foreach (var item in memory)
            {
                Console.WriteLine(item);
            }
        }

        public static void Main(String[] args)
        {
            Memory m = new Memory();
            Calculator c = new Calculator("Mem test", m);
            c.Factorial(5, true);
            c.SumArray(1,2,3,4,5);
            m.PrintMemory();

            Console.ReadKey();
        }
    }
}
