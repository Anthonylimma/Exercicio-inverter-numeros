using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;

class Program
{
    static void Main()
    {
        // Lendo os três números inteiros
        Console.Write("Digite o primeiro número: ");
        int numero1 = int.Parse(Console.ReadLine());

        Console.Write("Digite o segundo número: ");
        int numero2 = int.Parse(Console.ReadLine());

        Console.Write("Digite o terceiro número: ");
        int numero3 = int.Parse(Console.ReadLine());

        // Criando um array com os números
        int[] numeros = { numero1, numero2, numero3 };

        // Ordenando o array em ordem decrescente
        Array.Sort(numeros);
        Array.Reverse(numeros);

        // Imprimindo os números em ordem decrescente
        Console.WriteLine("Os números em ordem decrescente são:");
        foreach (int numero in numeros)
        {
            Console.WriteLine(numero);
        }
            Console.ReadKey();
    }
}