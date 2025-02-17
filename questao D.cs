using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<string> palavras = new List<string> { "carro", "elefante", "avião", "bicicleta", "extraordinário" };

        string maisLonga = "";

        foreach (string palavra in palavras)
        {
            if (palavra.Length > maisLonga.Length)
            {
                maisLonga = palavra;
            }
        }

        Console.WriteLine("A palavra mais longa da lista é: " + maisLonga);
        Console.ReadKey();
    }
}
