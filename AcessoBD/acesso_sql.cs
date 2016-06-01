//using AcessoBD.Properties;
using AcessoBD.Properties;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcessoBD
{

    public class acesso_sql
    {
        #region Criar Conexão
        private SqlConnection CriarConexao()
        {
            return new SqlConnection(Settings.Default.StringConexao);
            //return new SqlConnection();
        }
        #endregion


        #region Instanciar Parametros
        //Parametros que vão para o banco de dados
        private SqlParameterCollection sqlParameterCollection = new SqlCommand().Parameters;
        #endregion

        #region Limpar Parametros
        public void LimparParametros()
        {
            sqlParameterCollection.Clear();
        }
        #endregion

        #region Adicionar Parametros
        public void AdicionarParametros(string nomeParametro, object valorParametro)
        {
            sqlParameterCollection.Add(new SqlParameter(nomeParametro, valorParametro));
        }
        #endregion

        #region Execultar Manipilação de Inserir - Alterar - Excluir
        public object ExecultarManupulacao(CommandType commandType, string nomeStoredProcedureOuTextoSql)
        {

            try
            {
                //CriarConexao
                SqlConnection sqlConnection = CriarConexao();
                //AbrirConexao
                sqlConnection.Open();
                //Comando que leva informações ao banco de dados
                SqlCommand sqlCommand = sqlConnection.CreateCommand();
                //Colocando as coisas dentro do comando(dentro do trafego da conexao)
                sqlCommand.CommandType = commandType; //Procidure ou texto
                sqlCommand.CommandText = nomeStoredProcedureOuTextoSql; //nome procidure ou texto
                sqlCommand.CommandTimeout = 7200; // Em segundos - 7200s=2hrs  Tempo de conexão aberta

                //Adicinar parametros no comando
                foreach (SqlParameter sqlParameter in sqlParameterCollection)
                {
                    sqlCommand.Parameters.Add(new SqlParameter(sqlParameter.ParameterName, sqlParameter.Value));

                }

                //Execultar comando, ou seja, mandar o comando ir ate o banco de dados
                return sqlCommand.ExecuteScalar();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        #endregion

        #region Consultar registro do banco de dados
        public DataTable ExecultarConsulta(CommandType commandType, string nomeStoredProcedureOuTextoSql)
        {
            try
            {
                //CriarConexao
                SqlConnection sqlConnection = CriarConexao();
                //AbrirConexao
                sqlConnection.Open();
                //Comando que leva informações ao banco de dados
                SqlCommand sqlCommand = sqlConnection.CreateCommand();
                //Colocando as coisas dentro do comando(dentro do trafego da conexao)
                sqlCommand.CommandType = commandType; //Procidure ou texto
                sqlCommand.CommandText = nomeStoredProcedureOuTextoSql; //nome procidure ou texto
                sqlCommand.CommandTimeout = 7200; // Em segundos - 7200s=2hrs  Tempo de conexão aberta

                //Adicinar parametros no comando
                foreach (SqlParameter sqlParameter in sqlParameterCollection)
                {
                    sqlCommand.Parameters.Add(new SqlParameter(sqlParameter.ParameterName, sqlParameter.Value));
                }

                //Criando o adaptador
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);

                //Criando DataTable Vazia
                DataTable dataTable = new DataTable();

                //Mandar o comando ir até o banco buscar os dados e o adaptador preencher a tabela(datatable)
                sqlDataAdapter.Fill(dataTable);

                return dataTable;

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        #endregion
    }
}

















//  public class acesso_sql
//  {
//  public acesso_sql()
//  { }

//  public String conn = "Data Source=GICA03-HP;Initial Catalog=EnergisaParte2;Persist Security Info=True;User ID=sa;Password=123456";

//  public SqlConnection getConnection()
//  {
//      return this.getConnection("GICA03-HP", "1433", "sa", "EnergisaParte2", "123456");
//  }

//  public SqlConnection getConnection(string host, string port, string user, string db, string password)
//  {
//      SqlConnection connection;
//      String stringConnection = "Data Source=" + host + "," + port + "; " +
//          "Network Library=DBMSSOCN;Initial Catalog=" + db + ";" +
//          "User ID=" + user + ";Password=" + password + " ";
//      connection = new SqlConnection(stringConnection);
//      try
//      {
//          connection.Open();
//      }
//      catch (Exception ex)
//      {
//          //MessageBox.Show("Banco de Dados não encontrado! ");
//          throw new Exception();
//      }
//      return connection;
//  }

//  /// <summary>
//  /// fecha a conecção com o banco de dados
//  /// </summary>
//  /// <param name="conn"></param>
//  public void closeConnection(SqlConnection conn)
//  {
//      conn.Close();
//  }

//  /// <summary>
//  /// retorna lista com nome de cada subestação
//  /// </summary>
//  /// <returns></returns>
//  public List<string> listaSubestacao()
//  {
//      List<string> listaSE = new List<string>();
//      try
//      {
//          String query = "SELECT * FROM dbo.tblSE";

//          SqlConnection conn = this.getConnection();
//          SqlCommand cmdSelect = new SqlCommand(query, conn);
//          SqlDataReader leitor = cmdSelect.ExecuteReader();

//          while (leitor.Read())
//          {
//              string nome = leitor["NomeSE"].ToString();
//              listaSE.Add(nome);
//          }

//          this.closeConnection(conn);
//          return listaSE;
//      }
//      catch (SqlException ex)
//      {
//          //MessageBox.Show(ex.ToString());
//          return null;
//      }
//  }

//  /// <summary>
//  /// recupera data inicial e final de um ponto de medicao, jogando os mesmos em uma lista
//  /// </summary>
//  /// <param name="idSE">id da subestacao</param>
//  /// <param name="nomePM">nome do ponto de medicao</param>
//  /// <returns>lista de datas (data inicial e final)</returns>
//  public List<DateTime> recuperaDataInicial_Final_PM(string idSE, string nomePM)
//  {
//      List<DateTime> dataInicioeFimPm = new List<DateTime>();

//      try
//      {
//          String querySelectSE = "SELECT * FROM tblPM WHERE idSE = " + idSE + " and NomePM='"+nomePM+"'";
//          SqlConnection conn = this.getConnection();
//          SqlCommand cmdSelectSE = new SqlCommand(querySelectSE, conn);
//          SqlDataReader leitorPM = cmdSelectSE.ExecuteReader();
//          leitorPM.Read();

//          DateTime dataInicio = DateTime.Parse(leitorPM["dataInicio"].ToString());
//          DateTime dataFim = DateTime.Parse(leitorPM["dataFim"].ToString());

//          dataInicioeFimPm.Add(dataInicio);
//          dataInicioeFimPm.Add(dataFim);

//          this.closeConnection(conn);

//          return dataInicioeFimPm;
//      }
//      catch (SqlException ex)
//      {
//         // MessageBox.Show(ex.ToString());
//          return null;
//      }

//  }

//  /// <summary>
//  /// Recupera id de uma subestacao
//  /// </summary>
//  /// <param name="nomeSE"></param>
//  /// <returns></returns>
//  public string recuperaIdSE(string nomeSE) {
//      try
//      {
//          String querySelectSE = "SELECT IdSE FROM dbo.tblSE WHERE NomeSE = '" + nomeSE + "'";
//          SqlConnection conn = this.getConnection();
//          SqlCommand cmdSelectSE = new SqlCommand(querySelectSE, conn);
//          SqlDataReader leitorSE = cmdSelectSE.ExecuteReader();
//          leitorSE.Read();
//          string idSE = leitorSE["IdSE"].ToString();
//          this.closeConnection(conn);
//          return idSE;
//      }
//      catch (SqlException ex)
//      {
//         // MessageBox.Show(ex.ToString());
//          return null;
//      }
//  }

//  /// <summary>
//  /// recupera ids dos pontos de medição
//  /// </summary>
//  /// <param name="abrev_subestacao"> abreviação da subestação </param>
//  /// <returns></returns>
//  public List<string> recuperaIdsPM(string subestacao)
//  {
//      List<string> listaIds = new List<string>();
//      try
//      {

//          string idSE = recuperaIdSE(subestacao);
//          if (idSE != null)
//          {
//              String querySelectPM = "SELECT idPM FROM dbo.tblPM WHERE idSE = " + idSE;
//              SqlConnection conn2 = this.getConnection();
//              SqlCommand cmdSelectPM = new SqlCommand(querySelectPM, conn2);
//              SqlDataReader leitorPM = cmdSelectPM.ExecuteReader();
//              while (leitorPM.Read())
//              {
//                  string idPM = leitorPM["idPM"].ToString();
//                  listaIds.Add(idPM.ToString());
//              }
//              this.closeConnection(conn2);
//              return listaIds;
//          }
//          else return null;
//      }
//      catch (SqlException ex)
//      {
//         // MessageBox.Show(ex.ToString());
//          return null;
//      }
//  }

//  /// <summary>
//  /// recupera id de um ponto de medição
//  /// </summary>
//  /// <param name="abrev_subestacao"> abreviação da subestação </param>
//  /// <returns></returns>
//  public string recuperaIdDeUmPM(string nomePM, string idSE)
//  {
//      string id="";
//      try
//      {
//          String querySelectPM = "SELECT idPM FROM dbo.tblPM WHERE idSE="+ idSE +" and NomePM = '" + nomePM+"'";
//          SqlConnection conn2 = this.getConnection();
//          SqlCommand cmdSelectPM = new SqlCommand(querySelectPM, conn2);
//          SqlDataReader leitorPM = cmdSelectPM.ExecuteReader();
//          while (leitorPM.Read())
//          {
//              string idPM = leitorPM["idPM"].ToString();
//              id=idPM.ToString();
//          }
//          this.closeConnection(conn2);
//          return id;
//      }
//      catch (SqlException ex)
//      {
//         // MessageBox.Show(ex.ToString());
//          return null;
//      }
//  }


//  /// <summary>
//  /// recupera nomes dos pontos de medição
//  /// </summary>
//  /// <param name="abrev_subestacao"> abreviação da subestação </param>
//  /// <returns></returns>
//  public List<string> recuperaNomesPM(string subestacao)
//  {
//      List<string> listaIds = new List<string>();
//      try
//      {
//          String querySelectSE = "SELECT IdSE FROM dbo.tblSE WHERE NomeSE = '" + subestacao + "'";
//          SqlConnection conn = this.getConnection();
//          SqlCommand cmdSelectSE = new SqlCommand(querySelectSE, conn);
//          SqlDataReader leitorSE = cmdSelectSE.ExecuteReader();
//          leitorSE.Read();
//          string idSE = leitorSE["IdSE"].ToString();
//          this.closeConnection(conn);

//          String querySelectPM = "SELECT * FROM dbo.tblPM WHERE idSE = " + idSE;
//          SqlConnection conn2 = this.getConnection();
//          SqlCommand cmdSelectPM = new SqlCommand(querySelectPM, conn2);
//          SqlDataReader leitorPM = cmdSelectPM.ExecuteReader();
//          while (leitorPM.Read())
//          {
//              string idPM = leitorPM["NomePM"].ToString();
//              listaIds.Add(idPM.ToString());
//          }
//          this.closeConnection(conn2);
//          return listaIds;
//      }
//      catch (SqlException ex)
//      {
//        //  MessageBox.Show(ex.ToString());
//          return null;
//      }
//  }



//  public float SomaPotencias(string abrevSE, string dataInicial, string dataFinal, string idPm)
//  {
//      float soma = 0;
//      try
//      {                  
//          String query = "SELECT SUM(medicao) as soma from dadoCorrigido" + abrevSE + " WHERE data BETWEEN '" + dataInicial + "' AND '" + dataFinal + "' AND idPM=" + idPm.Trim();
//          SqlConnection conn = this.getConnection();
//          SqlCommand cmd = new SqlCommand(query, conn);
//          SqlDataReader leitorPM = cmd.ExecuteReader();
//          leitorPM.Read();
//          soma = float.Parse(leitorPM["soma"].ToString());

//          this.closeConnection(conn);

//          return soma;
//      }
//      catch (SqlException ex)
//      {
//         // MessageBox.Show(ex.ToString());
//          return soma;
//      }
//  }


//  public string retornaAbrevSE(string subestacao) {
//      try
//      {
//          String query = "SELECT * FROM tblSE WHERE NomeSE='"+subestacao+"'";
//          SqlConnection conn = this.getConnection();
//          SqlCommand cmd = new SqlCommand(query, conn);
//          SqlDataReader leitorPM = cmd.ExecuteReader();
//          leitorPM.Read();
//          string abrevSE = "";
//          abrevSE = leitorPM["AbrevSE"].ToString();
//          this.closeConnection(conn);

//          return abrevSE;
//      }
//      catch (SqlException ex)
//      {
//         // MessageBox.Show(ex.ToString());
//          return null;
//      }
//  }

//  /// <summary>
//  /// cria uma tabela usando a abreviação de uma subestacao
//  /// </summary>
//  /// <param name="abrevSE"> abreviacao usada para criar tabela</param>
//  public void criarTabelaMaximaSemanalSE(string abrevSE)
//  {
//      string sql = "CREATE TABLE maximaSemanal" + abrevSE + "(" +
//      "id int IDENTITY(1,1) NOT NULL," +
//      "idPM int  NOT NULL," +
//      "dia int NOT NULL, " +
//      "mes int NOT NULL, " +
//      "ano int NOT NULL, " +
//      "diaSemana int NOT NULL, " +
//      "hora int NOT NULL, " +
//      "minuto int NOT NULL, " +
//      "semana int NOT NULL, " +
//      "potencia float NOT NULL, " +
//      "PRIMARY KEY(id))";

//      SqlConnection conn = this.getConnection();
//      SqlCommand cmd = new SqlCommand(sql, conn);

//      try
//      {
//          cmd.ExecuteNonQuery();
//      }
//      catch (SqlException sqle)
//      {
//         // MessageBox.Show("Não foi possível criar a tabela. Erro: " + sqle);
//      }
//      closeConnection(conn);
//  }



//  public int insereDataTable(DataTable dt, string abrevSE)
//  {
//      try
//      {
//          SqlConnection conn = this.getConnection();
//          //conn.Open();

//          using (SqlBulkCopy copy = new SqlBulkCopy(conn))
//          {
//              copy.BatchSize = 10000;
//              copy.BulkCopyTimeout = 1000;

//              copy.ColumnMappings.Add("idPM", "idPM");
//              copy.ColumnMappings.Add("dia", "dia");
//              copy.ColumnMappings.Add("mes", "mes");
//              copy.ColumnMappings.Add("ano", "ano");
//              copy.ColumnMappings.Add("diaSemana", "diaSemana");
//              copy.ColumnMappings.Add("hora", "hora");
//              copy.ColumnMappings.Add("minuto", "minuto");
//              copy.ColumnMappings.Add("semana", "semana");
//              copy.ColumnMappings.Add("potencia", "potencia");

//              copy.DestinationTableName = "maximaSemanal" + abrevSE;
//              copy.WriteToServer(dt);
//          }

//          return 1;
//      }
//      catch (Exception)
//      {
//         // MessageBox.Show("Inserção no BD falhou!");
//          return 0;
//      }
//  }

//  public DataTable retornaMaximoSemanalPM(string abrevSE, int idPM){
//      // Create a command to extract the required data and assign it the connection string
//      SqlCommand cmd = new SqlCommand("SELECT * FROM maximaSemanal" + abrevSE + " where idPM="+idPM);
//      cmd.CommandType = CommandType.Text;
//      // Create a DataAdapter to run the command and fill the DataTable
//      SqlDataAdapter da = new SqlDataAdapter();
//      da.SelectCommand = cmd;
//      DataTable dt = new DataTable();
//      da.Fill(dt);

//      return dt;
//  }

//  /// <summary>
//  /// verifica se determinada tabela existe no banco de dados
//  /// </summary>
//  /// <param name="tabela">nome da tabela a ser pesquisada</param>
//  /// <returns></returns>
//  public bool verificaSeTabelaExiste(string tabela)
//  {

//      try
//  {
//          var sql = "SELECT COUNT(*) FROM information_schema.tables WHERE table_name = '"+tabela+"'";
//          SqlConnection conn = this.getConnection();
//          SqlCommand cmd = new SqlCommand(sql, conn);
//          //SqlDataReader leitorPM = cmd.ExecuteReader();

//          var count = Convert.ToInt32(cmd.ExecuteScalar());

//          return (count > 0);

//  }catch(Exception e){
//      return false;
//  }
//}


//  public int insereEnergiaSemana(DataTable dt)
//  {
//      try
//      {
//          SqlConnection conn = this.getConnection();
//          //conn.Open();

//          using (SqlBulkCopy copy = new SqlBulkCopy(conn))
//          {
//              copy.BatchSize = 10000;
//              copy.BulkCopyTimeout = 1000;

//              copy.ColumnMappings.Add("idSE", "idSE");
//              copy.ColumnMappings.Add("idPM", "idPM");
//              copy.ColumnMappings.Add("semana", "semana");
//              copy.ColumnMappings.Add("energia", "energia");

//              copy.DestinationTableName = "EnergiaSemana";
//              copy.WriteToServer(dt);
//          }

//          return 1;
//      }
//      catch (Exception)
//      {
//         // MessageBox.Show("Inserção no BD falhou!");
//          return 0;
//      }
//  }

//  public int insereEnergiaMes(DataTable dt)
//  {
//      try
//      {
//          SqlConnection conn = this.getConnection();
//          //conn.Open();

//          using (SqlBulkCopy copy = new SqlBulkCopy(conn))
//          {
//              copy.BatchSize = 10000;
//              copy.BulkCopyTimeout = 1000;

//              copy.ColumnMappings.Add("idSE", "idSE");
//              copy.ColumnMappings.Add("idPM", "idPM");
//              copy.ColumnMappings.Add("mes", "mes");
//              copy.ColumnMappings.Add("energia", "energia");

//              copy.DestinationTableName = "EnergiaMes";
//              copy.WriteToServer(dt);
//          }

//          return 1;
//      }
//      catch (Exception)
//      {
//         // MessageBox.Show("Inserção no BD falhou!");
//          return 0;
//      }
//  }


//  public int insereTaxaCrescimentoSemana(DataTable dt)
//  {
//      try
//      {
//          SqlConnection conn = this.getConnection();

//          using (SqlBulkCopy copy = new SqlBulkCopy(conn))
//          {
//              copy.BatchSize = 10000;
//              copy.BulkCopyTimeout = 1000;

//              copy.ColumnMappings.Add("idSE", "idSE");
//              copy.ColumnMappings.Add("idPM", "idPM");
//              copy.ColumnMappings.Add("semana", "semana");
//              copy.ColumnMappings.Add("taxaCrescimento", "taxa");

//              copy.DestinationTableName = "taxaCrescimentoSemana";
//              copy.WriteToServer(dt);
//          }

//          return 1;
//      }
//      catch (Exception)
//      {
//         // MessageBox.Show("Inserção no BD falhou!");
//          return 0;
//      }
//  }


//  public int insereTaxaCrescimentoMes(DataTable dt)
//  {
//      try
//      {
//          SqlConnection conn = this.getConnection();

//          using (SqlBulkCopy copy = new SqlBulkCopy(conn))
//          {
//              copy.BatchSize = 10000;
//              copy.BulkCopyTimeout = 1000;

//              copy.ColumnMappings.Add("idSE", "idSE");
//              copy.ColumnMappings.Add("idPM", "idPM");
//              copy.ColumnMappings.Add("mes", "mes");
//              copy.ColumnMappings.Add("taxaCrescimento", "taxa");

//              copy.DestinationTableName = "taxaCrescimentoMes";
//              copy.WriteToServer(dt);
//          }

//          return 1;
//      }
//      catch (Exception)
//      {
//          //MessageBox.Show("Inserção no BD falhou!");
//          return 0;
//      }
//  }






/*

#region Creating Conection
private SqlConnection CriarConexao()
{
    return new SqlConnection(Settings.Default.StringConexao);
}
#endregion
        #region Instanciar Parametros
//Parametros que vão para o banco de dados
private SqlParameterCollection sqlParameterCollection = new SqlCommand().Parameters;
#endregion

#region Limpar Parametros
public void LimparParametros()
{
    sqlParameterCollection.Clear();
}
#endregion

#region Adicionar Parametros
public void AdicionarParametros(string nomeParametro, object valorParametro)
{
    sqlParameterCollection.Add(new SqlParameter(nomeParametro, valorParametro));
}
#endregion

#region Execultar Manipilação de Inserir - Alterar - Excluir
public object ExecultarManupulacao(CommandType commandType, string nomeStoredProcedureOuTextoSql)
{

    try
    {
        //CriarConexao
        SqlConnection sqlConnection = CriarConexao();
        //AbrirConexao
        sqlConnection.Open();
        //Comando que leva informações ao banco de dados
        SqlCommand sqlCommand = sqlConnection.CreateCommand();
        //Colocando as coisas dentro do comando(dentro do trafego da conexao)
        sqlCommand.CommandType = commandType; //Procidure ou texto
        sqlCommand.CommandText = nomeStoredProcedureOuTextoSql; //nome procidure ou texto
        sqlCommand.CommandTimeout = 7200; // Em segundos - 7200s=2hrs  Tempo de conexão aberta

        //Adicinar parametros no comando
        foreach (SqlParameter sqlParameter in sqlParameterCollection)
        {
            sqlCommand.Parameters.Add(new SqlParameter(sqlParameter.ParameterName, sqlParameter.Value));

        }

        //Execultar comando, ou seja, mandar o comando ir ate o banco de dados
        return sqlCommand.ExecuteScalar();
    }
    catch (Exception ex)
    {
        throw new Exception(ex.Message);
    }
}
#endregion

#region Consultar registro do banco de dados
public DataTable ExecultarConsulta(CommandType commandType, string nomeStoredProcedureOuTextoSql)
{
    try
    {
        //CriarConexao
        SqlConnection sqlConnection = CriarConexao();
        //AbrirConexao
        sqlConnection.Open();
        //Comando que leva informações ao banco de dados
        SqlCommand sqlCommand = sqlConnection.CreateCommand();
        //Colocando as coisas dentro do comando(dentro do trafego da conexao)
        sqlCommand.CommandType = commandType; //Procidure ou texto
        sqlCommand.CommandText = nomeStoredProcedureOuTextoSql; //nome procidure ou texto
        sqlCommand.CommandTimeout = 7200; // Em segundos - 7200s=2hrs  Tempo de conexão aberta

        //Adicinar parametros no comando
        foreach (SqlParameter sqlParameter in sqlParameterCollection)
        {
            sqlCommand.Parameters.Add(new SqlParameter(sqlParameter.ParameterName, sqlParameter.Value));
        }

        //Criando o adaptador
        SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);

        //Criando DataTable Vazia
        DataTable dataTable = new DataTable();

        //Mandar o comando ir até o banco buscar os dados e o adaptador preencher a tabela(datatable)
        sqlDataAdapter.Fill(dataTable);

        return dataTable;

    }
    catch (Exception ex)
    {
        throw new Exception(ex.Message);
    }
}
 */
//#endregion


