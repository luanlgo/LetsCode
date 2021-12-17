using System;

namespace aula01Ambev.Model
{
    public class Estoque
    {
        public Produto Produto { get; set;}

        public Estoque(Produto produto)
        {
            Produto = produto;
        }

        public void CadastrarEstoque(Produto produto)
        {

        }

        public void DiminuirEstoque(Produto produto)
        {
            
        }

        public void AtualizarEstoque(Produto produto)
        {
            
        }
    }
}