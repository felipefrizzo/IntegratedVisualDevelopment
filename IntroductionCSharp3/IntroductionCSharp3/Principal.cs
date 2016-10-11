using System;
using System.Windows.Forms;

namespace IntroductionCSharp3
{
    class Principal
    {
        static void Main(string[] args)
        {
            const int t = 7;
            int[] vet = new int[t];

            Methods methods = new Methods();
            methods.fillIn(vet, t);
            methods.print(vet, t);
            Console.ReadKey();
        }
    }
}
