using System;
namespace bubblesort
{
    public class BubbleSort
    {
        public static int[] BubbleSortAlgorithm(int[] sequence)
        {

            int temp;
            for (int q = 0; q < sequence.Length - 1; q++)
            {
                for (int j = q + 1; j < sequence.Length; j++)
                {

                    if (sequence[q] > sequence[j])
                    {
                        temp = sequence[q];
                        sequence[q] = sequence[j];
                        sequence[j] = temp;
                    }
                }
            }

            return sequence;
        }
    }
}

