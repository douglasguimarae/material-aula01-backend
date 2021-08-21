using System;

namespace aula_03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("************* Calculando a média de notas de alunos **********");

            //variavel para a contagem de alunos com a média calculada
            int contadorDeAlunos = 0;

            //variavel que informa a quantidade de alunos que terão a média calculada
            int quantidadeDeAlunos = 5;

            while (contadorDeAlunos < quantidadeDeAlunos)
            {
                Console.Write("Informe o numero de matricula: ");
                string matricula = Console.ReadLine();

                Console.Write("Informe a Nota 01: ");
                int nota01 = Convert.ToInt32(Console.ReadLine());

                Console.Write("Informe a Nota 02: ");
                int nota02 = Convert.ToInt32(Console.ReadLine());

                Console.Write("Informe a Nota 03: ");
                int nota03 = Convert.ToInt32(Console.ReadLine());

                //Calcular a média dos alunos
                int mediaAluno = (nota01 + nota02 + nota03) / 3;

                //exibir se o aluno foi aprovado ou não
                if(mediaAluno >= 7)
                {
                    Console.WriteLine("O aluno " + matricula + " foi aprovado com média " + mediaAluno);
                }
                else
                {
                    Console.WriteLine("O aluno " + matricula + " foi reprovado com média " + mediaAluno);
                }

                contadorDeAlunos++;
            }
        }

        
    }
}
