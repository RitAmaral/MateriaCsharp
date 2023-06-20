using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangulos
{
    internal class Produto
    {
        public string Nome;
        public double Preco;
        public int Quantidade;

        public double ValorTotalEmStock()
        {
            return Preco * Quantidade;
        }
        public void AdicionarProdutos(int quantidade) // void não vai ter um retorno numérico que possa aparecer na tela
        {
            Quantidade += quantidade; // += é igual a Quantidade + quantidade
        }
        public void RemoverProdutos(int quantidade) // quantidade em minusculas porque é uma variável local, só na memória
        {
            Quantidade -= quantidade;
        }
        public override string ToString()
        {
            return "Nome: " + Nome
                   + "\n" // faz quebra de linha
                   + "Preço: "
                   + Preco.ToString("F2")
                   + "\n"
                   + "Quantidade: " 
                   + Quantidade
                   + "\n"
                   + "Valor Total em Stock: "
                   + ValorTotalEmStock().ToString("F2");
        }
        
    }
}
