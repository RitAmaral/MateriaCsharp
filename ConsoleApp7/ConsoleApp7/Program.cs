using ConsoleApp7.Entities;
using System.Threading.Channels;

internal class Program
{
    private static void Main(string[] args)
    {
        //Aula 16/05/2023

        /* ------------------------Exercício---------------------*/
        //Instancie manualmente os objetos mostrados abaixo e mostre-os na tela do terminal, conforme exemplo.

        Post post1 = new Post(DateTime.Parse("21/06/2023 13:10:02"), "Traveling to New Zealand", "I'm going to visit this wonderful country!", 12);

        Comment c1 = new Comment("Have a nice trip!"); //Escrever comentário
        Comment c2 = new Comment("Woww that's awesome!");

        post1.AddComment(c1); //Adicionar o comentário escrito em cima
        post1.AddComment(c2);

        Console.WriteLine(post1);

        Post post2 = new Post(DateTime.Parse("16/05/2023 14:34:13"), "Aqui estamos nós", "Cheios de vida a programar", 1000);

        Comment c3 = new Comment("Sois altamente!");
        Comment c4 = new Comment("Vou bloquear-te como SPAM");
        Comment c5 = new Comment("Não faço ideia do que estais para aí a fazer");

        post2.AddComment(c3);
        post2.AddComment(c4);
        post2.AddComment(c5);

        Console.WriteLine(post2);
    }
}