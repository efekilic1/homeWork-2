using System;

namespace ArrayHW
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int[] numbers = new int[20];
            int[] maxNumbers;
            int[] minNumbers;

            for (int i = 0; i < 20; i++)
            {



                numbers[i] = Convert.ToInt32(Console.ReadLine());
                

            }

            Array.Sort(numbers);

            int minAverage = 0;
            int maxAverage = 0;
            Console.WriteLine("En küçük 3 sayı: ");

            for (int i = 0; i < 3; i++)
            {
                minAverage += numbers[i];
                
                Console.Write(numbers[i]+" ");
            }

            Console.WriteLine("\nEn küçük 3 sayının toplamı = "+minAverage);
            Console.WriteLine("En küçük 3 sayının ortalaması = " + minAverage/3);
            Console.WriteLine("En büyük 3 sayı: ");


            for (int i =19; i>16; i--)
            {
                maxAverage += numbers[i];
                
                Console.Write(numbers[i] + " ");
            }
            Console.WriteLine("\nEn büyük 3 sayının toplamı = " + maxAverage);
            Console.WriteLine("En büyük 3 sayının ortalaması = " + maxAverage/3);
            int sumAverage = (maxAverage + minAverage) / 3;
            Console.WriteLine("Ortalamaların toplamları = " + sumAverage);
           





        }
    }
}
