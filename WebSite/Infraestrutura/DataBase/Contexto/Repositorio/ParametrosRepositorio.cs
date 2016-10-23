using System;
using WebSite.Infraestrutura.DataBase.Contexto.Interfaces;
using WebSite.Infraestrutura.DataBase.Contexto.Tables;
using System.Linq;

namespace WebSite.Infraestrutura.DataBase.Contexto.Repositorio
{
    public class ParametrosRepositorio : RepositoryBase<Parametros>, IParametrosRepositorio
    {
        public Parametros ObterPorNomeParametro(string nomeParametro)
        {
            return Db.Set<Parametros>().FirstOrDefault(p => p.NomeParametro == nomeParametro);
        }
    }
}