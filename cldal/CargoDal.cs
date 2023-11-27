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
    public class CargoDal
    {
        private SqlConnection _conexaoCargo;
        private SqlCommand _comandoSql;
        private Conexao _conexaoBanco;

        public CargoDal()
        {
            _conexaoBanco = new Conexao();
            _conexaoCargo = _conexaoBanco.obterConexao();
        }

        private int obterProximoId()
        {
            int codigo = 0;

            try
            {
                _comandoSql = new SqlCommand();
                _comandoSql.Connection = _conexaoCargo;
                _comandoSql.CommandText = " select isnull(max(carid) , 0) + 1 as codigo " +
                "from tblcargo";

                codigo = int.Parse(_comandoSql.ExecuteScalar().ToString());

                return codigo;
            }
            catch (Exception ex)
            {
                return -1;
                throw new Exception(ex.Message);
            }

        }

        public void inserir(CargoModel parCargo)

        {
            int codigo = obterProximoId();

            try
            {
                _comandoSql = new SqlCommand();
                _comandoSql.Connection = _conexaoCargo;
                _comandoSql.CommandText =
                    "insert into tblcargo (carid, carcargo , carsalario )" +
                    "values (@carid, @carcargo , @carsalario ) ";
                _comandoSql.Parameters.Add("@carid", SqlDbType.Float).Value = codigo;
                _comandoSql.Parameters.Add("@carcargo", SqlDbType.VarChar).Value = parCargo.Cargo;
                _comandoSql.Parameters.Add("@carsalario", SqlDbType.Decimal).Value = parCargo.Salario;

                _comandoSql.ExecuteNonQuery();


            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        

        public void excluir(int parCodigoCargo)
        {
            try
            {
                _comandoSql = new SqlCommand();
                _comandoSql.Connection = _conexaoCargo;
                _comandoSql.CommandText =
                    "delete from tblcargo" +
                    " where carid = @carid";

                _comandoSql.Parameters.Add("@carid", SqlDbType.Int).Value = parCodigoCargo;
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
                _comandoSql.Connection = _conexaoCargo;
                _comandoSql.CommandText =
                    "select carid , carcargo , carsalario" +
                    "from tblcargo " +
                    "order by carcargo asc ";

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

        public List<CargoModel> listarTodosArray()
        {
            List<CargoModel> lista = new List<CargoModel>();
            SqlDataReader leitor;

            try
            {
                _comandoSql = new SqlCommand();
                _comandoSql.Connection = _conexaoCargo;
                _comandoSql.CommandText =
                    "select carid , carcargo , carsalario " +
                    "    from tblcargo " +
                    "order by carcargo asc ";

                leitor = _comandoSql.ExecuteReader();
                while (leitor.Read())
                {
                    CargoModel item = new CargoModel();
                    item.Codigo = Convert.ToInt32(leitor["carid"]);
                    item.Cargo = leitor["carcargo"].ToString();
                    item.Salario = Convert.ToDecimal(leitor["carsalario"]);


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
