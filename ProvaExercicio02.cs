// See https://aka.ms/new-console-template for more information
namespace ProvaExercicio02
{
    class Prova02
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual nivel do professor:(Somente números de 1 a 3");
            int nivel = int.Parse(Console.ReadLine());

            Console.WriteLine("Entre com o numero de horas aulas ministrada");
            double aula = double.Parse(Console.ReadLine());


            if (nivel == 1)
            {
                double total = aula * 12.00;
                Console.WriteLine("Salário total:" + total);
            }
            else if (nivel == 2)
            {
                double total = aula * 17.00;
                Console.WriteLine("Salário total:" + total);
            }
            else if (nivel == 3)
            {
                double total = aula * 25.00;
                Console.WriteLine("Salário total:" + total);
            }

        }

    }
}
