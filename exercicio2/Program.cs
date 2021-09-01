using System;

namespace exercicio2
{

    class Program
    {
      

        static void Main(string[] args)
        {
            //declarando variáveis
                string nome1;
                string nome2;
            int idade1;
            int idade2;
            //pede os nomes e idades
            Console.WriteLine("digite o primeiro nome");
            nome1 = Console.ReadLine();
            //limpa o texto para não ficar poluído
            Console.Clear();
            Console.WriteLine("digite a primeira idade");
            //converte a idade string para int
            idade1 = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            Console.WriteLine("digite o segundo nome");
            nome2 = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("digite a segunda idade");
            idade2 = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            //mostra qual idade é maior e declara seu nome
            if(idade1 < idade2)
            {
                Console.WriteLine("Pessoa mais velha:" + nome2);
            }
            else
            {
                Console.WriteLine("Pessoa mais velha:" + nome1);
            }

        }
    }
}
