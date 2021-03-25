using System;
namespace Estudo_Csharp
{
    public class Armazem_estudo
    {
        public static void Armazem()
        {
            int[] inventario = { 200, 450, 700, 175, 250 }; // qtd de itens no armazem (arrays)
            int soma = 0;
            int qtd_indv = 0;

            foreach (int itens in inventario) // acessar cada iten dentro da array
            {
                soma += itens;
                qtd_indv++;
                Console.WriteLine($"Iten {qtd_indv} = {itens} itens : Relizando somatoria total : {soma}  ");
            }
            Console.WriteLine($"Nosso armazém possui {soma} itens em seu inventário");
            Console.ReadLine();
            Program.Limpar();
            Fraudulento();
        }

        public static void Fraudulento()
        {
            string[] inventario = { "B123", "C234", "A345", "C15", "B177", "G3003", "C235", "B179" };

            foreach (string itens in inventario)
            {
                if (itens.StartsWith("B"))
                {
                    Console.WriteLine($"{itens} --- Itens que começam com B podem ser fraudulentos");
                }
                else
                {
                    Console.WriteLine($"{itens} --- Item normal.");
                }

            }
            Console.ReadLine();
            Program.Limpar();
            Program.Voltar();

        }
    }



}
