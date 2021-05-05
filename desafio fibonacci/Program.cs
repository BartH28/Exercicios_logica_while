using System;

namespace desafio_fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0;
            int b = 1;

            Console.WriteLine(a);
            Console.WriteLine(b);

            for (int i = 0; i <= 13 ; i++)
            {
                int alg1 = a;
                int alg2 = b;

                int conta =  alg1 + alg2;
                
                Console.WriteLine(conta);

                alg1 = a = b;

                alg2 = b = conta;   
            }

        }
    }
}
