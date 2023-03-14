/*Algoritmo que lê quantas letra maisculas tem em uma palavra*/


using System;

class program
{
    public static void Main(string[] args)
    {
        string palavra = Console.ReadLine();
        int resposta;
        while (palavra != "FIM")
        {
            resposta = ContaMaiusculas(palavra);
            Console.WriteLine(resposta);
            palavra = Console.ReadLine();
        }
    }
    
    /*Funcao que recebe a palavra e conta as letras maiusculas*/
    static int ContaMaiusculas(string palavra)
    {
        int count = 0;
        for (int i = 0; i < palavra.Length; i++)
        {
            if (palavra[i] >= 'A' && palavra[i] <= 'Z' || palavra[i] == 'Ç')
            {
                count++;
            }
        }
        return count;
    }

}
