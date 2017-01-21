using System;
using System.Collections.Generic;
using System.Linq;
using WebSite.Infraestrutura.DataBase.Contexto.Interfaces;
using WebSite_LinaExcursao.Infraestrutura.DataBase.Contexto.Tables;

namespace WebSite.Infraestrutura.DataBase.Contexto.Repositorio
{
    public class ViagensRepositorio : RepositoryBase<Viagens>, IViagensRepositorio
    {
        public IEnumerable<Viagens> ObterProximasViagens()
        {
            return Db.Set<Viagens>().Where(p => p.DataSaida >= DateTime.Now).OrderBy(p => p.DataSaida);

        }
    }
}