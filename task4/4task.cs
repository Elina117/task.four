using System;

namespace argument
{
    public class array
    {
        public static int sum(ref int multiplicity, out int average, params int[] numbers)
        {

            //product
            multiplicity = 1;
            for (int i = 0; i < numbers.GetLength(0); i++)
            {
                multiplicity *= numbers[i];
            }


            //average
            average = numbers.Sum() / (numbers.Length);

            //summ
            int summ = numbers.Sum();
            return summ;


        }
        
    }
    
}

