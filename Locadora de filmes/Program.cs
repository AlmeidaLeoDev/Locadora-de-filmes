using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Locadora_de_filmes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pressione A para alugar um filme ou S para sair da locadora");
            char opcao = Console.ReadKey(true).KeyChar;
            if (opcao == 'A' || opcao == 'a')
            {
                // alugar um filme
                Console.WriteLine("Pressione 1 para alugar - Velozes e furiosos");
                Console.WriteLine("Pressione 2 para alugar - Piratas do caribe");
                Console.WriteLine("Pressione 3 para alugar - Avatar");
                int opcaoFile = Convert.ToInt32(Console.ReadKey(true).KeyChar.ToString());
                switch (opcaoFile)
                {
                    case 1:
                        Console.WriteLine("Você alugou Velozes e furiosos");
                        break;
                    case 2:
                        Console.WriteLine("Você alugou Piratas do caribe");
                        break;
                    case 3:
                        Console.WriteLine("Você alugou Avatar");
                        break;
                    default:
                        Console.WriteLine("Opção desconhecida");
                        break; 
                }
            }
            else if (opcao == 'S' || opcao == 's')
            {
                // sair da locadora
                Console.WriteLine("Muito obrigado, volte sempre!");
            }
            else
            {
                Console.WriteLine("Opção desconhecida");
            }
            Console.WriteLine();
            Console.WriteLine("Pressione qualquer tecla para encerrar");
            Console.ReadKey(); 
        }
    }
}
