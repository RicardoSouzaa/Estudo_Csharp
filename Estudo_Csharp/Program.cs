using System;

namespace Estudo_Csharp
{
    class Program
    {
        /*static void EscolhaEstudo(params int[] escolhas)
        {
            int i = 0;
            escolhas[i] = i;

        }
        */
        static void Limpar()
        {
            Console.Clear();
        }

        /*static void Voltar()
        {
            char v;
            Console.WriteLine("Voltar? (s/n)");
            v = Console.ReadKey().KeyChar;
            switch (char.ToLower(v))
            {
                case 's':
                    Limpar();
                    goto Inicio;

                case 'n':
                    goto Fim;

                default:
                    Limpar();
                    Console.WriteLine("Escolha (S)Sim ou (N)Não");
                    goto Estudo_orientacao_obj;
            }
        }
        */
        static void Main(string[] args)
        {

        Inicio:

            char escolhas;
            char voltar;

            Console.WriteLine("Qual estudo você deseja rodar?");
            Console.WriteLine("\n\t 1) Estudo do metodo parametro (somatória) \n\t 2) Estudo de Orientação a obj. \n\t 3) Sair");
            escolhas = Console.ReadKey().KeyChar;
            //EscolhaEstudo(escolhas);

            switch (escolhas)
            {
                case '1':
                    Limpar();
                    goto Estudo_Param;

                case '2':
                    Limpar();
                    goto Estudo_orientacao_obj;

                default:
                    Limpar();
                    goto Fim;
            }

        Estudo_Param:

            Estudo_Param.Somatoria(200, 100, 10, 27, 88, 9, 16);
            Console.ReadKey();
            
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

        Estudo_orientacao_obj:

            Pessoa p = new Pessoa();
            p.Nome = "Arnaldo Antunes";
            p.Bracos = 2;
            p.Pernas = 1;
            p.Olhos = 2;
            p.CorCabelo = "preto";
            Console.WriteLine($"{p.Nome} possui: \n\t{p.Bracos} braços \n\t{p.Pernas} pernas \n\t{p.Olhos} olhos \n\tcor do cabelo:{p.CorCabelo}");

            Pessoa p1 = new Pessoa("Loiro");
            p1.Nome = "Milton Neves";
            Console.WriteLine($"{p1.Nome} possui: \n\t{p1.Bracos} braços \n\t{p1.Pernas} pernas \n\t{p1.Olhos} olhos \n\tcor do cabelo:{p1.CorCabelo}");
            Console.ReadKey();
            //Voltar();

            /* 
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
                    goto Estudo_orientacao_obj;
            }
            */
        Fim:
            Console.WriteLine("\n\nObrigado");
            Console.ReadLine();
        }
    }
}

