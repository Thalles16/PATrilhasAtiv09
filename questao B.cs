using System;

class Program
{
    static void Main()
    {

    	string[] palavras = {"pao","chocolate","mel"};
    	
    	foreach (string palavra in palavras)
    	{
    	Console.WriteLine("as palavras do vetor sao: "+palavra);
    	}
        
        Console.WriteLine("\nPressione qualquer tecla para sair...");
        Console.ReadKey();
    }
}
