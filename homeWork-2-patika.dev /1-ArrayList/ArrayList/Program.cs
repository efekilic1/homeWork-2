using System;
using System.Collections;

namespace arrayList
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            ArrayList prime = new ArrayList();
            ArrayList notPrime = new ArrayList();

            
            int prim = 0;

            for(int i=0; i<20; i++)
            {
                Flag:
                string num1 = Console.ReadLine();
                int number;
                bool result = int.TryParse(num1, out number);
                if (result && number > 0)
                {
                    int num = int.Parse(num1);
                    if (num == 2)
                    {
                        prime.Add(num);
                    }
                    else
                    {
                        for (int j = 2; j < num; j++)
                        {
                            if (num % j == 0)
                            {
                                prim = 0;
                                break;
                            }
                            else
                            {
                                prim = 1;

                            }

                        }

                        if (prim == 0)
                        {

                            notPrime.Add(num);
                        }
                        else
                        {
                            prime.Add(num);

                        }

                    }
                }
                else
                {
                    Console.WriteLine("Please enter positive number");
                    goto Flag;
                }
                
                
                

     




            }
            Console.WriteLine("prime numbers: ");
            prime.Sort();
            int primeSum = 0;
            foreach (int num in prime)
            {
                Console.Write(num + " ");
                primeSum += num;
            }
            Console.WriteLine("\nmember numbers are: " + prime.Count);
            Console.WriteLine("Prime Numbers Sum = " + primeSum);

            Console.WriteLine("\nnot prime numbers: ");

            notPrime.Sort();
            int notPrimeSum = 0;
            foreach (int num in notPrime)
            {
                Console.Write(num + " ");
                notPrimeSum += num;
            }
            Console.WriteLine("\nmember numbers are: " + notPrime.Count);
            Console.WriteLine("Not Prime Numbers Sum = " + notPrimeSum);







        }
    }
    

}
