using System;

namespace aula01Ambev.Model.Clientes
{
    public class ClienteBase : EntidadeBase
    {
        public string Nome { get; set; }
        public string NomeSocial { get; set; }
        public string Documento { get; set; }
        public Endereco Endereco { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
        public bool EhPf => Documento.Length == 11;
        public virtual void VerificaDocumento(string Documento) { }    
   }
}