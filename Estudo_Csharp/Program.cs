using System;

namespace Estudo_Csharp
{
    class Program
    {
        public static void Limpar()
        {
            Console.Clear();
        }

        public static void Fim()
        {
            Console.WriteLine("\n\nObrigado");
            Console.ReadLine();
        }

        public static void Voltar()
        {
            char v;
            Console.WriteLine("Voltar para o menu principal? (s/n)");
            v = Console.ReadKey().KeyChar;
            switch (char.ToLower(v))
            {
                case 's':
                    Limpar();
                    Inicio();
                    break;

                case 'n':
                    Fim();
                    break;

                default:
                    Limpar();
                    Console.WriteLine("Escolha (S)Sim ou (N)Não");
                    Voltar();
                    break;
            }
        }

        static void Main(string[] args)
        {
            Inicio();
        }

        static void Inicio()
        {
            char escolhas;

            Console.WriteLine("Qual estudo você deseja rodar?");
            Console.WriteLine
            (
                "\n\t 1) Estudo do metodo parametro (somatória) " +
                "\n\t 2) Estudo de Orientação a obj. " +
                "\n\t 3) Estudo de if e else (Jogo de dados) " +
                "\n\t 4) Estudo de Foreach e Arrays (Itens no armazém) " +
                "\n\t 5) Estudo de Heranças de classes (Veículos/carros)" +
                "\n\t 6) Estudo de Recursividade (chamar a função dentro da mesma)" +
                "\n\t 7) Sair"
            );

            escolhas = Console.ReadKey().KeyChar;

            switch (escolhas)
            {
                case '1':
                    Limpar();
                    EStudoParam();
                    break;

                case '2':
                    Limpar();
                    Estudo_Orientacao_Obj();
                    break;

                case '3':
                    Limpar();
                    Jogo_dados.JogodeDados();
                    break;

                case '4':
                    Limpar();
                    Armazem_estudo.Armazem();
                    break;
                
                case '5':
                    Limpar();
                    Estudo_heraca();
                    break;

                case '6':
                    Limpar();
                    recursividade.calc();
                    break;

                case '7':
                    Limpar();
                    Fim();
                    break;

                default:
                    Limpar();
                    Fim();
                    break;
            }
        }
        static void EStudoParam()
        {
            Estudo_Param.Somatoria(200, 100, 10, 27, 88, 9, 16);
            Console.ReadKey();
            Voltar();
        }

        static void Estudo_Orientacao_Obj()
        {
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
            Voltar();
        }

        static void Estudo_heraca()
        {
            Carro c1 = new Carro("rapidão", "Vermelho");
            
            Console.WriteLine($"Nome do carro...: {c1.nome}");
            Console.WriteLine($"Cor do carro....: {c1.cor}");
            Console.WriteLine($"Qtd. de rodas...: {c1.getRodas()}");
            Console.WriteLine($"Velo. Maxima....: {c1.velMax} Km/h");
            Console.WriteLine($"Carro ligado?...: {c1.getLigado()}");
            
            
            CarroCombate cc1 = new CarroCombate();

            cc1.Desligar();
            cc1.velMax = 60;
            Console.WriteLine($"\n\n\nNome do carro...: {cc1.nome}");
            Console.WriteLine($"Cor do carro....: {cc1.cor}");
            Console.WriteLine($"Qtd. de rodas...: {cc1.getRodas()}");
            Console.WriteLine($"Velo. Maxima....: {cc1.velMax} Km/h");
            Console.WriteLine($"Carro ligado?...: {cc1.getLigado()}");
            Console.WriteLine($"Qtd de munição:.: {cc1.municao}");
            Console.ReadLine();
            Voltar();
        }

    }
}