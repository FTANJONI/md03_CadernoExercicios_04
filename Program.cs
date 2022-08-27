using System;

namespace md03_CadernoExercicios_04
{
    class Program
    {
        /*
         4. Faça um algoritmo que leia 3 números inteiros distintos e escreva o menor
            deles.
         */
        static void Main(string[] args)
        {
            int a, b, c;
            Console.WriteLine("Digite o primeiro valor");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite o segundo valor");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite o terceiro valor");
            c = Convert.ToInt32(Console.ReadLine());

            if (a < b && a < c)
            {
                Console.WriteLine("O número " + a.ToString() + " foi o menor valor digitado.");
            }
            else if(b < a && b < c)
            {
                Console.WriteLine("O número " + b.ToString() + " foi o menor valor digitado.");
            }
            else if (c < a && c < b)
            {
                Console.WriteLine("O número " + c.ToString() + " foi o menor valor digitado.");
            }
        }
    }
}
