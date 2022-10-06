using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Linq;
using System.Reflection.Emit;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace task4
{   //6 task
    enum grouchinesslevel
    {
        kind = 1,
        grumbles = 2,
        irritated = 3,
        evil = 4
    }
    struct ded
    {
        public string name;
        public byte grouchinesslevel;
        public string[] phrases;
        public byte hits;
    }
    public class Program
    {
        static byte Task6(ded oldman, params string[] sequence)
        {
            foreach (string i in oldman.phrases)
            {
                if (sequence.Contains(i))
                {
                    oldman.hits += 1;
                }
            }
            return oldman.hits;
        }


        static void task2()
        {
            Random rnd = new Random();
            int[] mass = new int[20];
            for (int i = 0; i < 20;)
            {
                int number = rnd.Next(0, 101);
                int j;
                for (j = 0; j < i; j++)
                {
                    if (number == mass[j])
                        break;
                }
                if (j == i)
                {
                    mass[i] = number;
                    i++;
                }

            }
                Console.WriteLine(String.Join(" ", mass));
                Console.Write("enter two numbers whitch you want to exchange: ");
                int IndexOfFirstNumber = Array.IndexOf(mass, int.Parse(Console.ReadLine()));
                int IndexOfSecondNumber = Array.IndexOf(mass, int.Parse(Console.ReadLine()));
                (mass[IndexOfFirstNumber], mass[IndexOfSecondNumber]) = (mass[IndexOfSecondNumber], mass[IndexOfFirstNumber]);
                Console.WriteLine(string.Join(" ", mass));
            
        }

        static void task5()
        {
            var listnumbers = new Dictionary<int, string>()
            {
                [0] = "###" + "\n" + "# #" + "\n" + "# #" + "\n" + "# #" + "\n" + "###",
                [1] = " # " + "\n" + "## " + "\n" + " # " + "\n" + " # " + "\n" + "###",
                [2] = " # " + "\n" + "# #" + "\n" + "  #" + "\n" + " # " + "\n" + "###",
                [3] = "## " + "\n" + "  #" + "\n" + " # " + "\n" + "  #" + "\n" + "## ",
                [4] = "# #" + "\n" + "# #" + "\n" + "###" + "\n" + "  #" + "\n" + "###",
                [5] = "###" + "\n" + "#  " + "\n" + "###" + "\n" + "  #" + "\n" + "## ",
                [6] = " ##" + "\n" + "#  " + "\n" + "###" + "\n" + "# #" + "\n" + "###",
                [7] = "###" + "\n" + "  #" + "\n" + "  #" + "\n" + " # " + "\n" + " # ",
                [8] = "###" + "\n" + "# #" + "\n" + " # " + "\n" + "# #" + "\n" + "###",
                [9] = "###" + "\n" + "# #" + "\n" + "###" + "\n" + "  #" + "\n" + "###",
            };

            Console.Write("If you want to continue push - 1" + "\n" + "Else push - 1");

            int InputData = int.Parse(Console.ReadLine());
            if (InputData == 1)
            {
                try
                {

                    Console.Write("Enter еhe number: ");
                    int EnterNumber = int.Parse(Console.ReadLine());
                    if (EnterNumber >= 0 & EnterNumber <= 9)
                    {
                        Console.WriteLine(listnumbers[EnterNumber]);
                    }
                    else
                    {
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.WriteLine("");
                        Thread.Sleep(3000);
                        Console.ResetColor();
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("An error has occurred!");
                }
                finally
                {
                    Console.WriteLine("Thanks for trying)))");
                }
            }
            else
            {
                Console.Write("Enter (exit) or (закрыть)");
                string exit = Console.ReadLine();
                if (exit == "exot" || exit == "закрыть")
                {
                    Environment.Exit(0);
                }
            }
        }

        static void task7()
        {
            static int[] Task7(int[] array, int leftIndex, int rightIndex)
            {

            }

        }

    }
}

