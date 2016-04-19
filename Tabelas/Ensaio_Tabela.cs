using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AcessoBD;
using Transferencia;
using System.Data;

namespace Tabelas
{
    public class Ensaio_Tabela
    {
        #region Instanciando Acesso Sql
        //Instanciar = criando um novo objeto se baseando em um modelo
        acesso_sql acesso_dados = new acesso_sql();
        #endregion

        public string InserirEnsaio(Ensaio ensaio)
        {
            try
            {
                acesso_dados.LimparParametros();
                acesso_dados.AdicionarParametros("@NomeEnsaio", ensaio.NomeEnsaio);
                acesso_dados.AdicionarParametros("@Descricao", ensaio.Descricao);
                acesso_dados.AdicionarParametros("@TStart", ensaio.TStart);
                acesso_dados.AdicionarParametros("@TStop", ensaio.TStop);
                acesso_dados.AdicionarParametros("@TRun", ensaio.TRun);
                acesso_dados.AdicionarParametros("@Ib", ensaio.Ib);
                acesso_dados.AdicionarParametros("@KVb", ensaio.KVb);
                acesso_dados.AdicionarParametros("@Tbref", ensaio.Tbref);

                acesso_dados.ExecultarManupulacao(CommandType.StoredProcedure, "inserirEnsaio").ToString();

                return "";
            }
            catch (Exception exception)
            { return exception.Message; }

        }

        public EnsaioColecao ConsultarEnsaioPorNome(string nome)
        {
            try
            {
                //Criar uma coleção de baterias
                EnsaioColecao ensaioColecao = new EnsaioColecao();

                acesso_dados.LimparParametros();
                acesso_dados.AdicionarParametros("@NomeEnsaio", nome);

                DataTable dataTable = acesso_dados.ExecultarConsulta(CommandType.StoredProcedure, "consultarEnsaioPorNome");

                foreach (DataRow linha in dataTable.Rows)
                {
                    Ensaio ensaio = new Ensaio();

                    ensaio.IdEnsaio = Convert.ToInt32(linha["IdEnsaio"]);
                    ensaio.NomeEnsaio = Convert.ToString(linha["NomeEnsaio"]);
                    ensaio.Descricao = Convert.ToString(linha["Descricao"]);
                    ensaio.TStart = Convert.ToString(linha["TStart"]);
                    ensaio.TStop = Convert.ToString(linha["TStop"]);
                    ensaio.TRun = Convert.ToString(linha["TRun"]);
                    ensaio.Ib = Convert.ToString(linha["Ib"]);
                    ensaio.KVb = Convert.ToString(linha["KVb"]);
                    ensaio.Tbref = Convert.ToString(linha["Tbref"]);

                    ensaioColecao.Add(ensaio);

                }

                return ensaioColecao;
            }
            catch (Exception exception)
            {
                throw new Exception("Detalhes:" + exception.Message);
            }
        }

        public EnsaioColecao ConsultarEnsaioPorId(int Id)
        {
            try
            {
                EnsaioColecao ensaioColecao = new EnsaioColecao();

                acesso_dados.LimparParametros();
                acesso_dados.AdicionarParametros("@IdEnsaio", Id);

                DataTable dataTable = acesso_dados.ExecultarConsulta(CommandType.StoredProcedure, "consultarEnsaioPorId");

                foreach (DataRow linha in dataTable.Rows)
                {
                    Ensaio ensaio = new Ensaio();

                    ensaio.IdEnsaio = Convert.ToInt32(linha["IdEnsaio"]);
                    ensaio.NomeEnsaio = Convert.ToString(linha["NomeEnsaio"]);
                    ensaio.Descricao = Convert.ToString(linha["Descricao"]);
                    ensaio.TStart = Convert.ToString(linha["TStart"]);
                    ensaio.TStop = Convert.ToString(linha["TStop"]);
                    ensaio.TRun = Convert.ToString(linha["TRun"]);
                    ensaio.Ib = Convert.ToString(linha["Ib"]);
                    ensaio.KVb = Convert.ToString(linha["KVb"]);
                    ensaio.Tbref = Convert.ToString(linha["Tbref"]);

                    ensaioColecao.Add(ensaio);
                }

                return ensaioColecao;
            }
            catch (Exception exception)
            {
                throw new Exception(" Detalhes:" + exception.Message);
            }
        }
    }
}
