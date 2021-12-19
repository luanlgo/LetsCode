namespace aula01Ambev.Model.Clientes
{
    public class ClientePj : ClienteBase
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