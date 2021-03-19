using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_9
{
    class Program
    {
        static void Main(string[] args)
        {
            string operacao;
            double numero1, numero2;
            bool verifc = true;
            Calculadora a = new Calculadora();

            Console.WriteLine("                         Bem vindo a Calculadora");
            Console.WriteLine("Aqui você pode fazer calculos de Soma, Subtração, Multiplacação e Divisão");
            Console.WriteLine("||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||\n");
            Console.WriteLine("                        Digite o primeiro Número");
            numero1 = double.Parse(Console.ReadLine());
            Console.WriteLine("                   Digite o sinal da operação x,/,-,+");
            operacao = Console.ReadLine();
            Console.WriteLine("                        Digite o segundo Número");
            numero2 = double.Parse(Console.ReadLine());

            do
            {
                switch (operacao)
                {
                    case "x":
                        Console.WriteLine(a.Multiplicacao(numero1, numero2));
                        verifc = false;
                        break;
                    case "/":
                        Console.WriteLine(a.Divisao(numero1, numero2));
                        verifc = false;
                        break;
                    case "-":
                        Console.WriteLine(a.Subtracao(numero1, numero2));
                        verifc = false;
                        break;
                    case "+":
                        Console.WriteLine(a.Soma(numero1, numero2));
                        verifc = false;
                        break;
                    default:
                        Console.WriteLine("                    ERRO DE OPERAÇÂO TENTE NOVAMENTE");
                        Console.WriteLine("                   Digite o sinal da operação x,/,-,+");
                        operacao = Console.ReadLine();
                        verifc = true;
                        break;
                }

            } while (verifc == true);

            Console.ReadLine();


        }
    }
}
