namespace aula01Ambev.Model
{
    public class Produto : EntidadeBase
    {
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public double Preco { get; set; }
        public int Quantidade { get; set; } 
    }
}