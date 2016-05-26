using SysOtica.Negocio.Classes_Basicas;
using SysOtica.Negocio.Excecoes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SysOtica.Conexao
{
    public class UsuarioDados : IUsuarioDados
    {
        ConexaoBD conn = new ConexaoBD();

        public void inserirUsuario(Usuario usu)
        {
            try {

            conn.AbrirConexao();
                string sql = "INSERT INTO usuario (us_senha, us_endereco, us_telefone, us_tipo, us_usuario, us_nome) values (@us_senha, @us_endereco, @us_telefone, @us_tipo, @us_usuario, @us_nome)";
            //instrucao a ser executada
            SqlCommand cmd = new SqlCommand(sql,conn.cone);

            cmd.Parameters.Add("@us_senha", SqlDbType.VarChar);
            cmd.Parameters["@us_senha"].Value = usu.Us_senha;

            cmd.Parameters.Add("@us_endereco", SqlDbType.VarChar);
            cmd.Parameters["@us_endereco"].Value = usu.Us_endereco;

            cmd.Parameters.Add("@us_telefone", SqlDbType.VarChar);
            cmd.Parameters["@us_telefone"].Value = usu.Us_telefone;

            cmd.Parameters.Add("@us_tipo", SqlDbType.VarChar);
            cmd.Parameters["@us_tipo"].Value = usu.Us_tipo;

            cmd.Parameters.Add("@us_usuario", SqlDbType.VarChar);
            cmd.Parameters["@us_usuario"].Value = usu.Us_usuario;

            cmd.Parameters.Add("@us_nome", SqlDbType.VarChar);
            cmd.Parameters["@us_nome"].Value = usu.Us_nome;

            //executando a instrucao 
            cmd.ExecuteNonQuery();
            //liberando a memoria 
            cmd.Dispose();
            //fechando a conexao
            conn.FecharConexao();

            }
            catch (SqlException e)
            {
                throw new BancoDeDadosException("Falha na comunicação com o banco de dados. \n" + e.Message);
            }


        }

        public void alteraUsuario(Usuario usu)
        {
            try
            {
                //abrir a conexão
                conn.AbrirConexao();
                string sql = "UPDATE usuario SET us_senha = @us_senha, us_endereco = @us_endereco, us_telefone = @us_telefone,us_tipo = @us_tipo, us_usuario = @us_usuario,us_nome = @us_nome WHERE us_id = @us_id";
                //instrucao a ser executada
                SqlCommand cmd = new SqlCommand(sql, conn.cone);

                cmd.Parameters.Add("@us_id", SqlDbType.Int);
                cmd.Parameters["@us_id"].Value = usu.Us_id;

                cmd.Parameters.Add("@us_senha", SqlDbType.VarChar);
                cmd.Parameters["@us_senha"].Value = usu.Us_senha;

                cmd.Parameters.Add("@us_endereco", SqlDbType.VarChar);
                cmd.Parameters["@us_endereco"].Value = usu.Us_endereco;

                cmd.Parameters.Add("@us_telefone", SqlDbType.VarChar);
                cmd.Parameters["@us_telefone"].Value = usu.Us_telefone;

                cmd.Parameters.Add("@us_tipo", SqlDbType.VarChar);
                cmd.Parameters["@us_tipo"].Value = usu.Us_tipo;

                cmd.Parameters.Add("@us_usuario", SqlDbType.VarChar);
                cmd.Parameters["@us_usuario"].Value = usu.Us_usuario;

                cmd.Parameters.Add("@us_nome", SqlDbType.VarChar);
                cmd.Parameters["@us_nome"].Value = usu.Us_nome;

                //executando a instrucao 
                cmd.ExecuteNonQuery();
                //liberando a memoria 
                cmd.Dispose();
                //fechando a conexao
                conn.FecharConexao();
            }
            catch (SqlException e)
            {
                throw new BancoDeDadosException("Falha na comunicação com o banco de dados. \n" + e.Message);
            }



        }

        public void deleteUsuario(Usuario usu)
        {
          

            try
            {
                //abrir a conexão
                conn.AbrirConexao();
                string sql = "DELETE FROM usuario WHERE us_id = @us_id";
                //instrucao a ser executada
                SqlCommand cmd = new SqlCommand(sql, conn.cone);
                cmd.Parameters.Add("@cl_id", SqlDbType.Int);
                cmd.Parameters["@cl_id"].Value = usu.Us_id;
                //executando a instrucao 
                cmd.ExecuteNonQuery();
                //liberando a memoria 
                cmd.Dispose();
                //fechando a conexao
                conn.FecharConexao();
            }
            catch (SqlException e)
            {
                throw new BancoDeDadosException("Falha na comunicação com o banco de dados. \n" + e.Message);
            }


        }



        public List<Usuario> listaUsuario()

        {
            string sql = "SELECT  us_id, us_usuario, us_senha, us_nome,  us_tipo, us_endereco , us_telefone FROM Usuario";
            List<Usuario> lista = new List<Usuario>();
            Usuario usu;


            try
            {
                conn.AbrirConexao();
                SqlCommand cmd = new SqlCommand(sql, conn.cone);
                SqlDataReader retorno = cmd.ExecuteReader();

                while (retorno.Read())
                {
                    usu = new Usuario();

                    usu.Us_id = retorno.GetInt32(retorno.GetOrdinal("us_id"));
                    usu.Us_usuario = retorno.GetString(retorno.GetOrdinal("us_usuario"));
                    usu.Us_senha = retorno.GetString(retorno.GetOrdinal("us_senha"));
                    usu.Us_nome = retorno.GetString(retorno.GetOrdinal("us_nome"));
                    usu.Us_tipo = retorno.GetString(retorno.GetOrdinal("us_tipo"));
                    usu.Us_endereco = retorno.GetString(retorno.GetOrdinal("us_endereco"));
                    usu.Us_telefone = retorno.GetString(retorno.GetOrdinal("us_telefone"));
                    
                    

                    lista.Add(usu);
                }
                conn.FecharConexao();
                return lista;

            }
            catch (SqlException e)
            {
                throw new BancoDeDadosException("Falha na comunicação com o banco de dados. \n" + e.Message);
            }

        }


 
        public bool verificaduplicidade(Usuario usu)
        {
            throw new NotImplementedException();
        }

        public List<Usuario> pesquisaUsuario(string us_nome)
        {
            string sql = "SELECT  us_id, us_usuario, us_senha, us_nome,  us_tipo, us_endereco , us_telefone FROM Usuario Where us_nome LIKE @us_nome + '%'";
            List<Usuario> lista = new List<Usuario>();

            if (us_nome != "")
            {

                try
                {
                    conn.AbrirConexao();
                    SqlCommand cmd = new SqlCommand(sql, this.conn.cone);
                    cmd.Parameters.Add("@us_nome", SqlDbType.VarChar, 50).Value = us_nome;

                    SqlDataReader retorno = cmd.ExecuteReader();

                    if (retorno.HasRows == false)
                    {

                        MessageBox.Show("Usuário não cadastrado!");

                    }
                    while (retorno.Read())
                    {
                        Usuario usu = new Usuario();

                        usu.Us_id = retorno.GetInt32(retorno.GetOrdinal("us_id"));
                        usu.Us_usuario = retorno.GetString(retorno.GetOrdinal("us_usuario"));
                        usu.Us_senha = retorno.GetString(retorno.GetOrdinal("us_senha"));
                        usu.Us_nome = retorno.GetString(retorno.GetOrdinal("us_nome"));
                        usu.Us_tipo = retorno.GetString(retorno.GetOrdinal("us_tipo"));
                        usu.Us_endereco = retorno.GetString(retorno.GetOrdinal("us_endereco"));
                        usu.Us_telefone = retorno.GetString(retorno.GetOrdinal("us_telefone"));


                        lista.Add(usu);
                    }

                }

                catch (SqlException e)
                {
                    throw new BancoDeDadosException("Falha na comunicação com o banco de dados. \n" + e.Message);
                }
            }
            conn.FecharConexao();
            return lista;

        }

            
    }
}
