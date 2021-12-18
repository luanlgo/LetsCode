using System;

namespace aula01Ambev.Model.Clientes
{
    public class ClientePf : ClienteBase
    {
        public override void VerificaDocumento(string documento) 
        { 
            if (documento.Length == 11)
            {
                Documento = documento;
            }
        }
    }
}