/*Algoritmo que recebe fazer a potencia de um numero pelo outro*/

using System;

class program
{
    public static void Main(string[] args)
    {
        int num1, num2;
        int pares;
        pares = int.Parse(Console.ReadLine());
        for (int i = 0; i < pares; i++)
        {
            string parada = Console.ReadLine();
            num1 = int.Parse(parada[0].ToString());
            num2 = int.Parse(parada[2].ToString());
            Console.WriteLine(Potencia(num1, num2));
        }
    }
/*Funcao que recebe dois numeros e retorno a potencia de um pelo outro*/
/*Caso receba 5 e 4, retornara o resultado de 5^4.*/
    static int Potencia(int num1, int num2)
    {
        int resposta = 1;
        for (int i = 1; i <= num2; i++)
        {
            resposta *= num1;
        }
        return resposta;
    }
}
