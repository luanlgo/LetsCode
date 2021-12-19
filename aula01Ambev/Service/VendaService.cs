using aula01Ambev.Database;
using aula01Ambev.Model;

namespace aula01Ambev.Service
{
    public class VendaService
    {
        private DatabaseRepository _database;
        private ClienteService _clienteService;
        private ProdutoService _produtoService;

        public VendaService(){
            _database = new DatabaseRepository();
            _clienteService = new ClienteService();
            _produtoService = new ProdutoService();
        }
 
        public Venda? BuscarPorId(int id) =>
            _database.Vendas.Where<Venda>( x => x.Id == id).FirstOrDefault();
        
        public Venda? BuscarPorClienteId(int idCliente) =>
            _database.Vendas.Where<Venda>( x => x.Cliente.Id == idCliente).FirstOrDefault();

        public void RegistrarVenda(int idCliente, Dictionary<int, int> produtosVenda) 
        {
            var cliente = _clienteService.BuscarPorId(idCliente);

            var produtos = new List<Produto>();
            
            foreach(int idProduto in produtosVenda.Keys){
                var quantidade = produtosVenda.GetValueOrDefault(idProduto); 
                _produtoService.DiminuirEstoque(idProduto, quantidade);
                produtos.Add(_produtoService.BuscarPorId(idProduto));
            }

            var venda = new Venda(){
                Cliente = cliente,
                Descricao = Guid.NewGuid().ToString(),
                Produtos = produtos
            };
            _database.Vendas.Inserir<Venda>(venda);
        }

        public void RegistrarVendaSemClienteCadastrado(Dictionary<int, int> produtosVenda) 
        {
            this.RegistrarVenda(0, produtosVenda);
        }
    }
}