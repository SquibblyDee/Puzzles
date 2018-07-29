using System;
using System.Collections.Generic;

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
            ////Declare all our needed vars
            string[] arr = {"Todd", "Tiffany", "Charlie", "Geneva", "Sydney"};
            string temp = "";
            int count = 0;
            List<string> longNames = new List<string>();
            Random rand = new Random();
            ////Iterate through the array and reorg the indexes randomly
            for(int i=0; i<arr.Length; i++)
            {
                int index = rand.Next(0,6);
                temp = arr[i];
                arr[i] = arr[index];
                arr[index] = temp;
            }
            ////Print our reorganized array
            Console.Write("[");
            foreach(string value in arr)
            {
                Console.Write(value+",");
            }
            Console.Write("]");
            for(int j=0; j<arr.Length; j++)
            {
                if(arr[j].Length>5)
                {
                    longNames.Add(arr[j]);
                }
            }
            ///Create our return array now that we have the count of names > 5 chars
            string[] returnArray = new string[longNames.Count];
            ////Push each name in the list into our new array and return it
            foreach(string name in longNames)
            {
                returnArray[count] = name;
                count++;
            }
            return returnArray;
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
