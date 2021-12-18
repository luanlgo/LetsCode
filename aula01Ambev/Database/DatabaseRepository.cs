using aula01Ambev.Model.Clientes;
using aula01Ambev.Model;

namespace aula01Ambev.Database
{
    public class DatabaseRepository
    {

        // TODO: Caso mude para uma aplicação funcional mude para dictionary, para ter um id(index) funcional
       public List<ClienteBase> Clientes { get; set; } = new List<ClienteBase>(){
            new ClienteBase(){
                Id = 0,
                Nome = "Cliente Default",
                Documento = "000.000.000-00",
                Email = "default@gmail.com",
                NomeSocial = "Cliente Default",
                Telefone = "00 0000-0000"
            }
       };
       public List<Filial> Filiais { get; set; } = new List<Filial>();
       public List<Produto> Produtos { get; set; } = new List<Produto>();
       public List<Venda> Vendas { get; set; } = new List<Venda>();

    }
}
