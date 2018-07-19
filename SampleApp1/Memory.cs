using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleApp1
{
    public static class Memory
    {

        private static List<string> memory = new List<string>();
        private static int counter;

        public static string List
        {
            set { memory.Add(value); counter++; }
        }

        public static Boolean IsEmpty()
        {
            if (memory.Count() == 0) return true;
            else return false;
        }

        public static void PrintMemory()
        {
            foreach (var item in memory)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine($"Operations done: {counter}");
        }

        public static void Main(String[] args)
        {
            //Memory m = new Memory();
            //Calculator c = new Calculator("Mem test", m);
            //c.Factorial(5, true);
            //c.SumArray(1,2,3,4,5);
            //m.PrintMemory();



            Console.ReadKey();
        }
    }
}
