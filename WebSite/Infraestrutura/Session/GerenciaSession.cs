using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebSite_LinaExcursao.Infraestrutura.DataBase.Contexto.Tables;

namespace WebSite_LinaExcursao.Infraestrutura.Session
{
    public class GerenciaSession : GerenciaSessionBase
    {
        private const string usuario = "Usuario";

        public static Usuarios Usuario
        {
            get
            {
                return LeComDefault<Usuarios>(usuario);
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