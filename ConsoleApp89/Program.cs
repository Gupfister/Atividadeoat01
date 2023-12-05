using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



using System;

class Program
{
    static void Main()
    {
        int escolha;

        do
        {

            Console.WriteLine("menu:");
            Console.WriteLine("1. Opção 1");
            Console.WriteLine("2. Opção 2");
            Console.WriteLine("3. Opção 3");
            Console.WriteLine("4. Opção 4");
            Console.WriteLine("5. Opção 5");
            Console.WriteLine("6. Opção 6");
            Console.WriteLine("7. Opção 7");
            Console.WriteLine("8. Opção 8");
            Console.WriteLine("9. Opção 9");
            Console.WriteLine("10. Opção 10");
            Console.WriteLine("11. Opção 11");
            Console.WriteLine("12. Sair");

            Console.Write("escolha uma alternativa de (1-12: ");
            if (int.TryParse(Console.ReadLine(), out escolha))
            {
                switch (escolha)
                {
                    case 1:
                        Console.WriteLine("Você escolheu a opção 1.");
                        break;
                    case 2:
                        Console.WriteLine("Você escolheu a opção 2.");
                        break;
                    case 3:
                        Console.WriteLine("Você escolheu a opção 3.");
                        break;
                    case 4:
                        Console.WriteLine("Você escolheu a opção 4.");
                        break;
                    case 5:
                        Console.WriteLine("Você escolheu a opção 5.");
                        break;
                    case 6:
                        Console.WriteLine("Você escolheu a opção 6.");
                        break;
                    case 7:
                        Console.WriteLine("Você escolheu a opção 7.");
                        break;
                    case 8:
                        Console.WriteLine("Você escolheu a opção 8.");
                        break;
                    case 9:
                        Console.WriteLine("Você escolheu a opção 9.");
                        break;
                    case 10:
                        Console.WriteLine("Você escolheu a opção 10.");
                        break;
                    case 11:
                        Console.WriteLine("Você escolheu a opção 11.");
                        break;
                    case 12:
                        Console.WriteLine("Saindo do programa. Até mais!");
                        break;

                    default:
                        Console.WriteLine("Opção inválida. Tente novamente. ");
                        break;
                }
            }
            else
            {
                Console.WriteLine("entrada inválida. Tente novamente. ");
            }

            Console.WriteLine("\nPressione qualquer tecla para continuar...");
            Console.ReadKey();
            Console.Clear();
        } while (escolha != 12);
    }
}