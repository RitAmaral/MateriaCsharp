using System;
using System.Runtime.Serialization;
using System.Security.Cryptography.X509Certificates;

internal class Program
{
    private static void Main(string[] args)
    {
        /*
        // Declaração de variáveis
      
        int idade;
        double salario, altura;
        char genero;
        string nome;
                    Se colocar aqui CultureInfo CI = CultureInfo.InvariantCulture; e teria de colocar em cima using system.globalization;
                    e colocar no: salario.ToString("F2", CI)
                    aparecerá um . em vez de , na consola
        idade = 20;
        salario = 4000.5565;
        altura = 1.70;
        genero = 'F';
        nome = "Alice";

        /* Outra forma de declarar variáveis
        int idade = 30;*/

        //Podemos escrever CW e depois clicar tab tab para aparecer console.writeline()

        /*
        Console.WriteLine(idade);
        Console.WriteLine(nome);
        Console.WriteLine(altura);
        Console.WriteLine(genero);
        Console.WriteLine(salario);

        Console.WriteLine("A funcionária " +nome+ ", do género " +genero+ ", ganha " +salario.ToString("F2")+ " euros, aos " +idade+ " anos!"); 
        */



        /*
        int x;
        double y;

        x = 5;
        y = 2 * x;

        Console.WriteLine(x);
        Console.WriteLine(y);
        */

        /*
        double b1, b2, h, area;

        b1 = 6.0;
        b2 = 8.0;
        h = 5.0;

        area = (b1 + b2) / 2.0 * h;

        Console.WriteLine(area);
        */



        //Console.ReadLine() = leia do visualG




        /*
        double salario1, salario2;
        string nome1, nome2;
        int idade1, idade2;
        char genero1, genero2;

        Console.WriteLine("Nome da primeira pessoa: ");
        nome1 = Console.ReadLine();
        Console.WriteLine("Salário da primeira pessoa: ");
        salario1 = double.Parse(Console.ReadLine()); //é preciso colocar parse no double, int e char para o programa perceber
        Console.WriteLine("Qual a sua idade? ");
        idade1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Qual o seu género? ");
        genero1 = char.Parse(Console.ReadLine());

        Console.WriteLine("Nome da segunda pessoa: ");
        nome2 = Console.ReadLine();
        Console.WriteLine("Salário da segunda pessoa: ");
        salario2 = double.Parse(Console.ReadLine());
        Console.WriteLine("Qual a sua idade? ");
        idade2 = int.Parse(Console.ReadLine());
        Console.WriteLine("Qual o seu género? ");
        genero2 = char.Parse(Console.ReadLine());

        Console.WriteLine("Nome 1: " + nome1);
        Console.WriteLine("Idade 1: " + idade1);
        Console.WriteLine("Salário 1: " + salario1.ToString("F2"));
        Console.WriteLine("Género 1: " + genero1);
        Console.WriteLine("Nome 2: " + nome2);
        Console.WriteLine("Idade 2: " + idade2);
        Console.WriteLine("Salário 2: " + salario2.ToString("F2"));
        Console.WriteLine("Género 2: " + genero2);
        */


        /*
        // Declaração de variáveis
        int hora;

        Console.WriteLine("Indique a hora do dia: ");
        hora = int.Parse(Console.ReadLine());

        if (hora < 12)
        {
            Console.WriteLine("Bom dia!");
        }
        else if (hora >= 12 && hora < 20) // || = ou && = e
        {
            Console.WriteLine("Boa tarde!");
        }
        else
        {
            Console.WriteLine("Boa noite!");
        }
        */


        /* Exercício: Fazer um programa que leia uma variável inteira, com valores aleatórios inseridos pelo utilizador,
         enquanto for  diferente de zero. Quando o valor inserido for igual a zero, deve mostrar a soma dos valores inseridos. */
        /*
        int soma, x;
        soma = 0;
        x = 1;

        while (x != 0)
        {
            Console.WriteLine("Introduza um número inteiro: ");
            x = int.Parse(Console.ReadLine());
            soma = soma + x;
        }

        Console.WriteLine("Soma: " + soma);
        */



        /* Fazer um programa que leia o valor de números indicado pelo utilizador.
          Ele insere os numeros e atingindo o total indicado por ele, o programa para e faz a soma dos
          valores inseridos. */
        /*
        int i, N, n, soma;
  
        soma = 0;

        Console.WriteLine("Quantos números vai inserir? ");
        n = int.Parse(Console.ReadLine());

        for (i = 1; i <= n; i++)
        {
            Console.WriteLine("Introduza um número inteiro: ");
            N = int.Parse(Console.ReadLine());
            soma = soma + N;
        }

        Console.WriteLine("Soma: " + soma);
        */




        /* Fazer um programa que leia a temperatura em Celsius e escreva o equivalente em Fahrenheit
         enquanto o utilizador responder que pretende continuar a inserir valores de temperatura */
        /*
        double F, C;

        Console.WriteLine("Qual é a temperatura em Celsius? ");
        C = double.Parse(Console.ReadLine());

        do 
        {
            Console.WriteLine("A temperatura em Fahrenheit é: ");
            F = ((9.0 * C)/(5.0 + 32.0));
            Console.WriteLine(F + ".");
            Console.WriteLine("Qual é a temperatura em Celsius? ");
            C = double.Parse(Console.ReadLine());
        }   
        while (C != 0);
        */



        // Exercício Vetor

        int N, i;

        Console.WriteLine("Quantos números vai inserir: ?");
        N = int.Parse(Console.ReadLine());
        int[] vet = new int[N];

        for (i = 0; i < N; i++)
        {
            Console.WriteLine("Escreva um número: ");

            vet[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("Os números inseridos foram: ");
        for (i = 0; i < N; i++)
        {
            Console.WriteLine(vet[i].ToString());
        }
    }
}