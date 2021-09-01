using System;

namespace exercicio2
{

    class Program
    {
      

        static void Main(string[] args)
        {
                string nome1;
                string nome2;
            int idade1;
            int idade2;
            Console.WriteLine("digite o primeiro nome");
            nome1 = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("digite a primeira idade");
            idade1 = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            Console.WriteLine("digite o segundo nome");
            nome2 = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("digite a segunda idade");
            idade2 = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
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
