using System;
using System.Configuration;
using System.Data.SqlClient;

namespace GerenciamentoProdutos.Data.ADONET
{
    public class GerencimanetoProdutoDataContextADO : IDisposable
    {
        private readonly SqlConnection _conection;

        public GerencimanetoProdutoDataContextADO()
        {
            var ConectionString = ConfigurationManager.ConnectionStrings["gerenciaProduto"].ConnectionString;
            _conection = new SqlConnection(ConectionString);
            _conection.Open();
        }

        public void ExecutCommand(String sql)
        {
            var command = new SqlCommand()
            {
                CommandText = sql,
                CommandType = System.Data.CommandType.Text,
                Connection = _conection

            };
            command.ExecuteNonQuery();
        }


        public SqlDataReader ExecutCommand_Query(String sql)
        {
            try
            {


                var command = new SqlCommand(sql, _conection);
                return command.ExecuteReader();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
      
        }


        public void Dispose()
        {
            if (_conection.State == System.Data.ConnectionState.Open)
            {
                _conection.Close();
            }
        }
    }
}
