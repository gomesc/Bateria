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
    public class Modelo_Tabela
    {
        #region Instanciando Acesso Sql
        //Instanciar = criando um novo objeto se baseando em um modelo
        acesso_sql acesso_dados = new acesso_sql();
        #endregion

        public string InserirModelosBateria(ModeloBateria modelosBateria)
        {
            try
            {
                acesso_dados.LimparParametros();
                acesso_dados.AdicionarParametros("@Modelo", modelosBateria.Modelo);
                acesso_dados.AdicionarParametros("@Vbn", modelosBateria.Vbn);
                acesso_dados.AdicionarParametros("@KT", modelosBateria.KT);
                acesso_dados.AdicionarParametros("@Tb0", modelosBateria.Tb0);
                acesso_dados.AdicionarParametros("@C10", modelosBateria.C10);
                acesso_dados.AdicionarParametros("@C20", modelosBateria.C20);
                acesso_dados.AdicionarParametros("@C100", modelosBateria.C100);
                acesso_dados.AdicionarParametros("@VbFloat", modelosBateria.VbFloat);
                acesso_dados.AdicionarParametros("@VbEq", modelosBateria.VbEq);

                acesso_dados.ExecultarManupulacao(CommandType.StoredProcedure, "inserirModelosBateria").ToString();

                return "";
            }
            catch (Exception exception)
            { return exception.Message; }

        }

        public ModeloBateriaColecao ConsultarModelosBateriaPorNome(string nome)
        {
            try
            {
                //Criar uma coleção de baterias
                ModeloBateriaColecao modelobateriacolecao = new ModeloBateriaColecao();

                acesso_dados.LimparParametros();
                acesso_dados.AdicionarParametros("@Modelo", nome);

                DataTable dataTable = acesso_dados.ExecultarConsulta(CommandType.StoredProcedure, "consultarModelosBateriaPorNome");

                foreach (DataRow linha in dataTable.Rows)
                {
                    ModeloBateria modelosBateria = new ModeloBateria();

                    modelosBateria.Id = Convert.ToInt32(linha["Id"]);
                    modelosBateria.Modelo = Convert.ToString(linha["Modelo"]);
                    modelosBateria.Vbn = Convert.ToString(linha["Vbn"]);
                    modelosBateria.KT = Convert.ToString(linha["KT"]);
                    modelosBateria.Tb0 = Convert.ToString(linha["Tb0"]);
                    modelosBateria.C10 = Convert.ToString(linha["C10"]);
                    modelosBateria.C20 = Convert.ToString(linha["C20"]);
                    modelosBateria.C100 = Convert.ToString(linha["C100"]);
                    modelosBateria.VbFloat = Convert.ToString(linha["VbFloat"]);
                    modelosBateria.VbEq = Convert.ToString(linha["VbEq"]);

                    modelobateriacolecao.Add(modelosBateria);

                }

                return modelobateriacolecao;
            }
            catch (Exception exception)
            {
                throw new Exception("Detalhes:" + exception.Message);
            }
        }

        public ModeloBateriaColecao ConsultarBateriasPorId(int id)
        {
            try
            {
                ModeloBateriaColecao modelobateriacolecao = new ModeloBateriaColecao();

                acesso_dados.LimparParametros();
                acesso_dados.AdicionarParametros("@Id", id);

                DataTable dataTable = acesso_dados.ExecultarConsulta(CommandType.StoredProcedure, "consultarModelosBateriaPorId");

                foreach (DataRow linha in dataTable.Rows)
                {
                    ModeloBateria modelosBateria = new ModeloBateria();

                    modelosBateria.Id = Convert.ToInt32(linha["Id"]);
                    modelosBateria.Modelo = Convert.ToString(linha["Modelo"]);
                    modelosBateria.Vbn = Convert.ToString(linha["Vbn"]);
                    modelosBateria.KT = Convert.ToString(linha["KT"]);
                    modelosBateria.Tb0 = Convert.ToString(linha["Tb0"]);
                    modelosBateria.C10 = Convert.ToString(linha["C10"]);
                    modelosBateria.C20 = Convert.ToString(linha["C20"]);
                    modelosBateria.C100 = Convert.ToString(linha["C100"]);
                    modelosBateria.VbFloat = Convert.ToString(linha["VbFloat"]);
                    modelosBateria.VbEq = Convert.ToString(linha["VbEq"]);

                    modelobateriacolecao.Add(modelosBateria);
                }

                return modelobateriacolecao;
            }
            catch (Exception exception)
            {
                throw new Exception(" Detalhes:" + exception.Message);
            }
        }
    }
}
