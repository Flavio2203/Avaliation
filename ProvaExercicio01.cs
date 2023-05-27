// See https://aka.ms/new-console-template for more information
using System;
using System.Xml.Schema;

namespace ExercicioProva01
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Entre com as quatros notas do aluno:");
            //           double n1 = double.Parse(Console.ReadLine());
            //           double n2 = double.Parse(Console.ReadLine());
            //           double n3 = double.Parse(Console.ReadLine());
            //           double n4 = double.Parse(Console.ReadLine());


            double[] notas = new double[4];
            double total = 0;
            decimal soma = 0;

            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("Entre com a nota n° " + (i + 1));
                notas[i] = int.Parse(Console.ReadLine());
                total = total + notas[i];

                soma = soma + int.Parse(Console.ReadLine());
            }

            //            Console.WriteLine(notas[1], notas[2], notas[3], notas[4]);

            double media = total / 4;
            decimal mediaTotal = soma / 4;

            if (media > 6)
            {
                Console.WriteLine("Nota: " + media);
                Console.WriteLine(mediaTotal);
                Console.WriteLine("Aprovado");
            }
            else
            {
                Console.WriteLine("Nota: " + media);
                Console.WriteLine(mediaTotal);
                Console.WriteLine("Reprovado");
            }

        }
    }
}
