using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysOtica.Conexao
{
    public class ConexaoBD : IConexaoBD
    {

        public SqlConnection cone = new SqlConnection();

        string connectionStringSqlServer = @"Data Source=DESKTOP-G6CQ56U;Initial Catalog=sysOtica;UId=root;Password=123456";

        public ConnectionState State { get; internal set; }

        //DESKTOP-KA9UELE\SQLEXPRESS
        //DESKTOP-G6CQ56U //Uid=root
        //MRX-PC\MSSQLSERVERSYSOT

        public void AbrirConexao()
        {
            this.cone = new SqlConnection(connectionStringSqlServer);
            this.cone.Open();
        }
        public void FecharConexao()
        {
            this.cone.Close();
            this.cone.Dispose();
        }
    }
}