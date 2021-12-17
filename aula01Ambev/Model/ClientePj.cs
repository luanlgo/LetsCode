using System;

namespace aula01Ambev.Model
{
    public class ClientePj : Pessoa
    {
        public override void VerificaDocumento(string documento)
        {
            if (documento.Length == 14)
            {
                Documento = documento;
            }
        }
    }

}