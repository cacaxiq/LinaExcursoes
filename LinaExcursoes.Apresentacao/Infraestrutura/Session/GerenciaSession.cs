using LinaExcursoes.Dominio.Tables;

namespace LinaExcursoes.Apresentacao.Infraestrutura.Session
{
    public class GerenciaSession : GerenciaSessionBase
    {
        private const string usuario = "Usuario";

        public static Usuario Usuario
        {
            get
            {
                return LeComDefault<Usuario>(usuario);
            }
            set
            {
                Atualiza(usuario, value);
            }
        }

        public static void Remove()
        {
            RemoveAll();
        }
    }
}