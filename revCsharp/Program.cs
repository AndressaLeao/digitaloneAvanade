using System;

namespace revisao
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno[] alunos  = new Aluno[5];
            int indiceAluno = 0;

            string opcaoDesejada = selecionaOpcao();

           

            while (opcaoDesejada.ToUpper() != "X")
            {
                switch (opcaoDesejada)
                {
                    case "1":
                        Console.WriteLine("Digite o nome do Aluno");
                        Aluno aluno = new Aluno();

                        aluno.Nome = Console.ReadLine();

                        Console.WriteLine("Digite a nota deste Aluno");

                        if (decimal.TryParse(Console.ReadLine(), out decimal nota))
                            {
                            aluno.Nota = nota;
                            
                            }
                        else
                        {
                            throw new ArithmeticException("O valor da nota deve ser decimal!");
                        }
                        alunos [indiceAluno] = aluno;
                        indiceAluno ++;
                        break;

                    case "2":
                        
                        foreach(var a in alunos)
                        {
                            if(!string.IsNullOrEmpty(a.Nome))
                            {
                                Console.WriteLine($"Aluno: {a.Nome}  - Nota {a.Nota}");
                            }
                            // else
                            // {
                            //     Console.WriteLine("Não há alunos");
                            // }
                        }
                        break;

                    case "3":
                        decimal soma = 0;
                        decimal numAlunos = 0;
                        // foreach(var a in alunos){
                        //     if(!string.IsNullOrEmpty(a.Nome))
                        //     {
                        //     soma = soma + a.Nota;
                            
                        //     numAlunos ++; 
                        //     }                          
                            
                        // }
                        for(int i = 0; i <alunos.Length; i++)
                        {
                            if(!string.IsNullOrEmpty(alunos[i].Nome))
                           {
                            soma = soma + alunos[i].Nota;
                            numAlunos ++; 
                           }
                           
                        }
                        decimal media = soma / numAlunos;
                        Conceito conceitoGeral;

                        if(media < 2)  
                        {
                            conceitoGeral = Conceito.E;
                        }
                        else if(media < 4)  
                        {
                            conceitoGeral =  Conceito.D;
                        }
                        else if(media < 6)  
                        {
                            conceitoGeral =  Conceito.C;
                        }
                        else if(media < 8)  
                        {
                            conceitoGeral = Conceito.B;
                        }
                        else
                        {
                            conceitoGeral =  Conceito.A;
                        }

                        

                        Console.WriteLine($"A média é:  {media}");
                        Console.WriteLine($"O conceito da nota é {conceitoGeral}");
                        break;
                    default:
                        throw new ArgumentOutOfRangeException();
        
                }
                opcaoDesejada = selecionaOpcao();
            } 
            

        }

        private static string selecionaOpcao()
        {
            Console.WriteLine("Digite a opção desejada:");

            Console.WriteLine("1- Inserir Alunos");
            Console.WriteLine("2- Listar aluno");
            Console.WriteLine("3- Calcular Média");
            Console.WriteLine("X- para sair");
            Console.WriteLine();

             string opcaoDesejada = Console.ReadLine();
            
            return opcaoDesejada;
        }
    }
}
