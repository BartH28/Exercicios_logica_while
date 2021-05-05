using System;

namespace exercicio_1
{
    class Program
    {
        static void Main(string[] args)
        {
            bool respostaCorreta = false;
            while (respostaCorreta == false)
            {
                Console.WriteLine("Insira uma nota de 0 a 10");
                int nota = int.Parse(Console.ReadLine());

                if (nota >= 0 && nota <= 10 )
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Sua nota é Valida");
                    Console.ResetColor();
                    respostaCorreta = true;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Sua nota não é valida");
                    Console.ResetColor();
                }
                
            }
        }
    }
}
