using System;

namespace aula01Ambev.Model
{
    public class Pessoa : EntidadeBase
    {
        public string Nome { get; set; }
        public string NomeSocial { get; set; }
        public string Documento { get; set; }
        public Endereco Endereco { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }

        public virtual void VerificaDocumento(string Documento) { }
        
        public virtual void Atualizar<T>(T entidade) { }
        public virtual Task<T> BuscarPorNome<T>(string nome) { }
        public virtual Task<T> BuscarPorId<T>(Guid id) { }
        public virtual void Cadastrar(T entidade) { }
   }
}