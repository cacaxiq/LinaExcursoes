using LinaExcursoes.Dominio.DTO;
using LinaExcursoes.Dominio.Interfaces;
using LinaExcursoes.Dominio.Tables;
using LinaExcursoes.Infraestrutura.Constantes;
using LinExcursoes.Infraestrutura.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LinaExcursoes.Dominio.Repositorio
{
    public class ViagemRepositorio : RepositoryBase<Viagem>, IViagensRepositorio
    {
        public IEnumerable<Viagem> ObterProximasViagens()
        {
            return Db.Set<Viagem>().Where(p => p.DataSaida >= DateTime.Now).OrderBy(p => p.DataSaida);
        }

        public IEnumerable<Viagem> ObterProximasViagensPraias()
        {
            return this.ObterProximasViagens(ConstantesAplicacao.Praias);
        }

        public IEnumerable<Viagem> ObterProximasViagensCidades()
        {
            return this.ObterProximasViagens(ConstantesAplicacao.CidadesTuristicas);
        }

        public IEnumerable<Viagem> ObterProximasViagensParques()
        {
            return this.ObterProximasViagens(ConstantesAplicacao.ParquesAquaticos);
        }

        public IEnumerable<Viagem> ObterProximasViagensEcoturismo()
        {
            return this.ObterProximasViagens(ConstantesAplicacao.EcoTurismo);
        }

        public ViagensLeadDTO ObterViagensLead(int id)
        {
            var resultado = new ViagensLeadDTO();

            resultado.ViagemPrincipal = GetById(id);

            if (resultado.ViagemPrincipal == null)
            {
                return null;
            }

            resultado.ListaViagem = FindBy(p => p.Tipo == resultado.ViagemPrincipal.Tipo && p.DataSaida >= DateTime.Now && p.Id != id).Take(4).OrderBy(p => p.DataSaida);

            var idViagensUsados = resultado.ListaViagem.Select(p => p.Id).ToArray();

            var listaCadatipo = FindBy(p => p.DataSaida >= DateTime.Now && !idViagensUsados.Contains(p.Id)).GroupBy(p => p.Tipo);

            resultado.ListaCadatipo = listaCadatipo.ToDictionary(p => p.Key, v => v.OrderBy(p => p.DataSaida).First()).Select(p => p.Value);

            return resultado;
        }

        public IEnumerable<string> ConsultarViagens()
        {
            var lista = Db.Set<Viagem>().Where(p => p.DataSaida >= DateTime.Now).OrderBy(p => p.DataSaida).ToList();

            var listaExibicao = lista.Select(item => string.Format("{0}/{1} de {2:m} a {3:m}&{4}",
                                                                    item.Local,
                                                                    item.Periodo,
                                                                    item.DataSaida,
                                                                    item.DataRetorno,
                                                                    item.Id));

            return listaExibicao.ToList();
        }

        public DetalheViagem ObterDetalheViagem(int id)
        {
            var resultado = new DetalheViagem();
            resultado.Detalhe = GetById(id);
            resultado.ListaViagem = this.ObterProximasViagens(resultado.Detalhe.Tipo).Where(p => p.Id != id);

            return resultado;
        }

        public IEnumerable<Viagem> ObterViagensPorPesquisa(string termo)
        {
            var lista = this.ConsultarViagens();

            var termoNormalizado = termo.Normalizacao();

            var filtro = lista.Where(p => p.Normalizacao().Contains(termoNormalizado)).Select(p => Convert.ToInt64(p.Split('&')[1])).ToArray();

            var listaFiltrada = Db.Set<Viagem>().Where(p => p.DataSaida >= DateTime.Now && filtro.Contains(p.Id)).OrderBy(p => p.DataSaida).ToList();

            return listaFiltrada;
        }

        private IEnumerable<Viagem> ObterProximasViagens(string tipoDestino)
        {
            return Db.Set<Viagem>().Where(p => p.Tipo == tipoDestino && p.DataSaida >= DateTime.Now).OrderBy(p => p.DataSaida);
        }
    }
}