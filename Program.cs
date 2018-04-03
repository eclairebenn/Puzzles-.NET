using System;
using System.Collections.Generic;

namespace puzzles
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Names();
        }

        public static int[] RandomArr()
        {
            int sum = 0;
            Random rand = new Random();
            int[] randArr = new int[10];
            randArr[0] = rand.Next(5,25);
            int min = randArr[0];
            int max = randArr[0];

            for(int i=1;i<randArr.Length;i++)
            {
                randArr[i] = rand.Next(5, 25);
                if(randArr[i] < min)
                {
                    min = randArr[i];
                }
                if(randArr[i] > max)
                {
                    max = randArr[i];
                }
                sum += randArr[i];
            }
            System.Console.WriteLine(min.ToString(), max, sum);

            return randArr;
        }

        public static string CoinFlip()
        {
            Random rand = new Random();
            string coin = "Not yet flipped";
            System.Console.WriteLine("Tossing a Coin!");
            int result = rand.Next(0,2);
            if(result==0)
            {
                coin = "Head";
                System.Console.WriteLine(coin);
            }
            else
            {
                coin = "Tail";
                System.Console.WriteLine(coin);
            }
            return coin;
        }

        public static double TossMultipleCoins(int num)
        {
            double ratioHT = 0;
            double headcount = 0;
            double total = 0;
            for(int i=0; i<num; i++)
            {
                string result = CoinFlip();
                total ++;
                if(result=="Head")
                {
                    headcount ++;
                }
            }
            ratioHT = headcount/total;
            return ratioHT;
        }

        public static List<string> Names()
        {
            Random rand = new Random();
            string[] arrayNames;
            arrayNames = new string[] {"Todd", "Tiffany", "Charlie", "Geneva", "Sydney"};
            for(int idx=0; idx<arrayNames.Length; idx++)
            {
                int newidx = rand.Next(0,arrayNames.Length);
                string temp = arrayNames[idx];
                arrayNames[idx] = arrayNames[newidx];
                arrayNames[newidx] = temp;               
            }

            List<string> longNames = new List<string>();
            for(int i=0; i<arrayNames.Length; i++)
            {
                if(arrayNames[i].Length > 5)
                {
                    longNames.Add(arrayNames[i]);
                }
            }
            return longNames;
        }
    }
}
