using System;

namespace teste3parte4
{
    class Program
    {
        static void Main()
        {

            double N1, nota1, N2, nota2, media;
            int contNotas = 0;

            while (contNotas < 2)
            {
                string auxn1 = Console.ReadLine();

                bool sucess = Double.TryParse(auxn1, out N1);

                if (sucess)
                {
                    if (N1 >= 0.0 && N1 <= 10.0)
                    {
                        while (contNotas < 2)
                        {
                            nota1 = N1;
                            contNotas = 1;

                            string auxn2 = Console.ReadLine();

                            bool sucesso = Double.TryParse(auxn2, out N2);
                            if (sucesso)
                            {
                                if (N2 >= 0.0 && N2 <= 10.0)
                                {
                                    nota2 = N2;
                                    contNotas++;

                                    media = (nota1 + nota2) / 2;
                                    Console.WriteLine($"media = {media}");
                                }
                                else
                                {
                                    Console.WriteLine("nota invalida");
                                }

                            }


                        }

                    }
                    else
                    {
                        Console.WriteLine("nota invalida");
                    }
                }

            }

        }



    }
}
