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
    public class ProdutoDados : IProdutoDados
    {
        ConexaoBD conn = new ConexaoBD();


        public void inserirProduto(Produto p)
        {
            try
            {
                //abrir a conexão
                conn.AbrirConexao();
                string sql = "INSERT INTO Produto (pr_descricao, pr_grife, pr_valor, pr_estoqueminimo, pr_unidade, pr_dtentrada, fr_id, ct_id, pr_qtd) values ( @pr_descricao, @pr_grife, @pr_valor, @pr_estoqueminimo, @pr_unidade, @pr_dtentrada, @ct_id, @fr_id, @pr_qtd)";
                //instrucao a ser executada
                SqlCommand cmd = new SqlCommand(sql, conn.cone);

                cmd.Parameters.Add("@pr_descricao", SqlDbType.VarChar);
                cmd.Parameters["@pr_descricao"].Value = p.Pr_descricao;

                cmd.Parameters.Add("@pr_unidade", SqlDbType.VarChar);
                cmd.Parameters["@pr_unidade"].Value = p.Pr_unidade;

                cmd.Parameters.Add("@pr_grife", SqlDbType.VarChar);
                cmd.Parameters["@pr_grife"].Value = p.Pr_grife;

                cmd.Parameters.Add("@pr_valor", SqlDbType.Decimal);
                cmd.Parameters["@pr_valor"].Value = p.Pr_valor;

                cmd.Parameters.Add("@pr_qtd", SqlDbType.Int);
                cmd.Parameters["@pr_qtd"].Value = p.Pr_qtd;

                cmd.Parameters.Add("@pr_estoqueminimo", SqlDbType.Int);
                cmd.Parameters["@pr_estoqueminimo"].Value = p.Pr_estoqueminimo;

                cmd.Parameters.Add("@pr_dtentrada", SqlDbType.Date);
                cmd.Parameters["@pr_dtentrada"].Value = p.Pr_dtentrada;

                cmd.Parameters.Add("@ct_id", SqlDbType.Int);
                cmd.Parameters["@ct_id"].Value = p.Categoria.Ct_id;

                cmd.Parameters.Add("@fr_id", SqlDbType.Int);
                cmd.Parameters["@fr_id"].Value = p.Fornecedor.Fr_id;



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
        public void alterarProduto(Produto p)
        {
            try
            {
                //abrir a conexão
                conn.AbrirConexao();
                string sql = "UPDATE Produto SET  pr_descricao = @pr_descricao, pr_grife = @pr_grife, pr_valor = @pr_valor,pr_qtd = @pr_qtd,pr_estoqueminimo = @pr_estoqueminimo, pr_unidade= @pr_unidade WHERE pr_id = @pr_id";
                //instrucao a ser executada
                SqlCommand cmd = new SqlCommand(sql, conn.cone);

                cmd.Parameters.Add("@pr_id", SqlDbType.Int);
                cmd.Parameters["@pr_id"].Value = p.Pr_id;

                cmd.Parameters.Add("@pr_descricao", SqlDbType.VarChar);
                cmd.Parameters["@pr_descricao"].Value = p.Pr_descricao;

                cmd.Parameters.Add("@pr_unidade", SqlDbType.VarChar);
                cmd.Parameters["@pr_unidade"].Value = p.Pr_unidade;


                cmd.Parameters.Add("@pr_grife", SqlDbType.VarChar);
                cmd.Parameters["@pr_grife"].Value = p.Pr_grife;

                cmd.Parameters.Add("@pr_valor", SqlDbType.Decimal);
                cmd.Parameters["@pr_valor"].Value = p.Pr_valor;

                cmd.Parameters.Add("@pr_qtd", SqlDbType.Int);
                cmd.Parameters["@pr_qtd"].Value = p.Pr_qtd;


                cmd.Parameters.Add("@pr_estoqueminimo", SqlDbType.Int);
                cmd.Parameters["@pr_estoqueminimo"].Value = p.Pr_estoqueminimo;

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
        public void excluirProduto(Produto p)
        {

            try
            {
                //abrir a conexão
                conn.AbrirConexao();
                string sql = "DELETE FROM Produto WHERE pr_id = @pr_id";

                // string sql = "Delete FROM produto Where pr_id = @pr_id in" +
                //    "(Select produto_fornecedor_fk FROM Produto) and (Select categoria_produto_fk FROM Produto)";


                //instrucao a ser executada
                SqlCommand cmd = new SqlCommand(sql, conn.cone);
                cmd.Parameters.Add("@pr_id", SqlDbType.Int);
                cmd.Parameters["@pr_id"].Value = p.Pr_id;
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
        public List<Produto> listarProduto()
        {
            string sql = "SELECT pr_id, pr_descricao, pr_grife, pr_valor, pr_estoqueminimo, pr_qtd FROM Produto";
            List<Produto> lista = new List<Produto>();
            Produto p;


            try
            {
                conn.AbrirConexao();
                SqlCommand cmd = new SqlCommand(sql, conn.cone);
                SqlDataReader retorno = cmd.ExecuteReader();

                while (retorno.Read())
                {
                    p = new Produto();
                    p.Pr_id = retorno.GetInt32(retorno.GetOrdinal("pr_id"));
                    p.Pr_descricao = retorno.GetString(retorno.GetOrdinal("pr_descricao"));
                    p.Pr_grife = retorno.GetString(retorno.GetOrdinal("pr_grife"));
                    p.Pr_valor = retorno.GetDecimal(retorno.GetOrdinal("pr_valor"));
                    p.Pr_estoqueminimo = retorno.GetInt32(retorno.GetOrdinal("pr_estoqueminimo"));
                    p.Pr_qtd = retorno.GetInt32(retorno.GetOrdinal("pr_qtd"));

                    lista.Add(p);
                }
                conn.FecharConexao();
                return lista;

            }
            catch (SqlException e)
            {
                throw new BancoDeDadosException("Falha na comunicação com o banco de dados. \n" + e.Message);
            }
        }
        public List<Produto> pesquisarProduto(string pr_descricao)
        {
            string sql = "SELECT pr_id, pr_descricao, pr_grife, pr_valor, pr_estoqueminimo, pr_qtd " +
                         "FROM Produto where pr_descricao LIKE @pr_descricao + '%'";



            List<Produto> lista = new List<Produto>();
            Produto p;

            if (pr_descricao != "")
            {

                try
                {
                    conn.AbrirConexao();
                    SqlCommand cmd = new SqlCommand(sql, this.conn.cone);
                    cmd.Parameters.Add("@pr_descricao", SqlDbType.VarChar, 50).Value = pr_descricao;

                    SqlDataReader retorno = cmd.ExecuteReader();

                    if (retorno.HasRows == false)
                    {

                        MessageBox.Show("Produto não cadastrado!");

                    }



                    while (retorno.Read())
                    {

                        p = new Produto();
                        p.Pr_id = retorno.GetInt32(retorno.GetOrdinal("pr_id"));
                        p.Pr_descricao = retorno.GetString(retorno.GetOrdinal("pr_descricao"));
                        p.Pr_grife = retorno.GetString(retorno.GetOrdinal("pr_grife"));
                        p.Pr_valor = retorno.GetDecimal(retorno.GetOrdinal("pr_valor"));
                        p.Pr_estoqueminimo = retorno.GetInt32(retorno.GetOrdinal("pr_estoqueminimo"));
                        p.Pr_qtd = retorno.GetInt32(retorno.GetOrdinal("pr_qtd"));

                        lista.Add(p);
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

        //ProdutoVenda
        public List<ProdutoVenda> getProduto(int vn_id)
        {
            string sql = "SELECT pv.pv_qtd, pv.pv_preco , p.pr_descricao, p.pr_id FROM produtovenda pv INNER JOIN venda v ON pv.vn_id = v.vn_id INNER JOIN produto p ON p.pr_id = pv.pr_id WHERE v.vn_id = @vn_id";
            
            List<ProdutoVenda> lista = new List<ProdutoVenda>();

            if (vn_id != 0)
            {

                try
                {
                    conn.AbrirConexao();
                    SqlCommand cmd = new SqlCommand(sql, this.conn.cone);
                    cmd.Parameters.Add("@vn_id", SqlDbType.Int).Value = vn_id;

                    SqlDataReader retorno = cmd.ExecuteReader();

                    if (retorno.HasRows == false)
                    {

                        MessageBox.Show("Produto não cadastrado!");

                    }

                    while (retorno.Read())
                    {
                        ProdutoVenda pv = new ProdutoVenda();

                        //pv.Produto = new Produto();


                        pv.Produto.Pr_descricao = retorno.GetString(retorno.GetOrdinal("pr_descricao"));
                        pv.Produto.Pr_id = retorno.GetInt32(retorno.GetOrdinal("pr_id"));
                        pv.Pv_preco = retorno.GetDecimal(retorno.GetOrdinal("pv_preco"));
                        pv.Pv_qtd = retorno.GetInt32(retorno.GetOrdinal("pv_qtd"));


                        lista.Add(pv);
                    }

                }
                catch (SqlException ex)
                {
                    throw new BancoDeDadosException("Falha na comunicação com o banco de dados. \n" + ex.Message);

                }


            }
            conn.FecharConexao();
            return lista;

        }

        public DataTable getPV(int vn_id)
        {
            string sql = "SELECT pv.pv_qtd, pv.pv_preco , p.pr_descricao, p.pr_id FROM produtovenda pv INNER JOIN venda v ON pv.vn_id = v.vn_id INNER JOIN produto p ON p.pr_id = pv.pr_id WHERE v.vn_id = @vn_id";
            DataTable dataTable = new DataTable();
            if (vn_id != 0)
            {

                try
                {
                    conn.AbrirConexao();
                    SqlCommand cmd = new SqlCommand(sql, this.conn.cone);
                    cmd.Parameters.Add("@vn_id", SqlDbType.Int).Value = vn_id;

                    SqlDataReader retorno = cmd.ExecuteReader();
                    SqlDataAdapter da = new SqlDataAdapter();

                    if (retorno.HasRows == false)
                    {

                        MessageBox.Show("Produto não cadastrado!");

                    }


                    da.Fill(dataTable);
                }
                catch (SqlException ex)
                {
                    throw new BancoDeDadosException("Falha na comunicação com o banco de dados. \n" + ex.Message);

                }


            }
            conn.FecharConexao();
            return dataTable;

        }

      

    }
}
