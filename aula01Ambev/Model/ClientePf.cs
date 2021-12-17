using System;

namespace aula01Ambev.Model
{
    public class ClientePf : Pessoa
    {
        public override void VerificaDocumento(string documento) 
        { 
            if (documento.Length == 11)
            {
                Documento = documento;
            }
        }

        public override void Atualizar(ClientePf clientePf)
        {
            var clienteDb = this.BuscarPorId(clientePf.id)
            clienteDb = clientePf 
            DataBase.Inserir<ClientePf>(clienteDb);
        }

        public override Task<T> BuscarPorNome<T>(string nome) 
        {
            return DataBase.BuscarPorNome(nome)
        }
        public override Task<T> BuscarPorId<T>(Guid id) { }
        public override void Cadastrar(T entidade) { }
    }
}