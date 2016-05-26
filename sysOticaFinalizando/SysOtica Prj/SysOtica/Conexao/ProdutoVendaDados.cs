using SysOtica.Negocio.Classes_Basicas;
using SysOtica.Negocio.Excecoes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysOtica.Conexao
{
   public class ProdutoVendaDados
    {
        ConexaoBD conn = new ConexaoBD();


        public void inserirProdutoVenda(ProdutoVenda pv)
        {
            try
            {
                //abrir a conexão
                conn.AbrirConexao();
                string sql = "INSERT INTO ProdutoVenda (vn_id) values (@vn_id)";
                //instrucao a ser executada
                SqlCommand cmd = new SqlCommand(sql, conn.cone);

                cmd.Parameters.Add("@vn_id", SqlDbType.Int);
                cmd.Parameters["@vn_id"].Value = pv.Venda.Vn_id;

               //foreach(Produto p in pv.Listaproduto)
               // {
               //     ConexaoBD conn1 = new ConexaoBD();
               //     conn1.AbrirConexao();

               //     string sqlproduto = "INSERT INTO Produto (ct_id,pr_descricao, pr_grife, pr_valor, pr_estoqueminimo,  pr_qtd, pr_unidade, pr_dtentrada, pr_tipo ) values (@ct_id, @pr_descricao, @pr_grife, @pr_valor, @pr_estoqueminimo, @pr_qtd, @pr_unidade, @pr_dtentrada, @pr_tipo )";
               //     SqlCommand cmd1 = new SqlCommand(sqlproduto, conn.cone);


               //     cmd.Parameters.Add("@pr_descricao", SqlDbType.VarChar);
               //     cmd.Parameters["@pr_descricao"].Value = p.Pr_descricao;

               //     cmd.Parameters.Add("@pr_unidade", SqlDbType.VarChar);
               //     cmd.Parameters["@pr_unidade"].Value = p.Pr_unidade;

               //     cmd.Parameters.Add("@pr_grife", SqlDbType.VarChar);
               //     cmd.Parameters["@pr_grife"].Value = p.Pr_grife;

               //     cmd.Parameters.Add("@pr_valor", SqlDbType.VarChar);
               //     cmd.Parameters["@pr_valor"].Value = p.Pr_valor;

               //     cmd.Parameters.Add("@pr_qtd", SqlDbType.VarChar);
               //     cmd.Parameters["@pr_qtd"].Value = p.Pr_qtd;

               //     cmd.Parameters.Add("@pr_estoqueminimo", SqlDbType.VarChar);
               //     cmd.Parameters["@pr_estoqueminimo"].Value = p.Pr_estoqueminimo;

               //     cmd.Parameters.Add("@pr_dtentrada", SqlDbType.Date);
               //     cmd.Parameters["@pr_dtentrada"].Value = p.Pr_dtentrada;

               //     cmd.Parameters.Add("@pr_tipo", SqlDbType.VarChar);
               //     cmd.Parameters["@pr_tipo"].Value = p.Pr_tipo;

               //     cmd1.ExecuteNonQuery();
               //     cmd1.Dispose();

               //     conn1.FecharConexao();
               // }


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


    }
}
