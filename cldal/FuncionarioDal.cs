using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;

using clmodel;



namespace cldal
{
    public class FuncionarioDal
    {
        private SqlConnection _conexaoFuncionarios;
        private SqlCommand _comandoSql;
        private Conexao _conexaoBanco;

        public FuncionarioDal()
        {
            _conexaoBanco = new Conexao();
            _conexaoFuncionarios = _conexaoBanco.obterConexao();
        }

        private int obterProximoId()
        {
            int codigo = 0;

            try
            {
                _comandoSql = new SqlCommand();
                _comandoSql.Connection = _conexaoFuncionarios;
                _comandoSql.CommandText = " select isnull(max(funid) , 0) + 1 as codigo " +
                "from tblfuncionario ";

                codigo = int.Parse(_comandoSql.ExecuteScalar().ToString());

                return codigo;
            }
            catch (Exception ex)
            {
                return -1;
                throw new Exception(ex.Message);
            }

        }

        public void inserir(FuncionariosModel parFun)

        {
            int codigo = obterProximoId();

            try
            {
                _comandoSql = new SqlCommand();
                _comandoSql.Connection = _conexaoFuncionarios;
                _comandoSql.CommandText =
                    "insert into tblfuncionario (funid , funnome , funidade , funcpf , funpis  , funsexo)" +
                    "values (@funid , @funnome , @funidade , @funcpf , @funpis  , @funsexo) ";
                _comandoSql.Parameters.Add("@funid", SqlDbType.Int).Value = codigo;
                _comandoSql.Parameters.Add("@funnome", SqlDbType.VarChar).Value = parFun.Nome;
                _comandoSql.Parameters.Add("@funidade", SqlDbType.Int).Value = parFun.Idade;
                _comandoSql.Parameters.Add("@funcpf", SqlDbType.BigInt).Value = parFun.Cpf;
                _comandoSql.Parameters.Add("@funpis", SqlDbType.BigInt).Value = parFun.Pis;
                _comandoSql.Parameters.Add("@funsexo", SqlDbType.VarChar).Value = parFun.Sexo;
                _comandoSql.ExecuteNonQuery();


            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }



        public void excluir(int parCodigoFun)
        {
            try
            {
                _comandoSql = new SqlCommand();
                _comandoSql.Connection = _conexaoFuncionarios;
                _comandoSql.CommandText =
                    "delete from tblfuncionario" +
                    " where funid = @funid";

                _comandoSql.Parameters.Add("@funid", SqlDbType.Int).Value = parCodigoFun;
                _comandoSql.ExecuteNonQuery();

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        public DataTable listarTodos()
        {
            DataTable tabela;
            SqlDataAdapter adaptador;

            try
            {
                _comandoSql = new SqlCommand();
                _comandoSql.Connection = _conexaoFuncionarios;
                _comandoSql.CommandText =
                    "select funid , funnome , funidade , funcpf , funpis  , funsexo" +
                    "from tblfuncionario " +
                    "order by funnome asc ";

                tabela = new DataTable();

                adaptador = new SqlDataAdapter(_comandoSql);
                adaptador.Fill(tabela);

                return tabela;
            }
            catch (Exception ex)
            {
                return null;
                throw new Exception(ex.Message);
            }
        }

        public List<FuncionariosModel> listarTodosArray()
        {
            List<FuncionariosModel> lista = new List<FuncionariosModel>();
            SqlDataReader leitor;

            try
            {
                _comandoSql = new SqlCommand();
                _comandoSql.Connection = _conexaoFuncionarios;
                _comandoSql.CommandText =
                    "select funid , funnome , funidade , funcpf , funpis  , funsexo" +
                    "    from tblfuncionario " +
                    "order by funnome asc ";

                leitor = _comandoSql.ExecuteReader();
                while (leitor.Read())
                {
                    FuncionariosModel item = new FuncionariosModel();
                    item.Codigo = Convert.ToInt32(leitor["funid"]);
                    item.Nome = leitor["funnome"].ToString();
                    item.Idade = Convert.ToInt32(leitor["funidade"]);
                    item.Cpf = Convert.ToInt64(leitor["funcpf"]);
                    item.Pis = Convert.ToInt64(leitor["funpis"]);
                    item.Sexo = leitor["funsexo"].ToString();


                    lista.Add(item);
                }

                leitor.Close();
                return lista;


            }
            catch (Exception ex)
            {
                return null;
                throw new Exception(ex.Message);
            }
        }
    }
}
