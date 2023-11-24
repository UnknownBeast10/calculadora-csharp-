using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Inicio:
            Console.Clear();

            Console.Write("Digite o primeiro número: ");
            double num1 = double.Parse(Console.ReadLine());

            Console.Write("Digite o segundo número: ");
            double num2 = double.Parse(Console.ReadLine());

            Console.Write("Escolha a operação ( [+] Adição | [-] Subtração | [x] Multiplicação | [:] Divisão ): ");
            char op = char.Parse(Console.ReadLine());

            double resultado = 0;

            switch(op)
            {
                default:
                    Console.WriteLine("Erro, Opção inválida!");
                    break;
                case '+':
                    resultado = num1 + num2;
                    Console.WriteLine("Resultado:.\n" + resultado);
                    break;
                case '-':
                    resultado = num1 - num2;
                    Console.WriteLine("Resultado:.\n" + resultado);
                    break;
                case 'x':
                    resultado = num1 * num2;
                    Console.WriteLine("Resultado:.\n" + resultado);
                    break;
                case ':':
                    if(num2 == 0)
                    {
                        Console.WriteLine("Não é Possivel dividir por zero!");
                    } else
                    {
                        resultado = num1 / num2;
                        Console.WriteLine("Resultado:.\n" + resultado);
                    }
                    break;
            }

            Console.Write("Continuar Calculando (s/n)?");
            string opc = Console.ReadLine();
            switch(opc)
            {
                default:
                    Console.WriteLine("Essa opção não é válida!");
                    break;
                case "s":
                    goto Inicio;
                case "n":
                    Console.WriteLine("Feche o Console para Encerrar a Sessão!");
                    break;
            }
            Console.ReadKey();
        }
    }
}
