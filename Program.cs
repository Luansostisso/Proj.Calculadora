using System;


namespace Calculadora {
    internal class Program {
        static void Main(string[] args) {


            Console.WriteLine("Qual operação deseja fazer?");
            Console.WriteLine("1 - Adição");
            Console.WriteLine("2 - Subtração");
            Console.WriteLine("3 - Multiplicação");
            Console.WriteLine("4 - Divisão \n");

            if (!int.TryParse(Console.ReadLine(), out int operacao) || operacao < 1 || operacao > 4) {
                Console.WriteLine("Operação inválida. Digite um número de 1 a 4.");
                return;
            }

            Console.WriteLine("Digite o primeiro número: ");
            if (!int.TryParse(Console.ReadLine(), out int num1)) {
                Console.WriteLine("Número inválido. Por favor, digite um número inteiro.");
                return;
            }

            Console.WriteLine("Digite o segundo número: ");
            if (!int.TryParse(Console.ReadLine(), out int num2)) {
                Console.WriteLine("Número inválido. Por favor, digite um número inteiro.");
                return;
            }

            int resultado = 0;

            switch (operacao) {
                case 1: {
                        resultado = Adicao(num1, num2);
                        break;
                    }
                case 2: {
                        resultado = Subtracao(num1, num2);
                        break;
                    }

                case 3: {
                        resultado = Multiplicacao(num1, num2);
                        break;
                    }

                case 4: {
                        resultado = Divisao(num1, num2);
                        break;
                    }

                default:
                    Console.WriteLine("Numero invalido, digite outro numero");
                    return;

            }

            Console.WriteLine("O resultado da operação com os números {0} e {1} é: {2}", num1, num2, resultado);

            Console.ReadLine();

            }
            public static int Adicao(int num1, int num2) {
                int resultado = num1 + num2;
                return resultado;
            }
            public static int Subtracao(int num1, int num2) {
                int resultado = num1 - num2;
                return resultado;
            }
            public static int Multiplicacao(int num1, int num2) {
                int resultado = num1 * num2;
                return resultado;
            }
            public static int Divisao(int num1, int num2) {
            if (num2 == 0) 
            {
                Console.WriteLine("Não é possível dividir por zero.");
                return 0; // Ou outra ação apropriada para lidar com a situação
            }
            else {
                int resultado = num1 / num2;
                return resultado;
            }
        }
    }
}