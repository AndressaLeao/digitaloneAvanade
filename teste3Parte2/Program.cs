using System;

namespace teste3Parte2
{
    class Program
    {
        static void Main()
        {
            int tamanho;
            int maiorVelocidade = 0;
            string size = Console.ReadLine();

            while (size != null)
            {

                bool sucesso = Int32.TryParse(size, out tamanho);

                if (sucesso)
                {

                    int[] velocidade;
                    velocidade = new int[tamanho];

                    string valores = Console.ReadLine();

                    string[] numeros = valores.Split(' ');
                    int i = 0;
                    int vel;

                    foreach (var num in numeros)
                    {

                        bool testparse = Int32.TryParse(num, out vel);

                        if (testparse)
                        {
                            velocidade[i] = vel;
                            i++;
                        }
                        else
                        {
                            break;
                        }

                    }

                    for (int j = 0; j < tamanho; j++)
                    {

                        if (maiorVelocidade < velocidade[j])
                        {
                            maiorVelocidade = velocidade[j];
                        }

                    }

                    if (maiorVelocidade < 10)
                    {
                        Console.WriteLine("1");
                    }
                    else if (maiorVelocidade >= 10 && maiorVelocidade < 20)
                    {
                        Console.WriteLine("2");
                    }
                    else if (maiorVelocidade >= 20)
                    {
                        Console.WriteLine("3");
                    }


                }
                else
                {
                    break;
                }


                size = Console.ReadLine();
                maiorVelocidade =0;
            }

        }
    }
}