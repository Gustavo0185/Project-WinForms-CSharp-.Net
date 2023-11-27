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
    public class ExtratoDal
    {
        private SqlConnection _conexaoExtrato;
        private SqlCommand _comandoSql;
        private Conexao _conexaoBanco;

        public ExtratoDal()
        {
            _conexaoBanco = new Conexao();
            _conexaoExtrato = _conexaoBanco.obterConexao();
        }

        private int obterProximoId()
        {
            int codigo = 0;

            try
            {
                _comandoSql = new SqlCommand();
                _comandoSql.Connection = _conexaoExtrato;
                _comandoSql.CommandText = " select isnull(max(id) , 0) + 1 as codigo " +
                "from tblextrato ";

                codigo = int.Parse(_comandoSql.ExecuteScalar().ToString());

                return codigo;
            }
            catch (Exception ex)
            {
                return -1;
                throw new Exception(ex.Message);
            }

        }

        public void inserir(ExtratoModel parEx)

        {
            int codigo = obterProximoId();

            try
            {
                _comandoSql = new SqlCommand();
                _comandoSql.Connection = _conexaoExtrato;
                _comandoSql.CommandText =
                    "insert into tblextrato (id , nome , cargo , vlhr ,salabr , impr , inss , salali )" +
                    "values (@id , @nome , @cargo , @salabr , @vlhr , @impr , @inss , @salali) ";
                _comandoSql.Parameters.Add("@id", SqlDbType.Int).Value = codigo;
                _comandoSql.Parameters.Add("@nome", SqlDbType.VarChar).Value = parEx.Nome;
                _comandoSql.Parameters.Add("@cargo", SqlDbType.VarChar).Value = parEx.Cargo;
                _comandoSql.Parameters.Add("@salabr", SqlDbType.Decimal).Value = parEx.SalaB;
                _comandoSql.Parameters.Add("@vlhr", SqlDbType.Decimal).Value = parEx.VlHr;
                _comandoSql.Parameters.Add("@impr", SqlDbType.Decimal).Value = parEx.ImpR;
                _comandoSql.Parameters.Add("@inss", SqlDbType.Decimal).Value = parEx.Inss;
                _comandoSql.Parameters.Add("@salali", SqlDbType.Decimal).Value = parEx.SalaL;
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
                _comandoSql.Connection = _conexaoExtrato;
                _comandoSql.CommandText =
                    "delete from tblextrato" +
                    " where id = @id";

                _comandoSql.Parameters.Add("@id", SqlDbType.Int).Value = parCodigoFun;
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
                _comandoSql.Connection = _conexaoExtrato;
                _comandoSql.CommandText =
                    "select id , nome , cargo , salabr , vlhr , impr , inss , salali " +
                    "from tblextrato " +
                    "order by nome asc ";

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

        public List<ExtratoModel> listarTodosArray()
        {
            List<ExtratoModel> lista = new List<ExtratoModel>();
            SqlDataReader leitor;

            try
            {
                _comandoSql = new SqlCommand();
                _comandoSql.Connection = _conexaoExtrato;
                _comandoSql.CommandText =
                    "select id , nome , cargo , salabr , vlhr , impr , inss , salali " +
                    "    from tblextrato " +
                    "order by nome asc ";

                leitor = _comandoSql.ExecuteReader();
                while (leitor.Read())
                {
                    ExtratoModel item = new ExtratoModel();
                    item.Codigo = Convert.ToInt32(leitor["id"]);
                    item.Nome = leitor["nome"].ToString();
                    item.Cargo = leitor["cargo"].ToString();
                    item.SalaB = Convert.ToDecimal(leitor["salabr"]);
                    item.VlHr = Convert.ToDecimal(leitor["vlhr"]);
                    item.ImpR = Convert.ToDecimal(leitor["impr"]);
                    item.Inss = Convert.ToDecimal(leitor["inss"]);
                    item.SalaL = Convert.ToDecimal(leitor["salali"]);


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
