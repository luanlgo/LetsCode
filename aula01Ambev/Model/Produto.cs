namespace aula01Ambev.Model
{
    public class Produto : EntidadeBase
    {
        private readonly Database _database;

        public string Nome { get; set; }
        public string Descricao { get; set; }
        public double Preco { get; set; }
        public int Quantidade { get; set; }
        
        public Produto(string nome, string descricao, double preco, int quantidade)
        {
            Nome = nome;
            Descricao = descricao;
            Preco = preco;
            Quantidade = quantidade;
        }
        
        public void Cadastrar(Produto produto)
        {
            _database.Inserir(produto);
        }

        public void Deletar(Guid id)
        {
            _database.Deletar(Id);
        }

        public void Atualizar(Produto produto)
        {
            _database.Atualizar(produto);
        }
    }
}