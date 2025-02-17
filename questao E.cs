using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<int> numeros = new List<int> { 10, 20, 30, 40, 50 };

        int soma = 0;
        int quantidade = numeros.Count;

        foreach (int num in numeros)
        {
            soma += num;
        }

        double media = (double)soma / quantidade;

        Console.WriteLine("A média dos números da lista é: " + media);
        Console.ReadKey();
    }
}
