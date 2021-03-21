using System;

namespace Estudo_Csharp
{
    class Estudo_Param
    {
        public static void Somatoria(params int[] n) // criando um metodo somatoria com parametros de array com valores inteiros e nome = n
        {
            int res = 0;
            if (n.Length < 1)
            {
                Console.WriteLine("Não existe valores para serem somados!");
            }
            else if (n.Length < 2)
            {
                Console.WriteLine($"Para realizar a somatória, precisa de dois ou mais numeros, foi digtado apenas o valor {n[0]}");
            }
            else
            {
                for (int i = 0; i < n.Length; i++)
                {
                    res += n[i]; // res vai receber o incremento do valor de i (0+i=0), (0+i=1), (1+i) etc.. 
                }
                Console.WriteLine($"A somatória dos valores digitado é: {res}");
            }
        }
    }

}
