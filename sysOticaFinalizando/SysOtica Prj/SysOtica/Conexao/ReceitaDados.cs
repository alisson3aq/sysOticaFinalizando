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
    public class ReceitaDados : IReceitaDados
    {
        ConexaoBD conn = new ConexaoBD();

        public void inserirReceita(Receita receita)
        {
            try
            {
                //abrir a conexão  //
                conn.AbrirConexao();
                string sql = "INSERT INTO Receita (rc_lodesferico, rc_loeesferico, rc_podesferico, rc_poeesferico,rc_lodcilindrico,rc_loecilindrico, rc_podcilindrico ,rc_poecilindrico,rc_lodeixo,rc_loeeixo,rc_podeixo,rc_poeeixo,rc_lodaltura,rc_loealtura,rc_podaltura,rc_poealtura,rc_loddnp,rc_loednp, rc_poddnp,rc_poednp,rc_nomemedico,rc_observacoes,rc_data,rc_dtavencimento, cl_id)  Values (@rc_lodesferico, @rc_loeesferico, @rc_podesferico, @rc_poeesferico, @rc_lodcilindrico, @rc_loecilindrico, @rc_podcilindrico ,@rc_poecilindrico, @rc_lodeixo, @rc_loeeixo, @rc_podeixo, @rc_poeeixo, @rc_lodaltura, @rc_loealtura, @rc_podaltura, @rc_poealtura,@rc_loddnp,@rc_loednp, @rc_poddnp,@rc_poednp,@rc_nomemedico, @rc_observacoes, @rc_data, @rc_dtavencimento, @cl_id)";
                //instrucao a ser executada
                SqlCommand cmd = new SqlCommand(sql, conn.cone);


                cmd.Parameters.Add("@rc_lodesferico", SqlDbType.Decimal);
                cmd.Parameters["@rc_lodesferico"].Value = receita.Rc_lodesferico;

                cmd.Parameters.Add("@rc_loeesferico", SqlDbType.Decimal);
                cmd.Parameters["@rc_loeesferico"].Value = receita.Rc_loeesferico;

                cmd.Parameters.Add("@rc_podesferico", SqlDbType.Decimal);
                cmd.Parameters["@rc_podesferico"].Value = receita.Rc_podesferico;

                cmd.Parameters.Add("@rc_poeesferico", SqlDbType.Decimal);
                cmd.Parameters["@rc_poeesferico"].Value = receita.Rc_poeesferico;

                cmd.Parameters.Add("@rc_lodcilindrico", SqlDbType.Decimal);
                cmd.Parameters["@rc_lodcilindrico"].Value = receita.Rc_lodcilindrico;

                cmd.Parameters.Add("@rc_loecilindrico", SqlDbType.Decimal);
                cmd.Parameters["@rc_loecilindrico"].Value = receita.Rc_loecilindrico;

                cmd.Parameters.Add("@rc_podcilindrico", SqlDbType.Decimal);
                cmd.Parameters["@rc_podcilindrico"].Value = receita.Rc_podcilindrico;

                cmd.Parameters.Add("@rc_poecilindrico", SqlDbType.Decimal);
                cmd.Parameters["@rc_poecilindrico"].Value = receita.Rc_poecilindrico;

                cmd.Parameters.Add("@rc_lodeixo", SqlDbType.Decimal);
                cmd.Parameters["@rc_lodeixo"].Value = receita.Rc_lodeixo;

                cmd.Parameters.Add("@rc_loeeixo", SqlDbType.Decimal);
                cmd.Parameters["@rc_loeeixo"].Value = receita.Rc_loeeixo;

                cmd.Parameters.Add("@rc_podeixo", SqlDbType.Decimal);
                cmd.Parameters["@rc_podeixo"].Value = receita.Rc_podeixo;

                cmd.Parameters.Add("@rc_poeeixo", SqlDbType.Decimal);
                cmd.Parameters["@rc_poeeixo"].Value = receita.Rc_poeeixo;

                cmd.Parameters.Add("@rc_lodaltura", SqlDbType.Decimal);
                cmd.Parameters["@rc_lodaltura"].Value = receita.Rc_lodaltura;

                cmd.Parameters.Add("@rc_loealtura", SqlDbType.Decimal);
                cmd.Parameters["@rc_loealtura"].Value = receita.Rc_loealtura;

                cmd.Parameters.Add("@rc_podaltura", SqlDbType.Decimal);
                cmd.Parameters["@rc_podaltura"].Value = receita.Rc_podaltura;

                cmd.Parameters.Add("@rc_poealtura", SqlDbType.Decimal);
                cmd.Parameters["@rc_poealtura"].Value = receita.Rc_poealtura;

                cmd.Parameters.Add("@rc_loddnp", SqlDbType.Decimal);
                cmd.Parameters["@rc_loddnp"].Value = receita.Rc_loddnp;

                cmd.Parameters.Add("@rc_loednp", SqlDbType.Decimal);
                cmd.Parameters["@rc_loednp"].Value = receita.Rc_loednp;

                cmd.Parameters.Add("@rc_poddnp", SqlDbType.Decimal);
                cmd.Parameters["@rc_poddnp"].Value = receita.Rc_poddnp;

                cmd.Parameters.Add("@rc_poednp", SqlDbType.Decimal);
                cmd.Parameters["@rc_poednp"].Value = receita.Rc_poednp;

                cmd.Parameters.Add("@rc_nomemedico", SqlDbType.VarChar);
                cmd.Parameters["@rc_nomemedico"].Value = receita.Rc_nomemedico;

                cmd.Parameters.Add("@rc_observacoes", SqlDbType.VarChar);
                cmd.Parameters["@rc_observacoes"].Value = receita.Rc_observacoes;

                cmd.Parameters.Add("@rc_data", SqlDbType.Date);
                cmd.Parameters["@rc_data"].Value = receita.Rc_data;

                cmd.Parameters.Add("@rc_dtavencimento", SqlDbType.Date);
                cmd.Parameters["@rc_dtavencimento"].Value = receita.Rc_dtavencimento;

                cmd.Parameters.Add("@cl_id", SqlDbType.Int);
                cmd.Parameters["@cl_id"].Value = receita.Cliente.Cl_id;

                //Int32 clId = Convert.ToInt32(cmd.ExecuteScalar());
                //executando a instrucao 


                /* foreach (Receita r  in c.Listareceita)
                 {
                     ConexaoBD conn1 = new ConexaoBD();

                     conn1.AbrirConexao();

                     string sqlitens = "INSERT INTO Receita (cl_id) VALUES (@cl_id)";
                     SqlCommand cmd1 = new SqlCommand(sqlitens, conn.cone);

                     cmd1.Parameters.Add("@cl_id", SqlDbType.Int);
                     cmd1.Parameters["@cl_id"].Value = r.Cliente.Cl_id;

                     //int recordsInserted = cmd.ExecuteNonQuery();
                     cmd1.ExecuteNonQuery();
                     cmd1.Dispose();
                     conn1.FecharConexao();

                 }*/



                //executando a instrucao 
                cmd.ExecuteNonQuery();
                //liberando a memoria 
                cmd.Dispose();
                //fechando a conexao
                if (conn.State == System.Data.ConnectionState.Open)
                    //fechando a conexao
                    conn.FecharConexao();


            }
            catch (SqlException e)
            {
                throw new BancoDeDadosException("Falha na comunicação com o banco de dados. \n" + e.Message);
            }


        }

        public void alterarReceita(Receita receita)
        {
            try
            {
                //abrir a conexão
                conn.AbrirConexao();
                string sql = "UPDATE Receita SET  rc_lodesferico = @rc_lodesferico, rc_loeesferico = @rc_loeesferico,rc_podesferico = @rc_podesferico, rc_poeesferico = @rc_poeesferico,rc_lodcilindrico = @rc_lodcilindrico,rc_loecilindrico = @rc_loecilindrico, rc_podcilindrico = @rc_podcilindrico ,rc_poecilindrico = @rc_poecilindrico,rc_lodeixo = @rc_lodeixo,rc_loeeixo = @rc_loeeixo,rc_podeixo = @rc_podeixo,rc_poeeixo = @rc_poeeixo,rc_lodaltura = @rc_lodaltura,rc_loealtura = @rc_loealtura,rc_podaltura = @rc_podaltura,rc_poealtura = @rc_poealtura,rc_loddnp = @rc_loddnp,rc_loednp = @rc_loednp, rc_poddnp = @rc_poddnp,rc_poednp = @rc_poednp,rc_nomemedico = @rc_nomemedico,rc_observacoes = @rc_observacoes,rc_data = @rc_data,rc_dtavencimento = @rc_dtavencimento WHERE rc_id = @rc_id";
                //instrucao a ser executada
                SqlCommand cmd = new SqlCommand(sql, conn.cone);

                cmd.Parameters.Add("@rc_id", SqlDbType.Int);
                cmd.Parameters["@rc_id"].Value = receita.Rc_id;

                cmd.Parameters.Add("@rc_lodesferico", SqlDbType.Decimal);
                cmd.Parameters["@rc_lodesferico"].Value = receita.Rc_lodesferico;

                cmd.Parameters.Add("@rc_loeesferico", SqlDbType.Decimal);
                cmd.Parameters["@rc_loeesferico"].Value = receita.Rc_loeesferico;

                cmd.Parameters.Add("@rc_podesferico", SqlDbType.Decimal);
                cmd.Parameters["@rc_podesferico"].Value = receita.Rc_podesferico;

                cmd.Parameters.Add("@rc_poeesferico", SqlDbType.Decimal);
                cmd.Parameters["@rc_poeesferico"].Value = receita.Rc_poeesferico;

                cmd.Parameters.Add("@rc_lodcilindrico", SqlDbType.Decimal);
                cmd.Parameters["@rc_lodcilindrico"].Value = receita.Rc_lodcilindrico;

                cmd.Parameters.Add("@rc_loecilindrico", SqlDbType.Decimal);
                cmd.Parameters["@rc_loecilindrico"].Value = receita.Rc_loecilindrico;

                cmd.Parameters.Add("@rc_podcilindrico", SqlDbType.Decimal);
                cmd.Parameters["@rc_podcilindrico"].Value = receita.Rc_podcilindrico;

                cmd.Parameters.Add("@rc_poecilindrico", SqlDbType.Decimal);
                cmd.Parameters["@rc_poecilindrico"].Value = receita.Rc_poecilindrico;

                cmd.Parameters.Add("@rc_lodeixo", SqlDbType.Decimal);
                cmd.Parameters["@rc_lodeixo"].Value = receita.Rc_lodeixo;

                cmd.Parameters.Add("@rc_loeeixo", SqlDbType.Decimal);
                cmd.Parameters["@rc_loeeixo"].Value = receita.Rc_loeeixo;

                cmd.Parameters.Add("@rc_podeixo", SqlDbType.Decimal);
                cmd.Parameters["@rc_podeixo"].Value = receita.Rc_podeixo;

                cmd.Parameters.Add("@rc_poeeixo", SqlDbType.Decimal);
                cmd.Parameters["@rc_poeeixo"].Value = receita.Rc_poeeixo;

                cmd.Parameters.Add("@rc_lodaltura", SqlDbType.Decimal);
                cmd.Parameters["@rc_lodaltura"].Value = receita.Rc_lodaltura;

                cmd.Parameters.Add("@rc_loealtura", SqlDbType.Decimal);
                cmd.Parameters["@rc_loealtura"].Value = receita.Rc_loealtura;

                cmd.Parameters.Add("@rc_podaltura", SqlDbType.Decimal);
                cmd.Parameters["@rc_podaltura"].Value = receita.Rc_podaltura;

                cmd.Parameters.Add("@rc_poealtura", SqlDbType.Decimal);
                cmd.Parameters["@rc_poealtura"].Value = receita.Rc_poealtura;

                cmd.Parameters.Add("@rc_loddnp", SqlDbType.Decimal);
                cmd.Parameters["@rc_loddnp"].Value = receita.Rc_loddnp;

                cmd.Parameters.Add("@rc_loednp", SqlDbType.Decimal);
                cmd.Parameters["@rc_loednp"].Value = receita.Rc_loednp;

                cmd.Parameters.Add("@rc_poddnp", SqlDbType.Decimal);
                cmd.Parameters["@rc_poddnp"].Value = receita.Rc_poddnp;

                cmd.Parameters.Add("@rc_poednp", SqlDbType.Decimal);
                cmd.Parameters["@rc_poednp"].Value = receita.Rc_poednp;

                cmd.Parameters.Add("@rc_nomemedico", SqlDbType.VarChar);
                cmd.Parameters["@rc_nomemedico"].Value = receita.Rc_nomemedico;

                cmd.Parameters.Add("@rc_observacoes", SqlDbType.VarChar);
                cmd.Parameters["@rc_observacoes"].Value = receita.Rc_observacoes;

                cmd.Parameters.Add("@rc_data", SqlDbType.Date);
                cmd.Parameters["@rc_data"].Value = receita.Rc_data;

                cmd.Parameters.Add("@rc_dtavencimento", SqlDbType.Date);
                cmd.Parameters["@rc_dtavencimento"].Value = receita.Rc_dtavencimento;

                //executando a instrucao 
                cmd.ExecuteNonQuery();
                //liberando a memoria 
                cmd.Dispose();
                //fechando a conexao
                conn.AbrirConexao();
            }
            catch (SqlException e)
            {
                throw new BancoDeDadosException("Falha na comunicação com o banco de dados. \n" + e.Message);
            }


        }

        public void excluirreceita(Receita receita)
        {

            try
            {
                //abrir a conexão
                conn.AbrirConexao();
                string sql = "DELETE FROM Receita WHERE rc_id = @rc_id";
                //instrucao a ser executada
                SqlCommand cmd = new SqlCommand(sql, conn.cone);
                cmd.Parameters.Add("@rc_id", SqlDbType.Int);
                cmd.Parameters["@rc_id"].Value = receita.Rc_id;
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

        public List<Receita> listaReceita()
        {
            string sql = " SELECT r.rc_id,    r.rc_lodesferico, r.rc_loeesferico,  r.rc_podesferico,    r.rc_poeesferico,  r.rc_lodcilindrico,          r.rc_loecilindrico,  r.rc_podcilindrico,  r.rc_poecilindrico," +
                    "             r.rc_lodeixo,               r.rc_loeeixo,     r.rc_podeixo,      r.rc_poeeixo,        r.rc_lodaltura,    r.rc_loealtura,             r.rc_podaltura,      r.rc_poealtura,      r.rc_loddnp,       r.rc_loednp,    r.rc_poddnp, " +
                    "             r.rc_poednp,                r.rc_nomemedico,  r.rc_observacoes,  r.rc_data,           r.rc_dtavencimento  FROM Receita as r Inner Join Cliente as c on r.cl_id = c.cl_id";

            List<Receita> lista = new List<Receita>();
            Receita receita;


            try
            {
                conn.AbrirConexao();
                SqlCommand cmd = new SqlCommand(sql, conn.cone);
                SqlDataReader retorno = cmd.ExecuteReader();

                while (retorno.Read())
                {
                    receita = new Receita();



                    receita.Rc_id = retorno.GetInt32(retorno.GetOrdinal("rc_id"));
                    receita.Rc_lodesferico = retorno.GetDecimal(retorno.GetOrdinal("rc_lodesferico"));
                    receita.Rc_loeesferico = retorno.GetDecimal(retorno.GetOrdinal("rc_loeesferico"));
                    receita.Rc_podesferico = retorno.GetDecimal(retorno.GetOrdinal("rc_podesferico"));
                    receita.Rc_poeesferico = retorno.GetDecimal(retorno.GetOrdinal("rc_poeesferico"));
                    receita.Rc_lodcilindrico = retorno.GetDecimal(retorno.GetOrdinal("rc_lodcilindrico"));
                    receita.Rc_loecilindrico = retorno.GetDecimal(retorno.GetOrdinal("rc_loecilindrico"));
                    receita.Rc_podcilindrico = retorno.GetDecimal(retorno.GetOrdinal("rc_podcilindrico"));
                    receita.Rc_poecilindrico = retorno.GetDecimal(retorno.GetOrdinal("rc_poecilindrico"));
                    receita.Rc_lodeixo = retorno.GetDecimal(retorno.GetOrdinal("rc_lodeixo"));
                    receita.Rc_loeeixo = retorno.GetDecimal(retorno.GetOrdinal("rc_loeeixo"));
                    receita.Rc_podeixo = retorno.GetDecimal(retorno.GetOrdinal("rc_podeixo"));
                    receita.Rc_poeeixo = retorno.GetDecimal(retorno.GetOrdinal("rc_poeeixo"));
                    receita.Rc_lodaltura = retorno.GetDecimal(retorno.GetOrdinal("rc_lodaltura"));
                    receita.Rc_loealtura = retorno.GetDecimal(retorno.GetOrdinal("rc_loealtura"));
                    receita.Rc_podaltura = retorno.GetDecimal(retorno.GetOrdinal("rc_podaltura"));
                    receita.Rc_poealtura = retorno.GetDecimal(retorno.GetOrdinal("rc_poealtura"));
                    receita.Rc_loddnp = retorno.GetDecimal(retorno.GetOrdinal("rc_loddnp"));
                    receita.Rc_loednp = retorno.GetDecimal(retorno.GetOrdinal("rc_loednp"));
                    receita.Rc_poddnp = retorno.GetDecimal(retorno.GetOrdinal("rc_poddnp"));
                    receita.Rc_poednp = retorno.GetDecimal(retorno.GetOrdinal("rc_poednp"));
                    receita.Rc_data = retorno.GetDateTime(retorno.GetOrdinal("rc_data"));
                    receita.Rc_nomemedico = retorno.GetString(retorno.GetOrdinal("rc_nomemedico"));
                    receita.Rc_dtavencimento = retorno.GetDateTime(retorno.GetOrdinal("rc_dtavencimento"));
                    receita.Rc_observacoes = retorno.GetString(retorno.GetOrdinal("rc_observacoes"));



                    lista.Add(receita);
                }
                conn.FecharConexao();
                return lista;

            }
            catch (SqlException e)
            {
                throw new BancoDeDadosException("Falha na comunicação com o banco de dados. \n" + e.Message);
            }




        }

        public List<Receita> puxaReceita(string cl_nome)
        {
            string sql = " SELECT r.rc_id,    r.rc_lodesferico, r.rc_loeesferico,  r.rc_podesferico,    r.rc_poeesferico,  r.rc_lodcilindrico,          r.rc_loecilindrico,  r.rc_podcilindrico,  r.rc_poecilindrico," +
                    "             r.rc_lodeixo,               r.rc_loeeixo,     r.rc_podeixo,      r.rc_poeeixo,        r.rc_lodaltura,    r.rc_loealtura,             r.rc_podaltura,      r.rc_poealtura,      r.rc_loddnp,       r.rc_loednp,    r.rc_poddnp, " +
                    "             r.rc_poednp,                r.rc_nomemedico,  r.rc_observacoes,  r.rc_data,           r.rc_dtavencimento  FROM Receita as r Inner Join Cliente as c on r.cl_id = c.cl_id where cl_nome LIKE @cl_nome + '%'";


            List<Receita> lista = new List<Receita>();

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
                        Receita receita = new Receita();

                        receita.Rc_id = retorno.GetInt32(retorno.GetOrdinal("rc_id"));
                        receita.Rc_lodesferico = retorno.GetDecimal(retorno.GetOrdinal("rc_lodesferico"));
                        receita.Rc_loeesferico = retorno.GetDecimal(retorno.GetOrdinal("rc_loeesferico"));
                        receita.Rc_podesferico = retorno.GetDecimal(retorno.GetOrdinal("rc_podesferico"));
                        receita.Rc_poeesferico = retorno.GetDecimal(retorno.GetOrdinal("rc_poeesferico"));
                        receita.Rc_lodcilindrico = retorno.GetDecimal(retorno.GetOrdinal("rc_lodcilindrico"));
                        receita.Rc_loecilindrico = retorno.GetDecimal(retorno.GetOrdinal("rc_loecilindrico"));
                        receita.Rc_podcilindrico = retorno.GetDecimal(retorno.GetOrdinal("rc_podcilindrico"));
                        receita.Rc_poecilindrico = retorno.GetDecimal(retorno.GetOrdinal("rc_poecilindrico"));
                        receita.Rc_lodeixo = retorno.GetDecimal(retorno.GetOrdinal("rc_lodeixo"));
                        receita.Rc_loeeixo = retorno.GetDecimal(retorno.GetOrdinal("rc_loeeixo"));
                        receita.Rc_podeixo = retorno.GetDecimal(retorno.GetOrdinal("rc_podeixo"));
                        receita.Rc_poeeixo = retorno.GetDecimal(retorno.GetOrdinal("rc_poeeixo"));
                        receita.Rc_lodaltura = retorno.GetDecimal(retorno.GetOrdinal("rc_lodaltura"));
                        receita.Rc_loealtura = retorno.GetDecimal(retorno.GetOrdinal("rc_loealtura"));
                        receita.Rc_podaltura = retorno.GetDecimal(retorno.GetOrdinal("rc_podaltura"));
                        receita.Rc_poealtura = retorno.GetDecimal(retorno.GetOrdinal("rc_poealtura"));
                        receita.Rc_loddnp = retorno.GetDecimal(retorno.GetOrdinal("rc_loddnp"));
                        receita.Rc_loednp = retorno.GetDecimal(retorno.GetOrdinal("rc_loednp"));
                        receita.Rc_poddnp = retorno.GetDecimal(retorno.GetOrdinal("rc_poddnp"));
                        receita.Rc_poednp = retorno.GetDecimal(retorno.GetOrdinal("rc_poednp"));
                        receita.Rc_data = retorno.GetDateTime(retorno.GetOrdinal("rc_data"));
                        receita.Rc_nomemedico = retorno.GetString(retorno.GetOrdinal("rc_nomemedico"));
                        receita.Rc_dtavencimento = retorno.GetDateTime(retorno.GetOrdinal("rc_dtavencimento"));
                        receita.Rc_observacoes = retorno.GetString(retorno.GetOrdinal("rc_observacoes"));

                        lista.Add(receita);
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

        public List<Receita> vendaReceita()
        {
            string sql = " SELECT r.rc_id, r.rc_nomemedico, r.rc_observacoes, r.rc_data,  r.rc_dtavencimento, r.cl_id FROM Receita as r Inner Join Cliente as c on r.cl_id = c.cl_id";


            List<Receita> lista = new List<Receita>();

            try
            {
                conn.AbrirConexao();
                SqlCommand cmd = new SqlCommand(sql, this.conn.cone);
                SqlDataReader retorno = cmd.ExecuteReader();

                while (retorno.Read())
                {
                    Receita receita = new Receita();
                    receita.Cliente.Cl_id = retorno.GetInt32(retorno.GetOrdinal("cl_id"));
                    receita.Rc_id = retorno.GetInt32(retorno.GetOrdinal("rc_id"));
                    receita.Rc_nomemedico = retorno.GetString(retorno.GetOrdinal("rc_nomemedico"));
                    receita.Rc_observacoes = retorno.GetString(retorno.GetOrdinal("rc_observacoes"));
                    receita.Rc_data = retorno.GetDateTime(retorno.GetOrdinal("rc_data"));
                    receita.Rc_dtavencimento = retorno.GetDateTime(retorno.GetOrdinal("rc_dtavencimento"));


                    lista.Add(receita);

                }


            }
            catch (SqlException ex)
            {
                throw new BancoDeDadosException("Falha na comunicação com o banco de dados. \n" + ex.Message);

            }

            conn.FecharConexao();
            return lista;


        }




    }

}
