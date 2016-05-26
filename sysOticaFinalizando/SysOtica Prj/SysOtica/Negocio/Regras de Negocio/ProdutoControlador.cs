using SysOtica.Conexao;
using SysOtica.Negocio.Classes_Basicas;
using SysOtica.Negocio.Excecoes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SysOtica.Negocio.Regras_de_Negocio
{
    public class ProdutoControlador
    {
        ProdutoDados controladorproduto = new ProdutoDados();



        public void verificaPreenchimento(Produto p)
        {

            if (String.IsNullOrEmpty(p.Pr_descricao))
            {
                MessageBox.Show("Campo vazio!");
            }
            if (p.Pr_qtd.Equals(""))
            {
                MessageBox.Show("Campo quantidade vazio!");
            }

            if (p.Pr_unidade.Equals(""))
            {

                MessageBox.Show("Campo unidade não selecionado!");
            }

            if (p.Pr_grife.Equals(""))
            {
                MessageBox.Show("Campo grife não selecionado!");
            }

            if (p.Pr_valor.Equals(""))
            {
                MessageBox.Show("Campo Valor vazio!");
            }
            if (p.Pr_estoqueminimo.Equals(""))
            {
                MessageBox.Show("Campo  Estoque vazio!");
            }

        }

        public void ValidarGuid(Produto p)
        {
            if (p == null)
            {
                MessageBox.Show("Int vazio ou inválido");
            }

        }

    }
}
