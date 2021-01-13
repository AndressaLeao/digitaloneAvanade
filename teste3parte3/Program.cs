using System;

namespace teste3parte3
{
    class Program
    {
        static void Main()
        {

            int R = 0;
            int V = 0;
            int D;
            int M = 0;
            int n = 0;



            string auxR = Console.ReadLine();

            bool sucess = Int32.TryParse(auxR, out R);

            if (sucess)
            {
                string auxD = Console.ReadLine();

                while (auxD != "")
                {
                    bool sucesso = Int32.TryParse(auxD, out D);

                    if (sucesso)
                    {
                        if (D >= V)
                        {
                            V = D;
                        }
                    }
                    auxD = Console.ReadLine();                    
                }
                M = 0;
                for (int i =0 ; M <= V ; i++)
                {
                    M = M + (R + i);
                    n =i;
                    
                }
                
                Console.WriteLine($"{n+1} ");

            }

        }
    }
}
