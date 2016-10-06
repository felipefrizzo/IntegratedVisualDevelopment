using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IntroductionCSharp
{
    public class Program
    {
        public void Main(string[] args)
        {
            double n = 0, res = 0;
            Console.WriteLine("Digite um numero: \n");
            n = Double.Parse(Console.ReadLine());
			if (n > 0) {
				res = Math.Sqrt(n);
				Console.WriteLine("A raiz de {0} é: {0:0.00}", n, res);	
				
				res = Math.Pow(n, 2.00);
				Console.WriteLine("O quadrado de {0} é: {0:0.00}", n, res);	
				
				res = Math.Pow(n, (1.00 / 3.00));
				Console.WriteLine("A raiz cúbica de {0} é: {0:0.00}", n, res);	
			} else {
				Console.WriteLine("Não foi possivel calcular!\n");
			}
            Console.ReadKey(); 
        }
    }
}
