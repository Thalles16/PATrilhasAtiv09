using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<int> numeros = new List<int> { 12, 45, 78, 23, 56, 89, 14, 99, 37 };

        int maior = int.MinValue;

        foreach (int num in numeros)
        {
            if (num > maior)
            {
                maior = num;
            }
        }

        Console.WriteLine("O maior número da lista é: " + maior);
        Console.ReadKey();
    }
}
