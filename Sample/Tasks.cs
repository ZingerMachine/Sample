﻿using System;
using System.Collections.Generic;
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
    }
}
