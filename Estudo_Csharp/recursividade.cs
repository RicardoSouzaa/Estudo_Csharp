using System;
namespace Estudo_Csharp
{
    class recursividade
    {
        //recursividade é utilizado para chamar a função dentro dela mesmo, definindo um fim.

        static public ulong fat(ulong n)  // método de recursividade
        {
            ulong res;
            if (n <= 1)
            {
                res = 1;
            }
            else
            {
                res = n * fat(n - 1);
            }
            return res;
        }

        static public void calc() // Método para fatorar o número escolhido maximo suportado e 65!
        {
            ulong resultado;
            ulong escolha;

            Console.WriteLine("Escolha o numero que deseja fatorar. Ex 5!");
            escolha = ulong.Parse(Console.ReadLine());

            resultado = fat(escolha);
            Console.WriteLine(resultado);
            Novamente();

            void Novamente()
            {
                char v;
                Console.WriteLine("Deseja fatorar outro número? (s/n)");
                v = Console.ReadKey().KeyChar;

                switch (char.ToLower(v))
                {
                    case 's':
                        Program.Limpar();
                        calc();
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
