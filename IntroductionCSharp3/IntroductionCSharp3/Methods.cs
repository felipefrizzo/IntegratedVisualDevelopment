using System;

namespace IntroductionCSharp3
{
    public class Methods
    {
        public void  fillIn(int[] v, int t)
        {
            for (int i = 0; i < t; i++)
            {
                Console.WriteLine("Digite o numero {0} de {1}", i+1, t);
                v[i] = Int32.Parse(Console.ReadLine());
                Console.Clear();
            }        
        }
        public void print(int[] v, int t)
        {
            for (int i = 0; i < t; i++)
            {
                if ((i + 1) == t){
                    Console.WriteLine("{0}. ", v[i]);
                } else {
                    Console.WriteLine("{0}, ", v[i]);
                }

            }
        }
    }
}
