using System.Collections.Generic;
using System;
using System.Linq;

namespace kilo
{
    class Program
    {

        static bool runapp = true;
        static void Main(string[] args)
        {
            var cengine = new Engine();
            while (runapp)
            {
                Console.WriteLine("Bem vindo");
                Console.WriteLine("Digite o valor, ou s para sair: ");
                var str = Console.ReadLine();
                if (String.IsNullOrEmpty(str))
                {
                    Console.WriteLine("Digite um valor valido.");
                    continue;
                }
                if (str.Equals("s"))
                {
                    runapp = false;
                    continue;
                }
                if (cengine.Calculate(str))
                {
                    Console.WriteLine("");
                    Console.WriteLine("Value is {0}", cengine.Value.ToString());
                }
                else
                {
                    Console.WriteLine("Error converting value.");

                }


            }
        }


    }
}
