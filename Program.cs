using System;

namespace Puzzles
{
    class Program
    {
        static int[] RandomArray()
        {
            ////Declare our array that will eventually be returned
            int[] arr = new int[10];
            Random rand = new Random();
            int min = 25;
            int max = 0;
            int sum = 0;
            ////Place 10 rando values in
            for(int i=0; i<arr.Length; i++)
            {
                arr[i] = rand.Next(5,25);
                if(arr[i]<min)
                {
                    min = arr[i];
                }
                else if(arr[i]>max)
                {
                    max = arr[i];
                }
                sum+=arr[i];
            }
            Console.WriteLine("Min Val: {0} - Max Val: {1} - Sum: {2}", min, max, sum);
            return arr;

        }
        static void Main(string[] args)
        {
            Console.WriteLine("\nCoin Flip");
            Console.WriteLine(RandomArray());
        }
    }
}
