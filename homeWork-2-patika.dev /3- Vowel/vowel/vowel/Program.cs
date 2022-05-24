using System;

namespace Xowel
{
    class MainClass
    {
        public static void Main(string[] args)
        {

            char[] cA = Console.ReadLine().ToCharArray();
            
            //Console.WriteLine(cA.Length);

            int j = 0;
            for (int i = 0; i<cA.Length; i++)
            {

                if((cA[i] == 'a') || (cA[i] == 'e') || (cA[i] == 'i') || (cA[i] == 'o') || (cA[i] == 'u'))
                {
                    j++;
                }
                
            }
            char[] vowel = new char[j];
            Console.WriteLine("Vowel numbers = "+j);

            int p = 0;
            for (int i = 0; i < cA.Length; i++)
            {

                if ((cA[i] == 'a') || (cA[i] == 'e') || (cA[i] == 'i') || (cA[i] == 'o') || (cA[i] == 'u'))
                {
                    vowel[p] = cA[i];
                    p++;
                }
              
            }
            Array.Sort(vowel);
            foreach (var v in vowel)
            {
                Console.Write(v + " ");
            }

        }
    }
}
