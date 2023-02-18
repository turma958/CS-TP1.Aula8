using CS_TP1.Aula8.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_TP1.Aula8
{
    public class Produto
    {
        /*
         * Id (int): o identificador único do produto;
            Nome (string): o nome do produto;
            Preco (double): o preço do produto;
            Quantidade (int): a quantidade em estoque do produto.
         */

        public int Id { get; set; }
        public string Nome { get; set; }
        public double Preco { get; set; }
        public int Quantidade { get; set; }

        public Produto(int id, string nome, double preco, int quantidade)
        {
            Id = id;
            Nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        }

        public void AdicionarQuantidade(int quantidade)
        {
            if (quantidade < 0)
            {
                throw new AdicionarException("A quantidade informada não pode ser negativa");
            }

            Quantidade += quantidade;
        }

        public void RemoverQuantidade(int quantidade)
        {
            if (quantidade < 0)
            {
                throw new RemoverException("A quantidade informada não pode ser negativa");
            }

            if (quantidade > Quantidade)
            {
                throw new InvalidOperationException("Não há quantidade suficiente em estoque para remover");
            }

            Quantidade -= quantidade;
        }
    }
}
