using System.Collections.Generic;
using System.Linq;
using aula01Ambev.Atualizar;

namespace aula01Ambev.Model
{
    public class Filial : EntidadeBase
    {
        public Filial(string nome) 
        {
            Id = Guid.NewGuid();
            Nome = nome;
        }

        public Filial(Guid id, string nome) 
        {
            Id = id;
            Nome = nome;
        }

        public void AtualizarNome(string nome)
        {
            Nome = nome;
        }

        public string Nome { get; set; }
    }

    public class FilialService 
    {
        public void Inserir(string nome)
        {
            Database.Inserir<Filial>(new Filial(nome));
        }

        public Filial BuscarPorId(Guid Id)
            => Database.Buscar<Filial>(Select(x => x.id == id));

        public Filial BuscarPorNome(string nome)
            => Database.Buscar<Filial>(Select(x => x.nome == nome));

        public void AtualizarFilial(Guid id, string nome)
        {
            var newFilial = BuscarPorId(id);
            newFilial.AtualizarNome(nome);
            Database.Atualizar<Filial>(newFilial)
        }
    }
}