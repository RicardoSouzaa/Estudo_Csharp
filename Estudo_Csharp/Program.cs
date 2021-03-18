using System;

namespace Estudo_Csharp
{
    class Program
    {
        static void Limpar()
        {
            Console.Clear();
        }

        static void Main(string[] args)
        {
        Inicio:

            int[] escolhaEstudo = new int[10]; int i;
            char voltar;

            Console.WriteLine("Qual estudo você deseja rodar?");
            Console.WriteLine("\n\t 1) Estudo do metodo parametro (somatória) \n\t 2) teste");
            i = int.Parse(Console.ReadLine());
            escolhaEstudo[i] = i;

            switch (escolhaEstudo[i])
            {
                case 1:
                    Limpar();
                    goto Estudo_Param;

                case 2:
                    Limpar();
                    goto Inicio;

                default:
                    Limpar();
                    goto Inicio;
            }

        Estudo_Param:

            Estudo_Param.Somatoria(200, 100, 10, 27, 88, 9, 16);
            Console.ReadLine();
            Console.WriteLine("Voltar? (s/n)");
            voltar = Console.ReadKey().KeyChar;

            switch (char.ToLower(voltar))
            {
                case 's':
                    Limpar();
                    goto Inicio;

                case 'n':
                    goto Fim;

                default:
                    Limpar();
                    Console.WriteLine("Escolha (S)Sim ou (N)Não");
                    goto Estudo_Param;
            }
        Fim:
            Console.WriteLine("\n\nObrigado");
            Console.ReadLine();
        }
    }
}

