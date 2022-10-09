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
        static byte task6(ded oldman, params string[] sequence)
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



        static int[] task7(int[] array, int leftIndex, int rightIndex)
        {
            var i = leftIndex;
            var j = rightIndex;
            var pivot = array[leftIndex];
            while (i <= j)
            {
                while (array[i] < pivot)
                {
                    i++;
                }

                while (array[j] > pivot)
                {
                    j--;
                }
                if (i <= j)
                {
                    int temp = array[i];
                    array[i] = array[j];
                    array[j] = temp;
                    i++;
                    j--;
                }
            }

            if (leftIndex < j)
                Task7(array, leftIndex, j);
            if (i < rightIndex)
                Task7(array, i, rightIndex);
            return array;
        }

        static void Main(string[] args)
        {
            
            //Console.Write("Введите дату рождения: ");
            //var day = Console.ReadLine();
            //DateTime birthDate = new DateTime(day);
            //int age = CalculateAge(birthDate);
            //Console.WriteLine("{0}", age);



            Console.Write("Task2");
            task2();
            Console.ReadKey();
            Console.Clear();
            


            Console.Write("Task5");
            task5();
            Console.ReadKey();
            Console.Clear();


            Console.Write("Task6");
            string[] q1 = { "проституки", "Гады!" };
            ded ded1 = new ded("Тимофей Тимошевич", 1, q1, 0);
            string[] q2 = { "проституты", "одноклеточные", "агузок", "бляди" };
            ded ded2 = new ded("Сергей Михайлович", 2, q2, 0);
            string[] q3 = { "проституки", "лентяи", "фашисты", "идиоты" };
            ded ded3 = new ded("Петр Петрович", 3, q3, 0);
            string[] q4 = { "Гады", "ебалаи", "бестолочи" };
            ded ded4 = new ded("Иван Степанович", 1, q4, 0);
            string[] q5 = { "проституки", "дебилы", "сучки" };
            ded ded5 = new ded("Алексей Семенович", 4, q5, 0);
            string[] words = { "проституки", "проституты", "Гады!", "бестолочи", "сучки-крашенные", "дебилы", "идиоты", "бляди" };
            Console.WriteLine("количество синяков от бабки: " + task6(ded1, words));
            Console.WriteLine("количество синяков от бабки: " + task6(ded1, words));
            Console.WriteLine("количество синяков от бабки: " + task6(ded1, words));
            Console.WriteLine("количество синяков от бабки: " + task6(ded1, words));
            Console.WriteLine("количество синяков от бабки: " + task6(ded1, words));
            Console.ReadKey();
            Console.Clear();

            int[] n3 = { 1, 4, 3, 2, 5, 7, 10, 9, 6, 8 };
            Console.WriteLine(string.Join(" ", task7(n3, 0, n3.Length - 1)));
            Console.ReadKey();
        }
        
    }   
}

