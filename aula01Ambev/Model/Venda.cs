using aula01Ambev.Model.Clientes;

namespace aula01Ambev.Model
{
    public class Venda : EntidadeBase
    {
        public string Descricao { get; set; }
        public ClienteBase Cliente { get; set; }
        public List<Produto> Produtos { get; set; }
    }
}