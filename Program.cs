using System;

namespace Puzzles
{
    class Program
    {
        static int[] RandomArray()
        {
            ////Declare our array that will eventually be returned
            Console.WriteLine("\nRandom Array:");
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

        static string CoinFlip()
        {
            Console.WriteLine("\nCoin Flip:");
            Random rand = new Random();
            int result = rand.Next(1,3);
            string returnString = "";
            if(result == 1)
            {
                returnString = "Heads";
                Console.WriteLine(returnString);
            }
            else
            {
                returnString = "Tails";
                Console.WriteLine(returnString);
            }
            return returnString;
        }

        static double FlipMultipleCoins(int num)
        {
            Console.WriteLine("\nFlip Multiple Coins:");
            Random rand = new Random();
            int headCount = 0;
            int tailCount = 0;
            double returnValue = 1.11;
            for(int i=0; i<num; i++)
            {
                int result2 = rand.Next(1,3);
                Console.WriteLine("RESULT: "+result2);
                if(result2 == 1)
                {
                    headCount++;
                }
                else
                {
                    tailCount++;
                }
            }
            returnValue = (double)num / (double)headCount;
            return returnValue;
        }

        static string[] Names()
        {
            string[] arr = {"Todd", "Tiffany", "Charlie", "Geneva", "Sydney"};
            string temp = "";
            Random rand = new Random();
            for(int i=0; i<arr.Length; i++)
            {
                int index = rand.Next(0,6);
                temp = arr[i];
                arr[i] = arr[index];
                arr[index] = temp;
            }
            Console.Write("[");
            foreach(string value in arr)
            {
                Console.Write(value+",");
            }
            Console.Write("]");
            return arr;
        }

        static void Main(string[] args)
        {
            RandomArray();
            CoinFlip();
            Console.WriteLine(FlipMultipleCoins(100));
            Names();
        }
    }
}
