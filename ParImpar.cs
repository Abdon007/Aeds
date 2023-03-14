/*Algoritmo que identifica se o numero é impar ou par*/

using System;

class Program
{
    public static void Main(string[] args)
    {
        int valor;
        string resposta;
        valor = int.Parse(Console.ReadLine());
        while (valor >= 0)
        {
            resposta = ParImpar(valor);
            Console.WriteLine(resposta);
            valor = int.Parse(Console.ReadLine());
        }
    }
/*Funcao que recebe o numero e o verifica se e impar ou par*/
    static string ParImpar(int valor)
    {
        string resposta = "PAR";

        if (valor % 2 == 0)
        {
            return resposta;
        }
        else
        {
            resposta = "IMPAR";
            return resposta;
        }
    }
}
