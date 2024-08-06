using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace sample
{
    class MenuTasks
    {
        public static void Invoke()
        {
            bool repeat = true;
            do
            {
                Console.WriteLine("\nEnter number list tasks:");

                string? num = Console.ReadLine();

                Tasks task = new Tasks();

                switch (num)
                {
                    case "1":
                        {
                            task.GetNames();
                            break;
                        }
                    case "2":
                        {
                            task.GetTruth();
                            break;
                        }
                    case "3":
                        {
                            task.Task_03();
                            break;
                        }
                    case "4":
                        {
                            task.Task_04();
                            break;
                        }
                    case "5":
                        {
                            task.Task_05();
                            break;
                        }
                    case "0":
                        {
                            repeat = false;
                            break;
                        }
                    default:
                        {
                            Console.WriteLine($"No list tasks");
                            break;
                        }
                }
            } while (repeat);
        }
    }
}