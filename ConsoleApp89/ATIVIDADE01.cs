using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using System;

public class ATIVIDADE01
{

    public static void Executar()
    {
        //INSERIR VALORES DE A, B E C
        Console.Write("Digite o valor de a: ");
        int a = int.Parse(Console.ReadLine());

        Console.Write("Digite o valor de b: ");
        int b = int.Parse(Console.ReadLine());

        Console.Write("Digite o valor de c: ");
        int c = int.Parse(Console.ReadLine());

        if (a + b < c)
        {
            Console.WriteLine("A soma de a + b é menor que c. ");
        }
        else
        {
            Console.WriteLine("A soma de a + b não é menor que c. ");
        }
    }
}

