using System;

namespace Estudo_Csharp
{
    public class Jogo_dados
    {
        public static void JogodeDados()
        {
            Random dados = new Random();

            int dado1 = dados.Next(1, 7);
            int dado2 = dados.Next(1, 7);
            int dado3 = dados.Next(1, 7);

            int total = dado1 + dado2 + dado3;
            Console.WriteLine($"Dados Lançados: {dado1} + {dado2} + {dado3} = {total}");

            if ((dado1 == dado2) || (dado2 == dado3) || (dado1 == dado3))
            {
                if ((dado1 == dado2) && (dado2 == dado3))
                {
                    Console.WriteLine("Parabéns, você jogou os dados e tirou os 3 numero iguais... Receba +6 de bonus");
                }
                else
                {
                    Console.WriteLine("Você rolou os dados e conseguiu 2 numeros iguais, receba +2 de bonus...");
                }
            }
            if (total >= 20)
            {
                Console.WriteLine("Você ganhou uma casa nova");
            }
            else if (total >= 16)
            {
                Console.WriteLine("Você ganhou um carro importado");
            }
            else if (total == 10)
            {
                Console.WriteLine("Você ganhou uma moto");
            }
            else if (total >= 5)
            {
                Console.WriteLine("Você ganhou uma bicicleta");
            }
            else
            {
                Console.WriteLine("Você ganhou uma nota de R$ 50,00");
            }
            Novamente();

            void Novamente()
            {
                char v;
                Console.WriteLine("Jogar novamente? (s/n)");
                v = Console.ReadKey().KeyChar;
                
                switch (char.ToLower(v))
                {
                    case 's':
                        Program.Limpar();
                        JogodeDados();
                        break;

                    case 'n':
                        Program.Limpar();
                        Program.Voltar();
                        break;

                    default:
                        Program.Limpar();
                        Console.WriteLine("Escolha (S)Sim ou (N)Não");
                        Novamente();
                        break;
                }
            }
            

        }
    }


}



