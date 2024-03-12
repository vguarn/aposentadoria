using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aposentadoria
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Em qual ano você nasceu? ");
             int ano = int.Parse(Console.ReadLine());
            Console.WriteLine("Há quantos anos você trabalha na empresa? ");
             int anoempresa = int.Parse(Console.ReadLine());
             int idade = 2024 - ano;

            if (idade >= 65 || anoempresa >= 30 || idade >= 60 && anoempresa >= 25)
            {
                Console.WriteLine("Você tem direito a aposentadoria!");
            }
            else
            {
                Console.WriteLine("Você não tem direito a aposentadoria.");
            }

            Console.ReadKey();
        }
    }
}
