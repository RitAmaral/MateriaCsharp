using System;
using System.Drawing;
using System.Net.Http.Headers;
using System.Runtime.InteropServices;
using Triangulos;

internal class Program
{
    private static void Main(string[] args)
    {
        //Aula 26/04/2023
        //Problema dos triangulos
        /*
        double xA, xB, xC, yA, yB, yC; // em double os números são inscritos com virgulas.
        double a1, a2, p1, p2;

        Console.WriteLine("Escreva as medidas do triangulo x: ");
        xA = double.Parse(Console.ReadLine());
        xB = double.Parse(Console.ReadLine());
        xC = double.Parse(Console.ReadLine());

        Console.WriteLine("Escreva as medidas do triangulo y: ");
        yA = double.Parse(Console.ReadLine());
        yB = double.Parse(Console.ReadLine());
        yC = double.Parse(Console.ReadLine());

        p1 = (xA + xB + xC) / 2;
        a1 = Math.Sqrt(p1 * (p1 - xA)*(p1 - xB)*(p1 - xC));
        Console.WriteLine("A área do triangulo x é: " + a1.ToString("F2")); //To.String("F2") = 2 casas decimais

        p2 = (yA + yB + yC) / 2;
        a2 = Math.Sqrt(p2 * (p2 - yA)*(p2 - yB)*(p2 - yC));
        Console.WriteLine("A área do triangulo y é: " + a2.ToString("F2"));

        // Qual dos triângulos tem a área maior?
        if (a1 > a2)
        {
            Console.WriteLine("O Triângulo x tem maior área que o triângulo y.");
        }
        else
        {
            Console.WriteLine("O Triângulo y tem maior área que o triângulo x.");
        }
        */

        //Outra forma de resolver o ex anterior, agora com classe Triangulo criada:
        /*
        Triangulo x, y; //declaramos VAR do tip classe
        x = new Triangulo(); //instanciamos os objetos triangulo x e y
        y = new Triangulo();

        Console.WriteLine("Escreva as medidas do triangulo x: ");
        x.A = double.Parse(Console.ReadLine());
        x.B = double.Parse(Console.ReadLine());
        x.C = double.Parse(Console.ReadLine());

        Console.WriteLine("Escreva as medidas do triangulo y: ");
        y.A = double.Parse(Console.ReadLine());
        y.B = double.Parse(Console.ReadLine());
        y.C = double.Parse(Console.ReadLine());


        double p = (x.A + x.B + x.C) / 2;
        double a1 = Math.Sqrt(p * (p - x.A) * (p - x.B) * (p - x.C));
        Console.WriteLine("A área do triangulo x é: " + a1.ToString("F2")); //To.String("F2") = 2 casas decimais

        p = (y.A + y.B + y.C) / 2;
        double a2 = Math.Sqrt(p * (p - y.A) * (p - y.B) * (p - y.C));
        Console.WriteLine("A área do triangulo y é: " + a2.ToString("F2"));

        // Qual dos triângulos tem a área maior?
        if (a1 > a2)
        {
            Console.WriteLine("O Triângulo x tem maior área que o triângulo y.");
        }
        else
        {
            Console.WriteLine("O Triângulo y tem maior área que o triângulo x.");
        }
        */

        // Exercício 1:
        /* Fazer um programa para ler os dados de duas pessoas, depois mostrar o nome da pessoa mais velha.*/
        /*
        Pessoa Nome, Idade;
        Pessoa P1 = new Pessoa(); //instanciamos os objetos pessoa P1 e P2
        Pessoa P2 = new Pessoa();

        Console.WriteLine("Escreva o nome da primeira Pessoa: ");
        P1.Nome = (Console.ReadLine());
        Console.WriteLine("Escreva a idade da primeira Pessoa: ");
        P1.Idade = int.Parse(Console.ReadLine());

        Console.WriteLine("Escreva o nome da segunda Pessoa: ");
        P2.Nome = (Console.ReadLine());
        Console.WriteLine("Escreva a idade da segunda Pessoa: ");
        P2.Idade = int.Parse(Console.ReadLine());

        Console.WriteLine("Dados da primeira pessoa: " + P1.Nome + ", " + P1.Idade + ".");
        Console.WriteLine("Dados da segunda pessoa: " + P2.Nome + ", " + P2.Idade + ".");

        //Qual a pessoa mais velha?
        if (P1.Idade > P2.Idade)
        {
            Console.WriteLine("A primeira pessoa é mais velha que a segunda.");
        }
        else
        {
            Console.WriteLine("A segunda pessoa é mais velha que a primeira.");
        }
        */
        //Exercício 2
        /* Fazer um programa para ler nome e salário de dois funcionários. 
           Depois, mostrar o salário médio dos funcionários. */
        /*
        Funcionario Nome, Salario;
        Funcionario F1 = new Funcionario();
        Funcionario F2 = new Funcionario();

        Console.WriteLine("Escreva o nome do primeiro funcionário: ");
        F1.Nome = Console.ReadLine();
        Console.WriteLine("Escreva o salário do primeiro funcionário: ");
        F1.Salario = double.Parse(Console.ReadLine());

        Console.WriteLine("Escreva o nome do segundo funcionário: ");
        F2.Nome = Console.ReadLine();
        Console.WriteLine("Escreva o salário do segundo funcionário: ");
        F2.Salario = double.Parse(Console.ReadLine());

        double media = (F1.Salario + F2.Salario) / 2;
        Console.WriteLine("O salário médio dos dois funcionários é: " + media + ".");
        */

        //Voltar ao exercício dos triangulos, agora com Métodos = Funções.
        /*
        Triangulo x, y; 
        x = new Triangulo(); 
        y = new Triangulo();

        Console.WriteLine("Escreva as medidas do triangulo x: ");
        x.A = double.Parse(Console.ReadLine());
        x.B = double.Parse(Console.ReadLine());
        x.C = double.Parse(Console.ReadLine());

        Console.WriteLine("Escreva as medidas do triangulo y: ");
        y.A = double.Parse(Console.ReadLine());
        y.B = double.Parse(Console.ReadLine());
        y.C = double.Parse(Console.ReadLine());

        double a1 = x.Area();
        double a2 = y.Area();

        Console.WriteLine("A área do triangulo x é: " + a1.ToString("F2")); 
        Console.WriteLine("A área do triangulo y é: " + a2.ToString("F2"));

        // Qual dos triângulos tem a área maior?
        if (a1 > a2)
        {
            Console.WriteLine("O Triângulo x tem maior área que o triângulo y.");
        }
        else
        {
            Console.WriteLine("O Triângulo y tem maior área que o triângulo x.");
        }
        */

        // Problema: Fazer um programa para ler os dados de um produto em stock (nome, preço e quantidade em stock).
        /*
        Produto p = new Produto();

        Console.WriteLine("Escreva o nome do produto: ");
        p.Nome = Console.ReadLine();
        Console.WriteLine("Escreva o preço do produto: ");
        p.Preco = double.Parse(Console.ReadLine());
        Console.WriteLine("Escreva a quantidade do produto: ");
        p.Quantidade = int.Parse(Console.ReadLine());

        //Mostrar os dados do produto (nome, preço, quantidade em stock, valor total em stock)
        Console.WriteLine("Dados do produto: " + p);
        Console.WriteLine();
        //Adicionar quantidade em stock:
        Console.WriteLine("Diga o número de produtos a serem adicionados: ");
        int qte = int.Parse(Console.ReadLine());
        p.AdicionarProdutos(qte);
        Console.WriteLine("Dados do produto: " + p);
        //Remover quantidade em stock:
        Console.WriteLine("Diga o número de produtos a serem removidos: ");
        qte = int.Parse(Console.ReadLine());
        p.RemoverProdutos(qte);
        Console.WriteLine("Dados do produto: " + p);
        */

        /* Exercício 1 - 
        Fazer um programa para ler os valores da largura e altura de um retângulo. Em seguida, mostrar na tela o valor
        da área, perímetro e diagonal. Usar uma classe como mostrado no projeto ao lado. */
        /* 
        Retangulo r = new Retangulo();

        Console.WriteLine("Escreva a largura do retângulo: ");
        r.Largura = double.Parse(Console.ReadLine());
        Console.WriteLine("Escreva a altura do retângulo: ");
        r.Altura = double.Parse(Console.ReadLine());
        Console.WriteLine("Os dados do retângulo são: " + r);
        */

        /*Exercício 2 - 
        Fazer um programa para ler os dados de um funcionário (nome, salário bruto e imposto). Em seguida, mostrar
        os dados do funcionário (nome e salário líquido). Em seguida, aumentar o salário do funcionário com base em
        numa percentagem dada (somente o salário bruto é afetado pela percentagem) e mostrar novamente os dados
        do funcionário. Use a classe projetada abaixo. */
        /*
        Func f = new Func();

        Console.WriteLine("Escreva o nome do funcionário: ");
        f.Nome = Console.ReadLine();
        Console.WriteLine("Escreva o salário bruto do funcionário; ");
        f.SalarioBruto = double.Parse(Console.ReadLine());
        Console.WriteLine("Escreva o imposto: ");
        f.Imposto = double.Parse(Console.ReadLine());
        Console.WriteLine("Os dados do funcionário são: " + f);

        Console.WriteLine("Diga a percentagem que quer aumentar ao funcionário: ");
        double perc = double.Parse(Console.ReadLine());
        f.AumentarSalario(perc);

        Console.WriteLine("Os dados atualizados do funcionário são: " + f);

        */
        /*Exercício 3 -
        Fazer um programa para ler o nome de um aluno e as três notas que ele obteve nos três trimestres do ano
        (primeiro trimestre vale 30 e o segundo e terceiro valem 35 cada). Ao final, mostrar qual a nota final do aluno
        no ano. Dizer também se o aluno está APROVADO ou REPROVADO e, em caso negativo, quantos pontos faltam
        para o aluno obter o mínimo para ser aprovado (que é 60 pontos). Deve criar uma classe Aluno para resolver
        este problema. */
        /*
        Aluno a = new Aluno();

        Console.WriteLine("Escreva o nome do aluno: ");
        a.Nome = Console.ReadLine();
        Console.WriteLine("Escreva a primeira nota do aluno: ");
        a.Nota1 = double.Parse(Console.ReadLine());
        Console.WriteLine("Escreva a segunda nota do aluno: ");
        a.Nota2 = double.Parse(Console.ReadLine());
        Console.WriteLine("Escreva a terceira nota do aluno: ");
        a.Nota3 = double.Parse(Console.ReadLine());

        Console.WriteLine("Os dados do aluno são: " + a);

        if (a.Aprovado())
        {
            Console.WriteLine("APROVADO");
        }
        else
        {
            Console.WriteLine("REPROVADO");
            Console.WriteLine("Faltam os seguintes pontos: " + a.NotaRestante());
        }
        */

        /* Exercício - Fazer um programa para ler a cotação do dólar e depois um valor em dólares a ser comprado por uma pessoa
        em euros . Informar quantos euros a pessoa vai pagar pelos dólares, considerando ainda que a pessoa terá que
        pagar 6% de imposto sobre o valor em dólar. Criar uma classe ConversorDeMoeda para ser responsável pelos
        cálculos. */
        /*
        Console.WriteLine("Qual é a cotação do dolar? ");
        double cotacao = double.Parse(Console.ReadLine());
        Console.WriteLine("Quantos dólares vai comprar? ");
        double quantia = double.Parse(Console.ReadLine());
        double resultado = ConversorDeMoeda.DolarEuro(quantia, cotacao);
        Console.WriteLine("Valor a pagar em euros, sendo que tem de pagar 6% de imposto sobre o valor do dólar = " + resultado);
        */

        
    }
}