using System;

namespace lista_1;

class Program
{

    static void Main(string[] args)
    {
        // mude o numero da opçao para testar as demais consultas
        int opcao = 10;

        switch (opcao)
        {
            case 1: exercicio01(); break;
            case 2: exercicio02(); break;
            case 3: exercicio03(); break;
            case 4: exercicio04(); break;
            case 5: exercicio05(); break;
            case 6: exercicio06(); break;
            case 7: exercicio07(); break;
            case 8: exercicio08(); break;
            case 9: exercicio09(); break;
            case 10: exercicio10(); break;

            default: Console.WriteLine("opçao invalida"); break;
        }
    }

    static void exercicio01()
    {
        Console.WriteLine("Digite um numero inteiro");
        int numero = int.Parse(Console.ReadLine()!);
        Console.WriteLine($"O numero digitado foi: {numero} ");
    }

    static void exercicio02()
    {
        Console.WriteLine("digite um numero real");
        double numero = double.Parse(Console.ReadLine()!);
        Console.WriteLine($"seu numero digitado foi: {numero}");
    }

    static void exercicio03()
    {
        Console.WriteLine("Digite um numero com ponto flutuante");
        float numero = float.Parse(Console.ReadLine()!);
        Console.WriteLine($"o numero digitado foi: {numero}");
    }

    static void exercicio04()
    {
        Console.WriteLine("Digite sim ou nao");
        string cond = Console.ReadLine()!;
        bool condicao = (cond == "sim");
        Console.WriteLine($"vc digitou: {cond}");
    }

    static void exercicio05()
    {
        Console.WriteLine("digite um caractere");
        char caractere = char.Parse(Console.ReadLine()!);
        Console.WriteLine($"o caractere digitado foi: {caractere}");
    }
    static void exercicio06() {
        Console.WriteLine("digite um numero decimal");
        double numero = double.Parse(Console.ReadLine()!);
        Console.WriteLine($"O numero digitado foi: {numero}");

    }
    static void exercicio07()
    {
        Console.WriteLine("Digite seu nome e em seguida sua idade");
        String nome = Console.ReadLine()!;
        int idade = int.Parse(Console.ReadLine()!);
        Console.WriteLine($"Seu nome é: {nome} " + $"e sua idade é: {idade}");
    }
    static void exercicio08()
    {
        Console.WriteLine("Digite o preço do produto");
        double preco = double.Parse(Console.ReadLine()!);
        Console.WriteLine("Digite o desconto do produto em porcentagem");
        double desconto = double.Parse(Console.ReadLine()!);
        Console.WriteLine($"O preço do seu produto com desconto aplicado é: " + (preco - (preco * desconto / 100)));

    }
    static void exercicio09()
    {
        Console.WriteLine("Digite uma palavra e sera exibido seu comprimento");
        String palavra = Console.ReadLine()!;
        Console.WriteLine(palavra.Length);


    }
    static void exercicio10()
    {
        Console.WriteLine("digite as informações de seu endereço(o número da\r\ncasa, rua, bairro, cidade e estado.) nesta ordem");
        int numeroCasa = int.Parse(Console.ReadLine()!);
        string rua = Console.ReadLine()!;
        string bairro = Console.ReadLine()!;
        string cidade = Console.ReadLine()!;
        String estado = Console.ReadLine()!;
        Console.WriteLine($"O numero da sua casa é: {numeroCasa}, a sua rua é: {rua}, o seu bairro é: {bairro}, sua cidade é: {cidade} e seu estado é: {estado}  ");
            

    }
        
}