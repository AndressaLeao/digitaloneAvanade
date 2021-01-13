using System;

namespace teste3parte5
{
    class Program
    {
        static void Main()
        {
            int n = 0;
            int cont = 0;
            string[] read = new string[106];
            while (n < 106)
            {
                read[n] = Console.ReadLine();
                if (String.IsNullOrEmpty(read[n]))
                {
                    break;
                }               
                n++;
            }
            string[] dicionario= new string[106];
            for (int j = 0; j < n; j++)
            {
                for (int i = 0; i <= j; i++)
                {
                    if (read[j] == dicionario[i] || string.IsNullOrEmpty(read[j]))
                    {
                        break;
                    }
                    else
                    {
                        if(string.IsNullOrEmpty(dicionario[i]))
                        {
                            dicionario[i] = read[j];
                            cont++;
                            break;
                        }
                    }
                }
            }
            Console.WriteLine($"saida {cont}");
        }
    }
}
