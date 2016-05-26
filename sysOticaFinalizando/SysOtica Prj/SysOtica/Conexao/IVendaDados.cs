using SysOtica.Negocio.Classes_Basicas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysOtica.Conexao
{
    public interface IVendaDados
    {
        void inserir(Venda v);
        List<Venda> getVenda(string cl_nome);
        void excluirVenda(Venda v);
        void excluiProdutoVenda(int vn_id);
    }
}
