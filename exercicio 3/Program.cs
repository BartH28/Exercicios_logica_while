using System;

namespace exercicio_3
{
    class Program
    {
        static void Main(string[] args)
        {
            bool respostaCorreta = false;


            while (respostaCorreta == false)
            {
                Console.WriteLine("Insira seu Nome");
                string nome = Console.ReadLine();
                Console.WriteLine("Insira seu Idade");
                int Idade = int.Parse(Console.ReadLine());
                Console.WriteLine("Insira seu Salario");
                double Salario = double.Parse(Console.ReadLine());
                Console.WriteLine("Insira seu Estado Civil  's' para solteiro(a), 'c' para casado(a), 'v' para viuvo(a), 'd' para divorcia(a)");
                string estadoCivil = Console.ReadLine().ToLower();

                if (nome != "" && Idade >= 0 && Idade <= 150 && Salario >= 0 && estadoCivil == "s" | estadoCivil == "c" | estadoCivil == "v" | estadoCivil == "d")
                {
                    Console.WriteLine("Seu cadastro esta valido");
                    respostaCorreta = true;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Seu cadastro esta invalido");
                    Console.ResetColor();
                }
            }



        }
    }
}
