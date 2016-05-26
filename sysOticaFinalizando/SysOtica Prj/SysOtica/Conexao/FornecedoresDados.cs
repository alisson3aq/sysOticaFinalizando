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
    public class FornecedoresDados : IFornecedorDados
    {
        ConexaoBD conn = new ConexaoBD();

        public void inserirFornecedor(Fornecedor fr)

        {
            try
            {
                //abrir a conexão
                conn.AbrirConexao();
                string sql = "INSERT INTO fornecedor ( fr_razaosocial, fr_inscricaoestadual, fr_fantasia, fr_endereco, fr_cidade, fr_uf, fr_bairro, fr_cep, fr_contato, fr_telefone, fr_fax, fr_email, fr_nomerepresentante, fr_telefonerepresentante, fr_celularrepresentante, fr_observacoes, fr_cnpj) VALUES (@fr_razaosocial, @fr_inscricaoestadual, @fr_fantasia, @fr_endereco, @fr_cidade, @fr_uf, @fr_bairro, @fr_cep, @fr_contato, @fr_telefone, @fr_fax, @fr_email, @fr_nomerepresentante, @fr_telefonerepresentante, @fr_celularrepresentante, @fr_observacoes, @fr_cnpj)";
                //instrucao a ser executada
                SqlCommand cmd = new SqlCommand(sql, conn.cone);

                cmd.Parameters.Add("@fr_razaosocial", SqlDbType.VarChar);
                cmd.Parameters["@fr_razaosocial"].Value = fr.Fr_razaosocial;

                cmd.Parameters.Add("@fr_inscricaoestadual", SqlDbType.VarChar);
                cmd.Parameters["@fr_inscricaoestadual"].Value = fr.Fr_inscricaoestadual;

                cmd.Parameters.Add("@fr_fantasia", SqlDbType.VarChar);
                cmd.Parameters["@fr_fantasia"].Value = fr.Fr_fantasia;

                cmd.Parameters.Add("@fr_endereco", SqlDbType.VarChar);
                cmd.Parameters["@fr_endereco"].Value = fr.Fr_endereco;

                cmd.Parameters.Add("@fr_cidade", SqlDbType.VarChar);
                cmd.Parameters["@fr_cidade"].Value = fr.Fr_cidade;

                cmd.Parameters.Add("@fr_uf", SqlDbType.VarChar);
                cmd.Parameters["@fr_uf"].Value = fr.Fr_uf;

                cmd.Parameters.Add("@fr_bairro", SqlDbType.VarChar);
                cmd.Parameters["@fr_bairro"].Value = fr.Fr_bairro;

                cmd.Parameters.Add("@fr_cep", SqlDbType.VarChar);
                cmd.Parameters["@fr_cep"].Value = fr.Fr_cep;

                cmd.Parameters.Add("@fr_contato", SqlDbType.VarChar);
                cmd.Parameters["@fr_contato"].Value = fr.Fr_contato;

                cmd.Parameters.Add("@fr_telefone", SqlDbType.VarChar);
                cmd.Parameters["@fr_telefone"].Value = fr.Fr_telefone;

                cmd.Parameters.Add("@fr_fax", SqlDbType.VarChar);
                cmd.Parameters["@fr_fax"].Value = fr.Fr_fax;

                cmd.Parameters.Add("@fr_email", SqlDbType.VarChar);
                cmd.Parameters["@fr_email"].Value = fr.Fr_email;

                cmd.Parameters.Add("@fr_nomerepresentante", SqlDbType.VarChar);
                cmd.Parameters["@fr_nomerepresentante"].Value = fr.Fr_nomerepresentante;

                cmd.Parameters.Add("@fr_telefonerepresentante", SqlDbType.VarChar);
                cmd.Parameters["@fr_telefonerepresentante"].Value = fr.Fr_telefonerepresentante;

                cmd.Parameters.Add("@fr_celularrepresentante", SqlDbType.VarChar);
                cmd.Parameters["@fr_celularrepresentante"].Value = fr.Fr_celularrepresentante;

                cmd.Parameters.Add("@fr_observacoes", SqlDbType.VarChar);
                cmd.Parameters["@fr_observacoes"].Value = fr.Fr_observacoes;

                cmd.Parameters.Add("@fr_cnpj", SqlDbType.VarChar);
                cmd.Parameters["@fr_cnpj"].Value = fr.Fr_cnpj;

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

        public void alteraFornecedor(Fornecedor fr)
        {

            try
            {
                //abrir a conexão
                conn.AbrirConexao();
                string sql = "UPDATE fornecedor SET  fr_razaosocial = @fr_razaosocial, fr_inscricaoestadual =@fr_inscricaoestadual, fr_fantasia = @fr_fantasia, fr_endereco =@fr_endereco, fr_cidade = @fr_cidade, fr_uf = @fr_uf, fr_bairro = @fr_bairro, fr_cep = @fr_cep, fr_contato = @fr_contato, fr_telefone = @fr_telefone, fr_fax = @fr_fax, fr_email =@fr_email, fr_nomerepresentante = @fr_nomerepresentante, fr_telefonerepresentante = @fr_telefonerepresentante, fr_celularrepresentante = @fr_celularrepresentante, fr_observacoes = @fr_observacoes, fr_cnpj = @fr_cnpj WHERE fr_id = @fr_id";
                //instrucao a ser executada
                SqlCommand cmd = new SqlCommand(sql, conn.cone);

                cmd.Parameters.Add("@fr_id", SqlDbType.Int);
                cmd.Parameters["@fr_id"].Value = fr.Fr_id;

                cmd.Parameters.Add("@fr_razaosocial", SqlDbType.VarChar);
                cmd.Parameters["@fr_razaosocial"].Value = fr.Fr_razaosocial;

                cmd.Parameters.Add("@fr_inscricaoestadual", SqlDbType.VarChar);
                cmd.Parameters["@fr_inscricaoestadual"].Value = fr.Fr_inscricaoestadual;

                cmd.Parameters.Add("@fr_fantasia", SqlDbType.VarChar);
                cmd.Parameters["@fr_fantasia"].Value = fr.Fr_fantasia;

                cmd.Parameters.Add("@fr_endereco", SqlDbType.VarChar);
                cmd.Parameters["@fr_endereco"].Value = fr.Fr_endereco;

                cmd.Parameters.Add("@fr_cidade", SqlDbType.VarChar);
                cmd.Parameters["@fr_cidade"].Value = fr.Fr_cidade;

                cmd.Parameters.Add("@fr_uf", SqlDbType.VarChar);
                cmd.Parameters["@fr_uf"].Value = fr.Fr_uf;

                cmd.Parameters.Add("@fr_bairro", SqlDbType.VarChar);
                cmd.Parameters["@fr_bairro"].Value = fr.Fr_bairro;

                cmd.Parameters.Add("@fr_cep", SqlDbType.VarChar);
                cmd.Parameters["@fr_cep"].Value = fr.Fr_cep;

                cmd.Parameters.Add("@fr_contato", SqlDbType.VarChar);
                cmd.Parameters["@fr_contato"].Value = fr.Fr_contato;

                cmd.Parameters.Add("@fr_telefone", SqlDbType.VarChar);
                cmd.Parameters["@fr_telefone"].Value = fr.Fr_telefone;

                cmd.Parameters.Add("@fr_fax", SqlDbType.VarChar);
                cmd.Parameters["@fr_fax"].Value = fr.Fr_fax;

                cmd.Parameters.Add("@fr_email", SqlDbType.VarChar);
                cmd.Parameters["@fr_email"].Value = fr.Fr_email;

                cmd.Parameters.Add("@fr_nomerepresentante", SqlDbType.VarChar);
                cmd.Parameters["@fr_nomerepresentante"].Value = fr.Fr_nomerepresentante;

                cmd.Parameters.Add("@fr_telefonerepresentante", SqlDbType.VarChar);
                cmd.Parameters["@fr_telefonerepresentante"].Value = fr.Fr_telefonerepresentante;

                cmd.Parameters.Add("@fr_celularrepresentante", SqlDbType.VarChar);
                cmd.Parameters["@fr_celularrepresentante"].Value = fr.Fr_celularrepresentante;

                cmd.Parameters.Add("@fr_observacoes", SqlDbType.VarChar);
                cmd.Parameters["@fr_observacoes"].Value = fr.Fr_observacoes;

                cmd.Parameters.Add("@fr_cnpj", SqlDbType.VarChar);
                cmd.Parameters["@fr_cnpj"].Value = fr.Fr_cnpj;

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

        public void excluiFornecedor(Fornecedor fr)
        {

         

            try
            {
                //abrir a conexão
                conn.AbrirConexao();
                string sql = "DELETE FROM fornecedor WHERE fr_id = @fr_id";
                //instrucao a ser executada
                SqlCommand cmd = new SqlCommand(sql, conn.cone);
                cmd.Parameters.Add("@fr_id", SqlDbType.Int);
                cmd.Parameters["@fr_id"].Value = fr.Fr_id;
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

        public List<Fornecedor> listaFornecedor()
        {
            string sql = "SELECT fr_id, fr_razaosocial, fr_inscricaoestadual, fr_fantasia, fr_endereco, fr_cidade, fr_uf, fr_bairro, fr_cep, fr_contato, fr_telefone, fr_fax, fr_email, fr_nomerepresentante, fr_celularrepresentante, fr_telefonerepresentante, fr_observacoes, fr_cnpj  FROM Fornecedor Order by fr_id";
            List<Fornecedor> lista = new List<Fornecedor>();
            Fornecedor fr;

            try
            {
                conn.AbrirConexao();
                SqlCommand cmd = new SqlCommand(sql, conn.cone);
                SqlDataReader retorno = cmd.ExecuteReader();



                while (retorno.Read())
                {
                    fr = new Fornecedor();
                    fr.Fr_id = retorno.GetInt32(retorno.GetOrdinal("fr_id"));
                    fr.Fr_razaosocial = retorno.GetString(retorno.GetOrdinal("fr_razaosocial"));
                    fr.Fr_inscricaoestadual = retorno.GetString(retorno.GetOrdinal("fr_inscricaoestadual"));
                    fr.Fr_fantasia = retorno.GetString(retorno.GetOrdinal("fr_fantasia"));
                    fr.Fr_endereco = retorno.GetString(retorno.GetOrdinal("fr_endereco"));
                    fr.Fr_cidade = retorno.GetString(retorno.GetOrdinal("fr_cidade"));
                    fr.Fr_uf = retorno.GetString(retorno.GetOrdinal("fr_uf"));
                    fr.Fr_bairro = retorno.GetString(retorno.GetOrdinal("fr_bairro"));
                    fr.Fr_cep = retorno.GetString(retorno.GetOrdinal("fr_cep"));
                    fr.Fr_contato = retorno.GetString(retorno.GetOrdinal("fr_contato"));
                    fr.Fr_telefone = retorno.GetString(retorno.GetOrdinal("fr_telefone"));
                    fr.Fr_fax = retorno.GetString(retorno.GetOrdinal("fr_fax"));
                    fr.Fr_email = retorno.GetString(retorno.GetOrdinal("fr_email"));
                    fr.Fr_nomerepresentante = retorno.GetString(retorno.GetOrdinal("fr_nomerepresentante"));
                    fr.Fr_celularrepresentante = retorno.GetString(retorno.GetOrdinal("fr_celularrepresentante"));
                    fr.Fr_telefonerepresentante = retorno.GetString(retorno.GetOrdinal("fr_telefonerepresentante"));
                    fr.Fr_observacoes = retorno.GetString(retorno.GetOrdinal("fr_observacoes"));
                    fr.Fr_cnpj = retorno.GetString(retorno.GetOrdinal("fr_cnpj"));

                    lista.Add(fr);
                }
                conn.FecharConexao();
                return lista;

            }
            catch (SqlException e)
            {
                throw new BancoDeDadosException("Falha na comunicação com o banco de dados. \n" + e.Message);
            }

        }

        public List<Fornecedor> pesquisarFornecedor(string fr_fantasia)
        {
            string sql = " SELECT fr_id, fr_razaosocial, fr_inscricaoestadual, fr_fantasia, fr_endereco, fr_cidade, fr_uf, fr_bairro, fr_cep, fr_contato, fr_telefone, fr_fax, fr_email, fr_nomerepresentante, fr_celularrepresentante, fr_telefonerepresentante, fr_observacoes, fr_cnpj FROM Fornecedor where fr_fantasia LIKE @fr_fantasia + '%'";
            List<Fornecedor> lista = new List<Fornecedor>();
            Fornecedor fr;
            if (fr_fantasia != "")
            {

                try
                {
                    conn.AbrirConexao();
                    SqlCommand cmd = new SqlCommand(sql, this.conn.cone);
                    cmd.Parameters.Add("@fr_fantasia", SqlDbType.VarChar, 50).Value = fr_fantasia;

                    SqlDataReader retorno = cmd.ExecuteReader();

                    if (retorno.HasRows == false)
                    {

                        MessageBox.Show("Nome Fantasia não cadastrado!");

                    }
                    while (retorno.Read())
                    {
                        fr = new Fornecedor();
                        fr.Fr_id = retorno.GetInt32(retorno.GetOrdinal("fr_id"));
                        fr.Fr_razaosocial = retorno.GetString(retorno.GetOrdinal("fr_razaosocial"));
                        fr.Fr_inscricaoestadual = retorno.GetString(retorno.GetOrdinal("fr_inscricaoestadual"));
                        fr.Fr_fantasia = retorno.GetString(retorno.GetOrdinal("fr_fantasia"));
                        fr.Fr_endereco = retorno.GetString(retorno.GetOrdinal("fr_endereco"));
                        fr.Fr_cidade = retorno.GetString(retorno.GetOrdinal("fr_cidade"));
                        fr.Fr_uf = retorno.GetString(retorno.GetOrdinal("fr_uf"));
                        fr.Fr_bairro = retorno.GetString(retorno.GetOrdinal("fr_bairro"));
                        fr.Fr_cep = retorno.GetString(retorno.GetOrdinal("fr_cep"));
                        fr.Fr_contato = retorno.GetString(retorno.GetOrdinal("fr_contato"));
                        fr.Fr_telefone = retorno.GetString(retorno.GetOrdinal("fr_telefone"));
                        fr.Fr_fax = retorno.GetString(retorno.GetOrdinal("fr_fax"));
                        fr.Fr_email = retorno.GetString(retorno.GetOrdinal("fr_email"));
                        fr.Fr_nomerepresentante = retorno.GetString(retorno.GetOrdinal("fr_nomerepresentante"));
                        fr.Fr_celularrepresentante = retorno.GetString(retorno.GetOrdinal("fr_celularrepresentante"));
                        fr.Fr_telefonerepresentante = retorno.GetString(retorno.GetOrdinal("fr_telefonerepresentante"));
                        fr.Fr_observacoes = retorno.GetString(retorno.GetOrdinal("fr_observacoes"));
                        fr.Fr_cnpj = retorno.GetString(retorno.GetOrdinal("fr_cnpj"));

                        lista.Add(fr);
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

        public bool verificaduplicidade(Fornecedor fornecedor)
        {
            throw new NotImplementedException();
        }

    }
}
