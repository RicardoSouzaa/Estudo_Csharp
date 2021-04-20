using System;
namespace Estudo_Csharp
{
    delegate int Op(int n1, int n2);

    public class Est_delegate
    {
        public static int soma(int n1, int n2)
        {
            return n1 + n2;
        }

        public static int mult(int n1, int n2)
        {
            return n1 * n2;
        }

        public static void estDelegate()
        {
            int res, v1, v2;

            Op d1 = new Op(soma);

            Console.WriteLine("digite o primeiro valor:");
            v1 = int.Parse(Console.ReadLine());
            Console.WriteLine("\ndigite o segundo valor:");
            v2 = int.Parse(Console.ReadLine());

            res = d1(v1, v2);
            Console.WriteLine($"\nSoma...: {res}  (return n1+n2)");


            d1 = new Op(mult);

            res = d1(v1, v2);
            Console.WriteLine($"\nMultiplicação...: {res}    (return n1*n2)\n\n");

            Novamente();

            void Novamente()
            {
                char v;
                Console.WriteLine("Deseja testar novamente? (s/n)");
                v = Console.ReadKey().KeyChar;

                switch (char.ToLower(v))
                {
                    case 's':
                        Program.Limpar();
                        estDelegate();
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
