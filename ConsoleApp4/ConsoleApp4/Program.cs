using ConsoleApp4;
using Microsoft.Win32;
using System.Net;
using System.Runtime.CompilerServices;
using System.Runtime.ConstrainedExecution;
using System.Runtime.Intrinsics.Arm;
using System.Transactions;

internal class Program
{
    private static void Main(string[] args)
    {
        /*
        Point p; //não precisamos de colocar new como se fosse uma classe, pq isto é um struct
        
        p.x = 10;
        p.y = 20;

        Console.WriteLine(p); // output = (10, 20)

        p = new Point();
        Console.WriteLine(p); // output = (0, 0)
        */

        /*
        //double x = null; ->impossível, por isso temos de fazer isto:
        double? x = null;
        double? y = 10.0;

        Console.WriteLine(x.GetValueOrDefault()); //como x tem valor nulo, o default é 0

        Console.WriteLine(y.GetValueOrDefault()); //como y tem valor 10, ele foi buscar o 10
        
        //Console.WriteLine(x.HasValue); //É basicamente uma pergunta. x tem valor? Se não, output é false
        //Console.WriteLine(y.HasValue); // Se y tem valor, output é true
        
        if (x.HasValue)
        {
            Console.WriteLine(x.Value);
        }
        else { Console.WriteLine("x é nulo"); }

        if (y.HasValue)
        {
            Console.WriteLine(y.Value);
        }
        else { Console.WriteLine("y é nulo"); }
        */

        /*
        //Exercício 1 - vetores
        Console.WriteLine("Quantas pessoas vão introduzir a sua altura? ");
        int n = int.Parse(Console.ReadLine());

        //Criação do vetor e instanciação
        double[] vetAlturas = new double[n];

        int i = 0;
        for (i = 0; i < n; i++)
        {
            Console.WriteLine("Escreva a altura da pessoa: ");
            vetAlturas[i] = double.Parse(Console.ReadLine());
        }

        double soma = 0.0;
        for (i = 0; i < n;i++)
        {
            soma += vetAlturas[i];
        }
        
        double media = soma / n;
        Console.WriteLine("A média das alturas é: " + media.ToString("F2"));
        */
        /*
        //Exercício 2 - vetores
        Console.WriteLine("Quantos produtos vai introduzir? ");
        int n = int.Parse(Console.ReadLine());

        Produto[] vet = new Produto[n]; //Produto com memória vazia com n espaços, depois vamos inserir valores:

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("Diga o nome do produto: ");
            string nome = Console.ReadLine();
            Console.WriteLine("Diga o preço do produto: ");
            double preco = double.Parse(Console.ReadLine());
            vet[i] = new Produto { Nome=nome, Preco=preco };
        }

        double soma = 0.0;
        for (int i = 0;i < n; i++)
        {
            soma += vet[i].Preco;
        }

        double media = soma / n;
        Console.WriteLine("A média do preço é : " + media.ToString());
        */

        //Exercício 3
        /*
        A dona de uma residência possui dez quartos para alugar para estudantes, sendo os
        quartos identificados pelos números 0 a 9.
        Quando um estudante deseja alugar um quarto, deve - se registar o nome e email
        deste estudante.
        Fazer um programa que inicie com todos os dez quartos vazios, e depois leia uma
        quantidade N representando o número de estudantes que vão alugar quartos(N
        pode ser de 1 a 10).Em seguida, registe o aluguer dos N estudantes. Para cada
        registro de aluguer, informar o nome e email do estudante, bem como qual dos
        quartos ele escolheu(de 0 a 9).Suponha que seja escolhido um quarto vago. No
        final, o programa deve imprimir um relatório de todas ocupações da residência, por
        ordem de quarto, conforme exemplo.
        */
        
        Console.WriteLine("Quantos estudantes vão alugar quarto? ");
        int n = int.Parse(Console.ReadLine());
        Quarto[] vet = new Quarto[n];

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("Qual o seu nome? ");
            string nome = Console.ReadLine();
            Console.WriteLine("Qual o seu email? ");
            string email = Console.ReadLine();
            Console.WriteLine("Qual o quarto que quer escolher? ");
            int quartoEscolhido = int.Parse(Console.ReadLine());
            Console.WriteLine();
            vet[i] = new Quarto(nome, email, quartoEscolhido);
        }

        Console.WriteLine("Relatório dos quartos ocupados: ");
        
        foreach (var obj in vet) //Leitura: "para cada objeto 'obj' contido em vet, faça:"
        {
            Console.WriteLine(obj);
        }
        
        //outra solução
        /*
        int[] array = new int[] {0, 1, 2, 3, 4, 5, 6, 7, 8, 9};
        foreach (int i in array)
        {
            if (vet[i] !=null)
            {
                Console.WriteLine(i + ": " + vet[i]);
            }
        }
        */

        //Modificador de parâmetros: params

        /*
        int s1 = Calculadora.Soma(5, 10);
        Console.WriteLine(s1); //output = 15

        int s2 = Calculadora.Soma(10, 15, 2);
        Console.WriteLine(s2); // output = 27

        int s3 = Calculadora.Soma(10, 20, 10, 2);
        Console.WriteLine(s3); // output = 42
        */

        //vetores
        /*
        int resultado = Calculadora.Sum(new int[] { 1, 2, 10, 25 });
        Console.WriteLine(resultado); //output = 38

        int resultado1 = Calculadora.Sum(new int[] { 1, 4, 10, 25, 15, 30 });
        Console.WriteLine(resultado1); //output = 85
        */
        /*
        //Params: uma calculadora para calcular a soma de uma quantidade variável de valores
        //Params: como colocamos params na classe, não precisamos de colocar aqui new int[]
        int resultado = Calculadora.Sum(1, 2, 10, 25);
        Console.WriteLine(resultado); //output = 38
        */
        /*
        //Boxing - É o processo de conversão de um objeto tipo valor para um objeto tipo referência compatível
        int x = 20;
        Object obj = x;
        Console.WriteLine(obj); //output = 20
        //Unboxing - É o processo de conversão de um objeto tipo referência para um objeto tipo valor compatível
        int y = (int)obj;
        Console.WriteLine(y); //output = 20
        */
        
    }
}