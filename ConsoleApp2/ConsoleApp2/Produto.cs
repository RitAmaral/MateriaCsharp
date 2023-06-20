using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    
    internal class Produto
    {   //Atributos
        private string _nome; //objetivo: esconder propriedades, para ninguém conseguir mexer
                            //mudar de public para private, e, por norma: mudar de Nome para _nome
        public double Preco { get; set; }
        public int Quantidade { get; set; }
        //Construtores
        public Produto() { }
        public Produto(string nome, double preco, int quantidade)
        {
            _nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        }
        public Produto(string nome, double preco)
        {
            _nome = nome;
            Preco = preco;
        }
        //Propridades
        public string Nome 
        { 
            get { return _nome; }
            set { //Nota: set é sempre privado, por isso temos de colocar value em vez de nome no if:
                if (value != null && value.Length > 1) //se fosse nome não ia reconhecer. value = que tem valor
                {
                    _nome = value;
                }
            }
        }
        /*
        public double Preco // prop tab tab
        { 
            get { return _preco; } 
        }
        */

        //Propriedades autoimplementadas
        /*
        public string GetNome() //Get permite obter os valores que queremos, e tem de ser public para conseguirmos chamá-lo no main.
        { return _nome; }
        public double GetPreco() 
        { return _preco; }
        public int GetQuantidade() 
        { return _quantidade; }
        
        public void SetNome(string nome)
        {
            if (nome != null && nome.Length > 1) //nome diferente de nulo/vazio e nome tem de ter comprimento maior que 1
            {
                _nome = nome;
            }
            else
            {
                Console.WriteLine("Tem que inserir um valor com mais do que um caracter.");
            }
        } 
        */
        public double ValorTotalEmStock()
        { return Preco * Quantidade;}

        public void AdicionarProdutos(int quantidade) // void porque não é para retornar, é para adicionar
        {
            Quantidade += quantidade; // += é igual a Quantidade + quantidade
        }
        public void RemoverProdutos(int quantidade) 
        { Quantidade -= quantidade; }

        public override string ToString()
        {
            return "\n"
                + "Nome: " + _nome
                + "\n"
                + "Preço: " + Preco.ToString("F2")
                + "\n"
                + "Quantidade: " + Quantidade.ToString()
                + "\n"
                + "Valor total em Stock: " + ValorTotalEmStock().ToString("F2");
        }
    }
    
}
