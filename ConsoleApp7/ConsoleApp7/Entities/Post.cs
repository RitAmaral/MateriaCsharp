using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7.Entities
{
    internal class Post
    {
        //Propriedades
        public DateTime Moment { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public int Likes { get; set; }
        public List<Comment> Comments { get; set; } = new List<Comment>(); //lista criada e vazia

        //Construtores
        public Post() { } //construtor padrão
        public Post(DateTime moment, string title, string content, int likes)
        {
            Moment = moment;
            Title = title;
            Content = content;
            Likes = likes;
        }

        //Secção de Métodos
        public void AddComment(Comment comment) //Comment = Lista; comment = argumento do método
        {
            Comments.Add(comment);
        }
        public void RemoveComment(Comment comment)
        {
            Comments.Remove(comment);
        }

        public override string ToString()
        {//StringBuilder é uma estratégia diferente, em vez de colocar sempre + .. + ..
            StringBuilder sb = new StringBuilder(); //criamos novo objeto: sb
            sb.AppendLine(Title); //AppendLine - muda a linha tal como Console.WriteLine
            sb.Append(Likes);
            sb.Append(" Likes - ");
            sb.AppendLine(Moment.ToString("dd/MM/yyyy HH:mm:ss"));
            sb.AppendLine(Content);
            sb.AppendLine("Comments: ");
            foreach (Comment comment in Comments)
            {
                sb.AppendLine(comment.Text); //como Comment e Post estão na mesma pasta, basta colocar Text (que vem da classe Comment)
            }
            return sb.ToString();
        }
    }
}
