namespace rainha_rodeio.Services
{
    public class JsonResultBL
    {
        public static object Sucesso(string titulo, string mensagem)
        {
            return new { Sucesso = true, Titulo = titulo, Mensagem = mensagem };
        }
         
        public static object Erro(string titulo, string mensagem)
        {
            return new { Sucesso = false, Titulo = titulo, Mensagem = mensagem };
        }
    }
}
