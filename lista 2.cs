using System;

namespace lista1;

class Program
{
    static void Main(String[] args)
    {
        int opcao = 10;
        switch (opcao)
        {
            case 1: exercicio1(); break;
            case 2: exercicio2(); break;
            case 3: exercicio3(); break;
            case 4: exercicio4(); break;
            case 5: exercicio5(); break;
            case 6: exercicio6(); break;
            case 7: exercicio7(); break;
            case 8: exercicio8(); break;
            case 9: exercicio9(); break;
            case 10: exercicio10(); break;

        }

        static void exercicio1()
        {
            Console.WriteLine("digite o primeiro numero");
            int n1 = int.Parse(Console.ReadLine()!);
            Console.WriteLine("digite o segundo numero");
            int n2 = int.Parse(Console.ReadLine()!);
            Console.WriteLine("A soma de seus numeros é: " + (n1 + n2));

        }
        static void exercicio2()
        {
            Console.WriteLine("digite um numero e sera exibido seu dobro");
            int numero = int.Parse(Console.ReadLine()!);
            Console.WriteLine("O dobro de seu numero é: " + (numero * 2));


        }
        static void exercicio3()
        {
            Console.WriteLine("digite um numero e sera exibido sua metade");
            int numero = int.Parse(Console.ReadLine()!);
            Console.WriteLine("A metade de seu numero é: " + (numero / 2));

        }
        static void exercicio4()
        {
            Console.WriteLine("Digite um numero e sera exibido seu quadrado");
            int numero = int.Parse(Console.ReadLine()!);
            Console.WriteLine("O quadrado do seu numero é: " + (numero * 2 * 2));
        }
        static void exercicio5()
        {
            Console.WriteLine("digite o primeiro numero e sera exibido o resultado da divisão do primeiro pelo segundo");
            int n1 = int.Parse(Console.ReadLine()!);
            Console.WriteLine("Digite o segundo numero");
            int n2 = int.Parse(Console.ReadLine()!);
            Console.WriteLine("O primeiro numero divido pelo segundo é: " + (n2 / n1));
        }
        static void exercicio6()
        {
            Console.WriteLine("Digite um numero e sera mostrado sua raiz");
            double numero = double.Parse(Console.ReadLine()!);
            double raiz = Math.Sqrt(numero);
            Console.WriteLine($"A raiz do seu numero é: {raiz} ");

        }
        static void exercicio7()
        {
            Console.WriteLine("digite o primeiro numero e sera exibido o resultado da subtração do segundo pelo primeiro");
            int n1 = int.Parse(Console.ReadLine()!);
            Console.WriteLine("Digite o segundo numero");
            int n2 = int.Parse(Console.ReadLine()!);
            Console.WriteLine("O segundo numero menos o primeiro é: " + (n2 - n1));

        }
        static void exercicio8()
        {
            Console.WriteLine("digite um numero e sera mostrado seu valor absoluto");
            double num = double.Parse(Console.ReadLine()!);
            if (num < 0)
            {
                Console.WriteLine($"Seu numero absoluto é: {-1 * num}");

            }
            else
            {
                Console.WriteLine($"Seu numero absoluto é {num}");

            }

        }
        static void exercicio9()
        {
            Console.WriteLine("Digite dois numero e será mostrado a multiplicação entre eles");
            double num1 = double.Parse(Console.ReadLine()!);
            double num2 = double.Parse(Console.ReadLine()!);
            Console.WriteLine($"A multiplicação entre seus numeros é: {num1 * num2} ");
        }
        static void exercicio10()
        {
            Console.WriteLine("digit um numero e sera mostrado o resto de sua divisão por 2");
            double num = double.Parse(Console.ReadLine()!);
            if (num % 2 == 0)
            {
                Console.WriteLine("Divisão exata não há resto para ser exibido");
            }
            else
            {
                Console.WriteLine($"O resto de sua divisão é: {num % 2}");
            }



        }
    }




}
