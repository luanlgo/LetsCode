using aula01Ambev.Model.Clientes;
using aula01Ambev.Database;

namespace aula01Ambev.Service
{
    public class ClienteService
    {
        private DatabaseRepository _database;

        public ClienteService(){
            _database = new DatabaseRepository();
        }

        public void Atualizar(ClienteBase cliente)
        {
            ClienteBase? clienteDb = this.BuscarPorId(cliente.Id);
            clienteDb = cliente;
            _database.Clientes.Inserir<ClienteBase>(clienteDb);
        }
        public ClienteBase? BuscarPorNome(string nome) =>
            _database.Clientes.Where<ClienteBase>( x => x.Nome == nome).FirstOrDefault();
        
        public ClienteBase? BuscarPorId(int id) =>
            _database.Clientes.Where<ClienteBase>( x => x.Id == id).FirstOrDefault();
        
        public void Cadastrar(ClienteBase entidade) 
        { 
            _database.Clientes.Inserir<ClienteBase>(entidade);
        }
    }
}