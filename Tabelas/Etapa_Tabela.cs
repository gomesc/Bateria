using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Transferencia;
using AcessoBD;
using System.Data;

namespace Tabelas
{
    public class Etapa_Tabela
    {
        #region Instanciando Acesso Sql
        //Instanciar = criando um novo objeto se baseando em um modelo
        acesso_sql acesso_dados = new acesso_sql();
        #endregion

        public string InserirEtapa(Etapa etapa)
        {
            try
            {
                acesso_dados.LimparParametros();
                acesso_dados.AdicionarParametros("@Tipo", etapa.Tipo);
                acesso_dados.AdicionarParametros("@Qb", etapa.Qb);
                acesso_dados.AdicionarParametros("@kVb", etapa.kVb);
                acesso_dados.AdicionarParametros("@NextQ", etapa.NextQ);
                acesso_dados.AdicionarParametros("@NextV", etapa.NextV);
                acesso_dados.AdicionarParametros("@NextT", etapa.NextT);
                acesso_dados.AdicionarParametros("@NextL", etapa.NextI);

                acesso_dados.ExecultarManupulacao(CommandType.StoredProcedure, "inserirEtapa").ToString();

                return "";
            }
            catch (Exception exception)
            { return exception.Message; }

        }

        public EtapaColecao ConsultarEtapasPorId(int Id)
        {
            try
            {
                EtapaColecao etapaColecao = new EtapaColecao();

                acesso_dados.LimparParametros();
                acesso_dados.AdicionarParametros("@IdEtapa", Id);

                DataTable dataTable = acesso_dados.ExecultarConsulta(CommandType.StoredProcedure, "consultarEtapasPorId");

                foreach (DataRow linha in dataTable.Rows)
                {
                    Etapa etapa = new Etapa();

                    etapa.IdEtapa = Convert.ToInt32(linha["IdEtapa"]);
                    etapa.Tipo = Convert.ToString(linha["Tipo"]);
                    etapa.Qb = Convert.ToString(linha["Qb"]);
                    etapa.kVb = Convert.ToString(linha["kVb"]);
                    etapa.NextQ = Convert.ToString(linha["NextQ"]);
                    etapa.NextV = Convert.ToString(linha["NextV"]);
                    etapa.NextT = Convert.ToString(linha["NextT"]);
                    etapa.NextI = Convert.ToString(linha["NextI"]);

                    etapaColecao.Add(etapa);
                }

                return etapaColecao;
            }
            catch (Exception exception)
            {
                throw new Exception(" Detalhes:" + exception.Message);
            }
        }

        public EtapaColecao ConsultarEtapas()
        {
            try
            {
                EtapaColecao etapaColecao = new EtapaColecao();

                acesso_dados.LimparParametros();

                DataTable dataTable = acesso_dados.ExecultarConsulta(CommandType.StoredProcedure, "consultarEtapas");

                foreach (DataRow linha in dataTable.Rows)
                {
                    Etapa etapa = new Etapa();

                    etapa.IdEtapa = Convert.ToInt32(linha["IdEtapa"]);
                    etapa.Tipo = Convert.ToString(linha["Tipo"]);
                    etapa.Qb = Convert.ToString(linha["Qb"]);
                    etapa.kVb = Convert.ToString(linha["kVb"]);
                    etapa.NextQ = Convert.ToString(linha["NextQ"]);
                    etapa.NextV = Convert.ToString(linha["NextV"]);
                    etapa.NextT = Convert.ToString(linha["NextT"]);
                    etapa.NextI = Convert.ToString(linha["NextI"]);

                    etapaColecao.Add(etapa);
                }

                return etapaColecao;
            }
            catch (Exception exception)
            {
                throw new Exception(" Detalhes:" + exception.Message);
            }
        }

        public Etapa ConsultarEtapas(string p)
        {
            throw new NotImplementedException();
        }
    }
}
