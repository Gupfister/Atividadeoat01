using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class ATIVIDADE01
{

    public static void Executar()
    {
        Console.Write("Digite o nome: ");
        String nome = Console.ReadLine();

        Console.WriteLine("Digite o sexo (m/f): ");
        char sexo = char.ToUpper(Console.ReadKey().KeyChar);

        Console.WriteLine(); // PULAR PARA OUTRA LINHA

        Console.Write("Digite o estado civil (Solteiro/casado/divorciado/viuvo); ");
        string estadoCivil = Console.ReadLine().ToUpper();

        if (sexo == 'f' && estadoCivil == "casado")
        {
            Console.Write("Digite o tempo de casado (anos): ");
            int TempoCasado;

            if (int.TryParse(Console.ReadLine(), out TempoCasado))
            { 


