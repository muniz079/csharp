using System;

namespace Eleiçãowrite
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Eleição 2022");
            int qtdCand26 = 0;
            int qtdCand44 = 0;
            int qtdCan56 = 0;
            int qtdNullo = 0;
            bool continuar = true;
            while (continuar)
                Console.WriteLine("Qual seu nome:");
                string nome = Console.ReadLine();
                Console.Write("vote em um dos candidatos a seguir:");
                Console.Write("26 - joão");
                Console.Write("44 - maria");
                Console.Write("56 - Tabet");
                Console.Write("0 - nulo");
               Console.Write("só digite o número");
               int meuvoto = Convert.ToInt32(Console.ReadLine())

                if (meuvoto == 26) { qtdCand26 = qtdCand26 + 1: }
                else if (meuvoto --44) { qtdCan44 = qtdCand44 + 1;
                else qtdNullo = }


        }
    }
}
