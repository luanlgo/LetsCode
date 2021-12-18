using aula01Ambev.Database;
using aula01Ambev.Model;

namespace aula01Ambev.Service
{
    public class FilialService
    {
         private DatabaseRepository _database;

        public FilialService(){
            _database = new DatabaseRepository();
        }
        public void Atualizar(Filial filial)
        {
            Filial? filialDb = this.BuscarPorId(filial.Id);
            filialDb = filial;
           _database.Filiais.Inserir<Filial>(filialDb);
        }
        public Filial? BuscarPorNome(string nome) =>
            _database.Filiais.Where<Filial>( x => x.Nome == nome).FirstOrDefault();
        
        public Filial? BuscarPorId(int id) =>
            _database.Filiais.Where<Filial>( x => x.Id == id).FirstOrDefault();
        
        public void Cadastrar(Filial entidade) 
        { 
            _database.Filiais.Inserir<Filial>(entidade);
        }
    }
}