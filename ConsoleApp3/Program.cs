using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Digite sua alura:");
            double altura = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite seu peso");
            double peso = double.Parse(Console.ReadLine());

            double IMC = peso / (altura * altura);

            if (IMC < 16.5)
            {
                Console.WriteLine("Você esta desnutrido!!!");
            }
            else if (IMC == 17 && IMC < 18.5)
            {
                Console.WriteLine("Você esta no peso ideal!!!");
            }
            else if (IMC == 18.5 && IMC < 24.9)
            {
                Console.WriteLine("Você esta acima do peso ideal");
            }
            else if (IMC == 30 && IMC < 35)
            {
                Console.WriteLine("Você esta com obesidade grau | ");

            }

            else if (IMC == 35 && IMC < 40)
            {
                Console.WriteLine("Você esta com obesidade grau || ");
            }
            
            else if (IMC > 40)
            {
                Console.WriteLine("Você esta com obesiadade grau ||");
            }

            Console.ReadKey();

        }
    }
}
