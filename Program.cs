using System;

public class Desafio
{
    public static void Main()
    {
        Console.WriteLine("Digitar o valor do salario: ");
        float wage = float.Parse(Console.ReadLine());
        Console.WriteLine("Digitar o valor do beneficio: ");
        float valore = float.Parse(Console.ReadLine());

        float impost = 0;
        if (wage >= 0 && wage <= 1100)
        {
            impost = 0.05F * wage;
            Console.WriteLine("Valor do salário é: " + wage);
        } else if (wage >= 1100 && wage <= 2500)
        {
            impost = 0.10F * wage;
            Console.WriteLine("Valor do salário é: " + wage);
        } else
        {
            impost = 0.15F * wage;
            Console.WriteLine("Valor do salário é: " + wage);
        }

        float exit = wage - impost + valore;
        Console.WriteLine(exit.ToString("0.00"));
    }
}