using System;
using System.Windows.Forms;

namespace IntroductionCSharp2
{
    public class Program
    {
        public void Main(string[] args)
        {
            double n1 = 0, n2 = 0, res = 0;

            try
            {
                Console.WriteLine("Digite o valor 01:");
                n1 = Double.Parse(Console.ReadLine());
                Console.WriteLine("Digite o valor 02:");
                n2 = Double.Parse(Console.ReadLine());

                if (n2 != 0)
                {
                    res = n1 / n2;
                    MessageBox.Show(
                        "Resultado = " + String.Format("{0:0.00}", res),
                        "Resultado",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );
                } else {
                    MessageBox.Show(
                        "Não há divisão por zero!",
                        "Atenção",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );
                }
            } catch {
                MessageBox.Show(
                    "Você informou números inválidos!", 
                    "Atenção", 
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }
    }
}
