using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;

using clmodel;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Input;


namespace cldal
{
    public class LoginDal
    {
        private SqlConnection _conexaoLogin;
        private SqlCommand _comandoSql;
        private Conexao _conexaoBanco;

        public LoginDal()
        {
            _conexaoBanco = new Conexao();
            _conexaoLogin = _conexaoBanco.obterConexao();
        }



        public void inserirU(LoginModel parLogin)

        {

            try
            {
                _comandoSql = new SqlCommand();
                _comandoSql.Connection = _conexaoLogin;
                _comandoSql.CommandText =
                    "insert into Usuarios (Username , Password)" +
                    "values (@Username , @Password) ";
                _comandoSql.Parameters.Add("@Username", SqlDbType.VarChar).Value = parLogin.Usuario;
                _comandoSql.Parameters.Add("@Password", SqlDbType.VarChar).Value = parLogin.Senha;
                _comandoSql.ExecuteNonQuery();


            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void atualizarU(LoginModel parLogin)
        {
            try
            {
                _comandoSql = new SqlCommand();
                _comandoSql.Connection = _conexaoLogin;
                _comandoSql.CommandText =
                    "update Usuarios" +
                    " set Username = @Username, " +
                    "     Password = @Password, ";
                _comandoSql.Parameters.Add("@Username", SqlDbType.VarChar).Value = parLogin.Usuario;
                _comandoSql.Parameters.Add("@Password", SqlDbType.VarChar).Value = parLogin.Senha;
                _comandoSql.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }


        }

        public bool ObterUsriario(string username, string password)
        {
            bool achou = false;
            SqlDataReader leitor;

            try
            {
                _comandoSql = new SqlCommand();
                _comandoSql.Connection = _conexaoLogin;
                _comandoSql.CommandText =
                    "select Username" +
                    "    from Usuarios " +
                    " WHERE Username = @Username " +
                    " AND Password = @Password";
                _comandoSql.Parameters.Add("@Username", SqlDbType.VarChar, 50).Value = username;
                _comandoSql.Parameters.Add("@Password", SqlDbType.VarChar, 100).Value = password;


                leitor = _comandoSql.ExecuteReader();
                if (leitor.Read())
                {
                    achou = true;
                }

                leitor.Close();
                return achou;
            }
            catch (Exception ex)
            {
                return false;
                throw new Exception(ex.Message);
            }

        }
    }
}


