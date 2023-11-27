using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;

namespace cldal
{
    public class Conexao
    {
        private SqlConnection _conexao;
        private SqlCommand _comandoSql;
        private String _stringConexao =
            "Data Source=DESKTOP-BB2OFFN; " +
            "Initial Catalog=PayrollTech; " +
            "Integrated Security=true; ";

        public SqlConnection obterConexao()
        {
            try
            {
                _conexao = new SqlConnection(_stringConexao);
                _conexao.Open();
                return _conexao;
            }
            catch (Exception ex)
            {
                return null;
                throw new Exception(ex.Message);
            }


        }


        public void fecharConexao(SqlConnection parConexao)
        {
            try
            {
                if (parConexao != null)
                {
                    if (parConexao.State == ConnectionState.Open)
                    {
                        parConexao.Close();
                    }

                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

    }
}
