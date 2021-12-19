using aula01Ambev.Database;
using aula01Ambev.Model;

namespace aula01Ambev.Service
{
    public class ProdutoService
    {
        private DatabaseRepository _database;

        public ProdutoService(){
            _database = new DatabaseRepository();
        }
        
        public void AtualizarProduto(Produto produto)
        {
            Produto? clienteDb = this.BuscarPorId(produto.Id);
            clienteDb = produto;
            _database.Produtos.Inserir<Produto>(clienteDb);
        }

        public void DiminuirEstoque(int idProduto, int quantidade)
        {
            Produto? estoqueDb = this.BuscarPorId(idProduto);
            estoqueDb.Quantidade -= quantidade;
            this.AtualizarProduto(estoqueDb);
        }

        public void AtualizarEstoque(int idProduto, int quantidade)
        {
            Produto? estoqueDb = this.BuscarPorId(idProduto);
            estoqueDb.Quantidade += quantidade;
           this.AtualizarProduto(estoqueDb);
        }
        
        public Produto? BuscarPorId(int id) =>
            _database.Produtos.Where<Produto>( x => x.Id == id).FirstOrDefault();
        
        public void Cadastrar(Produto entidade) 
        { 
            _database.Produtos.Inserir<Produto>(entidade);
        }

        public void Deletar(int id)
        {
            _database.Produtos.Deletar<Produto>(id);
        }
    }
}