using System;

namespace exercicio_2
{
    class Program
    {
        static void Main(string[] args)
        {
            bool respostaCorreta = false;
            string senha = "";
            string nome = "";

            while (respostaCorreta == false)
            {
                Console.WriteLine("Insira seu nome");
                nome = Console.ReadLine();

                Console.WriteLine("Insira sua senha");
                senha = Console.ReadLine();

                if (senha != nome)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Sua senha e nome são validas");
                    respostaCorreta = true;
                    Console.ResetColor();
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Sua senha e nome são iguais faça novamente");
                    Console.ResetColor();
                }

            }
        }
    }
}
