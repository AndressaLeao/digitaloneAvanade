using System;

namespace teste3
{
    class Program
    {
        static void Main()
        {
            int N;
                        
            string[] recebe = { Console.ReadLine() };
            // Console.WriteLine($" O numero digitado é {recebe}");

            foreach (var value in recebe)
            {
                bool sucesso = Int32.TryParse(value, out N);

                if (sucesso)
                {
                    //Console.WriteLine($" O numero digitado é {N}");
                    for( double i=1; i<= N; i++)
                    {
                        double iquadrado=2, icubo=3;
                        
                        Console.WriteLine($"{i} {iquadrado = Math.Pow(i, 2)} {icubo = Math.Pow(i, 3)}\n");
                    }
                }
                else
                {
                    Console.WriteLine($" O numero digitado é invalido");
                }
                
            }

           

            
        }
    }
}
