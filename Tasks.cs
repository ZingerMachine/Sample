using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sample
{
    internal class Tasks
    {
        public void GetNames()
        {
            string[] names = ["Kate", "Tom", "Sam", "Mike", "Alice"];

            foreach (string name in names)
            {
                Console.WriteLine($"{name} has {name.Length} characters.");
            }
        }

        public void GetTruth()
        {
            bool a = true;
            bool b = false;

            Console.WriteLine($"AND | a | b ");
            Console.WriteLine($"a | {a & a,-5} | {a & b,-5} ");
            Console.WriteLine($"b | {b & a,-5} | {b & b,-5} ");
            Console.WriteLine();
            Console.WriteLine($"OR | a | b ");
            Console.WriteLine($"a | {a | a,-5} | {a | b,-5} ");
            Console.WriteLine($"b | {b | a,-5} | {b | b,-5} ");
            Console.WriteLine();
            Console.WriteLine($"XOR | a | b ");
            Console.WriteLine($"a | {a ^ a,-5} | {a ^ b,-5} ");
            Console.WriteLine($"b | {b ^ a,-5} | {b ^ b,-5} ");
        }

        public void Task_03()
        {
            for (; true;);
        }

        public void Task_04()
        {
            for (int i = 1; i < 15; i++)
            {
                Console.WriteLine($"{i}! = :N0");
            }
        }

        public void Task_05()
        {
            Trace.Listeners.Add(new TextWriterTraceListener(
            File.CreateText(Path.Combine(Environment.GetFolderPath(
            Environment.SpecialFolder.DesktopDirectory), "log.txt"))));

            Trace.AutoFlush = true;

            Debug.WriteLine("Debug says, I am watching!");
            Trace.WriteLine("Trace says, I am watching!");
        }
    }
}
