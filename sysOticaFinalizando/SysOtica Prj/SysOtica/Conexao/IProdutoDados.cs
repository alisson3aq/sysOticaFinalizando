using SysOtica.Negocio.Classes_Basicas;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysOtica.Conexao
{
    public interface IProdutoDados
    {
        void inserirProduto(Produto p);
        void alterarProduto(Produto p);
        void excluirProduto(Produto p);
        List<Produto> listarProduto();
        List<Produto> pesquisarProduto(string pr_descricao);
        List<ProdutoVenda> getProduto(int vn_id);
        DataTable getPV(int vn_id);


    }
}
