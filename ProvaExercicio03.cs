// See https://aka.ms/new-console-template for more information
namespace ExercicioProva03
{
    class Prova
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-------------Cardápio---------");
            Console.WriteLine("100----Cachorro quente----R$1,10");
            Console.WriteLine("101---- Bauru simples ----R$1,30");
            Console.WriteLine("102---- Bauru com ovo ----R$1,50");
            Console.WriteLine("103----   Hamburguer  ----R$1,10");
            Console.WriteLine("104---- Cheeseburguer ----R$1,30");
            Console.WriteLine("105----  Refrigerante ----R$1,10");


            Console.WriteLine("Digite o código do pedido");
            int codigo = int.Parse(Console.ReadLine());

            double preco = 0;
            string especificacao = "";

            switch (codigo)
            {
                case 100:
                    especificacao = "Cachorro Quente";
                    preco = 1.10;
                    break;
                case 101:
                    especificacao = "Bauru Simples";
                    preco = 1.30;
                    break;
                case 102:
                    especificacao = "Bauru Com Ovo";
                    preco = 1.50;
                    break;
                case 103:
                    especificacao = "Hamburguer";
                    preco = 1.10;
                    break;
                case 104:
                    especificacao = "Cheeseburgue";
                    preco = 1.30;
                    break;
                case 105:
                    especificacao = "Refrigerante";
                    preco = 1.00;
                    break;

                default:
                    Console.WriteLine("Codigo inválido");
                    return;

            }

            Console.WriteLine("Digite a quantidade");
            int quantidade = int.Parse(Console.ReadLine());

            double total = preco * quantidade;

            Console.WriteLine("Codigo do pedido: " + codigo);
            Console.WriteLine("Especificação do item:" + especificacao);
            Console.WriteLine("Preço do item: " + preco);
            Console.WriteLine("Total: " + total.ToString("F2"));
        }

    }

}
