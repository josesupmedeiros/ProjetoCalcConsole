using System;

namespace CalculadoraTeste
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double resultado, n1, n2;
            string operacao, escolha;

            Console.WriteLine("Olá, está é uma calculadora feita para fins de estudos.\n");

            do
            {
                Console.WriteLine("Escolha o que deseja fazer:");
                Console.WriteLine("1 - Calculadora");
                Console.WriteLine("2 - Sair");
                escolha = Console.ReadLine();

                if (escolha == "1")
                {
                    Console.WriteLine("\nDigite o seu primeiro número?");
                    n1 = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("\nDigite o segundo número?");
                    n2 = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("\nQual a operação que deseja fazer?");
                    operacao = Console.ReadLine();

                    switch (operacao)
                    {
                        case "+":
                            resultado = n1 + n2;
                            Console.WriteLine("\nO resultado de {0} {1} {2} = {3}.\n", n1, operacao, n2, resultado);
                            break;

                        case "-":
                            resultado = n1 - n2;
                            Console.WriteLine("\nO resultado de {0} {1} {2} = {3}.\n", n1, operacao, n2, resultado);
                            break;

                        case "*":
                            resultado = n1 * n2;
                            Console.WriteLine("\nO resultado de {0} {1} {2} = {3}.\n", n1, operacao, n2, resultado);
                            break;

                        case "/":
                            resultado = n1 / n2;
                            Console.WriteLine("\nO resultado de {0} {1} {2} = {3}.\n", n1, operacao, n2, resultado);
                            break;

                        default:
                            Console.WriteLine("\nPor favor, inserir uma Operação válida.\n");
                            break;
                    }
                }

                if(escolha != "1" && escolha != "2")
                {
                    Console.WriteLine("\nPor favor, escolha uma das opções acima.\n");
                }
                
            } while (escolha != "2");
            

            
        }
    }
}