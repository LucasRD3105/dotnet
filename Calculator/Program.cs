using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        static void Menu()
        {
            Console.Clear();

            Console.WriteLine("O que deseja calcular? ");
            Console.WriteLine("1 - Soma");
            Console.WriteLine("2 - Subtração");
            Console.WriteLine("3 - Divisão");
            Console.WriteLine("4 - Multiplicação");
            Console.WriteLine("5 - Potência");
            Console.WriteLine("6 - Par ou ímpar?");
            Console.WriteLine("7 - Raiz");
            Console.WriteLine("8 - Sair");


            Console.WriteLine("------------------------");
            Console.WriteLine("Selecione uma das opções acima: ");
            short res = short.Parse(Console.ReadLine() ?? "0");

            switch (res)
            {
                case 1: Soma(); break;
                case 2: Subtracao(); break;
                case 3: Divisao(); break;
                case 4: Multiplicacao(); break;
                case 5: Potencia(); break;
                case 6: ParImpar(); break;
                case 7: Raiz(); break;
                case 8: Fim(); System.Environment.Exit(0); break;
                default: Menu(); break;
            }
        }

        static void Fim()
        {
            Console.Clear();

            Console.WriteLine("Obrigado, volte sempre!");
        }

        static void Soma()
        {
            Console.Clear();

            Console.WriteLine("Primeiro valor: ");
            float v1 = float.Parse(Console.ReadLine() ?? "0");

            Console.WriteLine("Segundo valor: ");
            float v2 = float.Parse(Console.ReadLine() ?? "0");

            float resultado = v1 + v2;
            Console.WriteLine("");
            Console.WriteLine($"O resultado da soma é {resultado}");
            Console.ReadKey();
            Menu();
        }

        static void Subtracao()
        {
            Console.Clear();

            Console.WriteLine("Primeiro valor: ");
            float v1 = float.Parse(Console.ReadLine() ?? "0");

            Console.WriteLine("Segundo valor: ");
            float v2 = float.Parse(Console.ReadLine() ?? "0");

            float resultado = v1 - v2;
            Console.WriteLine("");
            Console.WriteLine($"O resultado da subtração é {resultado}");
            Console.ReadKey();
            Menu();
        }

        static void Divisao()
        {
            Console.Clear();

            Console.WriteLine("Primeiro valor: ");
            float v1 = float.Parse(Console.ReadLine() ?? "0");

            Console.WriteLine("Segundo valor: ");
            float v2 = float.Parse(Console.ReadLine() ?? "0");

            float resultado = v1 / v2;
            Console.WriteLine("");
            Console.WriteLine($"O resultado da Divisão é {resultado}");
            Console.ReadKey();
            Menu();
        }

        static void Multiplicacao()
        {
            Console.Clear();

            Console.WriteLine("Primeiro valor: ");
            float v1 = float.Parse(Console.ReadLine() ?? "0");

            Console.WriteLine("Segundo valor: ");
            float v2 = float.Parse(Console.ReadLine() ?? "0");

            float resultado = v1 * v2;
            Console.WriteLine("");

            Console.WriteLine($"O resultado da multiplicação é {resultado}");
            Console.ReadKey();
            Menu();
        }

        static void Potencia()
        {
            Console.Clear();
            Console.WriteLine("Valor para realizar a potência: ");
            int v1 = int.Parse(Console.ReadLine() ?? "0");

            int resultado = v1 * v1;
            Console.WriteLine($"O valor da potência é {resultado}");
            Console.ReadKey();
            Menu();
        }

        static void ParImpar()
        {
            Console.Clear();

            Console.WriteLine("Qual o valor que deseja verificar se é par ou ímpar: ");
            float v1 = float.Parse(Console.ReadLine() ?? "0");

            float resultado = v1 % 2;

            if (resultado == 0)
            {
                Console.WriteLine($"O resto é {resultado}, portanto o número {v1} é PAR");
            }
            else
            {
                Console.WriteLine($"O resto é {resultado}, portanto o número {v1} é ÍMPAR");
            }
            Console.ReadKey();
            Menu();
        }

        static void Raiz()
        {
            Console.Clear();

            Console.WriteLine("Qual o valor que deseja calcular a raiz quadrada: ");
            float v1 = float.Parse(Console.ReadLine() ?? "0");

            float resultado = (float)Math.Sqrt(v1);
            Console.WriteLine($"O valor da raiz quadrada de {v1} é {resultado}");

            Console.ReadKey();
            Menu();
        }
    }
}
