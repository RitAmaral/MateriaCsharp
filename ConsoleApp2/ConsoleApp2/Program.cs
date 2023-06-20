using ConsoleApp2;
using System.Security.Cryptography.X509Certificates;

internal class Program
{
    private static void Main(string[] args)
    {
        //Exemplo 1
        /*
        Caixa c = new Caixa(15); // se vazio, output = 1000 pq o lado é 10, se 15 output = 3375 pq lado = 15.
        double volumeCaixa;
        volumeCaixa = c.CalculaVolume();
        Console.WriteLine("O volume da caixa é: " + volumeCaixa);
        */

        //Exemplo 2
        /*
        Pessoa p1 = new Pessoa();
        Pessoa p2 = new Pessoa("Maria", 5, 2000);
        Pessoa p3 = new Pessoa(10);

        Console.WriteLine("As pessoas são: " + p1 + "\n" + p2 + "\n" + p3);
        */

        /* Problema: Fazer um programa para ler os dados de um produto em stock (nome, preço e quantidade em stock).
        Melhoria:Vamos criar um construtor opcional, o qual recebe apenas nome e preço do produto.
        A quantidade em stock deste novo produto, por padrão, deverá então ser iniciada com o valor zero. */
        /*
        Produto p = new Produto("TV", 900, 0);
        //Produto p3 = new Produto("Computador", 1200.99, 1);

        //Mostrar os dados do produto (nome, preço, quantidade em stock, valor total em stock)
        Console.WriteLine("Dados do produto: " + p);
        Console.WriteLine();
        
        //Adicionar quantidade em stock:
        Console.WriteLine("Diga o número de produtos a serem adicionados: ");
        int qte = int.Parse(Console.ReadLine());
        p.AdicionarProdutos(qte);
        Console.WriteLine("Dados do produto: " + p);
        Console.WriteLine();
        //Remover quantidade em stock:
        Console.WriteLine("Diga o número de produtos a serem removidos: ");
        qte = int.Parse(Console.ReadLine());
        p.RemoverProdutos(qte);
        Console.WriteLine("Dados do produto: " + p);
        */
        /*
        Produto p2 = new Produto("PS5", 565,50);

        Console.WriteLine("Escreva a quantidade do produto: ");
        p2.Quantidade = int.Parse(Console.ReadLine());
        Console.WriteLine("Dados do produto: " + p2);
        Console.WriteLine();

        //Adicionar quantidade em stock:
        Console.WriteLine("Diga o número de produtos a serem adicionados: ");
        int qte2 = int.Parse(Console.ReadLine());
        p2.AdicionarProdutos(qte2);
        Console.WriteLine("Dados do produto: " + p2);
        Console.WriteLine();
        //Remover quantidade em stock:
        Console.WriteLine("Diga o número de produtos a serem removidos: ");
        qte2 = int.Parse(Console.ReadLine());
        p2.RemoverProdutos(qte2);
        Console.WriteLine("Dados do produto: " + p2);
        */

        //Ex do Produto atualizado com encapsulamento
        /*
        Produto p = new Produto("TV", 500.00, 10);
        
        //Console.WriteLine(p2._nome) -> isto agora não funciona porque está private, logo não podemos ir buscá-lo.
        //Get = obter
        Console.WriteLine(p.GetNome()); //Output: TV
        Console.WriteLine(p.GetPreco());
        //Set = modificar
        p.SetNome("TV 4k");
        Console.WriteLine(p.GetNome());

        p.SetNome(""); //Output: Tem que inserir um nome com mais do que um caracter.
        Console.WriteLine(p.GetNome()); //Aqui vai trazer o nome que era válido anteriormente: TV 4K
        */
        /*
        Produto p = new Produto("TV", 500.00, 10);
        p.Nome = "TV4K";
        Console.WriteLine(p.Nome);
        Console.WriteLine(p.Preco);
        */

        Produto p = new Produto("TV", 500.00, 10);
        Console.WriteLine(p);
        Console.WriteLine("Dados alterados: ");
        p.Nome = "TV5K";
        Console.WriteLine(p.Nome);
        p.Preco = 1000;
        Console.WriteLine(p.Preco);
        p.Quantidade = 20;
        Console.WriteLine(p.Quantidade);

        //Exercício do Banco
        /*
        ContaBancaria c = new ContaBancaria();
        Console.WriteLine("Entre o número de conta: ");
        c.NumConta = int.Parse(Console.ReadLine());
        Console.WriteLine("Entre o titular da conta: ");
        c.Nome = Console.ReadLine();

        Console.WriteLine("Deseja fazer um depósito inicial? S/N");
        char DepInicial = char.Parse(Console.ReadLine());
        if (DepInicial == 'S')
        {
            Console.WriteLine("Insira o valor do depósito inicial: ");
            c.ValorDepInicial = double.Parse(Console.ReadLine());
        }

        Console.WriteLine();
        Console.WriteLine("Dados da conta: " + c);
        Console.WriteLine();
        Console.WriteLine("Entre um valor para depósito: ");
        c.Deposito = double.Parse(Console.ReadLine());
        Console.WriteLine("Dados da conta atualizados: " + c);
        Console.WriteLine();

        Console.WriteLine("Entre um valor para levantamento: ");
        c.Levantamento = double.Parse(Console.ReadLine());
        Console.WriteLine("Dados da conta atualizados: " + c);
        */
    }
}