using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciamentoProdutos.Data.EF
{
    public class DadosConexao
    {
        public static String servidor = @"DESKTOP-6VTUT16\SQLEXPRESS";
        public static String banco = "testeDBAg";
        public static String usuario = "sa";
        public static String senha = "832285";

        public static String StringDeConexao
        {
            get
            {
                return @"Data Source=" + servidor + ";Initial Catalog=" + banco + ";User ID=" + usuario + ";Password=" + senha;
            }
        }
    }
}
