using System;

namespace teste1
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Digite o numero de operacaoes de divisão que voce deseja realizar");
            int limit = int.Parse(Console.ReadLine());
             
            Console.WriteLine($"voce deseja divirdir  {limit} numeros");
            Console.WriteLine("");

            
            
            for (int i = 0; i < limit; i++) 
                {
                    Console.WriteLine($"Digite o dividendo e o divisor  da divisao {i} separados  por espaco");
                    string[] line = Console.ReadLine().Split(" ");
                    //Console.WriteLine($"numero digitado {limit} and {line}");

                    int  X = int .Parse(line[0]);
                    int Y = int .Parse(line[1]);
                
                    Console.WriteLine($"numero digitado {X}");
                    Console.WriteLine($"numero digitado {Y}");
                    Console.WriteLine("");
                    decimal resto = X%Y;

                    if (Y == 0) {
                        Console.WriteLine("divisao impossivel");
                    } 
                    else if(resto != 0)                    
                    {
                        Console.WriteLine("divisao impossivel");
                        Console.WriteLine("");
                    }
                    else
                    {
                        double divisao = X / Y; // Digite aqui o calculo da divisao
                        Console.WriteLine(divisao.ToString("N1"));
                    }
                }
        }
    }

}

