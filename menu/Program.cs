using System;

namespace menu // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        public const int SAIDA_PROGRAMA = 0;
        public const int lER_ARQUIVO = 1;
        public const int TABUADA = 2;
        public const int CALCULO = 3;

    
        static void Main(string[] args)
        {
            while (true)
            {
                string mensagem = "Olá usuário, bem vindo ao programa\n" +
                    "\n Utilizando programação funcional " + "\n" +
                    "\n Digite umas das opções abaixo \n" +
                    "\n - Sair do programa" +
                    "\n - Para ler arquivos" +
                    "\n - Para executar a tabuada" +
                    "\n - Calcular média da alunos";

                    Console.WriteLine(mensagem);
                    Console.ReadLine();

                Console.WriteLine("Digite " + SAIDA_PROGRAMA + " para sair do programa");
                int valor = Convert.ToInt32(Console.ReadLine());

                if (SAIDA_PROGRAMA == valor)
                {
                    break;
                }
            }
        }
    }
}