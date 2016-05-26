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
    public class ClienteDados : IClienteDados
    {
        ConexaoBD conn = new ConexaoBD();

        public void inserirCliente(Cliente c)
        {

            try
            {
                conn.AbrirConexao();
                string sql = "INSERT INTO Cliente(cl_nome, cl_datanascimento, cl_cpf, cl_rg, cl_telefone, cl_celular, cl_telefone2, cl_cep, cl_endereco, cl_numero, cl_bairro, cl_cidade, cl_uf, cl_email, cl_nomepai, cl_nomemae, cl_profissao, cl_observacoes) Values (@cl_nome, @cl_datanascimento, @cl_cpf, @cl_rg, @cl_telefone, @cl_celular, @cl_telefone2, @cl_cep, @cl_endereco, @cl_numero, @cl_bairro, @cl_cidade, @cl_uf, @cl_email, @cl_nomepai, @cl_nomemae, @cl_profissao, @cl_observacoes)";
                //instrucao a ser executada
                SqlCommand cmd = new SqlCommand(sql, conn.cone);

                cmd.Parameters.Add("@cl_nome", SqlDbType.VarChar);
                cmd.Parameters["@cl_nome"].Value = c.Cl_nome;

                cmd.Parameters.Add("@cl_datanascimento", SqlDbType.Date);
                cmd.Parameters["@cl_datanascimento"].Value = c.Cl_datanascimento;

                cmd.Parameters.Add("@cl_cpf", SqlDbType.VarChar);
                cmd.Parameters["@cl_cpf"].Value = c.Cl_cpf;

                cmd.Parameters.Add("@cl_rg", SqlDbType.VarChar);
                cmd.Parameters["@cl_rg"].Value = c.Cl_rg;

                cmd.Parameters.Add("@cl_telefone", SqlDbType.VarChar);
                cmd.Parameters["@cl_telefone"].Value = c.Cl_telefone;

                cmd.Parameters.Add("@cl_celular", SqlDbType.VarChar);
                cmd.Parameters["@cl_celular"].Value = c.Cl_celular;

                cmd.Parameters.Add("@cl_telefone2", SqlDbType.VarChar);
                cmd.Parameters["@cl_telefone2"].Value = c.Cl_telefone2;

                cmd.Parameters.Add("@cl_cep", SqlDbType.VarChar);
                cmd.Parameters["@cl_cep"].Value = c.Cl_cep;

                cmd.Parameters.Add("@cl_endereco", SqlDbType.VarChar);
                cmd.Parameters["@cl_endereco"].Value = c.Cl_endereco;

                cmd.Parameters.Add("@cl_numero", SqlDbType.VarChar);
                cmd.Parameters["@cl_numero"].Value = c.Cl_numero;

                cmd.Parameters.Add("@cl_bairro", SqlDbType.VarChar);
                cmd.Parameters["@cl_bairro"].Value = c.Cl_bairro;

                cmd.Parameters.Add("@cl_cidade", SqlDbType.VarChar);
                cmd.Parameters["@cl_cidade"].Value = c.Cl_cidade;

                cmd.Parameters.Add("@cl_uf", SqlDbType.VarChar);
                cmd.Parameters["@cl_uf"].Value = c.Cl_uf;

                cmd.Parameters.Add("@cl_email", SqlDbType.VarChar);
                cmd.Parameters["@cl_email"].Value = c.Cl_email;

                cmd.Parameters.Add("@cl_nomepai", SqlDbType.VarChar);
                cmd.Parameters["@cl_nomepai"].Value = c.Cl_nomepai;

                cmd.Parameters.Add("@cl_nomemae", SqlDbType.VarChar);
                cmd.Parameters["@cl_nomemae"].Value = c.Cl_nomemae;

                cmd.Parameters.Add("@cl_profissao", SqlDbType.VarChar);
                cmd.Parameters["@cl_profissao"].Value = c.Cl_profissao;

                cmd.Parameters.Add("@cl_observacoes", SqlDbType.VarChar);
                cmd.Parameters["@cl_observacoes"].Value = c.Cl_observacoes;


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
        public void alterarCliente(Cliente c)
        {

            try
            {
                //abrir a conexão
                conn.AbrirConexao();
                string sql = "UPDATE Cliente SET  cl_nome = @cl_nome, cl_datanascimento = @cl_datanascimento, cl_cpf	= @cl_cpf, cl_rg = @cl_rg, cl_telefone = @cl_telefone, cl_celular = @cl_celular, cl_telefone2 = @cl_telefone2, cl_cep = @cl_cep, cl_endereco = @cl_endereco, cl_numero = @cl_numero, cl_bairro	= @cl_bairro, cl_cidade = @cl_cidade, cl_uf = @cl_uf, cl_email = @cl_email, cl_nomepai = @cl_nomepai, cl_nomemae = @cl_nomemae, cl_profissao = @cl_profissao, cl_observacoes = @cl_observacoes WHERE cl_id = @cl_id;";
                //instrucao a ser executada
                SqlCommand cmd = new SqlCommand(sql, conn.cone);

                cmd.Parameters.Add("@cl_id", SqlDbType.Int);
                cmd.Parameters["@cl_id"].Value = c.Cl_id;

                cmd.Parameters.Add("@cl_nome", SqlDbType.VarChar);
                cmd.Parameters["@cl_nome"].Value = c.Cl_nome;

                cmd.Parameters.Add("@cl_datanascimento", SqlDbType.Date);
                cmd.Parameters["@cl_datanascimento"].Value = c.Cl_datanascimento;

                cmd.Parameters.Add("@cl_cpf", SqlDbType.VarChar);
                cmd.Parameters["@cl_cpf"].Value = c.Cl_cpf;

                cmd.Parameters.Add("@cl_rg", SqlDbType.VarChar);
                cmd.Parameters["@cl_rg"].Value = c.Cl_rg;

                cmd.Parameters.Add("@cl_telefone", SqlDbType.VarChar);
                cmd.Parameters["@cl_telefone"].Value = c.Cl_telefone;

                cmd.Parameters.Add("@cl_celular", SqlDbType.VarChar);
                cmd.Parameters["@cl_celular"].Value = c.Cl_celular;

                cmd.Parameters.Add("@cl_telefone2", SqlDbType.VarChar);
                cmd.Parameters["@cl_telefone2"].Value = c.Cl_telefone2;

                cmd.Parameters.Add("@cl_cep", SqlDbType.VarChar);
                cmd.Parameters["@cl_cep"].Value = c.Cl_cep;

                cmd.Parameters.Add("@cl_endereco", SqlDbType.VarChar);
                cmd.Parameters["@cl_endereco"].Value = c.Cl_endereco;

                cmd.Parameters.Add("@cl_numero", SqlDbType.VarChar);
                cmd.Parameters["@cl_numero"].Value = c.Cl_numero;

                cmd.Parameters.Add("@cl_bairro", SqlDbType.VarChar);
                cmd.Parameters["@cl_bairro"].Value = c.Cl_bairro;

                cmd.Parameters.Add("@cl_cidade", SqlDbType.VarChar);
                cmd.Parameters["@cl_cidade"].Value = c.Cl_cidade;

                cmd.Parameters.Add("@cl_uf", SqlDbType.VarChar);
                cmd.Parameters["@cl_uf"].Value = c.Cl_uf;

                cmd.Parameters.Add("@cl_email", SqlDbType.VarChar);
                cmd.Parameters["@cl_email"].Value = c.Cl_email;

                cmd.Parameters.Add("@cl_nomepai", SqlDbType.VarChar);
                cmd.Parameters["@cl_nomepai"].Value = c.Cl_nomepai;

                cmd.Parameters.Add("@cl_nomemae", SqlDbType.VarChar);
                cmd.Parameters["@cl_nomemae"].Value = c.Cl_nomemae;

                cmd.Parameters.Add("@cl_profissao", SqlDbType.VarChar);
                cmd.Parameters["@cl_profissao"].Value = c.Cl_profissao;

                cmd.Parameters.Add("@cl_observacoes", SqlDbType.VarChar);
                cmd.Parameters["@cl_observacoes"].Value = c.Cl_observacoes;

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
        public void excluirCliente(Cliente c)
        {
            try
            {

                //abrir a conexão
                conn.AbrirConexao();
                string sql = "DELETE FROM Cliente WHERE cl_id = @cl_id";
                //instrucao a ser executada
                SqlCommand cmd = new SqlCommand(sql, conn.cone);
                cmd.Parameters.Add("@cl_id", SqlDbType.Int);
                cmd.Parameters["@cl_id"].Value = c.Cl_id;
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


        public List<Cliente> listarCliente()
        {
            string sql = "SELECT  cl_id, cl_nome,cl_datanascimento, cl_cpf, cl_rg, cl_telefone,cl_celular, cl_telefone2,cl_cep,cl_endereco,cl_numero, cl_bairro,cl_cidade, cl_uf,cl_email,cl_nomepai,cl_nomemae, cl_profissao, cl_observacoes FROM Cliente";
            List<Cliente> lista = new List<Cliente>();
            Cliente c;
            try
            {
                conn.AbrirConexao();
                SqlCommand cmd = new SqlCommand(sql, conn.cone);
                SqlDataReader retorno = cmd.ExecuteReader();

                while (retorno.Read())
                {
                    c = new Cliente();
                    c.Cl_id = retorno.GetInt32(retorno.GetOrdinal("cl_id"));
                    c.Cl_nome = retorno.GetString(retorno.GetOrdinal("cl_nome"));
                    c.Cl_datanascimento = retorno.GetDateTime(retorno.GetOrdinal("cl_datanascimento"));
                    c.Cl_cpf = retorno.GetString(retorno.GetOrdinal("cl_cpf"));
                    c.Cl_rg = retorno.GetString(retorno.GetOrdinal("cl_rg"));
                    c.Cl_telefone = retorno.GetString(retorno.GetOrdinal("cl_telefone"));
                    c.Cl_celular = retorno.GetString(retorno.GetOrdinal("cl_celular"));
                    c.Cl_telefone2 = retorno.GetString(retorno.GetOrdinal("cl_telefone2"));
                    c.Cl_cep = retorno.GetString(retorno.GetOrdinal("cl_cep"));
                    c.Cl_endereco = retorno.GetString(retorno.GetOrdinal("cl_endereco"));
                    c.Cl_numero = retorno.GetString(retorno.GetOrdinal("cl_numero"));
                    c.Cl_bairro = retorno.GetString(retorno.GetOrdinal("cl_bairro"));
                    c.Cl_cidade = retorno.GetString(retorno.GetOrdinal("cl_cidade"));
                    c.Cl_uf = retorno.GetString(retorno.GetOrdinal("cl_uf"));
                    c.Cl_email = retorno.GetString(retorno.GetOrdinal("cl_email"));
                    c.Cl_nomepai = retorno.GetString(retorno.GetOrdinal("cl_nomepai"));
                    c.Cl_nomemae = retorno.GetString(retorno.GetOrdinal("cl_nomemae"));
                    c.Cl_profissao = retorno.GetString(retorno.GetOrdinal("cl_profissao"));
                    c.Cl_observacoes = retorno.GetString(retorno.GetOrdinal("cl_observacoes"));
                    lista.Add(c);
                }
                conn.FecharConexao();
                return lista;

            }
            catch (SqlException e)
            {
                throw new BancoDeDadosException("Falha na comunicação com o banco de dados. \n" + e.Message);
            }
        }


        public List<Cliente> pesquisarCliente(string cl_nome)
        {
            string sql = "SELECT  cl_id, cl_nome,cl_datanascimento,cl_cpf,cl_rg, cl_telefone,cl_celular, cl_telefone2,cl_cep,cl_endereco,cl_numero, cl_bairro,cl_cidade, cl_uf,cl_email,cl_nomepai,cl_nomemae, cl_profissao, cl_observacoes FROM Cliente where cl_nome LIKE @cl_nome + '%'";

            List<Cliente> lista = new List<Cliente>();

            if (cl_nome != "")
            {

                try
                {
                    conn.AbrirConexao();
                    SqlCommand cmd = new SqlCommand(sql, this.conn.cone);
                    cmd.Parameters.Add("@cl_nome", SqlDbType.VarChar, 100).Value = cl_nome;

                    SqlDataReader retorno = cmd.ExecuteReader();


                    if (retorno.HasRows == false)
                    {

                        MessageBox.Show("Cliente não cadastrado!");

                    }


                    while (retorno.Read())
                    {
                        Cliente c = new Cliente();
                        c.Cl_id = retorno.GetInt32(retorno.GetOrdinal("cl_id"));
                        c.Cl_nome = retorno.GetString(retorno.GetOrdinal("cl_nome"));
                        c.Cl_datanascimento = retorno.GetDateTime(retorno.GetOrdinal("cl_datanascimento"));
                        c.Cl_cpf = retorno.GetString(retorno.GetOrdinal("cl_cpf"));
                        c.Cl_rg = retorno.GetString(retorno.GetOrdinal("cl_rg"));
                        c.Cl_telefone = retorno.GetString(retorno.GetOrdinal("cl_telefone"));
                        c.Cl_celular = retorno.GetString(retorno.GetOrdinal("cl_celular"));
                        c.Cl_telefone2 = retorno.GetString(retorno.GetOrdinal("cl_telefone2"));
                        c.Cl_cep = retorno.GetString(retorno.GetOrdinal("cl_cep"));
                        c.Cl_endereco = retorno.GetString(retorno.GetOrdinal("cl_endereco"));
                        c.Cl_numero = retorno.GetString(retorno.GetOrdinal("cl_numero"));
                        c.Cl_bairro = retorno.GetString(retorno.GetOrdinal("cl_bairro"));
                        c.Cl_cidade = retorno.GetString(retorno.GetOrdinal("cl_cidade"));
                        c.Cl_uf = retorno.GetString(retorno.GetOrdinal("cl_uf"));
                        c.Cl_email = retorno.GetString(retorno.GetOrdinal("cl_email"));
                        c.Cl_nomepai = retorno.GetString(retorno.GetOrdinal("cl_nomepai"));
                        c.Cl_nomemae = retorno.GetString(retorno.GetOrdinal("cl_nomemae"));
                        c.Cl_profissao = retorno.GetString(retorno.GetOrdinal("cl_profissao"));
                        c.Cl_observacoes = retorno.GetString(retorno.GetOrdinal("cl_observacoes"));
                        lista.Add(c);
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

        public List<Cliente> getCliente(int cl_id)
        {
            string sql = "SELECT  cl_id, cl_nome,cl_datanascimento,cl_cpf,cl_rg, cl_telefone,cl_celular, cl_telefone2,cl_cep,cl_endereco,cl_numero, cl_bairro,cl_cidade, cl_uf,cl_email,cl_nomepai,cl_nomemae, cl_profissao, cl_observacoes FROM Cliente WHERE cl_id = @cl_id";

            List<Cliente> lista = new List<Cliente>();
            Cliente c = new Cliente();

            try
            {
                conn.AbrirConexao();
                SqlCommand cmd = new SqlCommand(sql, conn.cone);

                cmd.Parameters.Add("@cl_id", SqlDbType.Int);
                cmd.Parameters["@cl_id"].Value = c.Cl_id;


                SqlDataReader retorno = cmd.ExecuteReader();
                while (retorno.Read())
                {
                    c = new Cliente();
                    c.Cl_id = retorno.GetInt32(retorno.GetOrdinal("cl_id"));
                    c.Cl_nome = retorno.GetString(retorno.GetOrdinal("cl_nome"));
                    c.Cl_datanascimento = retorno.GetDateTime(retorno.GetOrdinal("cl_dtnascimento"));
                    c.Cl_cpf = retorno.GetString(retorno.GetOrdinal("cl_cpf"));
                    c.Cl_rg = retorno.GetString(retorno.GetOrdinal("cl_rg"));
                    c.Cl_telefone = retorno.GetString(retorno.GetOrdinal("cl_telefone"));
                    c.Cl_celular = retorno.GetString(retorno.GetOrdinal("cl_celular"));
                    c.Cl_telefone2 = retorno.GetString(retorno.GetOrdinal("cl_telefone2"));
                    c.Cl_cep = retorno.GetString(retorno.GetOrdinal("cl_cep"));
                    c.Cl_endereco = retorno.GetString(retorno.GetOrdinal("cl_endereco"));
                    c.Cl_numero = retorno.GetString(retorno.GetOrdinal("cl_numero"));
                    c.Cl_bairro = retorno.GetString(retorno.GetOrdinal("cl_bairro"));
                    c.Cl_cidade = retorno.GetString(retorno.GetOrdinal("cl_cidade"));
                    c.Cl_uf = retorno.GetString(retorno.GetOrdinal("cl_uf"));
                    c.Cl_email = retorno.GetString(retorno.GetOrdinal("cl_email"));
                    c.Cl_nomepai = retorno.GetString(retorno.GetOrdinal("cl_nomepai"));
                    c.Cl_nomemae = retorno.GetString(retorno.GetOrdinal("cl_nomemae"));
                    c.Cl_profissao = retorno.GetString(retorno.GetOrdinal("cl_profissao"));
                    c.Cl_observacoes = retorno.GetString(retorno.GetOrdinal("cl_observacoes"));
                    lista.Add(c);
                }
                return lista;
            }
            catch (SqlException e)
            {
                throw new BancoDeDadosException("Falha na comunicação com o banco de dados. \n" + e.Message);
            }
        }

    }
}
