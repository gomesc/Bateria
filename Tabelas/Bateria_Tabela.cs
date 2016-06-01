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
    public class Bateria_Tabela
    {
        #region Instanciando Acesso Sql
        //Instanciar = criando um novo objeto se baseando em um modelo
        acesso_sql acesso_dados = new acesso_sql();
        #endregion

        public string InserirBateria(Bateria bateria)
        {
            try
            {
                acesso_dados.LimparParametros();
                acesso_dados.AdicionarParametros("@IdModelo", bateria.IdModelo);
                acesso_dados.AdicionarParametros("@NomeBateria", bateria.NomeBateria);
                acesso_dados.AdicionarParametros("@Serie", bateria.Serie);
                acesso_dados.AdicionarParametros("@Fabricacao", bateria.Fabricacao);
                acesso_dados.AdicionarParametros("@Lote", bateria.Lote);


                acesso_dados.ExecultarManupulacao(CommandType.StoredProcedure, "inserirBateria").ToString();

                return "";
            }
            catch (Exception exception)
            { return exception.Message; }

        }

        public BateriaColecao ConsultarBateriasPorNome(string nome)
        {
            try
            {
                //Criar uma coleção de baterias
                BateriaColecao bateriaColecao = new BateriaColecao();

                acesso_dados.LimparParametros();
                acesso_dados.AdicionarParametros("@NomeBateria", nome);

                DataTable dataTable = acesso_dados.ExecultarConsulta(CommandType.StoredProcedure, "consultarBateriaPorNome");

                //Percorrer o DataTable e transformar em coleção de cliente
                //Cada linha do DataTable é um cliente
                //Data=Dados Row=Linha
                foreach (DataRow linha in dataTable.Rows)
                {
                    Bateria bateria = new Bateria();

                    bateria.Id = Convert.ToInt32(linha["Id"]);
                    bateria.IdModelo = Convert.ToInt32(linha["IdModelo"]);
                    bateria.NomeBateria = Convert.ToString(linha["NomeBateria"]);
                    bateria.Serie = Convert.ToString(linha["Serie"]);
                    bateria.Fabricacao = Convert.ToString(linha["Fabricacao"]);
                    bateria.Lote = Convert.ToString(linha["Lote"]);

                    bateriaColecao.Add(bateria);

                }

                return bateriaColecao;
            }
            catch (Exception exception)
            {
                throw new Exception("Detalhes:" + exception.Message);
            }
        }

        public BateriaColecao ConsultarBateriasPorId(int idEmpresa)
        {
            try
            {
                BateriaColecao bateriaColecao = new BateriaColecao();

                acesso_dados.LimparParametros();
                acesso_dados.AdicionarParametros("@Id", idEmpresa);

                DataTable dataTable = acesso_dados.ExecultarConsulta(CommandType.StoredProcedure, "consultarBateriasPorId");

                foreach (DataRow linha in dataTable.Rows)
                {
                    Bateria bateria = new Bateria();

                    bateria.Id = Convert.ToInt32(linha["Id"]);
                    bateria.IdModelo = Convert.ToInt32(linha["IdModelo"]);
                    bateria.NomeBateria = Convert.ToString(linha["NomeBateria"]);
                    bateria.Serie = Convert.ToString(linha["Serie"]);
                    bateria.Fabricacao = Convert.ToString(linha["Fabricacao"]);
                    bateria.Lote = Convert.ToString(linha["Lote"]);

                    bateriaColecao.Add(bateria);
                }

                return bateriaColecao;
            }
            catch (Exception exception)
            {
                throw new Exception(" Detalhes:" + exception.Message);
            }
        }

    }

}
